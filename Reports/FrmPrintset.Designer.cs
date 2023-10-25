
namespace DMZ.UI.Reports
{
    partial class FrmPrintset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintset));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NrCopias = new System.Windows.Forms.NumericUpDown();
            this.btncancelar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbSvia = new DMZ.UI.UC.CbDefault();
            this.dmzOptionGroup2 = new DMZ.UI.UC.DmzOptionGroup();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cbA5 = new DMZ.UI.UC.CbDefault();
            this.cbA4 = new DMZ.UI.UC.CbDefault();
            this.dmzOptionGroup1 = new DMZ.UI.UC.DmzOptionGroup();
            this.cbING = new DMZ.UI.UC.CbDefault();
            this.cbPT = new DMZ.UI.UC.CbDefault();
            this.cbDuplicado = new DMZ.UI.UC.CbDefault();
            this.cbOriginal = new DMZ.UI.UC.CbDefault();
            this.cbTriplicado = new DMZ.UI.UC.CbDefault();
            this.dmzCMexport = new DMZ.UI.UC.DMZContextMenuStrip();
            this.exportarDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarParaWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarParaPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarParaExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NrCopias)).BeginInit();
            this.panel5.SuspendLayout();
            this.dmzOptionGroup2.SuspendLayout();
            this.dmzOptionGroup1.SuspendLayout();
            this.dmzCMexport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(-1, 1);
            this.panel4.Size = new System.Drawing.Size(389, 29);
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(357, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.Text = "Definições ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 421);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(386, 5);
            this.panel7.TabIndex = 101;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnOptions);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NrCopias);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 385);
            this.panel1.TabIndex = 102;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.BackColor = System.Drawing.SystemColors.Control;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnOptions.ForeColor = System.Drawing.Color.Navy;
            this.btnOptions.Image = global::DMZ.UI.Properties.Resources.External_Link_251px;
            this.btnOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOptions.Location = new System.Drawing.Point(3, 350);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(105, 28);
            this.btnOptions.TabIndex = 110;
            this.btnOptions.Text = "EXPORTAR";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Visible = false;
            this.btnOptions.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Image = global::DMZ.UI.Properties.Resources.Refresh_18px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(4, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 22);
            this.button1.TabIndex = 108;
            this.button1.Text = "Impressora";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(372, 21);
            this.comboBox1.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(3, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 105;
            this.label2.Text = "Nº Cópias";
            // 
            // NrCopias
            // 
            this.NrCopias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrCopias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.NrCopias.Location = new System.Drawing.Point(3, 314);
            this.NrCopias.Name = "NrCopias";
            this.NrCopias.Size = new System.Drawing.Size(105, 23);
            this.NrCopias.TabIndex = 104;
            this.NrCopias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.MistyRose;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btncancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btncancelar.Image = global::DMZ.UI.Properties.Resources.cancel_201px;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(177, 351);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(97, 27);
            this.btncancelar.TabIndex = 102;
            this.btncancelar.Text = "FECHAR";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.button3.ForeColor = System.Drawing.Color.LightCoral;
            this.button3.Image = global::DMZ.UI.Properties.Resources.printer_out_of_paper_22px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(276, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 28);
            this.button3.TabIndex = 94;
            this.button3.Text = "IMPRIMIR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cbSvia);
            this.panel5.Controls.Add(this.dmzOptionGroup2);
            this.panel5.Controls.Add(this.dmzOptionGroup1);
            this.panel5.Controls.Add(this.cbDuplicado);
            this.panel5.Controls.Add(this.cbOriginal);
            this.panel5.Controls.Add(this.cbTriplicado);
            this.panel5.Location = new System.Drawing.Point(3, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(374, 226);
            this.panel5.TabIndex = 93;
            // 
            // cbSvia
            // 
            this.cbSvia.BackColor = System.Drawing.Color.Transparent;
            this.cbSvia.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSvia.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSvia.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSvia.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbSvia.CbText = "Segunda Via";
            this.cbSvia.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSvia.Imagem = ((System.Drawing.Image)(resources.GetObject("cbSvia.Imagem")));
            this.cbSvia.IsOptionGroup = false;
            this.cbSvia.IsReadOnly = false;
            this.cbSvia.IsRequered = false;
            this.cbSvia.Location = new System.Drawing.Point(264, 3);
            this.cbSvia.Name = "cbSvia";
            this.cbSvia.OnlyCheckBox = false;
            this.cbSvia.Size = new System.Drawing.Size(110, 22);
            this.cbSvia.TabIndex = 110;
            this.cbSvia.Value = null;
            this.cbSvia.Value2 = null;
            this.cbSvia.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbSvia_CheckedChangeds);
            // 
            // dmzOptionGroup2
            // 
            this.dmzOptionGroup2.BackColor = System.Drawing.Color.Beige;
            this.dmzOptionGroup2.ButtonCount = 0;
            this.dmzOptionGroup2.Controls.Add(this.btnPreview);
            this.dmzOptionGroup2.Controls.Add(this.cbA5);
            this.dmzOptionGroup2.Controls.Add(this.cbA4);
            this.dmzOptionGroup2.Imagem = ((System.Drawing.Image)(resources.GetObject("dmzOptionGroup2.Imagem")));
            this.dmzOptionGroup2.IsRequered = false;
            this.dmzOptionGroup2.Label1Text = "Tipo de papel";
            this.dmzOptionGroup2.Location = new System.Drawing.Point(2, 127);
            this.dmzOptionGroup2.Name = "dmzOptionGroup2";
            this.dmzOptionGroup2.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dmzOptionGroup2.Size = new System.Drawing.Size(374, 93);
            this.dmzOptionGroup2.TabIndex = 90;
            this.dmzOptionGroup2.Value = null;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnPreview.FlatAppearance.BorderSize = 0;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnPreview.ForeColor = System.Drawing.Color.Snow;
            this.btnPreview.Image = global::DMZ.UI.Properties.Resources.printer_error_22px;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreview.Location = new System.Drawing.Point(262, 65);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(105, 28);
            this.btnPreview.TabIndex = 109;
            this.btnPreview.Text = "PREVISÃO";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cbA5
            // 
            this.cbA5.BackColor = System.Drawing.Color.Transparent;
            this.cbA5.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbA5.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbA5.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbA5.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbA5.CbText = "A5";
            this.cbA5.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbA5.Imagem = ((System.Drawing.Image)(resources.GetObject("cbA5.Imagem")));
            this.cbA5.IsOptionGroup = false;
            this.cbA5.IsReadOnly = false;
            this.cbA5.IsRequered = false;
            this.cbA5.Location = new System.Drawing.Point(3, 63);
            this.cbA5.Name = "cbA5";
            this.cbA5.OnlyCheckBox = false;
            this.cbA5.Size = new System.Drawing.Size(90, 22);
            this.cbA5.TabIndex = 89;
            this.cbA5.Value = null;
            this.cbA5.Value2 = null;
            this.cbA5.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbA5_CheckedChangeds);
            // 
            // cbA4
            // 
            this.cbA4.BackColor = System.Drawing.Color.Transparent;
            this.cbA4.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbA4.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbA4.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbA4.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbA4.CbText = "A4";
            this.cbA4.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbA4.Imagem = ((System.Drawing.Image)(resources.GetObject("cbA4.Imagem")));
            this.cbA4.IsOptionGroup = false;
            this.cbA4.IsReadOnly = false;
            this.cbA4.IsRequered = false;
            this.cbA4.Location = new System.Drawing.Point(3, 35);
            this.cbA4.Name = "cbA4";
            this.cbA4.OnlyCheckBox = false;
            this.cbA4.Size = new System.Drawing.Size(90, 22);
            this.cbA4.TabIndex = 88;
            this.cbA4.Value = null;
            this.cbA4.Value2 = null;
            this.cbA4.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbA4_CheckedChangeds);
            // 
            // dmzOptionGroup1
            // 
            this.dmzOptionGroup1.BackColor = System.Drawing.Color.MistyRose;
            this.dmzOptionGroup1.ButtonCount = 0;
            this.dmzOptionGroup1.Controls.Add(this.cbING);
            this.dmzOptionGroup1.Controls.Add(this.cbPT);
            this.dmzOptionGroup1.Imagem = ((System.Drawing.Image)(resources.GetObject("dmzOptionGroup1.Imagem")));
            this.dmzOptionGroup1.IsRequered = false;
            this.dmzOptionGroup1.Label1Text = "Lingua";
            this.dmzOptionGroup1.Location = new System.Drawing.Point(2, 28);
            this.dmzOptionGroup1.Name = "dmzOptionGroup1";
            this.dmzOptionGroup1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzOptionGroup1.Size = new System.Drawing.Size(374, 93);
            this.dmzOptionGroup1.TabIndex = 88;
            this.dmzOptionGroup1.Value = null;
            // 
            // cbING
            // 
            this.cbING.BackColor = System.Drawing.Color.Transparent;
            this.cbING.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbING.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbING.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbING.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbING.CbText = "INGLÊS";
            this.cbING.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbING.Imagem = ((System.Drawing.Image)(resources.GetObject("cbING.Imagem")));
            this.cbING.IsOptionGroup = false;
            this.cbING.IsReadOnly = false;
            this.cbING.IsRequered = false;
            this.cbING.Location = new System.Drawing.Point(3, 63);
            this.cbING.Name = "cbING";
            this.cbING.OnlyCheckBox = false;
            this.cbING.Size = new System.Drawing.Size(90, 22);
            this.cbING.TabIndex = 89;
            this.cbING.Value = null;
            this.cbING.Value2 = null;
            this.cbING.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbING_CheckedChangeds);
            // 
            // cbPT
            // 
            this.cbPT.BackColor = System.Drawing.Color.Transparent;
            this.cbPT.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPT.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPT.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPT.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbPT.CbText = "PORTUGÊS";
            this.cbPT.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPT.Imagem = ((System.Drawing.Image)(resources.GetObject("cbPT.Imagem")));
            this.cbPT.IsOptionGroup = false;
            this.cbPT.IsReadOnly = false;
            this.cbPT.IsRequered = false;
            this.cbPT.Location = new System.Drawing.Point(3, 35);
            this.cbPT.Name = "cbPT";
            this.cbPT.OnlyCheckBox = false;
            this.cbPT.Size = new System.Drawing.Size(90, 22);
            this.cbPT.TabIndex = 88;
            this.cbPT.Value = null;
            this.cbPT.Value2 = null;
            this.cbPT.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbPT_CheckedChangeds);
            // 
            // cbDuplicado
            // 
            this.cbDuplicado.BackColor = System.Drawing.Color.Transparent;
            this.cbDuplicado.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDuplicado.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDuplicado.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDuplicado.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDuplicado.CbText = "Duplicado";
            this.cbDuplicado.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDuplicado.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDuplicado.Imagem")));
            this.cbDuplicado.IsOptionGroup = false;
            this.cbDuplicado.IsReadOnly = false;
            this.cbDuplicado.IsRequered = false;
            this.cbDuplicado.Location = new System.Drawing.Point(83, 3);
            this.cbDuplicado.Name = "cbDuplicado";
            this.cbDuplicado.OnlyCheckBox = false;
            this.cbDuplicado.Size = new System.Drawing.Size(90, 22);
            this.cbDuplicado.TabIndex = 86;
            this.cbDuplicado.Value = null;
            this.cbDuplicado.Value2 = null;
            // 
            // cbOriginal
            // 
            this.cbOriginal.BackColor = System.Drawing.Color.Transparent;
            this.cbOriginal.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbOriginal.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbOriginal.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOriginal.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbOriginal.CbText = "Original";
            this.cbOriginal.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbOriginal.Imagem = ((System.Drawing.Image)(resources.GetObject("cbOriginal.Imagem")));
            this.cbOriginal.IsOptionGroup = false;
            this.cbOriginal.IsReadOnly = false;
            this.cbOriginal.IsRequered = false;
            this.cbOriginal.Location = new System.Drawing.Point(3, 3);
            this.cbOriginal.Name = "cbOriginal";
            this.cbOriginal.OnlyCheckBox = false;
            this.cbOriginal.Size = new System.Drawing.Size(90, 22);
            this.cbOriginal.TabIndex = 85;
            this.cbOriginal.Value = null;
            this.cbOriginal.Value2 = null;
            // 
            // cbTriplicado
            // 
            this.cbTriplicado.BackColor = System.Drawing.Color.Transparent;
            this.cbTriplicado.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTriplicado.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTriplicado.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTriplicado.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbTriplicado.CbText = "Triplicado";
            this.cbTriplicado.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTriplicado.Imagem = ((System.Drawing.Image)(resources.GetObject("cbTriplicado.Imagem")));
            this.cbTriplicado.IsOptionGroup = false;
            this.cbTriplicado.IsReadOnly = false;
            this.cbTriplicado.IsRequered = false;
            this.cbTriplicado.Location = new System.Drawing.Point(180, 3);
            this.cbTriplicado.Name = "cbTriplicado";
            this.cbTriplicado.OnlyCheckBox = false;
            this.cbTriplicado.Size = new System.Drawing.Size(90, 22);
            this.cbTriplicado.TabIndex = 87;
            this.cbTriplicado.Value = null;
            this.cbTriplicado.Value2 = null;
            // 
            // dmzCMexport
            // 
            this.dmzCMexport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzCMexport.ContextBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzCMexport.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.dmzCMexport.ForeColor = System.Drawing.Color.White;
            this.dmzCMexport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarDocumentoToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripComboBox1});
            this.dmzCMexport.Name = "dmzCMexport";
            this.dmzCMexport.Size = new System.Drawing.Size(182, 59);
            // 
            // exportarDocumentoToolStripMenuItem
            // 
            this.exportarDocumentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarParaWordToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportarParaPDFToolStripMenuItem,
            this.toolStripSeparator3,
            this.exportarParaExcelToolStripMenuItem});
            this.exportarDocumentoToolStripMenuItem.Name = "exportarDocumentoToolStripMenuItem";
            this.exportarDocumentoToolStripMenuItem.ShowShortcutKeys = false;
            this.exportarDocumentoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exportarDocumentoToolStripMenuItem.Text = "Exportar documento";
            // 
            // exportarParaWordToolStripMenuItem
            // 
            this.exportarParaWordToolStripMenuItem.Checked = true;
            this.exportarParaWordToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportarParaWordToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exportarParaWordToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Microsoft_Word_25px;
            this.exportarParaWordToolStripMenuItem.Name = "exportarParaWordToolStripMenuItem";
            this.exportarParaWordToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exportarParaWordToolStripMenuItem.Text = "Word";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // exportarParaPDFToolStripMenuItem
            // 
            this.exportarParaPDFToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.PDF_25px;
            this.exportarParaPDFToolStripMenuItem.Name = "exportarParaPDFToolStripMenuItem";
            this.exportarParaPDFToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exportarParaPDFToolStripMenuItem.Text = "PDF";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(100, 6);
            // 
            // exportarParaExcelToolStripMenuItem
            // 
            this.exportarParaExcelToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Microsoft_Excel_25px;
            this.exportarParaExcelToolStripMenuItem.Name = "exportarParaExcelToolStripMenuItem";
            this.exportarParaExcelToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exportarParaExcelToolStripMenuItem.Text = "Excel";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Tamanho da Página",
            "100%",
            "150%",
            "200%"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "100%";
            // 
            // FrmPrintset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(386, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Name = "FrmPrintset";
            this.Text = "FrmPrintset";
            this.Load += new System.EventHandler(this.FrmPrintset_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NrCopias)).EndInit();
            this.panel5.ResumeLayout(false);
            this.dmzOptionGroup2.ResumeLayout(false);
            this.dmzOptionGroup1.ResumeLayout(false);
            this.dmzCMexport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private UC.CbDefault cbDuplicado;
        private UC.CbDefault cbOriginal;
        private UC.CbDefault cbTriplicado;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NrCopias;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private UC.DmzOptionGroup dmzOptionGroup1;
        private UC.CbDefault cbING;
        private UC.CbDefault cbPT;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnOptions;
        private UC.DMZContextMenuStrip dmzCMexport;
        private System.Windows.Forms.ToolStripMenuItem exportarDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarParaWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportarParaPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exportarParaExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private UC.DmzOptionGroup dmzOptionGroup2;
        private UC.CbDefault cbA5;
        private UC.CbDefault cbA4;
        private UC.CbDefault cbSvia;
    }
}