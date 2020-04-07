using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace HttpPrintingServer
{
    public class PrintingUtils
    {
        public void print(dynamic printingobject)
        {

            string s = printingobject.ToString();

            dynamic jsonResponse = JsonConvert.DeserializeObject(s);
            string printersettingfile = jsonResponse["printersetting"].Value;
            var body = jsonResponse["body"];
            Console.WriteLine("printing setting file name");
            Console.WriteLine(printersettingfile);
            foreach (var item in body) {
                var content = item["content"];
                Console.Write("item contentt " + content +"\n");
            }

            using (StreamReader r = new StreamReader(printersettingfile))
            {
                string json = r.ReadToEnd();
                var i = 123;
            }



            //PrintDialog pd = new PrintDialog();
            //var doc = ((IDocumentPaginatorSource)getFlowDocument()).DocumentPaginator;
            //pd.PrintQueue = new PrintQueue(new PrintServer(), new PrinterSettings().PrinterName);
            //pd.PrintDocument(doc, "Printed Document");
        }
        FlowDocument getFlowDocument() 
        {
            FlowDocument flowDocument = new FlowDocument();
            return flowDocument;

        }
        //FlowDocument getFlowDocument(SaleModel saleModel)
        //{
        //    FlowDocument fd = new FlowDocument();
        //    fd.PageWidth = 280;
        //    if (saleModel.Font != null)
        //    {
        //        fd.FontFamily = new System.Windows.Media.FontFamily(saleModel.Font);
        //    }
        //    else
        //    {
        //        fd.FontFamily = new System.Windows.Media.FontFamily("Arial");
        //    }

        //    fd.PagePadding = new Thickness(0, 0, 0, 0);
        //    fd.TextAlignment = TextAlignment.Center;
        //    Section header = new Section();
        //    Paragraph header1 = new Paragraph(new Bold(new Run("Usman General Store")));
        //    Paragraph header2 = new Paragraph(new Run("Noori Darbar Road, Muslim Abad,Pull Fateh Garh, Lahore. 0300-4396491"));


        //    string date = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
        //    Paragraph header3 = new Paragraph(new Run("Sales Id: " + saleModel.SaleId));
        //    Paragraph header4 = new Paragraph(new Run("Date: " + date));
        //    Paragraph header5 = new Paragraph(new Run("______________________________________"));
        //    header1.FontSize = 17;// old was 14
        //    header2.FontSize = 14;// old was 10
        //    header3.FontSize = 12;// old was 9
        //    header4.FontSize = 12;
        //    header5.FontSize = 10;
        //    header.Blocks.Add(header1);
        //    header.Blocks.Add(header2);
        //    header.Blocks.Add(header3);
        //    header.Blocks.Add(header4);
        //    header.Blocks.Add(header5);


        //    Section middle = new Section();
        //    middle.FontSize = 11; // old size was 9
        //    Table table = new Table();
        //    table.TextAlignment = TextAlignment.Left;
        //    TableColumn tb1 = new TableColumn();
        //    tb1.Width = new GridLength(140);
        //    TableColumn tb2 = new TableColumn();
        //    TableColumn tb3 = new TableColumn();
        //    TableColumn tb4 = new TableColumn();
        //    table.Columns.Add(tb1);
        //    table.Columns.Add(tb2);
        //    table.Columns.Add(tb3);
        //    table.Columns.Add(tb4);
        //    table.RowGroups.Add(new TableRowGroup());
        //    TableRow trHeader = new TableRow();
        //    table.RowGroups[0].Rows.Add(trHeader);
        //    trHeader.Cells.Add(new TableCell(new Paragraph(new Run("Name"))));
        //    trHeader.Cells.Add(new TableCell(new Paragraph(new Run("Rs"))));
        //    trHeader.Cells.Add(new TableCell(new Paragraph(new Run("Qty"))));
        //    trHeader.Cells.Add(new TableCell(new Paragraph(new Run("Ttl"))));

        //    foreach (SaleItem item in saleModel.SaleList)
        //    {
        //        TableRow tr = new TableRow();
        //        table.RowGroups[0].Rows.Add(tr);
        //        //tr.Cells.Add(new TableCell(new Paragraph(new Run("Item 1"))));
        //        //tr.Cells.Add(new TableCell(new Paragraph(new Run("100"))));
        //        //tr.Cells.Add(new TableCell(new Paragraph(new Run("100"))));
        //        //tr.Cells.Add(new TableCell(new Paragraph(new Run("1000"))));
        //        tr.Cells.Add(new TableCell(new Paragraph(new Run(item.name))));
        //        tr.Cells.Add(new TableCell(new Paragraph(new Run(item.price))));
        //        tr.Cells.Add(new TableCell(new Paragraph(new Run(item.quantity))));
        //        tr.Cells.Add(new TableCell(new Paragraph(new Run(item.total))));
        //    }
        //    middle.Blocks.Add(table);
        //    double Payment = Convert.ToDouble(saleModel.DiscountedBill) + Convert.ToDouble(saleModel.Change);
        //    middle.Blocks.Add(new Paragraph(new Run("______________________________________")));
        //    middle.Blocks.Add(new Paragraph(new Bold(new Run("           Total Items                      " + saleModel.SaleList.Count))));
        //    middle.Blocks.Add(new Paragraph(new Bold(new Run("           Bill                                   " + saleModel.DiscountedBill))));
        //    middle.Blocks.Add(new Paragraph(new Bold(new Run("           Payment                          " + Payment))));
        //    middle.Blocks.Add(new Paragraph(new Bold(new Run("           Balance                            " + saleModel.Change))));
        //    middle.TextAlignment = TextAlignment.Left;

        //    Section footer = new Section();
        //    Paragraph footer1 = new Paragraph(new Run("Thankyou for Purchasing."));
        //    Paragraph footer2 = new Paragraph(new Run("Software Developed By QuickLinqs."));
        //    Paragraph footer3 = new Paragraph(new Bold(new Run("QuickLinqs Phone: 03024759550  www.quicklinqs.com")));
        //    Paragraph footer4 = new Paragraph(new Run("                "));
        //    footer1.FontSize = 14;
        //    footer2.FontSize = 10;
        //    footer3.FontSize = 9;
        //    footer.Blocks.Add(footer1);
        //    footer.Blocks.Add(footer2);
        //    footer.Blocks.Add(footer3);
        //    footer.Blocks.Add(footer4);


        //    fd.Blocks.Add(header);
        //    fd.Blocks.Add(middle);
        //    fd.Blocks.Add(footer);
        //    return fd;
        //}
    }
}
