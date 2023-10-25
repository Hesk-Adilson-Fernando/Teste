using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DMZ.BL.Classes;
using DMZ.UI.Basic;

//using System.Web.UI.WebControls;

namespace DMZ.UI.Reports
{
	public class ReportGenerator
	{
		private float _multipageRatio = 1.5F;
		private CultureInfo ci = new CultureInfo("en-US");
		private DataTable _dt;
		private string dsName;
        private const string nsRd = "http://schemas.microsoft.com/SQLServer/reporting/reportdesigner";
        private string ns = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition";

		public ReportGenerator(DataTable dt, string dsName)
		{
			_dt = dt;
			this.dsName = dsName;
		}
        public Stream GeneraReport()
		{
			string xml;
			var sb = new StringBuilder();
			#region Settings
            var settings = new XmlWriterSettings
            {
                CheckCharacters = true,
                CloseOutput = true,
                Encoding = Encoding.UTF8,
                Indent = true,
                IndentChars = "\t",
                NewLineChars = "\r\n",
                NewLineHandling = NewLineHandling.Replace,
                NewLineOnAttributes = false,
                OmitXmlDeclaration = false
            };
            #endregion
			var writer = XmlWriter.Create(sb, settings);
			writer.WriteStartDocument();
			{
				writer.WriteStartElement("Report", ns);
				writer.WriteAttributeString("xmlns", "rd", "", nsRd);
				{
					AddDataSource(writer, dsName);
					float htb = 0.63492F, maxWidth = 4.0F;
					var dimensioni = new RectangleF(1.37301F, 0.68783F, 13.25397F, 2.98941F);
					var pad = new Padding(2, 2, 2, 2);
					var size = new SizeF(21F, 29.7F);
					var margin = new Padding(0.5F, 0.5F, 0.5F, 0.5F);
					GenerateSettingsHeader(writer, size, size, margin);
                    AddDataSet(writer, _dt, dsName);

                    writer.WriteStartElement("Body");
					{
						writer.WriteElementString("ColumnSpacing", "1cm");
						writer.WriteElementString("Height", "5cm");
						writer.WriteStartElement("ReportItems");
						{
                            GeraPageHeader(writer);
							GeneraTabella(writer, _dt, dsName, dimensioni, pad, pad, htb, maxWidth);
						}
						writer.WriteEndElement();
					}
					writer.WriteEndElement();


				}
				writer.WriteEndElement();
			}
			writer.WriteEndDocument();
			writer.Flush();
			writer.Close();
			xml = sb.ToString().Replace("utf-16", "utf-8");
			Stream ret = new MemoryStream(Encoding.UTF8.GetBytes(xml));
			return ret;
		}
        private void GeraPageHeader(XmlWriter writer)
        {
            //var emp = (Application.OpenForms["DemoMdi"] as DemoMdi).Tmpempresa;
            var image =Generic.Util.ByteToImage(Pbl.Empresa.Logo);
            GeneraTextBox2(writer, "textbox1", RectangleF.Empty,new Padding(10,47,20,2), null, Pbl.Empresa.Nome,Pbl.Empresa.Nome.Length,"0.6","16","Bold");
            //GeneraTextBox2(writer, "textbox2", RectangleF.Empty,new Padding(2,47,20,2), null, emp.Morada,emp.Morada.Length,"0.6","10","Normal");
            //GeneraLinha(writer);
            if (!string.IsNullOrEmpty(Titulo))
            {
                GeneraTextBox2(writer, "textbox3", RectangleF.Empty,new Padding(2,47,2,2), null, Titulo,Titulo.Length,"0.6","16","Bold");
            }
            if (!string.IsNullOrEmpty(Filtro))
            {
                GeneraTextBox2(writer, "textbox4", RectangleF.Empty,new Padding(2,47,2,2), null, "Filtro: "+Filtro,Filtro.Length,"0.6","10","Normal");
            }
        }

        private void GeneraLinha(XmlWriter writer)
        {
            writer.WriteStartElement("Line");
            writer.WriteAttributeString("Name", "linha1");
            {
                writer.WriteElementString("rd", "DefaultName", nsRd, "linha1");
                //if (dimensioni != RectangleF.Empty)
                //{
                //    writer.WriteElementString("Top", dimensioni.Top.ToString(ci) + "cm");
                //    writer.WriteElementString("Left", dimensioni.Left.ToString(ci) + "cm");
                //    writer.WriteElementString("Width", dimensioni.Width.ToString(ci) + "cm");
                //    writer.WriteElementString("Height", dimensioni.Height.ToString(ci) + "cm");
                //}
                //writer.WriteElementString("CanGrow", "true");
                //if (padding != null)
                //{
                writer.WriteStartElement("Style");
                {
                    //writer.WriteElementString("LineColor", Color.Black.ToString());
                   // writer.WriteElementString("LineStyle", "Solid");
                    //writer.WriteElementString("LineWidth", "2pt");
                }
                writer.WriteEndElement();


                //}

            }
            writer.WriteEndElement();
        }

