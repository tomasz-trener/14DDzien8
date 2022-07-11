
using P04AplikacjaZawodnicy.Core.Repositories;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaZawodnicy.Tools
{
    public class PDFManager
    {
        public string StworzPdf(Zawodnik[] zawodnicy)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text

            for (int i = 0; i < zawodnicy.Length; i++)
                gfx.DrawString(zawodnicy[i].ImieNazwiskoKraj, font, XBrushes.Blue, 20, 50 + i * 40);

            //gfx.DrawString("Hello, World!", font, XBrushes.Black,
            //  new XRect(0, 0, page.Width, page.Height),
            //  XStringFormats.Center);

            // Save the document...
            string filename = DateTime.Now.ToString("yyyyMMddhhmmss") + "_HelloWorld.pdf";
            document.Save(filename);
            return filename;
            // ...and start a viewer.
            // Process.Start(filename);
        }
    }
}
