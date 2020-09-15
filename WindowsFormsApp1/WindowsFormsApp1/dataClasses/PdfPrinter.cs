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
using System.Web.UI;
using Microsoft.VisualBasic.Compatibility.VB6;
using System.IO;

namespace WindowsFormsApp1.dataClasses
{
    class PdfPrinter
    {

        public int printFirms(string folder, List<Firm> firms)
        {
            PdfWriter writer;
            try
            {
                writer = new PdfWriter(folder + "\\imprese.pdf");
            }
            catch
            {
                return -1;
            }
            using (writer)
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
            PdfWriter writer;
            try
            {
                writer = new PdfWriter(folder + "\\analisi.pdf");
            }
            catch
            {
                return -1;
            }
            using (writer)
            {
                using (var pdfDoc = new PdfDocument(writer))
                {
                    pdfDoc.SetDefaultPageSize(PageSize.A4.Rotate());
                    var doc = new iText.Layout.Document(pdfDoc);
                    // Doc Title
                    Paragraph title = new Paragraph();
                    title.Add("Analisi");
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
                        cell.Add(new Paragraph(a.id.ToString()));
                        table.AddCell(cell);
                        cell = new Cell();
                        cell.Add(new Paragraph(a.date.ToString()));
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

        public int printRegister(string folder, List<Module> form)
        {
            PdfWriter writer;
            try
            {
                writer = new PdfWriter(folder + "\\registro.pdf");
            }
            catch
            {
                return -1;
            }
            using (writer)
            {
                using (var pdfDoc = new PdfDocument(writer))
                {
                    pdfDoc.SetDefaultPageSize(PageSize.A4.Rotate());
                    var doc = new iText.Layout.Document(pdfDoc);
                    // Doc Title
                    Paragraph title = new Paragraph();
                    title.Add("Registro");
                    title.SetFontSize(30);
                    title.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                    doc.Add(title);

                    // Doc table
                    var table = new Table(11);
                    table.UseAllAvailableWidth();

                    // First row
                    Cell cell = new Cell();
                    cell.Add(new Paragraph("ID"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Data"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Carico/Scarico"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Produttore"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Trasportatore"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Targa"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("CER"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Pinzare"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Kg"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Comune"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Cantiere"));
                    table.AddCell(cell);

                    // Filling Table
                    for (int i = 0; i < form.Count; i++)
                    {
                        string formString = form[i].getString(";");

                        string[] fields = formString.Split(';');

                        foreach (string field in fields)
                        {
                            cell = new Cell();
                            Paragraph par = new Paragraph(field);
                            par.SetFontSize(8);
                            cell.Add(par);
                            table.AddCell(cell);
                        }
                    }

                    doc.Add(table);
                }
            }
            return 1;
        }

        public int printSite(string folder, List<Site>  site)
        {
            PdfWriter writer;
            try
            {
                writer = new PdfWriter(folder + "\\cantieri.pdf");
            }
            catch
            {
                return -1;
            }
            using (writer)
            {
                using (var pdfDoc = new PdfDocument(writer))
                {
                    
                    pdfDoc.SetDefaultPageSize(PageSize.A4.Rotate());
                    var doc = new iText.Layout.Document(pdfDoc);
                    // Doc Title
                    Paragraph title = new Paragraph();
                    title.Add("Cantieri");
                    title.SetFontSize(30);
                    title.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                    doc.Add(title);

                    // Doc table
                    var table = new Table(2);
                    table.UseAllAvailableWidth();

                    // First row
                    Cell cell = new Cell();
                    cell.Add(new Paragraph("Comune"));
                    table.AddCell(cell);
                    cell = new Cell();
                    cell.Add(new Paragraph("Cantiere"));
                    table.AddCell(cell);

                    // Filling Table
                    for (int i = 0; i < site.Count; i++)
                    {
                        string siteString = site[i].getString(";");
                        string[] fields = siteString.Split(';');

                        cell = new Cell(fields.Length-1, 1);
                        cell.Add(new Paragraph(fields[0]));
                        table.AddCell(cell);

                        for(int j = 1; j < fields.Length ; j++)
                        {
                            cell = new Cell();
                            cell.Add(new Paragraph(fields[j]));
                            table.AddCell(cell);
                        }
                    }

                    doc.Add(table);
                    
                }
            }
            return 1;
        }

        public int printMonths(string folder, List<List<MonthElement>> months)
        {
            // Foreach month in year
            foreach(var month in months)
            {
                // Check if there are data in this month
                if (month == null || month.Count == 0 || month[0].veichles.Count == 0)
                    continue;

                // Generate the filename
                var currMonth = months.IndexOf(month) + 1;
                var currYear = month[0].veichles[0].dates[0].date.Year;
                var monthName = Microsoft.VisualBasic.DateAndTime.MonthName(currMonth);

                string filename = currMonth.ToString() + "_" + monthName + ".pdf";

                PdfWriter writer;
                try
                {
                    writer = new PdfWriter(folder + "\\" + filename);
                }
                catch
                {
                    return -1;
                }

                // Create file in the folder with the generated filename
                using (writer)
                {
                    using (var pdfDoc = new PdfDocument(writer))
                    {
                        pdfDoc.SetDefaultPageSize(PageSize.A4.Rotate());
                        var doc = new iText.Layout.Document(pdfDoc);

                        var hcenter = iText.Layout.Properties.TextAlignment.CENTER;
                        var vcenter = iText.Layout.Properties.VerticalAlignment.MIDDLE;


                        // Doc Title
                        Paragraph title = new Paragraph(monthName);
                        title.SetFontSize(30);
                        doc.Add(title);

                        // Doc table
                        // Generate a table with colums count equal to the days in the month plus 2 (firm, veichle) plus 2 (normal and to break) plus total
                        var table = new Table(DateTime.DaysInMonth(month[0].veichles[0].dates[0].date.Year, months.IndexOf(month)+1)+2 +2 +1);
                        table.UseAllAvailableWidth();

                        // First row
                        Cell cell = new Cell();
                        cell.Add(new Paragraph("Impresa").SetTextAlignment(hcenter).SetVerticalAlignment(vcenter)).SetBold().SetFontSize(15);
                        table.AddCell(cell);
                        cell = new Cell();
                        cell.Add(new Paragraph("Mezzo").SetTextAlignment(hcenter).SetVerticalAlignment(vcenter)).SetBold().SetFontSize(15);
                        table.AddCell(cell);

                        // Days
                        for (int day = 1; day <= DateTime.DaysInMonth(currYear, currMonth); day ++)
                        {
                            var date = day.ToString() + "/" + currMonth.ToString() + "/" + currYear.ToString();

                            cell = new Cell();
                            cell.Add(new Paragraph(date).SetFontSize(8).SetTextAlignment(hcenter).SetVerticalAlignment(vcenter));
                            cell.SetRotationAngle(-Math.PI/2);
                            table.AddCell(cell);
                        }

                        // Total trip counts
                        cell = new Cell();
                        cell.Add(new Paragraph("N").SetBold().SetFontSize(15));
                        table.AddCell(cell);
                        cell = new Cell();
                        cell.Add(new Paragraph("P").SetBold().SetFontSize(15));
                        table.AddCell(cell);
                        cell = new Cell();
                        cell.Add(new Paragraph("Totale").SetBold().SetFontSize(15));
                        table.AddCell(cell);

                        // Foreach firm in this current month
                        foreach (var element in month)
                        {
                            // Create first cell with firm name
                            cell = new Cell(element.veichles.Count, 1);
                            cell.Add(new Paragraph(element.firm).SetTextAlignment(hcenter).SetVerticalAlignment(vcenter));
                            table.AddCell(cell);

                            // For every veichle in this current firm
                            foreach(var veichle in element.veichles)
                            {
                                // Create cell with veichle informations
                                cell = new Cell();
                                cell.Add(new Paragraph(veichle.veichle.plate).SetTextAlignment(hcenter).SetVerticalAlignment(vcenter));
                                table.AddCell(cell);

                                // Foreach day in this current month
                                for (int day = 1; day <= DateTime.DaysInMonth(currYear, currMonth); day++)
                                {
                                    // Create cell with the count of veichle trips
                                    // If 0 trip, fill with nothing
                                    var datestring = day.ToString() + "/" + currMonth.ToString() + "/" + currYear.ToString();
                                    var date = DateTime.Parse(datestring);

                                    if(veichle.dates.FindAll(x=>(x.date == date)).Count > 0)
                                    {
                                        var count = veichle.dates.FindAll(x => (x.date == date))[0].count;
                                        cell = new Cell();
                                        cell.Add(new Paragraph(count.ToString()).SetFontSize(8).SetTextAlignment(hcenter).SetVerticalAlignment(vcenter));
                                        table.AddCell(cell);
                                    }
                                    else
                                    {
                                        cell = new Cell();
                                        cell.Add(new Paragraph(""));
                                        table.AddCell(cell);
                                    }
                                }

                                // Create cell whith total trip count int this current month for this specific veichle
                                cell = new Cell();
                                cell.Add(new Paragraph(veichle.normalCount.ToString()).SetTextAlignment(hcenter).SetVerticalAlignment(vcenter));
                                table.AddCell(cell);
                                cell = new Cell();
                                cell.Add(new Paragraph(veichle.toBreakCount.ToString()).SetTextAlignment(hcenter).SetVerticalAlignment(vcenter));
                                table.AddCell(cell);
                                cell = new Cell();
                                cell.Add(new Paragraph(veichle.totalCount.ToString()).SetTextAlignment(hcenter).SetVerticalAlignment(vcenter));
                                table.AddCell(cell);
                            }
                        }

                        doc.Add(table);

                    }
                }
            }


            return 1;
        }

    }
}
