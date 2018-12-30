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
using MySql.Data.MySqlClient;

namespace TourQueryManager
{
    public partial class FrmVouchersOptionsPage : Form
    {
        static string queryId;
        static string connectionString = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
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
            bool closeForm = true;
            if ((button == BtnPrintHotelVouchers) || (button == BtnPrintBoth))
            {
                //MessageBox.Show("Button pressed = " + button.Text, "PRINTING HOTEL VOUCHERS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /* open connection */
                try
                {
                    mySqlConnection.Open();
                }
                catch (Exception errConnOpen)
                {
                    MessageBox.Show("Error in opening mysql connection because : " + errConnOpen.Message);
                    return;
                }

                /* now execute query to obtain data from hotel booking table
                 * and fill t in dataset
                 */
                string mySqlQueryString = "SELECT DISTINCT `idhotelinfo` FROM `hotelbookinginfo` WHERE `queryid` = '" + queryId + "' ORDER BY `idhotelinfo`";
                DataSet dataset = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlQueryString, mySqlConnection);
                mySqlDataAdapter.Fill(dataset, "TABLE_HOTEL_ID");
                if ((dataset == null) || (dataset.Tables["TABLE_HOTEL_ID"].Rows.Count < 1))
                {
                    MessageBox.Show("No Hotel information present for QueryId = " + queryId, "No Data Present", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    try
                    {
                        mySqlConnection.Close();
                    }
                    catch (Exception errConnClose)
                    {
                        MessageBox.Show("Error in opening mysql connection because : " + errConnClose.Message);
                    }
                    return;
                }
                saveFileDialogItinerary.Title = "HOTEL VOUCHER FILE NAME";
                if (saveFileDialogItinerary.ShowDialog() == DialogResult.OK)
                {
                    /* file selected */
                    Debug.WriteLine("OUT FILE SELECTED : " + saveFileDialogItinerary.FileName);
                }
                else
                {
                    Debug.WriteLine("File not selected thus returning");
                    try
                    {
                        mySqlConnection.Close();
                    }
                    catch (Exception errConnClose)
                    {
                        MessageBox.Show("Error in opening mysql connection because : " + errConnClose.Message);
                    }
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

                /* add hotel booking details.
                 * add different page for different hotel
                 */
                for (int pageNumber = 0; pageNumber < dataset.Tables["TABLE_HOTEL_ID"].Rows.Count; pageNumber++)
                {
                    mySqlQueryString = "SELECT * FROM `hotelbookinginfo` WHERE `queryid` = '" + queryId + "' AND idhotelinfo = " + dataset.Tables["TABLE_HOTEL_ID"].Rows[pageNumber]["idhotelinfo"].ToString();
                    mySqlDataAdapter = new MySqlDataAdapter(mySqlQueryString, mySqlConnection);
                    string tableNameHotelRates = "TABLE_HOTEL_ID_" + pageNumber.ToString();
                    mySqlDataAdapter.Fill(dataset, tableNameHotelRates);
                    mySqlQueryString = "SELECT `hoteladdress`, `hotelname` FROM `hotelinfo` WHERE `idhotelinfo` = " + dataset.Tables["TABLE_HOTEL_ID"].Rows[pageNumber]["idhotelinfo"].ToString();
                    mySqlDataAdapter = new MySqlDataAdapter(mySqlQueryString, mySqlConnection);
                    string tableNameHotelAddress = "HOTEL_ADDRESS_" + pageNumber.ToString();
                    mySqlDataAdapter.Fill(dataset, tableNameHotelAddress);
                    if (dataset.Tables[tableNameHotelRates].Rows.Count < 1)
                    {
                        continue;
                    }
                    if (pageNumber > 0)
                    {
                        section.AddPageBreak();
                    }
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
                    paragraph.AddFormattedText("Confirmed By", "Heading2");
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("Hotel Confirmation No", "Heading2");

                    row = table.AddRow();
                    rowsCount++;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText(queryId, "Heading3");
                    paragraph = row.Cells[1].AddParagraph();
                    paragraph.AddFormattedText(dataset.Tables[tableNameHotelRates].Rows[0]["confirmby"].ToString(), "Heading3");
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText(dataset.Tables[tableNameHotelRates].Rows[0]["idconfirmation"].ToString(), "Heading3");
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
                    //MyPdfDocuments.WriteHdrContentParagraph(row.Cells[0], dataset.Tables[tableNameHotelAddress].Rows[0]["hotelname"].ToString(), dataset.Tables[tableNameHotelAddress].Rows[0]["hoteladdress"].ToString());
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.Format.RightIndent = "1.5cm";
                    paragraph.AddFormattedText(dataset.Tables[tableNameHotelAddress].Rows[0]["hotelname"].ToString() + "\n", "Heading3");
                    paragraph.AddFormattedText(dataset.Tables[tableNameHotelAddress].Rows[0]["hoteladdress"].ToString());

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
                    for (int index = 1; index < columnCount; index++)
                    {
                        column = table.AddColumn(Unit.FromCentimeter(columnWidth + 0.45));
                        column.Format.Alignment = ParagraphAlignment.Left;
                    }
                    column = table.AddColumn(Unit.FromCentimeter(columnWidth - (0.45 * 5)));
                    column.Format.Alignment = ParagraphAlignment.Left;
                    row = table.AddRow();
                    rowsCount++;
                    row.VerticalAlignment = VerticalAlignment.Center;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("Lead Passenger Name", "Heading2");
                    row.Cells[0].MergeRight = 1;
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText(dataset.Tables[tableNameHotelRates].Rows[0]["leadpassangername"].ToString(), "Heading3");
                    row.Cells[2].MergeRight = 3;
                    row = table.AddRow();
                    rowsCount++;
                    row.VerticalAlignment = VerticalAlignment.Center;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("Check In Date", "Heading2");
                    paragraph = row.Cells[1].AddParagraph();
                    //paragraph.AddFormattedText(dataset.Tables[tableNameHotelRates].Rows[0]["checkindate"].ToString(), "Heading3");
                    paragraph.AddFormattedText(DateTime.Parse(dataset.Tables[tableNameHotelRates].Rows[0]["checkindate"].ToString()).ToString("yyyy - MM - dd"), "Heading3");
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("Check Out Date", "Heading2");
                    paragraph = row.Cells[3].AddParagraph();
                    //paragraph.AddFormattedText(dataset.Tables[tableNameHotelRates].Rows[0]["checkoutdate"].ToString(), "Heading3");
                    paragraph.AddFormattedText(DateTime.Parse(dataset.Tables[tableNameHotelRates].Rows[0]["checkoutdate"].ToString()).ToString("yyyy - MM - dd"), "Heading3");
                    paragraph = row.Cells[4].AddParagraph();
                    paragraph.AddFormattedText("No of Nights", "Heading2");
                    paragraph = row.Cells[5].AddParagraph();
                    double noOfnights = (DateTime.Parse(dataset.Tables[tableNameHotelRates].Rows[0]["checkoutdate"].ToString()) -
                        DateTime.Parse(dataset.Tables[tableNameHotelRates].Rows[0]["checkindate"].ToString())).TotalDays;
                    paragraph.AddFormattedText(Convert.ToInt32(noOfnights).ToString(), "Heading3");
                    row = table.AddRow();
                    rowsCount++;
                    row.VerticalAlignment = VerticalAlignment.Center;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("Pick Time", "Heading2");
                    paragraph = row.Cells[1].AddParagraph();
                    //paragraph.AddFormattedText(dataset.Tables[tableNameHotelRates].Rows[0]["checkindate"].ToString(), "Heading3");
                    paragraph.AddFormattedText(DateTime.Parse(dataset.Tables[tableNameHotelRates].Rows[0]["checkindate"].ToString()).ToString("HH:mm"), "Heading3");
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("Drop Time", "Heading2");
                    paragraph = row.Cells[3].AddParagraph();
                    //paragraph.AddFormattedText(dataset.Tables[tableNameHotelRates].Rows[0]["checkoutdate"].ToString(), "Heading3");
                    paragraph.AddFormattedText(DateTime.Parse(dataset.Tables[tableNameHotelRates].Rows[0]["checkoutdate"].ToString()).ToString("HH:mm"), "Heading3");
                    row.Cells[4].MergeRight = 1;


                    table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.SkyBlue);
                    rowsCount = columnCount = 0;
                    section.AddParagraph("\n", "Normal");

                    table = section.AddTable();
                    table.Borders.Visible = true;
                    table.Borders.Width = 0.75;
                    table.Borders.Color = Colors.SkyBlue;
                    columnCount = 6;
                    columnWidth = (21.0 - 2.0) / columnCount;
                    column = table.AddColumn(Unit.FromCentimeter(1.5));
                    column.Format.Alignment = ParagraphAlignment.Center;
                    column = table.AddColumn(Unit.FromCentimeter(2 * columnWidth - 1.5));
                    column.Format.Alignment = ParagraphAlignment.Center;
                    for (int index = 2; index < columnCount; index++)
                    {
                        column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                        column.Format.Alignment = ParagraphAlignment.Center;
                    }
                    row = table.AddRow();
                    rowsCount++;
                    row.VerticalAlignment = VerticalAlignment.Center;
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
                    for (int roomCounter = 0; roomCounter < dataset.Tables[tableNameHotelRates].Rows.Count; roomCounter++)
                    {
                        row = table.AddRow();
                        rowsCount++;
                        row.VerticalAlignment = VerticalAlignment.Center;
                        paragraph = row.Cells[0].AddParagraph();
                        paragraph.AddFormattedText((roomCounter + 1).ToString(), "Heading3");
                        paragraph = row.Cells[1].AddParagraph();
                        paragraph.AddFormattedText(dataset.Tables[tableNameHotelRates].Rows[roomCounter]["roomtype"].ToString(), "Heading3");
                        paragraph = row.Cells[2].AddParagraph();
                        paragraph.AddFormattedText(dataset.Tables[tableNameHotelRates].Rows[roomCounter]["mealplan"].ToString(), "Heading3");
                        paragraph = row.Cells[3].AddParagraph();
                        paragraph.AddFormattedText(dataset.Tables[tableNameHotelRates].Rows[roomCounter]["countroom"].ToString(), "Heading3");
                        paragraph = row.Cells[4].AddParagraph();
                        int numberOfGuest = Convert.ToInt32(dataset.Tables[tableNameHotelRates].Rows[roomCounter]["countadults"]) + Convert.ToInt32(dataset.Tables[tableNameHotelRates].Rows[roomCounter]["countchildren"]);
                        paragraph.AddFormattedText(numberOfGuest.ToString(), "Heading3");
                        paragraph = row.Cells[5].AddParagraph();
                        string guestType = "Adults(" + dataset.Tables[tableNameHotelRates].Rows[roomCounter]["countadults"].ToString() + ")";
                        if (Convert.ToInt32(dataset.Tables[tableNameHotelRates].Rows[roomCounter]["countchildren"]) > 0)
                        {
                            guestType = guestType + "\nChildren(" + dataset.Tables[tableNameHotelRates].Rows[roomCounter]["countchildren"].ToString() + ")";
                        }
                        if (Convert.ToInt32(dataset.Tables[tableNameHotelRates].Rows[roomCounter]["countinfants"]) > 0)
                        {
                            guestType = guestType + "\nBabies(" + dataset.Tables[tableNameHotelRates].Rows[roomCounter]["countinfants"].ToString() + ")";
                        }
                        paragraph.AddFormattedText(guestType, "Heading3");
                    }

                    table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.SkyBlue);
                    rowsCount = columnCount = 0;
                    section.AddParagraph("\n", "Normal");

                    MyPdfDocuments.WriteHotelVoucherStaticDetails(section);
                }

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
                    closeForm = false;
                }
                finally
                {
                    System.IO.File.Delete(imagePath);
                }
                /* now close connection */
                try
                {
                    mySqlConnection.Close();
                }
                catch (Exception errConnClose)
                {
                    MessageBox.Show("Error in opening mysql connection because : " + errConnClose.Message);
                }

