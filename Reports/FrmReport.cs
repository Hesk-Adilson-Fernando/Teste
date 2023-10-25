using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.DAL.Classes;
using DMZ.UI.Classes;
using Microsoft.Reporting.WinForms;
using System.Runtime.InteropServices;
using DMZ.UI.Basic;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;


namespace DMZ.UI.Reports
{
    public partial class FrmReport : FrmClasse2
    {
        [DllImport("Winspool.drv")]
        private static extern bool SetDefaultPrinter(string printerName);
        public FrmReport()
        {
            InitializeComponent();
            toolStrip = (ToolStrip)reportViewer1.Controls.Find("toolStrip1", true)[0];
        }
        private ToolStrip toolStrip;
        public string TabelaName { get; set; }
        string path = Application.StartupPath;
        private string _reportPath;

        public string TempReportFullPath { get; set; }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            Cancelado = false;
            toolStrip.Visible = false;
            cbOriginal.Update(true);
            if (!Pbl.Impressoras.HasRows())
            {
                Pbl.Impressoras = ReportHelper.PrinterList();
            }
            comboBox1.DataSource = Pbl.Impressoras;
            comboBox1.DisplayMember = "Descricao";
            comboBox1.Text = Pbl.Impressoras.Select("Defa=1")[0]["Descricao"].ToString();
            reportViewer1.LocalReport.EnableExternalImages = true;
            if (Ps.Ds == null)
            {
                Ps.Ds = new DS {EnforceConstraints = false};
            }
            using (var con = new GCon())
            {
                Ps.Ds.EnforceConstraints = false;                
                if (Ps.DtPrint.HasRows())
                {
                    TabelaName = Ps.DtPrint.TableName.Trim();
                    ReportHelper.KillPrimaryKey(Ps.Ds.Tables[TabelaName]);
                }
                ReportHelper.ExecCases(Ps,con);
                _reportPath = ReportHelper.SetReportPath(Ps);
            }
            if (Cancelado) return;
            if (!string.IsNullOrEmpty(_reportPath))
            {
                ReportHelper.SetReportDataSource(Ps, reportViewer1.LocalReport, _reportPath);
                ReportHelper.GetSetListParameter(Ps,reportViewer1.LocalReport);
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.PageWidth;
                reportViewer1.RefreshReport();
                Updatecontrols();
            }
            else
            {
                MsBox.Show("Desculpa o ficheiro de impressão não foi definido, \r\n Defina na configuração do documento que está a imprimir!");
            }
        }

        private void Updatecontrols()
        {
            reportViewer1.Refresh();
            tbPaginas.Text = reportViewer1.CurrentPage.ToString() + "/" + reportViewer1.GetTotalPages();
            //tsTbPaginaactual.KeyPress += KeyPressEvento;
        }

