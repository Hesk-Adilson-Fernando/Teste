using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DMZ.UI.Basic;
using Microsoft.Reporting.WinForms;

namespace DMZ.UI.Reports
{
    public partial class FrmGenreport : FrmClasse2
    {
        public FrmGenreport()
        {
            InitializeComponent();
        }
        public DataTable Gendt { get; set; }
        private void TesteReport_Load(object sender, EventArgs e)
        {
            const string dsName = "DataSet1";
            var gen = new ReportGenerator(Gendt, dsName) {Titulo = Titulo, Filtro = Filtro};
            var ds = new ReportDataSource(dsName, Gendt);
            ReportViewer1.Reset();
            ReportViewer1.LocalReport.DataSources.Add(ds);
            ReportViewer1.LocalReport.DisplayName = "Mapa";
            ReportViewer1.LocalReport.LoadReportDefinition(gen.GeneraReport());
            ReportViewer1.RefreshReport();
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
                    if (!frm.IsMdiContainer) continue;
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
        public string Titulo { get; set; }
        public string Filtro { get; set; }
    }
}