                if (closeForm)
                {
                    Debug.WriteLine("File saved: " + saveFileDialogItinerary.FileName);
                }
                else
                {
                    return;
                }
            }

            if ((button == BtnPrintFlightTickets) || (button == BtnPrintBoth))
            {
                //MessageBox.Show("Button pressed = " + button.Text, "PRINTING FLIGHT TICKETS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /* open connection */
                try
                {
                    mySqlConnection.Open();
                }
                catch (Exception errConnOpen)
                {
                    MessageBox.Show("Error in opening mysql connection because : " + errConnOpen.Message);
                    return;
                }

                /* now execute query to obtain data from hotel booking table
                 * and fill t in dataset
                 */
                string mySqlQueryString = "SELECT DISTINCT `pnr` FROM `flightbookinginfo` WHERE `queryid` = '" + queryId + "' ORDER BY `pnr`";
                DataSet dataset = new DataSet();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlQueryString, mySqlConnection);
                mySqlDataAdapter.Fill(dataset, "TABLE_FLIGHT_PNR");
                if ((dataset == null) || (dataset.Tables["TABLE_FLIGHT_PNR"].Rows.Count < 1))
                {
                    MessageBox.Show("No Flight information present for QueryId = " + queryId, "No Data Present", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    try
                    {
                        mySqlConnection.Close();
                    }
                    catch (Exception errConnClose)
                    {
                        MessageBox.Show("Error in opening mysql connection because : " + errConnClose.Message);
                    }
                    return;
                }
                saveFileDialogItinerary.Title = "FLIGHT TICKET FILE NAME";
                if (saveFileDialogItinerary.ShowDialog() == DialogResult.OK)
                {
                    /* file selected */
                    Debug.WriteLine("OUT FILE SELECTED : " + saveFileDialogItinerary.FileName);
                }
                else
                {
                    Debug.WriteLine("File not selected thus returning");
                    try
                    {
                        mySqlConnection.Close();
                    }
                    catch (Exception errConnClose)
                    {
                        MessageBox.Show("Error in opening mysql connection because : " + errConnClose.Message);
                    }
                    return;
                }
                string imagePath = saveFileDialogItinerary.FileName + "logo.png";
                Properties.Resources.ExcursionHolidaysSmallLogo.Save(imagePath);

                Document document = new Document();
                document.Info.Title = "FLIGHT TICKET FOR " + queryId;

                /* Ask for printing price on ticket */
                bool printPrice = false;
                DialogResult dialogResult = MessageBox.Show("Flight price details needs to be printed in the flight voucher?", "PRINT PRICE ON VOUCHER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    printPrice = true;
                }
                else
                {
                    Debug.WriteLine("Price not printing in the ticket");
                }

                /* now cange the style of the document */
                MyPdfDocuments.DefineStyles(document);

                /* add section to document */
                Section section = document.AddSection();
                for (int pageNumber = 0; pageNumber < dataset.Tables["TABLE_FLIGHT_PNR"].Rows.Count; pageNumber++)
                {
                    mySqlQueryString = "SELECT * FROM `flightbookinginfo` WHERE `queryid` = '" + queryId + "' AND `pnr` = '" + dataset.Tables["TABLE_FLIGHT_PNR"].Rows[pageNumber]["pnr"].ToString() + "'";
                    mySqlDataAdapter = new MySqlDataAdapter(mySqlQueryString, mySqlConnection);
                    string tableFlightInfo = "TABLE_FLIGHT_ID_" + pageNumber.ToString();
                    mySqlDataAdapter.Fill(dataset, tableFlightInfo);
                    if (dataset.Tables[tableFlightInfo].Rows.Count < 1)
                    {
                        continue;
                    }
                    if (pageNumber > 0)
                    {
                        section.AddPageBreak();
                    }
                    Paragraph paragraph;
                    Table table = null;
                    Column column = null;
                    int columnCount = 0;// 1;
                    double columnWidth = 0;// (21.0 - 2.0) / columnCount;
                    Row row = null;
                    int rowsCount = 0;

                    table = section.AddTable();
                    table.Borders.Visible = false;
                    table.Borders.Width = 0.75;
                    table.Borders.Color = Colors.SkyBlue;
                    columnCount = 3;
                    columnWidth = (21.0 - 2.0) / columnCount;
                    column = table.AddColumn(Unit.FromCentimeter(1.2));
                    column.Format.Alignment = ParagraphAlignment.Left;
                    columnCount++;
                    column = table.AddColumn(Unit.FromCentimeter(columnWidth - 1.2));
                    column.Format.Alignment = ParagraphAlignment.Left;
                    column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                    column.Format.Alignment = ParagraphAlignment.Center;
                    column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                    column.Format.Alignment = ParagraphAlignment.Right;
                    row = table.AddRow();
                    rowsCount++;
                    MigraDoc.DocumentObjectModel.Shapes.Image image = row.Cells[0].AddImage(imagePath);
                    image.Width = "1cm";
                    MyPdfDocuments.WriteAgencyAddressDetails(row.Cells[1]);
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("E - Ticket\nTICKETED", "Heading2");
                    paragraph = row.Cells[3].AddParagraph();
                    paragraph.AddFormattedText("PNR: " + dataset.Tables[tableFlightInfo].Rows[0]["pnr"].ToString() +
                        " \nIssued Date: " + DateTime.Parse(dataset.Tables[tableFlightInfo].Rows[0]["issuedate"].ToString()).ToString("ddd dd MM yyyy") +
                        "", "Normal");

                    table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.None, 0, Colors.SkyBlue);
                    rowsCount = columnCount = 0;
                    section.AddParagraph("\n", "Normal");

                    table = section.AddTable();
                    table.Borders.Visible = false;
                    table.Borders.Width = 0.75;
                    table.Borders.Color = Colors.SkyBlue;
                    columnCount = 3;
                    columnWidth = (21.0 - 2.0) / columnCount;
                    column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                    column.Format.Alignment = ParagraphAlignment.Left;
                    column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                    column.Format.Alignment = ParagraphAlignment.Center;
                    column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                    column.Format.Alignment = ParagraphAlignment.Right;
                    row = table.AddRow();
                    rowsCount++;
                    row.Shading.Color = Colors.AliceBlue;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("Passanger Name", "Heading3");
                    paragraph = row.Cells[1].AddParagraph();
                    paragraph.AddFormattedText("Ticket Number", "Heading3");
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("Frequent flyer no.", "Heading3");
                    string[] persons = dataset.Tables[tableFlightInfo].Rows[0]["passangername"].ToString().Split(',');
                    string[] tickets = dataset.Tables[tableFlightInfo].Rows[0]["ticketnumber"].ToString().Split(',');
                    string[] ffys = dataset.Tables[tableFlightInfo].Rows[0]["ffy"].ToString().Split(',');
                    for (int index = 0; index < persons.Length; index++)
                    {
                        if (string.Equals(persons[index], ""))
                        {
                            continue;
                        }
                        row = table.AddRow();
                        rowsCount++;
                        paragraph = row.Cells[0].AddParagraph();
                        paragraph.AddFormattedText(persons[index]);
                        paragraph = row.Cells[1].AddParagraph();
                        try
                        {
                            paragraph.AddFormattedText(tickets[index]);
                        }
                        catch (Exception errindex)
                        {
                            MessageBox.Show("Error : " + errindex.Message, "Error in index", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            paragraph.AddFormattedText("");
                        }
                        paragraph = row.Cells[2].AddParagraph();
                        try
                        {
                            paragraph.AddFormattedText(ffys[index]);
                        }
                        catch (Exception errindex)
                        {
                            MessageBox.Show("Error : " + errindex.Message, "Error in index", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            paragraph.AddFormattedText("-");
                        }
                    }

                    table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.None, 0.75, Colors.SkyBlue);
                    rowsCount = columnCount = 0;
                    section.AddParagraph("\n", "Normal");

                    table = section.AddTable();
                    table.Borders.Visible = false;
                    table.Borders.Width = 0.75;
                    table.Borders.Color = Colors.SkyBlue;
                    columnCount = 4;
                    columnWidth = (21.0 - 2.0) / columnCount;
                    for (int index = 0; index < columnCount; index++)
                    {
                        column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                        column.Format.Alignment = ParagraphAlignment.Left;
                    }
                    row = table.AddRow();
                    row.Shading.Color = Colors.AliceBlue;
                    rowsCount++;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("Flight", "Heading3");
                    paragraph = row.Cells[1].AddParagraph();
                    paragraph.AddFormattedText("Departure", "Heading3");
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("Arrival", "Heading3");
                    paragraph = row.Cells[3].AddParagraph();
                    paragraph.AddFormattedText("Status", "Heading3");
                    for (int flightCounter = 0; flightCounter < dataset.Tables[tableFlightInfo].Rows.Count; flightCounter++)
                    {
                        row = table.AddRow();
                        rowsCount++;
                        paragraph = row.Cells[0].AddParagraph();
                        paragraph.AddFormattedText(dataset.Tables[tableFlightInfo].Rows[flightCounter]["flightinfo"].ToString());
                        paragraph = row.Cells[1].AddParagraph();
                        paragraph.AddFormattedText(dataset.Tables[tableFlightInfo].Rows[flightCounter]["departureinfo"].ToString());
                        paragraph = row.Cells[2].AddParagraph();
                        paragraph.AddFormattedText(dataset.Tables[tableFlightInfo].Rows[flightCounter]["arrivalinfo"].ToString());
                        paragraph = row.Cells[3].AddParagraph();
                        paragraph.AddFormattedText(dataset.Tables[tableFlightInfo].Rows[flightCounter]["statusinfo"].ToString());
                    }
                    table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.None, 0.75, Colors.SkyBlue);
                    rowsCount = columnCount = 0;
                    section.AddParagraph("\n", "Normal");

                    table = section.AddTable();
                    table.Borders.Visible = false;
                    table.Borders.Width = 0.75;
                    table.Borders.Color = Colors.SkyBlue;
                    columnCount = 4;
                    columnWidth = (21.0 - 2.0) / columnCount;
                    for (int index = 0; index < 2; index++)
                    {
                        column = table.AddColumn(Unit.FromCentimeter(columnWidth + 1.0));
                        column.Format.Alignment = ParagraphAlignment.Left;
                    }
                    for (int index = 2; index < 4; index++)
                    {
                        column = table.AddColumn(Unit.FromCentimeter(columnWidth - 1.0));
                        column.Format.Alignment = ParagraphAlignment.Right;
                    }
                    if (printPrice)
                    {
                        row = table.AddRow();
                        rowsCount++;
                        row.Shading.Color = Colors.AliceBlue;
                        paragraph = row.Cells[0].AddParagraph();
                        paragraph.AddFormattedText("Payment Details", "Heading3");
                        row.Cells[0].MergeRight = 3;
                    }
                    row = table.AddRow();
                    rowsCount++;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("This is an Electronic ticket. Please carry a positive identification for Check in.");
                    paragraph.Format.Font.Bold = true;
                    row.Cells[0].MergeRight = 1;
                    if (printPrice)
                    {
                        int totalPrice = Convert.ToInt32(dataset.Tables[tableFlightInfo].Rows[0]["amountfare"]) +
                            Convert.ToInt32(dataset.Tables[tableFlightInfo].Rows[0]["amountgst"]) +
                            Convert.ToInt32(dataset.Tables[tableFlightInfo].Rows[0]["amountsurcharge"]);
                        row.Cells[0].MergeDown = 3;
                        paragraph = row.Cells[2].AddParagraph();
                        paragraph.AddFormattedText("Fare", "Normal");
                        paragraph = row.Cells[3].AddParagraph();
                        paragraph.AddFormattedText(dataset.Tables[tableFlightInfo].Rows[0]["amountfare"].ToString(), "Normal");
                        row = table.AddRow();
                        rowsCount++;
                        paragraph = row.Cells[2].AddParagraph();
                        paragraph.AddFormattedText("K3/GST", "Normal");
                        paragraph = row.Cells[3].AddParagraph();
                        paragraph.AddFormattedText(dataset.Tables[tableFlightInfo].Rows[0]["amountgst"].ToString(), "Normal");
                        row = table.AddRow();
                        rowsCount++;
                        paragraph = row.Cells[2].AddParagraph();
                        paragraph.AddFormattedText("Fee & Surcharge", "Normal");
                        paragraph = row.Cells[3].AddParagraph();
                        paragraph.AddFormattedText(dataset.Tables[tableFlightInfo].Rows[0]["amountsurcharge"].ToString(), "Normal");
                        row = table.AddRow();
                        rowsCount++;
                        paragraph = row.Cells[2].AddParagraph();
                        paragraph.AddFormattedText("Total Amount");
                        paragraph.Format.Font.Bold = true;
                        paragraph = row.Cells[3].AddParagraph();
                        paragraph.AddFormattedText(totalPrice.ToString());
                        paragraph.Format.Font.Bold = true;
                    }
                    table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.None, 0.5, Colors.SkyBlue);
                    rowsCount = columnCount = 0;
                    paragraph = section.AddParagraph("\n\n\n", "Normal");

                    /* ADD TERMINAL DETAILS HERE */
                    //paragraph = section.AddParagraph("<TERMINAL DETAILS TYPED HERE XXX XXX XXX XXX XXX XXX XXX XXX XXX XXX XXX XXX>");
                    //paragraph.Format.Font.Color = Colors.Red;
                    table = section.AddTable();
                    table.Borders.Visible = false;
                    table.Borders.Width = 0.75;
                    table.Borders.Color = Colors.SkyBlue;
                    columnCount = 1;
                    columnWidth = (21.0 - 2.0) / columnCount;
                    column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                    column.Format.Alignment = ParagraphAlignment.Left;
                    row = table.AddRow();
                    rowsCount++;
                    MyPdfDocuments.WriteFlightVoucherNote(row.Cells[0]);

                    table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 0, Colors.SkyBlue);
                }

                PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always);

                try
                {
                    /* try to save file */
                    renderer.Document = document;
                    renderer.RenderDocument();
                    renderer.PdfDocument.Save(saveFileDialogItinerary.FileName);
                    renderer.PdfDocument.Close();
                    Process.Start(saveFileDialogItinerary.FileName);
                    Debug.WriteLine("File saved: " + saveFileDialogItinerary.FileName);
                }
                catch (Exception errSave)
                {
                    MessageBox.Show("Error in saving file " + saveFileDialogItinerary.FileName + " because " + errSave.Message);
                    Debug.WriteLine("Error in saving file " + saveFileDialogItinerary.FileName + " because " + errSave.Message);
                    closeForm = false;
                }
                finally
                {
                    System.IO.File.Delete(imagePath);
                }
                try
                {
                    mySqlConnection.Close();
                }
                catch (Exception errConnClose)
                {
                    MessageBox.Show("Error in opening mysql connection because : " + errConnClose.Message);
                }
            }
            if (closeForm)
            {
                Close();
            }
        }
    }
}