        public string Filtro { get; set; }

        public string Titulo { get; set; }

        private void GeneraLogoTipo(XmlWriter writer, Image Imagem, RectangleF empty, Padding padding)
        {
            writer.WriteStartElement("Image");
            writer.WriteAttributeString("Name", Imagem.ToString());
            {
                writer.WriteElementString("rd", "DefaultName", nsRd, "Imagem");
                //if (dimensioni != RectangleF.Empty)
                //{
                //    writer.WriteElementString("Top", dimensioni.Top.ToString(ci) + "cm");
                //    writer.WriteElementString("Left", dimensioni.Left.ToString(ci) + "cm");
                //    writer.WriteElementString("Width", dimensioni.Width.ToString(ci) + "cm");
                //    writer.WriteElementString("Height", dimensioni.Height.ToString(ci) + "cm");
                //}
                //writer.WriteElementString("Source", "Embedded");
               // writer.WriteElementString("Value", Imagem.ToString());
                //writer.WriteElementString("Width", $"{width}cm");
                //writer.WriteElementString("Height", $"{heigth}cm");
                //if (padding != null)
                //{
                //    writer.WriteStartElement("Style");
                //    {
                //        writer.WriteElementString("PaddingLeft", padding.Left.ToString(ci) + "pt");
                //        writer.WriteElementString("PaddingRight", padding.Right.ToString(ci) + "pt");
                //        writer.WriteElementString("PaddingTop", padding.Top.ToString(ci) + "pt");
                //        writer.WriteElementString("PaddingBottom", padding.Bottom.ToString(ci) + "pt");
                //    }
                //    writer.WriteEndElement();
                //}
            }
            writer.WriteEndElement();
        }

        private void GeneraTextBox2(XmlWriter writer, string textboxName, RectangleF dimensioni, Padding padding, CellColors colors, string value, int width, string heigth,string fontSize,string FontWeigth)
        {
            writer.WriteStartElement("Textbox");
            writer.WriteAttributeString("Name", textboxName);
            {
                writer.WriteElementString("rd", "DefaultName", nsRd, textboxName);
                //if (dimensioni != RectangleF.Empty)
                //{
                //    writer.WriteElementString("Top", dimensioni.Top.ToString(ci) + "cm");
                //    writer.WriteElementString("Left", dimensioni.Left.ToString(ci) + "cm");
                //    writer.WriteElementString("Width", dimensioni.Width.ToString(ci) + "cm");
                //    writer.WriteElementString("Height", dimensioni.Height.ToString(ci) + "cm");
                //}
                writer.WriteElementString("CanGrow", "true");
                writer.WriteElementString("Value", value);
                writer.WriteElementString("Width", $"{width}cm");
                writer.WriteElementString("Height", $"{heigth}cm");
                
                if (padding != null)
                {
                    writer.WriteStartElement("Style");
                    {
                        writer.WriteElementString("FontSize", $"{fontSize}pt");
                        writer.WriteElementString("FontFamily", "Century Gothic");
                        writer.WriteElementString("FontWeight", FontWeigth);
                        if (colors != null)
                        {
                            writer.WriteElementString("Color", colors.ForegroundColor.Name);
                            writer.WriteElementString("BackgroundColor", colors.BackgroundColor.Name);
                        }
                        writer.WriteElementString("PaddingLeft", padding.Left.ToString(ci) + "pt");
                        writer.WriteElementString("PaddingRight", padding.Right.ToString(ci) + "pt");
                        writer.WriteElementString("PaddingTop", padding.Top.ToString(ci) + "pt");
                        writer.WriteElementString("PaddingBottom", padding.Bottom.ToString(ci) + "pt");
                    }
                    writer.WriteEndElement();


                }

            }
            writer.WriteEndElement();
        }
        #region Metodi Privati
		private SizeF GetDynamicSize(string s)
		{
			var f = new Font(FontFamily.GenericSansSerif, 10);
			var bmp = new Bitmap(1, 1);
			var g = Graphics.FromImage(bmp);
			g.PageUnit = GraphicsUnit.Millimeter;
			var ret = SizeF.Empty;
			ret = g.MeasureString(s, f);
			g.Dispose();
			return ret;
		}

