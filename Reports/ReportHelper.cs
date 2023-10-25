using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.DAL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports.DSTableAdapters;
using Microsoft.Reporting.WinForms;

namespace DMZ.UI.Reports
{
    public static class ReportHelper
    {
        [DllImport("Winspool.drv")]
        static extern bool SetDefaultPrinter(string printerName);

        static string _reportPath;
        static LocalReport _reportViewer1;
        public static DateTime DataHora { get; private set; }

        static ReportDataSource _dataSource2 = null;
        static readonly string path = Application.StartupPath;
        public static void KillPrimaryKey(DataTable locDataTable)
        {
            var locPriKeyCount = locDataTable.PrimaryKey.Length;
            var prevPriColumns = new string[locPriKeyCount];
            //1.Store ColumnNames in a string Array
            for (var ii = 0; ii < locPriKeyCount; ii++) prevPriColumns[ii] = locDataTable.PrimaryKey[ii].ColumnName;
            //2.Clear PrimaryKey
            locDataTable.PrimaryKey = null;
            //3.Clear Unique settings
            for (var ii = 0; ii < locPriKeyCount; ii++) locDataTable.Columns[prevPriColumns[ii]].Unique = false;
        }
        public static void PrinterList(ComboBox comboBox1)
        {
            // USING WMI. (WINDOWS MANAGEMENT INSTRUMENTATION)
            var objMs = new ManagementScope(ManagementPath.DefaultPath);
            objMs.Connect();
            var objQuery = new SelectQuery("SELECT * FROM Win32_Printer");
            var objMos = new ManagementObjectSearcher(objMs, objQuery);
            var objMoc = objMos.Get();
            foreach (var o in objMoc)
            {
                var printers = (ManagementObject)o;
                if (Convert.ToBoolean(printers["Local"]))       // LOCAL PRINTERS.
                {
                    comboBox1.Items.Add(printers["Name"]);
                }
                if (printers["Network"].ToBool())     // ALL NETWORK PRINTERS.
                {
                    comboBox1.Items.Add(printers["Name"]);
                }
            }
            var printerSettings = new PrinterSettings();
            var defaultPrinterName = printerSettings.PrinterName;
            comboBox1.Text = defaultPrinterName;
        }
        public static DataTable PrinterList( bool defaultPrinterName = false)
        {
            // USING WMI. (WINDOWS MANAGEMENT INSTRUMENTATION)
            var objMs = new ManagementScope(ManagementPath.DefaultPath);
            objMs.Connect();

            var objQuery = new SelectQuery("SELECT * FROM Win32_Printer");
            var objMos = new ManagementObjectSearcher(objMs, objQuery);
            var objMoc = objMos.Get();
            var lista = new  DataTable("Impressoras");
            var dc =new DataColumn("Descricao",typeof(string));
            lista.Columns.Add(dc);
            var dc2 = new DataColumn("Defa", typeof(bool));
            lista.Columns.Add(dc2);
            if (defaultPrinterName)
            {
                var printerSettings = new PrinterSettings();
                var defaultPrintName = printerSettings.PrinterName;
                var dr = lista.NewRow();
                dr["Descricao"]=defaultPrintName;
                dr["Defa"] = true;
                lista.Rows.Add(dr);
            }
            else
            {
                var printerSettings = new PrinterSettings();
                var defaultPrintName = printerSettings.PrinterName;
                foreach (var o in objMoc)
                {
                    var printers = (ManagementObject)o;
                    var dr = lista.NewRow();
                    if (printers["Local"].ToBool())       // LOCAL PRINTERS.
                    {

                        dr["Descricao"]=printers["Name"].ToString();
                        if (printers["Name"].ToString().ToLower().Equals(defaultPrintName.ToLower().Trim()))
                        {
                            dr["Defa"] = true;
                        }
                    }
                    if (printers["Network"].ToBool())     // ALL NETWORK PRINTERS.
                    {
                        dr["Descricao"]=printers["Name"].ToString();
                        if (printers["Name"].ToString().ToLower().Equals(defaultPrintName.ToLower().Trim()))
                        {
                            dr["Defa"] = true;
                        }
                    }
                    lista.Rows.Add(dr);
                }      
            }
            return lista;
        }
        public static void FillDt(DataSet Ds,DataTable dt2, string tbName)
        {
            if (!(dt2?.Rows.Count > 0)) return;
            foreach (var d in dt2.AsEnumerable())
            {
                if (d == null) continue;
                var r = Ds.Tables[$"{tbName}"].NewRow();
                foreach (DataColumn col in d.Table.Columns)
                {
                    if (string.IsNullOrEmpty(col.ColumnName)) continue;
                    var coll = col.ColumnName;
                    if (Ds.Tables[$"{tbName}"].Columns.Contains(coll.Trim()))
                    {
                        r[coll] = d[coll];
                    }
                }
                Ds.Tables[$"{tbName}"].Rows.Add(r);
            }
        }
        internal static void ExecCases(PrintSetup Ps, GCon con)
        {
            switch (Ps.Origem.Trim())
            {
                case "PJ":
                    break;
                case "CP":
                    FillContas(Ps.Ds);
                    var dt2 = SQL.GetGen2DT($@"select txiva,sum(subtotall) subtotall,sum(valival) valival from faccl where Faccstamp='{Ps.Ds.Tables["facc"].Rows[0]["faccstamp"].ToTrim()}' 
                                                        group by txiva order by txiva ");
                    FillDt2(dt2, "DMZ", Ps.Ds);
                    break;
                case "FT":
                    FillContas(Ps.Ds);
                    if (Ps.Ds.Fact.HasRows())
                    {
                        if (Pbl.Param.Modeloja)
                        {
                            foreach (var item in Ps.Ds.Tables["Fact"].AsEnumerable())
                            {
                                item["Nomedoc"] = $"{item["Nomedoc"]} {Pbl.Usr.Codccu.ToString().ToUpper()}";
                            }
                        }
                        var dt = SQL.GetGen2DT($@"select txiva,sum(subtotall) subtotall,sum(valival) valival from factl where Factstamp='{Ps.Ds.Tables["fact"].Rows[0]["factstamp"].ToTrim()}' 
                                                        group by txiva order by txiva ");
                        FillDt2(dt, "DMZ", Ps.Ds);
                    }
                    else
                    {
                        MsBox.Show("O sistema não consegue imprimir o documento \r\nErro encontrado!..");
                        Cancelado = true;
                    }
                    break;
                case "RCL":
                    if (Pbl.Param.Modeloja)
                    {
                        var codigo = Pbl.Usr.Codccu;
                        foreach (var item in Ps.Ds.Tables["Rcl"].AsEnumerable())
                        {
                            item["Nomedoc"] = $"{item["Nomedoc"]} {codigo.ToString().ToUpper()} ";
                        }
                    }
                    break;
                case "Encontro":
                    var Encontrodaptador = new EncontroTableAdapter { Connection = con.NResult };
                    Encontrodaptador.Fill(Ps.Ds.Encontro, Ps.CLocalStamp);
                    KillPrimaryKey(Ps.Ds.Encontro);
                    var FormaspEncontrodaptador = new FormaspEncontroTableAdapter { Connection = con.NResult };
                    FormaspEncontrodaptador.Fill(Ps.Ds.FormaspEncontro, Ps.CLocalStamp);
                    Ps.DtPrint.TableName = "Encontro";
                    DataHora = Ps.Ds.Tables["Encontro"].RowZero("data").ToDateTimeValue();
                    Ps.DataSource2 = new ReportDataSource("DataSet2", Ps.Ds.Tables["FormaspEncontro"]);
                    break;

                case "Turma":
                    var Horario = new HorarioTableAdapter { Connection = con.NResult };
                    Horario.Fill(Ps.Ds.Horario, Ps.CLocalStamp);
                    KillPrimaryKey(Ps.Ds.Horario);
                    Ps.Horario = new ReportDataSource("Horario", Ps.Ds.Tables["Horario"]);
                    var Turmadisc = new TurmadiscTableAdapter { Connection = con.NResult };
                    Turmadisc.Fill(Ps.Ds.Turmadisc, Ps.CLocalStamp);
                    Ps.Turmadisc = new ReportDataSource("Turmadisc", Ps.Ds.Tables["Turmadisc"]);
                    break;

                case "percl":
                    var str = $@"select Referenc,prc.data,prc.Descricao,Remuner=IIF(Tipo=0,BaseVencimento,iif(Tipo=1,Valor,0)),
                                                    Desconto=IIF(Tipo>1,Valor,0) from prc 
                                                    join Proces on prc.Processtamp=Proces.Processtamp
                                                    where Proces.Processtamp='{Ps.Ds.Tables["Percl"].Rows[0]["Processtamp"].ToTrim()}' and Prc.pestamp='{Ps.Ds.Tables["Percl"].Rows[0]["pestamp"].ToTrim()}' 
                                                    order by prc.Tipo";
                    var dtPrc = SQL.GetGen2DT(str);
                    FillDt2(dtPrc, "DMZ", Ps.Ds);
                    Ps.DataSource3 = new ReportDataSource("DataSet3", Ps.Ds.Tables["DMZ"]);
                    break;
            }

        }
        internal static void SetReportDataSource(PrintSetup Ps, LocalReport reportViewer1,string rpath)
        {
            reportViewer1.ReportPath = rpath;
            if (!Pbl.Param.Modeloja)
            {
                FillDt3(Pbl.Empresa.ToDataTable(), "Empresa", Ps.Ds);
            }
            else
            {
                var str = $@"SELECT Empresa.Empresastamp, Empresa.Codigo, Empresa.Nome, Empresa.Morada2, Empresa.Sede, Empresa.Telefone, Empresa.Fax, Empresa.cp, Empresa.Actividade, Empresa.Sigla, Empresa.Infobanc, Empresa.Declarante, 
                     Empresa.Refdeclara, Empresa.logo, Empresa.Webpage, Empresa.Empslogan, Empresa.Actdgi, Empresa.Reparticao, Empresa.LogoGrande, Empresa.MostraNome, Empresa.Moeda, Empresa.Capitalsocial, Empresa.Matricula, 
                     Empresa.Grupo1, Empresa.Grupo2, Empresa.Logo1, Empresa.Logo2, Empresa.Logo3, Empresa.Logo4, Empresa.Logo5, Empresa.Logo6, Empresa.Logo7, Empresa.Logo8, Empresa.Logo9, Empresa.Logo10, Empresa.Logo11, 
                     Empresa.Logo12, Empresa.Logo13, Empresa.Logo14, Empresa.Logo15, Empresa.Cl1, Empresa.Cl2, Empresa.Cl3, Empresa.Cl4, Empresa.Cl5, Empresa.Cl6, Empresa.Cl7, Empresa.Cl8, Empresa.Cl9, Empresa.Cl10, 
                     Empresa.Cl11, Empresa.Cl12, Empresa.Cl13, Empresa.Cl14, Empresa.Cl15, Empresa.Emptransporte, CCu.Morada, CCu.Email, CCu.Cell, CCu.Nuit
                    FROM Empresa INNER JOIN CCu ON Empresa.Empresastamp = CCu.Empresastamp where ccu.Descricao='{Pbl.Usr.Ccusto.Trim()}'";
                var dt = SQL.GetGenDT(str);
                FillDt3(dt, "Empresa", Ps.Ds);
            }
            var rd1 = new ReportDataSource("Entidade", Ps.Ds.Tables["Empresa"]);
            reportViewer1.DataSources.Clear();
            reportViewer1.DataSources.Add(rd1);
            reportViewer1.EnableExternalImages = true;
            reportViewer1.DataSources.Add(new ReportDataSource(Ps.DatasetName, Ps.Ds.Tables[Ps.DtPrint.TableName]));
            if (Ps.UseFormasp)
            {
                reportViewer1.DataSources.Add(new ReportDataSource("Formasp", Ps.Ds.Tables["Formasp"]));
            }
            if (Ps.DtPrint.TableName.ToLower().Trim().Equals("fact") || Ps.DtPrint.TableName.ToLower().Trim().Equals("facc"))
            {
                reportViewer1.DataSources.Add(new ReportDataSource("TabIvas", Ps.Ds.Tables["DMZ"]));
                reportViewer1.DataSources.Add(new ReportDataSource("Contas", Ps.Ds.Tables["Contas"]));
            }
            if (Ps.DataSource3 != null)
            {
                reportViewer1.DataSources.Add(Ps.DataSource3);
            }
            if (Ps.DataSource2 != null)
            {
                reportViewer1.DataSources.Add(Ps.DataSource2);
            }
            if (Ps.Horario != null)
            {
                reportViewer1.DataSources.Add(Ps.Horario);
            }
            if (Ps.Turmadisc != null)
            {
                reportViewer1.DataSources.Add(Ps.Turmadisc);
            }
        }

        internal static void Deletefile(PrintSetup Ps,string reportPath)
        {
            if (!Pbl.Param.Localrdlc)
            {
                if (!Ps.XmlString.IsNullOrEmpty())
                {
                    if (File.Exists(reportPath))
                    {
                        File.Delete(reportPath);
                    }
                }
            }
        }

        public static string WriteRDLCReport(string report)
        {
            var TempReportFullPath = "";
            if (!report.IsNullOrEmpty())
            {
                var fileName = Application.StartupPath + "\\Temp";
                var stamp = Pbl.Rdlcstamp();

                if (!Directory.Exists(fileName))
                {
                    Directory.CreateDirectory(fileName);
                    File.WriteAllText(path + $"\\Temp\\report{stamp}.rdlc", report);
                }
                else
                {
                    File.WriteAllText(path + $"\\Temp\\report{stamp}.rdlc", report);
                }
                TempReportFullPath = path + $"\\Temp\\report{stamp}.rdlc";
            }

            return TempReportFullPath;
        }
        public static void PrintReport(PrintSetup Ps)
        {
            if (Ps.Ds != null)
            {
                try
                {
                    Ps.Ds.EnforceConstraints = false;
                    _reportPath = SetReportPath(Ps);
                    _reportViewer1 = new LocalReport { ReportPath = _reportPath };
                    if (_reportViewer1 != null)
                    {
                        using (var con = new GCon())
                        {
                            ExecCases(Ps, con);
                            _reportPath = Ps.ReportPath==""?SetReportPath(Ps): Ps.ReportPath;
                            SetReportDataSource(Ps, _reportViewer1, _reportPath);
                            GetSetListParameter(Ps, _reportViewer1);
                            #region Definicao da impressora padrao e impressao ....
                            if (Ps.NrCopias == 0)
                            {
                                if (Pbl.Param.NumImpressao == 0)
                                {
                                    Ps.NrCopias = 1;
                                }
                                else
                                {
                                    Ps.NrCopias = Pbl.Param.NumImpressao;
                                }
                            }
                            SetDefaultPrinter(Ps.Impressora);
                            _reportViewer1.Refresh();
                            if (Ps.ListaTipodoc?.Count > 0)
                            {
                                var StatusdocumentoParam = _reportViewer1.GetParameters().FirstOrDefault(x => x.Name.Equals("Statusdocumento"));
                                if (StatusdocumentoParam != null)
                                {
                                    foreach (ReportParameter rpt in Ps.ListaTipodoc.Select(tipodocumento => new ReportParameter("Statusdocumento", tipodocumento)))
                                    {
                                        _reportViewer1.SetParameters(new[] { rpt });
                                        Imprime(Ps.NrCopias, Ps.POS);
                                    }
                                }
                                else
                                {
                                    Imprime(Ps.NrCopias, Ps.POS);
                                }
                            }
                            else
                            {
                                Imprime(Ps.NrCopias, Ps.POS);
                            }
                            #endregion
                        }
                        if (Ps.ReportPath=="")
                        {
                            Deletefile(_reportPath, Ps.Nomfile);
                        }
                    }
                    else
                    {
                        MsBox.Show("Relatório não encontrado");
                    }
                }
                catch (Exception ex)
                {

                    MsBox.Show(ex.Message);
                }
            }
        }

        public static string SetReportPath(PrintSetup ps)
        {
            return ReportPath(ps.Nomfile,ps.XmlString);
        }

        public static string ReportPath(string Nomfile,string XmlString)
        {
            if (Pbl.Param.Localrdlc)
            {
                return $"../../Reports/{Nomfile.Trim()}.rdlc";
            }
            else
            {
                return !XmlString.IsNullOrEmpty() ? WriteRDLCReport(XmlString) : $"../../Reports/{Nomfile.Trim()}.rdlc";
            }
        }

        public static void Deletefile(string path,string rdlc)
        {
            if (!Pbl.Param.Localrdlc)
            {
                if (!rdlc.IsNullOrEmpty())
                {
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
            }

        }
        private static void Imprime(decimal numImpressao, bool pOS)
        {
            for (int i = 0; i < numImpressao; i++)
            {
                _reportViewer1.Print(pOS);
            }
        }
        public static (string moedadesc, decimal total) BuildExtenso(string tabela,DS Ds)
        {
            (string moedadesc, decimal total) xx = ("", 0);
            if (Ds != null)
            {
                string moeda = Ds?.Tables[$"{tabela.Trim()}"].Rows[0]["moeda"].ToString();
                if (moeda.Equals("MZN"))
                {
                    xx.total = Ds.Tables[$"{tabela.Trim()}"].Rows[0]["Total"].ToDecimal();
                    xx.moedadesc = "Metical";
                }
                else
                {
                    xx.total = Ds.Tables[$"{tabela.Trim()}"].Rows[0]["MTotal"].ToDecimal();
                    xx.moedadesc = SQL.GetValue("Descricao", "moedas", $"moeda='{Ds.Tables[$"{tabela.Trim()}"].Rows[0]["moeda"]}'");
                }
            }
            return xx;
        }
        public static string DefaultPrinter { get; set; }
        public static void FillDt2(DataTable dt2, string tbName,DataSet Ds)
        {
            if (dt2 !=null)
            {
                int colReais;
                if (Ds.Tables[$"{tbName}"].HasRows())
                {
                    Ds.Tables[$"{tbName}"].Rows.Clear();
                }
                if (Ds.Tables[$"{tbName}"].Columns.Count > dt2.Columns.Count)
                {
                    colReais = Ds.Tables[$"{tbName}"].Columns.Count-(Ds.Tables[$"{tbName}"].Columns.Count - dt2.Columns.Count);
                }
                else
                {
                    colReais = Ds.Tables[$"{tbName}"].Columns.Count;
                }
                for (var j = 0; j < colReais; j++)
                {
                    Ds.Tables[$"{tbName}"].Columns[j].DataType = dt2.Columns[j].DataType;  
                }
                for (var i = 0; i < dt2.Rows.Count; i++)
                {
                    if (dt2.Rows[i] == null) continue;
                    var r = Ds.Tables[$"{tbName}"].NewRow();                  
                    for (var j = 0; j < colReais; j++)
                    {
                        var tipo = dt2.Rows[i][j].GetType();
                        if (tipo==typeof(DateTime))
                        {
                            r[j] = ((DateTime)dt2.Rows[i][j]).ToShortDateString();  
                        }
                        else if (tipo==typeof(decimal))
                        {
                            r[j] = dt2.Rows[i][j].ToString().ToDecimal();  
                        }
                        else if (tipo==typeof(DBNull))
                        {
                            r[j] = dt2.Rows[i][j].ToString().ToDecimal();  
                        }
                        else
                        {
                            r[j] = dt2.Rows[i][j].ToString();
                        }
                        
                    }
                    Ds.Tables[$"{tbName}"].Rows.Add(r);
                }
            }
            else
            {
                MsBox.Show("A pesquisa não encontrou nada para os parametros indicados");
                Cancelado = true;
            }
        }
        public static void FillDt3(DataTable dt2, string tbName, DataSet Ds)
        {
            if (dt2 != null)
            {
                var dt = Ds?.Tables[$"{tbName}"];
                if (dt.HasRows())
                {
                    dt.Rows.Clear();
                }
                foreach (var row in dt2.AsEnumerable())
                {
                    if (row != null)
                    {
                        var r = dt.NewRow();
                        foreach (DataColumn col in dt.Columns)
                        {
                            if (dt2.Columns.Contains(col.ColumnName))
                            {
                                r[col.ColumnName] = row[col.ColumnName];
                            }
                        }
                        dt.Rows.Add(r);
                    }
                }
            }
            else
            {
                MsBox.Show("A pesquisa não encontrou nada para os parametros indicados");
                Cancelado = true;
            }
        }
        public static bool Cancelado { get; set; }
        public static void GetSetListParameter(PrintSetup Ps,LocalReport reportViewer1)
        {
            var ListaParam = new List<ReportParameter>();
            foreach (var p in reportViewer1.GetParameters())
            {
                switch (p.Name)
                {
                    case "SoftwareVersion":
                        ListaParam.Add(new ReportParameter("SoftwareVersion", Pbl.Info));
                        break;
                    case "Data":
                        ListaParam.Add(new ReportParameter("Data", Pbl.SqlDate.ToLongDateString()));
                        break;
                    case "Statusdocumento":
                        ListaParam.Add(new ReportParameter("Statusdocumento", "Original"));
                        break;
                    case "MoedaNacional":
                        ListaParam.Add(new ReportParameter("MoedaNacional", Pbl.MoedaBase));
                        break;
                    case "LinguaNacional":
                        ListaParam.Add(new ReportParameter("LinguaNacional", Ps.LinguaNacional));
                        break;
                    case "Filtro":
                        ListaParam.Add(new ReportParameter("Filtro", Ps.Filtro));
                        break;
                    case "cTituloRelatorio":
                        ListaParam.Add(new ReportParameter("cTituloRelatorio", Ps.CTituloRelatorio));
                        break;
                    case "Login":
                        ListaParam.Add(new ReportParameter("Login", Pbl.Usr.Login));
                        break;
                    case "Mostranib":
                        ListaParam.Add(new ReportParameter("Mostranib", Pbl.Param.Mostranib.ToString().ToLower()));
                        break;
                    case "Entidade":
                        ListaParam.Add(new ReportParameter("Entidade", Ps.EntidadePrint));
                        break;
                    case "pUtilizador":
                        ListaParam.Add(new ReportParameter("pUtilizador", Pbl.Usr.Nome));
                        break;
                    case "DataDoccc":
                        ListaParam.Add(new ReportParameter("DataDoccc", DataHora.ToLongDateString()));
                        break;
                    case "Intervalo":
                        ListaParam.Add(new ReportParameter("Intervalo", Ps.Intervalo));
                        break;
                    case "NomeProduto":
                        ListaParam.Add(new ReportParameter("NomeProduto", Ps.NomeProduto));
                        break;
                        // 
                    case "Docgravacao":
                        ListaParam.Add(new ReportParameter("Docgravacao", Ps.Inserindo?"Previsão - (Documento não gravado)":""));
                        break;
                    case "Extenso":
                        if (Ps.Ds.Tables[Ps.DtPrint.TableName.Trim()].Columns.Contains("Total"))
                        {
                            if (Ps.Ds.Tables[Ps.DtPrint.TableName.Trim()].Rows[0]["Total"].ToString().ToDecimal() != 0)
                            {
                                var extenso = BuildExtenso(Ps.DtPrint.TableName.Trim(), Ps.Ds);
                                if (Ps.LinguaNacional.Equals("PT"))
                                {
                                    ListaParam.Add(new ReportParameter("Extenso", extenso.total.ToExtenso(extenso.moedadesc.ToUpper().Trim())));
                                }
                                else
                                {
                                    ListaParam.Add(new ReportParameter("Extenso", $"{extenso.total.ToExtensoEng()} {extenso.moedadesc.ToUpper().Trim()}"));
                                }
                            }
                            else
                            {
                                ListaParam.Add(new ReportParameter("Extenso", "ZERRO"));
                            }
                        }
                        else
                        {
                            if (Ps.LinguaNacional.Equals("PT"))
                            {
                                ListaParam.Add(new ReportParameter("Extenso", 0.ToDecimal().ToExtenso("Metical".ToUpper().Trim())));
                            }
                            else
                            {
                                ListaParam.Add(new ReportParameter("Extenso", $"{0.ToDecimal().ToExtensoEng()} {"Dollar".ToUpper().Trim()}"));
                            }
                        }
                        break;

                }
            }
            if (Ps.ListaParam != null)
            {
                foreach (ReportParameter p in Ps.ListaParam)
                {
                    if (p != null)
                    {
                        switch (p.Name)
                        {
                            case "valorareceber":
                                ListaParam.Add(p);
                                break;
                        }
                    }
                }
            }
            reportViewer1.SetParameters(ListaParam);
        }
        public static void PrintReport(List<ReportParameter> lista, bool impressoraNormal)
        {
            var tmpPrt = GenBl.PrintCaixa(Pbl.SqlDate, Pbl.Usr.Codtz.ToDecimal());
            var ds = new DS { EnforceConstraints = false };
            _reportViewer1 = new LocalReport { ReportPath = @"../../Reports/Caixapos.rdlc" };
            FillDt(ds, tmpPrt, "DMZ");
            _reportViewer1.SetParameters(lista);
            // SetReportDataSource("DMZ",ds,"",impressoraNormal);
        }

        public static void FillContas(DS ds)
        {
            FillDt3(Pbl.ContasEmpresa, "Contas", ds);
        }

    }
}
