using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourQueryManager
{
    public partial class FrmVouchersOptionsPage : Form
    {
        static string queryId;
        public FrmVouchersOptionsPage(string argv)
        {
            InitializeComponent();
            queryId = argv;
        }

        private void FrmVouchersOptionsPage_Load(object sender, EventArgs e)
        {
            /* Do some work for loading of the page */
            Text = "GENERATE VOUCHERS FOR " + queryId;
            lblQueryInfo.Text = "PRINT VOUCHERS AND TICKETS FOR " + queryId;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPrintVouchersAndTickets_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if ((button == BtnPrintHotelVouchers) || (button == BtnPrintBoth))
            {
                //MessageBox.Show("Button pressed = " + button.Text, "PRINTING HOTEL VOUCHERS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (saveFileDialogItinerary.ShowDialog() == DialogResult.OK)
                {
                    /* file selected */
                    Debug.WriteLine("OUT FILE SELECTED : " + saveFileDialogItinerary.FileName);
                }
                else
                {
                    Debug.WriteLine("File not selected thus returning");
                    return;
                }
                string imagePath = saveFileDialogItinerary.FileName + "logo.png";
                Properties.Resources.ExcursionHolidaysSmallLogo.Save(imagePath);

                Document document = new Document();
                document.Info.Title = "HOTEL VOUCHER FOR " + queryId;

                /* now cange the style of the document */
                MyPdfDocuments.DefineStyles(document);

                /* add section to document */
                Section section = document.AddSection();
                Paragraph paragraph = section.AddParagraph("HOTEL VOUCHER", "Heading1");
                /* enter reference details in tabular form */
                Table table = null;
                Column column = null;
                int columnCount = 0;// 1;
                double columnWidth = 0;// (21.0 - 2.0) / columnCount;
                Row row = null;
                int rowsCount = 0;
                
                table = section.AddTable();
                table.Borders.Visible = true;
                table.Borders.Width = 0.75;
                table.Borders.Color = Colors.SkyBlue;
                columnCount = 3;
                columnWidth = (21.0 - 2.0) / columnCount;
                for (int index = 0; index < columnCount; index++)
                {
                    column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                    column.Format.Alignment = ParagraphAlignment.Center;
                }
                row = table.AddRow();
                rowsCount++;
                paragraph = row.Cells[0].AddParagraph();
                paragraph.AddFormattedText("Reference No", "Heading2");
                paragraph = row.Cells[1].AddParagraph();
                paragraph.AddFormattedText("Confirmation No", "Heading2");
                paragraph = row.Cells[2].AddParagraph();
                paragraph.AddFormattedText("Hotel Confirmation No", "Heading2");

                row = table.AddRow();
                rowsCount++;
                /* Add contant for the table information */
                table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.SkyBlue);
                rowsCount = columnCount = 0;
                section.AddParagraph("\n", "Normal");
                /* add hotel address and agency address in table */
                table = section.AddTable();
                table.Borders.Visible = false;
                table.Borders.Width = 0.75;
                columnCount = 2;
                columnWidth = (21.0 - 2.0) / columnCount;
                column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                column.Format.Alignment = ParagraphAlignment.Left;
                column = table.AddColumn(Unit.FromCentimeter(1.2));
                column.Format.Alignment = ParagraphAlignment.Left;
                columnCount++;
                column = table.AddColumn(Unit.FromCentimeter(columnWidth - 1.2));
                column.Format.Alignment = ParagraphAlignment.Left;
                row = table.AddRow();
                rowsCount++;
                paragraph = row.Cells[0].AddParagraph();
                paragraph.AddFormattedText("Hotel Address Details", "Heading2");
                paragraph = row.Cells[1].AddParagraph();
                paragraph.AddFormattedText("Agency Address Details", "Heading2");
                row.Cells[1].MergeRight = 1;

                row = table.AddRow();
                rowsCount++;
                paragraph = row.Cells[0].AddParagraph();
                paragraph.Format.RightIndent = "1.5cm";
                paragraph.AddFormattedText("<HOTEL ADDRESS PRESENT IN DATABSE XXX XXX XXX XXX XXX XXX XXX XXX XXX XXX XXX XXX XXX XXXX XXX XXX XXX XXX>", "Heading3");

                MigraDoc.DocumentObjectModel.Shapes.Image image = row.Cells[1].AddImage(imagePath);
                image.Width = "1cm";
                //image.Left = "-2.4cm";

                MyPdfDocuments.WriteAgencyAddressDetails(row.Cells[2]);
                /* Add contant for the table information */
                table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.SkyBlue);
                rowsCount = columnCount = 0;
                section.AddParagraph("\n", "Normal");

                table = section.AddTable();
                table.Borders.Visible = true;
                table.Borders.Width = 0.75;
                table.Borders.Color = Colors.SkyBlue;
                columnCount = 6;
                columnWidth = (21.0 - 2.0) / columnCount;
                for (int index = 0; index < columnCount; index++)
                {
                    column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                    column.Format.Alignment = ParagraphAlignment.Left;
                }
                row = table.AddRow();
                rowsCount++;
                paragraph = row.Cells[0].AddParagraph();
                paragraph.AddFormattedText("Lead Passenger Name", "Heading2");
                row.Cells[0].MergeRight = 1;
                paragraph = row.Cells[2].AddParagraph();
                paragraph.AddFormattedText("<Passanger name here>", "Heading3");
                row.Cells[2].MergeRight = 3;
                row = table.AddRow();
                rowsCount++;
                paragraph = row.Cells[0].AddParagraph();
                paragraph.AddFormattedText("Check In Date", "Heading2");
                paragraph = row.Cells[1].AddParagraph();
                paragraph.AddFormattedText("<Check In Date here>", "Heading3");
                paragraph = row.Cells[2].AddParagraph();
                paragraph.AddFormattedText("Check Out Date", "Heading2");
                paragraph = row.Cells[3].AddParagraph();
                paragraph.AddFormattedText("<Check out Date here>", "Heading3");
                paragraph = row.Cells[4].AddParagraph();
                paragraph.AddFormattedText("No of Nights", "Heading2");
                paragraph = row.Cells[5].AddParagraph();
                paragraph.AddFormattedText("<No of nights here>", "Heading3");


                table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.SkyBlue);
                rowsCount = columnCount = 0;
                section.AddParagraph("\n", "Normal");

                table = section.AddTable();
                table.Borders.Visible = true;
                table.Borders.Width = 0.75;
                table.Borders.Color = Colors.SkyBlue;
                columnCount = 6;
                columnWidth = (21.0 - 2.0) / columnCount;
                for (int index = 0; index < columnCount; index++)
                {
                    column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                    column.Format.Alignment = ParagraphAlignment.Left;
                }
                row = table.AddRow();
                rowsCount++;
                //row.Shading.Color = Colors.LightSlateGray;
                paragraph = row.Cells[0].AddParagraph();
                paragraph.AddFormattedText("S. No", "Heading2");
                paragraph = row.Cells[1].AddParagraph();
                paragraph.AddFormattedText("Room Type", "Heading2");
                paragraph = row.Cells[2].AddParagraph();
                paragraph.AddFormattedText("Meal Plan", "Heading2");
                paragraph = row.Cells[3].AddParagraph();
                paragraph.AddFormattedText("No of Rooms", "Heading2");
                paragraph = row.Cells[4].AddParagraph();
                paragraph.AddFormattedText("No of Guests", "Heading2");
                paragraph = row.Cells[5].AddParagraph();
                paragraph.AddFormattedText("Guests Type", "Heading2");
                row = table.AddRow();
                rowsCount++;
                
                table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.SkyBlue);
                rowsCount = columnCount = 0;
                section.AddParagraph("\n", "Normal");

                MyPdfDocuments.WriteHotelVoucherStaticDetails(section);
                
                PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always);

                try
                {
                    /* try to save file */
                    renderer.Document = document;
                    renderer.RenderDocument();
                    renderer.PdfDocument.Save(saveFileDialogItinerary.FileName);
                    renderer.PdfDocument.Close();
                    Process.Start(saveFileDialogItinerary.FileName);
                }
                catch (Exception errSave)
                {
                    MessageBox.Show("Error in saving file " + saveFileDialogItinerary.FileName + " because " + errSave.Message);
                    Debug.WriteLine("Error in saving file " + saveFileDialogItinerary.FileName + " because " + errSave.Message);
                }
                finally
                {
                    System.IO.File.Delete(imagePath);
                }

            }
            if ((button == BtnPrintFlightTickets) || (button == BtnPrintBoth))
            {
                MessageBox.Show("Button pressed = " + button.Text, "PRINTING FLIGHT TICKETS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }
    }
}