		private void GeneraSezioneTabella(SezioneTabella sezione, XmlWriter writer, DataTable dt, Padding padding, float height)
		{
			string nomeSezione = "", templateValore = "", valore;
			CellColors colors = null;
			switch (sezione)
			{
				case SezioneTabella.Header:
					{
						nomeSezione = "Header";
						templateValore = "{0}";
						colors = new CellColors(Color.Chocolate, Color.White);
						break;
					}
				case SezioneTabella.Details:
					{
						nomeSezione = "Details";
						templateValore = "=Fields!{0}.Value";
						break;
					}
				case SezioneTabella.Footer:
					{
						nomeSezione = "Footer";
						templateValore = "{0}";
						break;
					}
			}
			writer.WriteStartElement(nomeSezione);
			{
				if (sezione == SezioneTabella.Header)
					writer.WriteElementString("RepeatOnNewPage", "true");
				writer.WriteStartElement("TableRows");
				{
					writer.WriteStartElement("TableRow");
					{
						writer.WriteElementString("Height", height.ToString(ci) + "cm");
						writer.WriteStartElement("TableCells");
						{
							for (int i = 0; i < dt.Columns.Count; i++)
							{
								writer.WriteStartElement("TableCell");
								{
									writer.WriteStartElement("ReportItems");
									{
										valore = string.Format(templateValore, dt.Columns[i].ColumnName);
										GeneraTextBox(writer, "textbox" + nomeSezione + i, RectangleF.Empty, padding, colors, valore);
									}
									writer.WriteEndElement();
								}
								writer.WriteEndElement();
							}
						}
						writer.WriteEndElement();
					}
					writer.WriteEndElement();
				}
				writer.WriteEndElement();
			}
			writer.WriteEndElement();
		}

		private void GeneraTabella(XmlWriter writer, DataTable dt, string dsName, RectangleF dimensioniTabella, Padding paddingTextBox, Padding paddingHeader, float heightTextBox, float MaxWidth)
		{
			writer.WriteStartElement("Table");
			writer.WriteAttributeString("Name", "tabella" + dsName);
			{
				writer.WriteStartElement("Style");
				{
					writer.WriteStartElement("BorderStyle");
					{
						writer.WriteElementString("Default", "Solid");
					}
					writer.WriteEndElement();
				}
				writer.WriteEndElement();

				writer.WriteElementString("Top", dimensioniTabella.Top.ToString(ci) + "cm");
				writer.WriteElementString("Left", dimensioniTabella.Left.ToString(ci) + "cm");
				writer.WriteElementString("Width", dimensioniTabella.Width.ToString(ci) + "cm");
				writer.WriteElementString("Height", dimensioniTabella.Height.ToString(ci) + "cm");

				writer.WriteStartElement("TableColumns");
				{
					for (var i = 0; i < dt.Columns.Count; i++)
					{
						writer.WriteStartElement("TableColumn");
						{
							var dc = dt.Columns[i];
							var sizeWidthComputed = 0.0F;
							var rowMaxLength = GetDynamicSize(dt.Rows[0][i].ToString()).Width / 10;
							var headerMaxLength = GetDynamicSize(dc.ColumnName).Width / 10 + 0.2F;
							foreach (DataRow row in dt.Rows)
							{
								var rowSizeWidth = GetDynamicSize(row[i].ToString()).Width / 10;
								if (rowSizeWidth > rowMaxLength)
									rowMaxLength = rowSizeWidth;
							}

							if (rowMaxLength > headerMaxLength)
								if (rowMaxLength > MaxWidth)
									sizeWidthComputed = MaxWidth;
								else
									sizeWidthComputed = rowMaxLength;
							else
								sizeWidthComputed = headerMaxLength;

							writer.WriteElementString("Width", (sizeWidthComputed).ToString(ci) + "cm");
						}
						writer.WriteEndElement();
					}
				}
				writer.WriteEndElement();

				GeneraSezioneTabella(SezioneTabella.Header, writer, dt, paddingHeader, heightTextBox);
				GeneraSezioneTabella(SezioneTabella.Details, writer, dt, paddingTextBox, heightTextBox);
			}
			writer.WriteEndElement();
		}

		private void AddDataSet(XmlWriter writer, DataTable dt, string dsName)
		{
			writer.WriteStartElement("DataSets");
			{
				writer.WriteStartElement("DataSet");
				writer.WriteAttributeString("Name", dsName);
				{
					writer.WriteStartElement("Fields");
					{
						for (var i = 0; i < dt.Columns.Count; i++)
						{
							writer.WriteStartElement("Field");
							writer.WriteAttributeString("Name", dt.Columns[i].ColumnName);
							{
								writer.WriteElementString("DataField", dt.Columns[i].ColumnName);
								writer.WriteElementString("rd", "TypeName", nsRd, dt.Columns[i].DataType.ToString());
							}
							writer.WriteEndElement();
						}
					}
					writer.WriteEndElement();

					writer.WriteStartElement("Query");
					{
						writer.WriteElementString("DataSourceName", dsName);
						writer.WriteElementString("CommandText", "");
						writer.WriteElementString("rd", "DataSourceName", nsRd, "true");
					}
					writer.WriteEndElement();
				}
				writer.WriteEndElement();
			}
			writer.WriteEndElement();
		}

