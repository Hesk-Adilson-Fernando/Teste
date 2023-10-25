using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace DMZ.UI.Reports
{
     public static class PrintReport
     {

        public static void PrintToPrinter(this LocalReport report)
         {
                if (report == null) return;
                var pageSettings = new PageSettings
                {
                    PaperSize = report.GetDefaultPageSettings().PaperSize,
                    Landscape = report.GetDefaultPageSettings().IsLandscape,
                    Margins = report.GetDefaultPageSettings().Margins
                };
                //PaperSize = report.GetDefaultPageSettings().PaperSize,
                //Landscape = report.GetDefaultPageSettings().IsLandscape,
                //Margins = report.GetDefaultPageSettings().Margins
                PrintToPrinter(report, pageSettings);
         }

        public static void PrintToPrinter(this LocalReport report, PageSettings pageSettings)
        {
            string deviceInfo =
                $@"<DeviceInfo>
                    <OutputFormat>EMF</OutputFormat>
                    <PageWidth>{pageSettings.PaperSize.Width * 100}in</PageWidth>
                    <PageHeight>{pageSettings.PaperSize.Height * 100}in</PageHeight>
                    <MarginTop>{pageSettings.Margins.Top * 100}in</MarginTop>
                    <MarginLeft>{pageSettings.Margins.Left * 100}in</MarginLeft>
                    <MarginRight>{pageSettings.Margins.Right * 100}in</MarginRight>
                    <MarginBottom>{pageSettings.Margins.Bottom * 100}in</MarginBottom>
                </DeviceInfo>";

            Warning[] warnings;
            var streams = new List<Stream>();
            var currentPageIndex = 0;

            report.Render("Image", deviceInfo, 
                (name, fileNameExtension, encoding, mimeType, willSeek) => 
                {
                    var stream = new MemoryStream();
                    streams.Add(stream);
                    return stream;
                }, out warnings);

            foreach (var stream in streams)
                stream.Position = 0;

            if (streams == null || streams.Count == 0)
                throw new Exception("Error: no stream to print.");

            var printDocument = new PrintDocument {DefaultPageSettings = pageSettings};
            if (!printDocument.PrinterSettings.IsValid)
                throw new Exception("Error: cannot find the default printer.");
            else
            {
                printDocument.PrintPage += (sender, e) =>
                {
                    var pageImage = new Metafile(streams[currentPageIndex]);
                    var adjustedRect = new Rectangle(
                        e.PageBounds.Left - (int)e.PageSettings.HardMarginX,
                        e.PageBounds.Top - (int)e.PageSettings.HardMarginY,
                        e.PageBounds.Width,
                        e.PageBounds.Height);
                    e.Graphics.FillRectangle(Brushes.White, adjustedRect);
                    e.Graphics.DrawImage(pageImage, adjustedRect);
                    currentPageIndex++;
                    e.HasMorePages = (currentPageIndex < streams.Count);
                    e.Graphics.DrawRectangle(Pens.Red, adjustedRect);
                };
                printDocument.EndPrint += (sender, e) =>
                {
                    if (streams == null) return;
                    foreach (Stream stream in streams)
                        stream.Close();
                    streams = null;
                };
                printDocument.Print();
            }
        }

     }
}