        public bool Cancelado { get; set; }
        public DataTable Dt { get; set; }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MsBox.Show("Deve selecionar a impressora!..");
                return;
            }
            var defaultPrinter = reportViewer1.PrinterSettings.PrinterName.Trim();
            var lista = new List<string>();
            if(cbOriginal.cb1.Checked)
                lista.Add(cbOriginal.CbText);
            if (cbDuplicado.cb1.Checked)
                lista.Add(cbDuplicado.CbText);
            if (cbTriplicado.cb1.Checked)
                lista.Add(cbTriplicado.CbText);
            ReportParameterInfo StatusdocumentoParam;
            StatusdocumentoParam = reportViewer1.LocalReport.GetParameters().FirstOrDefault(x => x.Name.Equals("Statusdocumento"));
            if (reportViewer1.PrinterSettings.PrinterName.Trim() !=comboBox1.Text.Trim())
            {
                //Set the default printer.
                SetDefaultPrinter(comboBox1.Text.Trim());  
            }
            
            if (StatusdocumentoParam != null)
            {
                foreach (var rp in lista.Select(tipodocumento => new ReportParameter("Statusdocumento", tipodocumento)))
                {
                    reportViewer1.LocalReport.SetParameters(new[] { rp });
                    ImprimirDoc();
                }
            }
            else
            {
                ImprimirDoc();
            }
            SetDefaultPrinter(defaultPrinter);
        }

        private void ImprimirDoc()
        {
            for (int i = 0; i < NrCopias.Value; i++)
            {
                reportViewer1.RefreshReport();
                reportViewer1.LocalReport.Print();
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
           dmzCMexport.ShowMenuStrip(btnOptions);
        }

        private void exportarParaWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToFile("Word");
        }

        private void exportarParaExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToFile("Excel");
        }

        private void exportarParaPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToFile("Pdf");
        }
        private void ExportToFile(string sender)
        {
            try
            {
                var x = reportViewer1.LocalReport.ListRenderingExtensions();
                RenderingExtension render = null;

                switch (sender)
                {
                    case "Word":
                        render = x[5];
                        break;
                    case "Excel":
                        render = x[1];
                        break;
                    case "Pdf":
                        render = x[3];
                        break;
                }

                if (render == null) return;
                var dr = reportViewer1.ExportDialog(render);
                if (dr == DialogResult.OK)
                    MsBox.Show("Executado com sucesso!");
            }
            catch (Exception x)
            {
                    MsBox.Show(x.Message);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // ExecutePercentClick(toolStripComboBox1.Text);
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (!Maximizado)
            {
                Maximizar();
            }
            else
            {
                Minimizar();
            }
        }

        public bool Maximizado { get; set; }
        private void Maximizar()
        {
            NSize = Size;
            NLocation = Location;
            if (MdiParent != null)
            {
                var height = MdiParent.Size.Height;
                var width = MdiParent.Size.Width;
                Size = new Size(width - 190, height - 165);
                var x = MdiParent.Location.X;
                var y = MdiParent.Location.Y;
                Location = new Point(x + 175, y + 110);
                Maximizado = true;
                var lista = Application.OpenForms;
                foreach (Form frm in lista)
                {
                    if (frm == null) continue;
                    if (frm.IsMdiContainer)
                    {
                        if (frm is DemoMdi)
                        {
                            if (((DemoMdi) frm).Ocultado)
                            {
                                MoveUp();
                            }
                        }
                        else
                        {
                            MoveUp();
                        }
                    }
                }
            }
            else
            {
                var height = Screen.PrimaryScreen.WorkingArea.Size.Height;
                var width = Screen.PrimaryScreen.WorkingArea.Size.Width;
                Size = new Size(width - 190, height - 165);
                var x = Screen.PrimaryScreen.WorkingArea.Location.X;
                var y = Screen.PrimaryScreen.WorkingArea.Location.Y;
                Location = new Point(x + 175, y + 110);    
            }
        }
        public void MoveUp()
        {
            NSize = Size;
            NLocation = Location;
            var height = MdiParent.Size.Height;
            var width = MdiParent.Size.Width;
            Size = new Size(width - 70, height - 165);
            var x = MdiParent.Location.X;
            var y = MdiParent.Location.Y;
            Location = new Point(48, y + 110);
        }
        public void MoveDow()
        {
            Size = NSize;
            Location = NLocation;
        }
        public void Minimizar()
        {
            Size = NSize;
            Location = NLocation;
            Maximizado = false;
        }
        public Size NSize { get; set; }
        public Point NLocation { get; set; }
        public PrintSetup Ps { get; internal set; }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsBtnFirst_Click(object sender, EventArgs e)
        {
            ((ToolStripButton) toolStrip.Items[0]).PerformClick();
            Updatecontrols();
        }

        private void tsBtnBack_Click(object sender, EventArgs e)
        {
            ((ToolStripButton) toolStrip.Items[1]).PerformClick();
            Updatecontrols();
        }

        private void tsbtnNext_Click(object sender, EventArgs e)
        {
            ((ToolStripButton) toolStrip.Items[5]).PerformClick();
            Updatecontrols();
        }

        private void tsbtnLast_Click(object sender, EventArgs e)
        {
            ((ToolStripButton) toolStrip.Items[6]).PerformClick();
            Updatecontrols();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ReportHelper.Deletefile(Ps,_reportPath);
            Close();
        }

        private void toolStripButton2_DoubleClick(object sender, EventArgs e)
        {
            ((ToolStripButton)toolStrip.Items[5]).PerformClick();
            Updatecontrols();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ((ToolStripButton)toolStrip.Items[1]).PerformClick();
            reportViewer1.Refresh();
            Updatecontrols();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ((ToolStripButton)toolStrip.Items[9]).PerformClick();
            reportViewer1.Refresh();
            Updatecontrols();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //reportViewer1.CurrentPage = reportViewer1.CurrentPage + 1;
            ((ToolStripButton)toolStrip.Items[5]).PerformClick();
            reportViewer1.Refresh();
            Updatecontrols();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }


}
