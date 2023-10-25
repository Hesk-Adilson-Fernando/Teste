
namespace DMZ.UI.Reports
{
    partial class FrmGenreport
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
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMaxMin);
            this.panel4.Size = new System.Drawing.Size(794, 29);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnMaxMin, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(762, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.Text = "Listagem";
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnMaxMin.FlatAppearance.BorderSize = 0;
            this.btnMaxMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxMin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.Image = global::DMZ.UI.Properties.Resources.Maximize_Window_25px;
            this.btnMaxMin.Location = new System.Drawing.Point(735, 2);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(23, 22);
            this.btnMaxMin.TabIndex = 86;
            this.btnMaxMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ReportViewer1);
            this.panel1.Location = new System.Drawing.Point(2, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 415);
            this.panel1.TabIndex = 25;
            // 
            // ReportViewer1
            // 
            this.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.ReportViewer1.Name = "ReportViewer1";
            this.ReportViewer1.ServerReport.BearerToken = null;
            this.ReportViewer1.Size = new System.Drawing.Size(792, 413);
            this.ReportViewer1.TabIndex = 1;
            // 
            // FrmGenreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGenreport";
            this.Text = "TesteReport";
            this.Load += new System.EventHandler(this.TesteReport_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer1;
    }
}