		private void AddDataSource(XmlWriter writer, string dsName)
		{
			writer.WriteStartElement("DataSources");
			{
				writer.WriteStartElement("DataSource");
				{
					writer.WriteAttributeString("Name", dsName);
					writer.WriteElementString("DataSourceReference", dsName);
				}
				writer.WriteEndElement();
			}
			writer.WriteEndElement();
		}

		private void GeneraTextBox(XmlWriter writer, string textboxName, RectangleF dimensioni, Padding padding, CellColors colors, string value)
		{
			writer.WriteStartElement("Textbox");
			writer.WriteAttributeString("Name", textboxName);
			{
				writer.WriteElementString("rd", "DefaultName", nsRd, textboxName);
				if (dimensioni != RectangleF.Empty)
				{
					writer.WriteElementString("Top", dimensioni.Top.ToString(ci) + "cm");
					writer.WriteElementString("Left", dimensioni.Left.ToString(ci) + "cm");
					writer.WriteElementString("Width", dimensioni.Width.ToString(ci) + "cm");
					writer.WriteElementString("Height", dimensioni.Height.ToString(ci) + "cm");
				}
				writer.WriteElementString("CanGrow", "true");
				writer.WriteElementString("Value", value);
				if (padding != null)
				{
					writer.WriteStartElement("Style");
					{
						writer.WriteStartElement("BorderStyle");
						{
							writer.WriteElementString("Default", "Solid");
						}
						writer.WriteEndElement();

						if (colors != null)
						{
							writer.WriteElementString("Color", colors.ForegroundColor.Name);
							writer.WriteElementString("BackgroundColor", colors.BackgroundColor.Name);
						}

						writer.WriteElementString("PaddingLeft", padding.Left.ToString(ci) + "pt");
						writer.WriteElementString("PaddingRight", padding.Right.ToString(ci) + "pt");
						writer.WriteElementString("PaddingTop", padding.Top.ToString(ci) + "pt");
						writer.WriteElementString("PaddingBottom", padding.Bottom.ToString(ci) + "pt");
					}
					writer.WriteEndElement();
				}
			}
			writer.WriteEndElement();
		}

		private void GenerateSettingsHeader(XmlWriter writer, SizeF InteractiveSize, SizeF PageSize, Padding margin)
		{
			writer.WriteElementString("Language", "it-IT");
			writer.WriteElementString("rd", "DrawGrid", nsRd, "true");
			writer.WriteElementString("rd", "gridspacing", nsRd, "0.25cm");
			writer.WriteElementString("rd", "snaptogrid", nsRd, "true");
			writer.WriteElementString("InteractiveHeight", InteractiveSize.Height.ToString(ci) + "cm");
			writer.WriteElementString("InteractiveWidth", InteractiveSize.Width.ToString(ci) + "cm");
			writer.WriteElementString("RightMargin", margin.Right.ToString(ci) + "cm");
			writer.WriteElementString("LeftMargin", margin.Left.ToString(ci) + "cm");
			writer.WriteElementString("BottomMargin", margin.Bottom.ToString(ci) + "cm");
			writer.WriteElementString("TopMargin", margin.Top.ToString(ci) + "cm");
			writer.WriteElementString("PageHeight",  "29.7cm");
			writer.WriteElementString("PageWidth", "21cm");
			writer.WriteElementString("Width", PageSize.Width.ToString(ci) + "cm");
		}
		#endregion
	}

	#region Oggetti Custom
	public enum SezioneTabella
	{
		Header,
		Details,
		Footer
	}

	public class CellColors
	{
		public CellColors(Color bg, Color fore)
		{
			this.bg = bg;
			this.fore = fore;
		}
		private Color bg;
		private Color fore;

		public Color BackgroundColor => bg;
        public Color ForegroundColor => fore;
    }

	public class Padding
	{
		public Padding(float top, float left, float bottom, float right)
		{
			TopLeft = new PointF(left, top);
			BottomRight = new PointF(right, bottom);
		}

		private PointF TopLeft { get; }
		private PointF BottomRight { get; }

		public float Top => TopLeft.Y;
        public float Left => TopLeft.X;
        public float Bottom => BottomRight.Y;
        public float Right => BottomRight.X;
    }
	#endregion

}
