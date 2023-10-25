using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DMZ.BL.Classes;

namespace DMZ.UI.Reports
{
    public class Reportbuilder
    {
        static string path = Application.StartupPath;
        XmlTextWriter _xmlTextWriter;
        DataTable _dtempresa;
        private void WriteElementString(string name, string value)
        {
            _xmlTextWriter.WriteElementString(name, value);
        }
        private void WriteEndDocument()
        {
            _xmlTextWriter.WriteEndDocument();
        }
        public void Writefile(string report)
        {
            File.WriteAllText(path + "\\Temp\\report.rdlc", report);
        }
        private void WriteEndElement()
        {
            _xmlTextWriter.WriteEndElement();
        }
        private void WriteStartElement(string str)
        {
            _xmlTextWriter.WriteStartElement(str);
        }
        void CreatecurEmp()
        {
            WriteStartElement("DataSet");
            _xmlTextWriter.WriteAttributeString("Name", "emp");
            WriteStartElement("Query");
            WriteElementString("DataSourceName", "DataSource1");
            var commandText = "Select ";
            var count = 0;
            foreach (DataColumn dc in _dtempresa.Columns)
            {
                count += 1;
                commandText += " " + _dtempresa.TableName + "." + dc.ColumnName;
                if (count < _dtempresa.Columns.Count)
                {
                    commandText += " ,";
                }
            }
            commandText += " From empresa ";
            WriteElementString("CommandText", commandText);
            WriteStartElement("rd:DesignerState");
            WriteStartElement("QueryDefinition");
            _xmlTextWriter.WriteAttributeString("xmlns", "http://schemas.microsoft.com/ReportingServices/QueryDefinition/Relational");
            WriteStartElement("SelectedColumns");
            foreach (DataColumn dc in _dtempresa.Columns)
            {
                WriteStartElement("ColumnExpression");
                _xmlTextWriter.WriteAttributeString("ColumnOwner", "emp");
                _xmlTextWriter.WriteAttributeString("ColumnName", dc.ColumnName);
                WriteEndElement();////ColumnExpression
            }
            WriteEndElement();////SelectedColumns
            WriteEndElement();////QueryDefinition
            WriteEndElement();////rd:DesignerState
            WriteEndElement();////Query
            WriteStartElement("Fields");
            foreach (DataColumn dc in _dtempresa.Columns)
            {
                WriteStartElement("Field");
                _xmlTextWriter.WriteAttributeString("Name", dc.ColumnName);
                WriteElementString("DataField", dc.ColumnName);
                WriteElementString("rd:TypeName", dc.DataType.ToString());
                WriteEndElement();////ColumnExpression
            }
            WriteEndElement();////Fields
            WriteEndElement();////DataSet
            ///////////////////////////////
        }
        public void Build(UC.Print print)
        {
            _xmlTextWriter = new XmlTextWriter(path + "\\Temp\\" + print.id + ".rdl", Encoding.UTF8) { Formatting = Formatting.Indented };
            _dtempresa = SQL.GetGen2DT("select * from empresa");
            _xmlTextWriter.WriteStartDocument();
            WriteStartElement("Report");
            _xmlTextWriter.WriteAttributeString("xmlns:rd", "http://schemas.microsoft.com/SQLServer/reporting/reportdesigner");
            _xmlTextWriter.WriteAttributeString("xmlns:cl", "http://schemas.microsoft.com/sqlserver/reporting/2010/01/componentdefinition");
            _xmlTextWriter.WriteAttributeString("xmlns", "http://schemas.microsoft.com/sqlserver/reporting/2010/01/reportdefinition");
            WriteElementString("AutoRefresh", "0");
            if (Pbl.MYSQLMode == false)
            {
                WriteStartElement("DataSources");
                WriteStartElement("DataSource");
                _xmlTextWriter.WriteAttributeString("Name", "DataSource1");
                WriteStartElement("ConnectionProperties");
                WriteElementString("DataProvider", "SQL");
               // WriteElementString("ConnectString", "Data Source=" + Pbl.ServerInstance + ";Initial Catalog=" + Pbl.BaseDados);
                WriteElementString("IntegratedSecurity", "true");
                WriteElementString("rd:DataSourceID", "2d0c9a4c - c709 - 4ea5 - 8678 - ac874549e21e");
                WriteEndElement();///ConnectionProperties
                WriteElementString("rd:SecurityType", "Integrated");
                WriteEndElement();///DataSource
                WriteEndElement();////DataSources
            }
            else
            {

                WriteStartElement("DataSources");
                WriteStartElement("DataSource");
                _xmlTextWriter.WriteAttributeString("Name", "DataSource1");
                WriteStartElement("ConnectionProperties");
                WriteElementString("DataProvider", "ODBC");
               // WriteElementString("ConnectString", "Dsn=" + Pbl._Dsn + "; description=server; server=" + Pbl._localhost + "; database=" + Pbl.BaseDados + "; port=" + Pbl._Port);
                WriteElementString("rd:SecurityType", "DataBase");
                WriteElementString("rd:DataSourceID", "980abd79-8d65-4769-94f3-4893592caa4c");
                WriteEndElement();///ConnectionProperties
                WriteEndElement();///DataSource
                WriteEndElement();////DataSources
            }
            WriteStartElement("DataSets");
            CreatecurEmp();
            if (print.UsaQweryAdionalA)
            {
                var datasets = print._cursor.Split(',');
                for (var i = 0; i < datasets.Length; i++)
                {
                    var curdt = SQL.GetGen2DT(print.QweryAdionalA);
                    WriteStartElement("DataSet");
                    _xmlTextWriter.WriteAttributeString("Name", print.QweryAdionalANome);
                    WriteStartElement("Query");
                    WriteElementString("DataSourceName", "DataSource1");
                    var commandText = "Select ";
                    var count = 0;
                    foreach (DataColumn dc in curdt.Columns)
                    {
                        count += 1;
                        commandText += " " + curdt.TableName + "." + dc.ColumnName;
                        if (count < curdt.Columns.Count)
                        {
                            commandText += " ,";
                        }
                    }
                    commandText += " From " + i;
                    WriteElementString("CommandText", commandText);
                    WriteStartElement("rd:DesignerState");
                    WriteStartElement("QueryDefinition");
                    _xmlTextWriter.WriteAttributeString("xmlns", "http://schemas.microsoft.com/ReportingServices/QueryDefinition/Relational");
                    WriteStartElement("SelectedColumns");
                    foreach (DataColumn dc in _dtempresa.Columns)
                    {
                        WriteStartElement("ColumnExpression");
                        _xmlTextWriter.WriteAttributeString("ColumnOwner", "empresa");
                        _xmlTextWriter.WriteAttributeString("ColumnName", dc.ColumnName);
                        WriteEndElement();////ColumnExpression
                    }
                    WriteEndElement();////SelectedColumns
                    WriteEndElement();////QueryDefinition
                    WriteEndElement();////rd:DesignerState
                    WriteEndElement();////Query
                    WriteStartElement("Fields");
                    foreach (DataColumn dc in _dtempresa.Columns)
                    {
                        WriteStartElement("Field");
                        _xmlTextWriter.WriteAttributeString("Name", dc.ColumnName);
                        WriteElementString("DataField", dc.ColumnName);
                        WriteElementString("rd:TypeName", dc.DataType.ToString());
                        WriteEndElement();////ColumnExpression
                    }
                    WriteEndElement();////Fields
                    WriteEndElement();////DataSet
                }
            }
            if (print.UsaQweryAdionalb)
            {
                var datasets = print._cursor.Split(',');
                for (var i = 0; i < datasets.Length; i++)
                {
                    var curdt = SQL.GetGen2DT(print.QweryAdionalb);
                    WriteStartElement("DataSet");
                    _xmlTextWriter.WriteAttributeString("Name", print.QweryAdionalbNome);
                    WriteStartElement("Query");
                    WriteElementString("DataSourceName", "DataSource1");
                    var commandText = "Select ";
                    var count = 0;
                    foreach (DataColumn dc in curdt.Columns)
                    {
                        count += 1;
                        commandText += " " + curdt.TableName + "." + dc.ColumnName;
                        if (count < curdt.Columns.Count)
                        {
                            commandText += " ,";
                        }
                    }
                    commandText += " From " + datasets[i];
                    WriteElementString("CommandText", commandText);
                    WriteStartElement("rd:DesignerState");
                    WriteStartElement("QueryDefinition");
                    _xmlTextWriter.WriteAttributeString("xmlns", "http://schemas.microsoft.com/ReportingServices/QueryDefinition/Relational");
                    WriteStartElement("SelectedColumns");
                    foreach (DataColumn dc in _dtempresa.Columns)
                    {
                        WriteStartElement("ColumnExpression");
                        _xmlTextWriter.WriteAttributeString("ColumnOwner", "empresa");
                        _xmlTextWriter.WriteAttributeString("ColumnName", dc.ColumnName);
                        WriteEndElement();////ColumnExpression
                    }
                    WriteEndElement();////SelectedColumns
                    WriteEndElement();////QueryDefinition
                    WriteEndElement();////rd:DesignerState
                    WriteEndElement();////Query
                    WriteStartElement("Fields");
                    foreach (DataColumn dc in _dtempresa.Columns)
                    {
                        WriteStartElement("Field");
                        _xmlTextWriter.WriteAttributeString("Name", dc.ColumnName);
                        WriteElementString("DataField", dc.ColumnName);
                        WriteElementString("rd:TypeName", dc.DataType.ToString());
                        WriteEndElement();////ColumnExpression
                    }
                    WriteEndElement();////Fields
                    WriteEndElement();////DataSet
                }
            }
            if (print.UsaQweryPersonalida == false)
            {
                var datasets = print._cursor.Split(',');
                for (var i = 0; i < datasets.Length; i++)
                {
                    var curdt = SQL.GetGen2DT("select * from " + datasets[i]);
                    WriteStartElement("DataSet");
                    _xmlTextWriter.WriteAttributeString("Name", "Cur" + datasets[i]);
                    WriteStartElement("Query");
                    WriteElementString("DataSourceName", "DataSource1");
                    var commandText = "Select ";
                    var count = 0;
                    foreach (DataColumn dc in curdt.Columns)
                    {
                        count += 1;
                        commandText += " " + curdt.TableName + "." + dc.ColumnName;
                        if (count < curdt.Columns.Count)
                        {
                            commandText += " ,";
                        }
                    }
                    commandText += " From " + datasets[i];
                    WriteElementString("CommandText", commandText);
                    WriteStartElement("rd:DesignerState");
                    WriteStartElement("QueryDefinition");
                    _xmlTextWriter.WriteAttributeString("xmlns", "http://schemas.microsoft.com/ReportingServices/QueryDefinition/Relational");

                    WriteStartElement("SelectedColumns");
                    foreach (DataColumn dc in curdt.Columns)
                    {
                        WriteStartElement("ColumnExpression");
                        _xmlTextWriter.WriteAttributeString("ColumnOwner", datasets[i]);
                        _xmlTextWriter.WriteAttributeString("ColumnName", dc.ColumnName);
                        WriteEndElement();////ColumnExpression
                    }
                    WriteEndElement();////SelectedColumns
                    WriteEndElement();////QueryDefinition
                    WriteEndElement();////rd:DesignerState
                    WriteEndElement();////Query
                    WriteStartElement("Fields");
                    foreach (DataColumn dc in curdt.Columns)
                    {
                        WriteStartElement("Field");
                        _xmlTextWriter.WriteAttributeString("Name", dc.ColumnName);
                        WriteElementString("DataField", dc.ColumnName);
                        WriteElementString("rd:TypeName", dc.DataType.ToString());
                        WriteEndElement();////ColumnExpression
                    }
                    WriteEndElement();////Fields
                    WriteEndElement();////DataSet
                }
            }
            else
            {
                var datasets = print._cursor.Split(',');
                for (var i = 0; i < datasets.Length; i++)
                {
                    var curdt = SQL.GetGen2DT(print.QweryPersonalida);
                    WriteStartElement("DataSet");
                    _xmlTextWriter.WriteAttributeString("Name", print.QweryPersonalidaNome);
                    WriteStartElement("Query");
                    WriteElementString("DataSourceName", "DataSource1");
                    var commandText = "Select ";
                    var count = 0;
                    foreach (DataColumn dc in curdt.Columns)
                    {
                        count += 1;
                        commandText += " " + curdt.TableName + "." + dc.ColumnName;
                        if (count < curdt.Columns.Count)
                        {
                            commandText += " ,";
                        }
                    }
                    commandText += " From " + datasets[i];
                    WriteElementString("CommandText", commandText);
                    WriteStartElement("rd:DesignerState");
                    WriteStartElement("QueryDefinition");
                    _xmlTextWriter.WriteAttributeString("xmlns", "http://schemas.microsoft.com/ReportingServices/QueryDefinition/Relational");
                    WriteStartElement("SelectedColumns");
                    foreach (DataColumn dc in _dtempresa.Columns)
                    {
                        WriteStartElement("ColumnExpression");
                        _xmlTextWriter.WriteAttributeString("ColumnOwner", "empresa");
                        _xmlTextWriter.WriteAttributeString("ColumnName", dc.ColumnName);
                        WriteEndElement();////ColumnExpression
                    }
                    WriteEndElement();////SelectedColumns
                    WriteEndElement();////QueryDefinition
                    WriteEndElement();////rd:DesignerState
                    WriteEndElement();////Query
                    WriteStartElement("Fields");
                    foreach (DataColumn dc in _dtempresa.Columns)
                    {
                        WriteStartElement("Field");
                        _xmlTextWriter.WriteAttributeString("Name", dc.ColumnName);
                        WriteElementString("DataField", dc.ColumnName);
                        WriteElementString("rd:TypeName", dc.DataType.ToString());
                        WriteEndElement();////ColumnExpression
                    }
                    WriteEndElement();////Fields
                    WriteEndElement();////DataSet
                }

            }
            WriteEndElement();////DataSets
            WriteStartElement("ReportSections");
            WriteStartElement("ReportSection");
            WriteStartElement("Body");
            WriteStartElement("ReportItems");
            WriteStartElement("Textbox");
            _xmlTextWriter.WriteAttributeString("Name", "ReportTitle");
            WriteElementString("CanGrow", "true");
            WriteElementString("KeepTogether", "true");
            WriteStartElement("Paragraphs");
            WriteStartElement("Paragraph");
            WriteStartElement("TextRuns");
            WriteStartElement("TextRun");
            WriteStartElement("Value");
            WriteEndElement();////Value
            WriteStartElement("Style");
            WriteElementString("FontFamily", "Verdana");
            WriteElementString("FontSize", "20pt");
            WriteEndElement();////Style
            WriteEndElement();////TextRun
            WriteEndElement();////TextRuns
            WriteStartElement("Style");
            WriteEndElement();////Style
            WriteEndElement();////Paragraph
            WriteEndElement();////Paragraphs
            WriteElementString("rd:WatermarkTextbox", "Title");
            WriteElementString("rd:DefaultName", "ReportTitle");
            WriteElementString("Height", "0.4in");
            WriteElementString("Width", "5.5in");
            WriteElementString("ZIndex", "1");
            WriteStartElement("Style");
            WriteStartElement("Border");
            WriteElementString("Style", "None");
            WriteEndElement();////Border
            WriteElementString("PaddingLeft", "2pt");
            WriteElementString("PaddingRight", "2pt");
            WriteElementString("PaddingTop", "2pt");
            WriteElementString("PaddingBottom", "2pt");
            WriteEndElement();////Style
            WriteEndElement();////Textbox
            WriteEndElement();////ReportItems
            WriteElementString("Height", "2.25in");
            WriteStartElement("Style");
            WriteStartElement("Border");
            WriteElementString("Style", "None");
            WriteEndElement();////Border
            WriteEndElement();////Style
            WriteEndElement();////Body
            WriteElementString("Width", "27in");
            WriteStartElement("Page");
            WriteStartElement("PageFooter");
            WriteElementString("Height", "0.45in");
            WriteElementString("PrintOnFirstPage", "true");
            WriteElementString("PrintOnLastPage", "true");
            WriteStartElement("ReportItems");
            WriteStartElement("Textbox");
            _xmlTextWriter.WriteAttributeString("Name", "ExecutionTime");
            WriteElementString("CanGrow", "true");
            WriteElementString("KeepTogether", "true");
            WriteStartElement("Paragraphs");
            WriteStartElement("Paragraph");
            WriteStartElement("TextRuns");
            WriteStartElement("TextRun");
            WriteElementString("Value", "=Globals!ExecutionTime");
            WriteStartElement("Style");
            WriteEndElement();////Style
            WriteEndElement();////TextRun
            WriteEndElement();////TextRuns
            WriteStartElement("Style");
            WriteElementString("TextAlign", "Right");
            WriteEndElement();////Style
            WriteEndElement();////Paragraph
            WriteEndElement();////Paragraphs
            WriteElementString("rd:DefaultName", "ExecutionTime");
            WriteElementString("Top", "0.2in");
            WriteElementString("Left", "4in");
            WriteElementString("Height", "0.25in");
            WriteElementString("Width", "2in");
            WriteStartElement("Style");
            WriteStartElement("Border");
            WriteElementString("Style", "None");
            WriteEndElement();////Border
            WriteElementString("PaddingLeft", "2pt");
            WriteElementString("PaddingRight", "2pt");
            WriteElementString("PaddingTop", "2pt");
            WriteElementString("PaddingBottom", "2pt");
            WriteEndElement();////Style
            WriteEndElement();////Textbox
            WriteEndElement();////ReportItems
            WriteStartElement("Style");
            WriteStartElement("Border");
            WriteElementString("Style", "None");
            WriteEndElement();////Border
            WriteEndElement();////Style
            WriteEndElement();////PageFooter
            WriteElementString("LeftMargin", "1in");
            WriteElementString("RightMargin", "1in");
            WriteElementString("TopMargin", "1in");
            WriteElementString("BottomMargin", "1in");
            WriteStartElement("Style");
            WriteEndElement();////Style
            WriteEndElement();////Page
            WriteEndElement();////ReportSection
            WriteEndElement();////ReportSections
            WriteElementString("rd:ReportUnitType", "Inch");
            if (Pbl.MYSQLMode == false)
            {
                WriteElementString("rd:ReportID", "f6bd452f-b28e-4005-974c-cdc9f4726ae7");
            }
            else
            {
                WriteElementString("rd:ReportID", "6fe29918-d24f-4dcd-b588-1b4c258986aa");
            }
            WriteEndElement();////Report
            WriteEndDocument();
            _xmlTextWriter.Close();
            var start = new ProcessStartInfo {FileName = path + "\\Temp\\" + print.id + ".rdlc"};
            Process.Start(start);
        }

    }

}
