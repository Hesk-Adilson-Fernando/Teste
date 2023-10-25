using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DMZ.UI.Reports
{
    public partial class FrmPrintset : FrmClasse2
    {
        public FrmPrintset()
        {
            InitializeComponent();
            Ps = new PrintSetup();
        }
        public PrintSetup Ps;
        public Action<string,decimal,List<string>,string,string> DadosEnviados { get; internal set; }
        public bool ShowPreviewButton { get; set; } = true;
        private void FrmPrintset_Load(object sender, EventArgs e)
        {
            //ReportHelper.PrinterList(comboBox1);
            if (!Pbl.Impressoras.HasRows())
            {
                Pbl.Impressoras = ReportHelper.PrinterList();
            }
            comboBox1.DataSource = Pbl.Impressoras;
            comboBox1.DisplayMember = "Descricao";
            comboBox1.Text = Pbl.Impressoras.Select("Defa=1")[0]["Descricao"].ToString();
            NrCopias.Value=1;
           //tbImpressora.tb1.Text=Pbl.Usr.Impnormal;
           cbOriginal.Update(true);
           cbPT.Update(true);
           cbA4.Update(true);
            btnPreview.Visible = ShowPreviewButton;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {
                var lista = new List<string>();
                if (cbOriginal.cb1.Checked)
                    lista.Add(cbOriginal.CbText.ToUpper());
                if (cbDuplicado.cb1.Checked)
                    lista.Add(cbDuplicado.CbText.ToUpper());
                if (cbTriplicado.cb1.Checked)
                    lista.Add(cbTriplicado.CbText.ToUpper());
                string tipoPapel="";
                if (cbA4.cb1.Checked)
                {
                    tipoPapel = "A4";
                }
                if (cbA5.cb1.Checked)
                {
                    tipoPapel = "A5";
                }
                Ps.LinguaNacional = cbPT.cb1.Checked ? UI.Linguas.PT.ToString() : UI.Linguas.EN.ToString();
                if (DadosEnviados==null)
                {
                    Ps.Impressora = comboBox1.Text.Trim();
                    Ps.NrCopias = NrCopias.Value;
                    Ps.ListaTipodoc = lista;
                    ReportHelper.PrintReport(Ps);
                }
                else
                {
                    DadosEnviados.Invoke(comboBox1.Text.Trim(), NrCopias.Value, lista, Ps.LinguaNacional, tipoPapel);
                }
                
            }
            else
            {
                MsBox.Show("Deve indicar a impressora destino! ");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pbl.Impressoras = ReportHelper.PrinterList();
            comboBox1.DataSource = Pbl.Impressoras;
            comboBox1.DisplayMember = "Descricao";
            comboBox1.Text = Pbl.Impressoras.Select("Defa=1")[0]["Descricao"].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dmzCMexport.ShowMenuStrip(btnOptions);
        }



        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (Ps != null)
            {
                if (cbSvia.cb1.Checked)
                {
                    if (Ps.DtPrint.TableName =="Fact")
                    {
                        foreach (DataRow item in Ps.DtPrint.Rows)
                        {
                            item["SegundaVia"] = true;
                        }
                    }                   
                }
                Ps.LinguaNacional = cbPT.cb1.Checked ? UI.Linguas.PT.ToString() : UI.Linguas.EN.ToString();
                //Ps.CLocalStamp, Ps.OrigemlabelText, Ps.No, Ps.Nomfile, Ps.Origem, Ps.MdiForm, cbPT.cb1.Checked ? UI.Linguas.PT : UI.Linguas.EN, Ps.XmlString,Ps.Ds,Ps.DtPrint, Ps.Formasp, Ps.UseFormasp,Ps.Filtro,Ps.CTituloRelatorio,Ps.Lista
                Imprimir.DoPrint(Ps);
                Close();
            }
            else
            {
                MsBox.Show("Parâmetros não configurados");
            }
        }

        private void cbPT_CheckedChangeds()
        {
            cbING.Update(!cbPT.cb1.Checked);
        }

        private void cbING_CheckedChangeds()
        {
            cbPT.Update(!cbING.cb1.Checked);
        }

        private void cbDefault2_Load(object sender, EventArgs e)
        {

        }

        private void cbA4_CheckedChangeds()
        {
            cbA5.Update(!cbA4.cb1.Checked);
        }

        private void cbA5_CheckedChangeds()
        {
            cbA4.Update(!cbA5.cb1.Checked);
        }

        private void cbSvia_CheckedChangeds()
        {
            //cbOriginal.Update(!cbSvia.cb1.Checked); 
            //cbDuplicado.Update(!cbSvia.cb1.Checked);
            //cbTriplicado.Update(!cbSvia.cb1.Checked);
        }
    }

    
}
