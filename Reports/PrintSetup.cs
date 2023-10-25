
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DMZ.UI.Reports
{
    public class PrintSetup
    {
        public bool Inserindo { get; set; }
        public string OrigemlabelText { get; set; }
        public string CLocalStamp { get; set; }
        public string No { get; set; }
        public string Nomfile { get; set; }
        public string Origem { get; set; }
        public Form MdiForm { get; set; }
        public string XmlString { get; set; }
        public DataTable DtPrint { get;  set; }
        public DataTable Formasp { get;  set; }
        public DS Ds { get; internal set; }
        public bool UseFormasp { get;  set; }
        public string Filtro { get;  set; }
        public string CTituloRelatorio { get;  set; }
        public string Impressora { get;  set; }
        public decimal NrCopias { get;  set; }
        public List<string> ListaTipodoc { get;  set; }
        public string LinguaNacional { get;  set; }
        public string Intervalo { get;  set; }
        public string NomeProduto { get;  set; }
        public string EntidadePrint { get;  set; }
        public List<ReportParameter> ListaParam { get;  set; }
        public ReportDataSource DataSource2 { get;  set; }
        public ReportDataSource DataSource3 { get;  set; }
        public ReportDataSource DataSource4 { get;  set; }
        public ReportDataSource DataSource5 { get;  set; }
        public string DatasetName { get; set; }  = "DataSet1";
        public ReportDataSource Horario { get;  set; }
        public ReportDataSource Turmadisc { get;  set; }
        public string ReportPath { get; set; } = "";
        public bool POS { get; internal set; }
    }
}
