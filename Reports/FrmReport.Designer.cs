using DMZ.UI.UC;

namespace DMZ.UI.Reports
{
    partial class FrmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbENReport = new DMZ.UI.UC.CbDefault();
            this.cbDuplicado = new DMZ.UI.UC.CbDefault();
            this.cbOriginal = new DMZ.UI.UC.CbDefault();
            this.cbTriplicado = new DMZ.UI.UC.CbDefault();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tbPaginas = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tsBtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBack = new System.Windows.Forms.ToolStripButton();
            this.tsTbPaginaactual = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsTbTotalpaginas = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.dmzCMexport = new DMZ.UI.UC.DMZContextMenuStrip();
            this.exportarDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarParaWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarParaPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarParaExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.NrCopias = new System.Windows.Forms.NumericUpDown();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.dmzCMexport.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NrCopias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMaxMin);
            this.panel4.Size = new System.Drawing.Size(937, 27);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnMaxMin, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DMZ.UI.Properties.Resources.DOT_25px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(910, 1);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 6);
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.Text = "Imprimir";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(6, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 397);
            this.panel1.TabIndex = 25;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DMZ.UI.Reports.RptFacc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(925, 395);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnOptions);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(7, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 44);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.NrCopias);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.cbENReport);
            this.panel5.Controls.Add(this.cbDuplicado);
            this.panel5.Controls.Add(this.cbOriginal);
            this.panel5.Controls.Add(this.cbTriplicado);
            this.panel5.Location = new System.Drawing.Point(411, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 28);
            this.panel5.TabIndex = 2;
            // 
            // cbENReport
            // 
            this.cbENReport.BackColor = System.Drawing.Color.Transparent;
            this.cbENReport.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbENReport.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbENReport.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbENReport.CbForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cbENReport.CbText = "INGLÊS";
            this.cbENReport.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbENReport.Imagem = global::DMZ.UI.Properties.Resources.unchecked_checkbox_20px;
            this.cbENReport.IsOptionGroup = false;
            this.cbENReport.IsReadOnly = false;
            this.cbENReport.IsRequered = false;
            this.cbENReport.Location = new System.Drawing.Point(381, 0);
            this.cbENReport.Name = "cbENReport";
            this.cbENReport.OnlyCheckBox = true;
            this.cbENReport.Size = new System.Drawing.Size(90, 22);
            this.cbENReport.TabIndex = 88;
            this.cbENReport.Value = null;
            this.cbENReport.Value2 = null;
            this.cbENReport.Visible = false;
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
            this.cbDuplicado.Location = new System.Drawing.Point(85, 3);
            this.cbDuplicado.Name = "cbDuplicado";
            this.cbDuplicado.OnlyCheckBox = true;
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
            this.cbOriginal.OnlyCheckBox = true;
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
            this.cbTriplicado.Location = new System.Drawing.Point(181, 3);
            this.cbTriplicado.Name = "cbTriplicado";
            this.cbTriplicado.OnlyCheckBox = true;
            this.cbTriplicado.Size = new System.Drawing.Size(90, 22);
            this.cbTriplicado.TabIndex = 87;
            this.cbTriplicado.Value = null;
            this.cbTriplicado.Value2 = null;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 89;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tbPaginas,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(139, 28);
            this.toolStrip1.TabIndex = 93;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::DMZ.UI.Properties.Resources.Less_Than_25px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Página anterior ";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tbPaginas
            // 
            this.tbPaginas.Name = "tbPaginas";
            this.tbPaginas.Size = new System.Drawing.Size(50, 28);
            this.tbPaginas.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::DMZ.UI.Properties.Resources.More_Than_25px;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 25);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Página seguinte";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::DMZ.UI.Properties.Resources.Refresh_202px;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 25);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnOptions.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_251px;
            this.btnOptions.Location = new System.Drawing.Point(900, 4);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(21, 34);
            this.btnOptions.TabIndex = 84;
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.btnPrint.Location = new System.Drawing.Point(870, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(28, 34);
            this.btnPrint.TabIndex = 81;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(5, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "Impressora";
            // 
            // tsBtnFirst
            // 
            this.tsBtnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tsBtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFirst.ForeColor = System.Drawing.Color.White;
            this.tsBtnFirst.Image = global::DMZ.UI.Properties.Resources.double_left_22px1;
            this.tsBtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFirst.Name = "tsBtnFirst";
            this.tsBtnFirst.Size = new System.Drawing.Size(23, 22);
            this.tsBtnFirst.Text = "toolStripButton1";
            this.tsBtnFirst.ToolTipText = "Primeira página";
            this.tsBtnFirst.Click += new System.EventHandler(this.tsBtnFirst_Click);
            // 
            // tsBtnBack
            // 
            this.tsBtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tsBtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBack.Image = global::DMZ.UI.Properties.Resources.Back_23px;
            this.tsBtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBack.Name = "tsBtnBack";
            this.tsBtnBack.Size = new System.Drawing.Size(23, 22);
            this.tsBtnBack.Text = "toolStripButton2";
            this.tsBtnBack.ToolTipText = "Página anterior ";
            this.tsBtnBack.Click += new System.EventHandler(this.tsBtnBack_Click);
            // 
            // tsTbPaginaactual
            // 
            this.tsTbPaginaactual.Name = "tsTbPaginaactual";
            this.tsTbPaginaactual.Size = new System.Drawing.Size(30, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel1.Text = "de";
            // 
            // tsTbTotalpaginas
            // 
            this.tsTbTotalpaginas.Name = "tsTbTotalpaginas";
            this.tsTbTotalpaginas.ReadOnly = true;
            this.tsTbTotalpaginas.Size = new System.Drawing.Size(30, 25);
            // 
            // tsbtnNext
            // 
            this.tsbtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tsbtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNext.Image = global::DMZ.UI.Properties.Resources.Forward_23px;
            this.tsbtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNext.Name = "tsbtnNext";
            this.tsbtnNext.Size = new System.Drawing.Size(23, 22);
            this.tsbtnNext.Text = "toolStripButton3";
            this.tsbtnNext.ToolTipText = "Página seguinte";
            this.tsbtnNext.Click += new System.EventHandler(this.tsbtnNext_Click);
            // 
            // tsbtnLast
            // 
            this.tsbtnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tsbtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLast.Image = global::DMZ.UI.Properties.Resources.Double_Right_23px;
            this.tsbtnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLast.Name = "tsbtnLast";
            this.tsbtnLast.Size = new System.Drawing.Size(23, 22);
            this.tsbtnLast.Text = "toolStripButton4";
            this.tsbtnLast.ToolTipText = "Última página";
            this.tsbtnLast.Click += new System.EventHandler(this.tsbtnLast_Click);
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
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
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
            this.exportarParaWordToolStripMenuItem.Click += new System.EventHandler(this.exportarParaWordToolStripMenuItem_Click);
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
            this.exportarParaPDFToolStripMenuItem.Click += new System.EventHandler(this.exportarParaPDFToolStripMenuItem_Click);
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
            this.exportarParaExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarParaExcelToolStripMenuItem_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnMaxMin.FlatAppearance.BorderSize = 0;
            this.btnMaxMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxMin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.Image = global::DMZ.UI.Properties.Resources.Maximize_Window_25px;
            this.btnMaxMin.Location = new System.Drawing.Point(885, 1);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(23, 22);
            this.btnMaxMin.TabIndex = 85;
            this.btnMaxMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ Master 20";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Location = new System.Drawing.Point(264, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 30);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(275, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 90;
            this.label3.Text = "Nº Cópias";
            // 
            // NrCopias
            // 
            this.NrCopias.Location = new System.Drawing.Point(341, 3);
            this.NrCopias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NrCopias.Name = "NrCopias";
            this.NrCopias.Size = new System.Drawing.Size(36, 20);
            this.NrCopias.TabIndex = 1;
            this.NrCopias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(938, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.dmzCMexport.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NrCopias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private DMZContextMenuStrip dmzCMexport;
        public System.Windows.Forms.Button btnMaxMin;
        private UC.CbDefault cbTriplicado;
        private UC.CbDefault cbDuplicado;
        private UC.CbDefault cbOriginal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem exportarDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarParaWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarParaPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarParaExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnFirst;
        private System.Windows.Forms.ToolStripButton tsBtnBack;
        private System.Windows.Forms.ToolStripTextBox tsTbPaginaactual;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tsTbTotalpaginas;
        private System.Windows.Forms.ToolStripButton tsbtnNext;
        private System.Windows.Forms.ToolStripButton tsbtnLast;
        private Generic.DMZToolTip dmzToolTip1;
        private System.Windows.Forms.Panel panel5;
        private CbDefault cbENReport;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox tbPaginas;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NrCopias;
    }
}
