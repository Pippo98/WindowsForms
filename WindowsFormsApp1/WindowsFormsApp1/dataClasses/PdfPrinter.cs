using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Web.UI.HtmlControls;
using System.Windows.Forms.VisualStyles;
using iText.StyledXmlParser.Jsoup.Nodes;
using iText.IO.Util;
using System.Threading;
using System.Runtime.InteropServices;
using iText.Kernel.Geom;

namespace WindowsFormsApp1.dataClasses
{
    class PdfPrinter
    {

        public int printFirms(string folder, List<Firm> firms)
        {
            using (var writer = new PdfWriter(folder + "\\imprese.pdf"))
            {
                using (var pdfDoc = new PdfDocument(writer))
                {
                    var doc = new iText.Layout.Document(pdfDoc);
                    // Doc Title
                    Paragraph title = new Paragraph();
                    title.Add("Imprese");
                    title.SetFontSize(30);
                    title.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                    doc.Add(title);

                    // Doc table
                    var table = new Table(3);
                    table.UseAllAvailableWidth();

                    // First row
                    Cell cell = new Cell();
                    cell.Add(new Paragraph("Impresa"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Targhe"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Tipo di mezzo"));
                    table.AddCell(cell);

                    // Filling Table
                    for (int i = 0; i < firms.Count; i++)
                    {
                        Firm firm = firms[i];
                        if(firm == null)
                        {
                            continue;
                        }
                        if(firm.targhe.Count == 0 || firm.targhe == null)
                        {
                            cell = new Cell();
                            cell.Add(new Paragraph(firm.name));
                            table.AddCell(cell);
                            cell = new Cell();
                            cell.Add(new Paragraph("nessuna Targa"));
                            table.AddCell(cell);
                            cell = new Cell();
                            cell.Add(new Paragraph("nessuna tipologia di mezzo"));
                            table.AddCell(cell);
                            continue;
                        }
                        cell = new Cell(firm.targhe.Count, 1);
                        cell.Add(new Paragraph(firm.name));
                        table.AddCell(cell);

                        for (int j = 0; j < firm.targhe.Count; j++)
                        {
                            cell = new Cell();
                            cell.Add(new Paragraph(firm.targhe[j].Item1));
                            table.AddCell(cell);
                            cell = new Cell();
                            cell.Add(new Paragraph(firm.targhe[j].Item2));
                            table.AddCell(cell);
                        }

                    }

                    doc.Add(table);
                }
            }
            return 1;
        }

        public int printAnalysis(string folder, List<Analysis> analysis)
        {
            using (var writer = new PdfWriter(folder + "\\analisi.pdf"))
            {
                using (var pdfDoc = new PdfDocument(writer))
                {
                    pdfDoc.SetDefaultPageSize(PageSize.A4.Rotate());
                    var doc = new iText.Layout.Document(pdfDoc);
                    // Doc Title
                    Paragraph title = new Paragraph();
                    title.Add("Imprese");
                    title.SetFontSize(30);
                    title.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                    doc.Add(title);

                    // Doc table
                    var table = new Table(7);
                    table.UseAllAvailableWidth();

                    // First row
                    Cell cell = new Cell();
                    cell.Add(new Paragraph("ID"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Data"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("CER"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Cantiere"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Comune"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Produttore"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Validità"));
                    table.AddCell(cell);

                    // Filling Table
                    for (int i = 0; i < analysis.Count; i++)
                    {
                        Analysis a = analysis[i];
                        if (a == null)
                            continue;

                        cell = new Cell();
                        cell.Add(new Paragraph(a.id));
                        table.AddCell(cell);
                        cell = new Cell();
                        cell.Add(new Paragraph(a.date));
                        table.AddCell(cell);
                        cell = new Cell();
                        cell.Add(new Paragraph(a.CER));
                        table.AddCell(cell);
                        cell = new Cell();
                        cell.Add(new Paragraph(a.siteName));
                        table.AddCell(cell);
                        cell = new Cell();
                        cell.Add(new Paragraph(a.siteLocation));
                        table.AddCell(cell);
                        cell = new Cell();
                        cell.Add(new Paragraph(a.producer));
                        table.AddCell(cell);
                        cell = new Cell();
                        cell.Add(new Paragraph(a.validity));
                        table.AddCell(cell);
                    }

                    doc.Add(table);
                }
            }
            return 1;
        }
    }
}
