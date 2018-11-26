using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace TourQueryManager
{
    public partial class FrmAdminQueryWorkingPage : Form
    {
        static string frmArgStr;
        static string mysqlConnectionString = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection frmMysqlConnection = new MySqlConnection(mysqlConnectionString);
        
        public FrmAdminQueryWorkingPage(string frmAdminQueryWorkingArgument)
        {
            InitializeComponent();
            frmArgStr = frmAdminQueryWorkingArgument;
        }

        private void FrmAdminQueryWorkingPage_Load(object sender, EventArgs e)
        {
            Text = "SELECT QUERY TO GENERATE " + frmArgStr;
            DataGrdVuAdminQueriesLoad(frmArgStr);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGrdVuAdminQueriesLoad(string argumentString)
        {
            string mysqlSelectQuery = null;
            mysqlSelectQuery = "SELECT `queryid`, `place`, `fromdate`, `todate`, `querystartdate`, `name`, `querycurrentstate` " +
                "FROM `queries` WHERE ";
            if (string.Equals(argumentString, "ITINERARY"))
            {
                mysqlSelectQuery += "`querycurrentstate` >= " + Properties.Resources.queryStageDoneByUser +
                " AND `querycurrentstate` <= " + Properties.Resources.queryStageMailed;
            }
            else if (string.Equals(argumentString, "FINALIZE OFFER"))
            {
                mysqlSelectQuery += "`querycurrentstate` = " + Properties.Resources.queryStageMailed;
            }
            else if (string.Equals(argumentString, "UPDATE ACCEPTED OFFER"))
            {
                mysqlSelectQuery += "`querycurrentstate` >= " + Properties.Resources.queryStageDealDone +
                " AND `querycurrentstate` <= " + Properties.Resources.queryStageVoucherCompleted;
            }
            else if (string.Equals(argumentString, "VOUCHERS"))
            {
                mysqlSelectQuery += "`querycurrentstate` >= " + Properties.Resources.queryStageVoucherCompleted;
            }
            else if (string.Equals(argumentString, "VIEW ALL"))
            {
                mysqlSelectQuery += "`querycurrentstate` != 0";
            }

            else
            {
                MessageBox.Show("Wrong method invoked");
                return;
            }

            try
            {
                frmMysqlConnection.Open();
            }
            catch (Exception errConnOpen)
            {
                MessageBox.Show("Error in opening mysql connection because : " + errConnOpen.Message);
                return;
            }

            DataSet queryDataset = new DataSet();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mysqlSelectQuery, frmMysqlConnection);
            try
            {
                mySqlDataAdapter.Fill(queryDataset, "ASSIGNED_QUERIES");
                DataGrdVuAdminQueries.Rows.Clear();
                if (queryDataset != null)
                {
                    foreach (DataRow item in queryDataset.Tables["ASSIGNED_QUERIES"].Rows)
                    {
                        int index = DataGrdVuAdminQueries.Rows.Add();
                        DataGrdVuAdminQueries.Rows[index].Cells["QueryId"].Value = item["queryid"].ToString();
                        DataGrdVuAdminQueries.Rows[index].Cells["FromDate"].Value = item["fromdate"].ToString();
                        DataGrdVuAdminQueries.Rows[index].Cells["Name"].Value = item["name"].ToString();
                        DataGrdVuAdminQueries.Rows[index].Cells["QueryStage"].Value = item["querycurrentstate"].ToString() + " ( " + MyPdfDocuments.PrintCurrentQueryStage(Convert.ToInt32(item["querycurrentstate"])) + " )";
                        DataGrdVuAdminQueries.Rows[index].Cells["ToDate"].Value = item["todate"].ToString();
                        DataGrdVuAdminQueries.Rows[index].Cells["Location"].Value = item["place"].ToString();
                        DataGrdVuAdminQueries.Rows[index].Cells["AssignedDate"].Value = item["querystartdate"].ToString();
                    }
                }
                DataGrdVuAdminQueries.ClearSelection();
            }
            catch (Exception errQuery)
            {
                MessageBox.Show("Error in executing command because : " + errQuery.Message);
            }
            try
            {
                frmMysqlConnection.Close();
            }
            catch (Exception errConnClose)
            {
                MessageBox.Show("Error in Closing mysql connection because : " + errConnClose.Message);
            }
        }
        
        private void DataGrdVuAdminQueries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrdVuAdminQueries.Rows.Count > 0)
            {
                /* Open new Form of Working and pass queryId to the working */
                try
                {
                    Debug.WriteLine("Generating VOUCHERS FOR : \n" +
                    DataGrdVuAdminQueries.SelectedRows[0].Cells["AssignedDate"].Value.ToString() + "\n" +
                    DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString() + "\n" +
                    DataGrdVuAdminQueries.SelectedRows[0].Cells["Location"].Value.ToString() + "\n" +
                    DataGrdVuAdminQueries.SelectedRows[0].Cells["fromDate"].Value.ToString() + "\n" +
                    DataGrdVuAdminQueries.SelectedRows[0].Cells["toDate"].Value.ToString() + "\n");
                }
                catch (Exception errSelectedIndex)
                {
                    Debug.WriteLine("No rows selected because : " + errSelectedIndex.Message);
                    return;
                }

                if (string.Equals(frmArgStr, "VOUCHERS"))
                {
                    FrmVouchersOptionsPage newFrmPage = new FrmVouchersOptionsPage(DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString());
                    Hide();
                    newFrmPage.ShowDialog();
                    Show();
                }
                else if (string.Equals(frmArgStr, "FINALIZE OFFER"))
                {
                    FrmFinalizeQueryPage newFrmPage = new FrmFinalizeQueryPage(DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString());
                    Hide();
                    newFrmPage.ShowDialog();
                    Show();
                }
                else if (string.Equals(frmArgStr, "UPDATE ACCEPTED OFFER"))
                {
                    FrmFinalizeQueryPage newFrmPage = new FrmFinalizeQueryPage(DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString());
                    Hide();
                    newFrmPage.ShowDialog();
                    Show();
                }
                else if (string.Equals(frmArgStr, "VIEW ALL"))
                {
                    Debug.WriteLine("VIEW ALL QUERY SELECTED Thus nothing to do\n");
                }
                else if (string.Equals(frmArgStr, "ITINERARY"))
                {
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

                    /* get all information from database regarding this queryid*/
                    string mysqlQueryString = "SELECT * FROM `queries` WHERE `queryid` = " + DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString();
                    try
                    {
                        frmMysqlConnection.Open();
                    }
                    catch (Exception errConnOpen)
                    {
                        MessageBox.Show("Error in opening mysql connection because : " + errConnOpen.Message);
                        return;
                    }

                    DataSet queryDataset = new DataSet();
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mysqlQueryString, frmMysqlConnection);
                    mySqlDataAdapter.Fill(queryDataset, "SELECTED_QUERY");
                    mysqlQueryString = "SELECT * FROM `queryworkingday` WHERE `queryid` = " + DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString();
                    mySqlDataAdapter.SelectCommand.CommandText = mysqlQueryString;
                    mySqlDataAdapter.Fill(queryDataset, "QUERY_DAY_INFO");
                    mysqlQueryString = "SELECT * FROM `queryworkinghotel` WHERE `queryid` = " + DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString();
                    mySqlDataAdapter.SelectCommand.CommandText = mysqlQueryString;
                    mySqlDataAdapter.Fill(queryDataset, "QUERY_HOTEL_INFO");
                    mysqlQueryString = "SELECT * FROM `queryworkingflight` WHERE `queryid` = " + DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString();
                    mySqlDataAdapter.SelectCommand.CommandText = mysqlQueryString;
                    mySqlDataAdapter.Fill(queryDataset, "QUERY_FLIGHT_INFO");
                    mysqlQueryString = "SELECT * FROM `queryworkingtravel` WHERE `queryid` = " + DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString();
                    mySqlDataAdapter.SelectCommand.CommandText = mysqlQueryString;
                    mySqlDataAdapter.Fill(queryDataset, "QUERY_TRAVEL_INFO");
                    mysqlQueryString = "select `T1`.idhotelinfo, `T2`.hotelrating, `T1`.hotelcity , `T1`.hotelname, `T2`.roomtype " +
                        "from `hotelinfo` as `T1` inner join `queryworkinghotel` as `T2` on `T1`.`idhotelinfo` = `T2`.`idhotelinfo` " +
                        "WHERE `T2`.`queryid` = '" + DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString() +"' " +
                        "order by `T1`.hotelcity";
                    mySqlDataAdapter.SelectCommand.CommandText = mysqlQueryString;
                    mySqlDataAdapter.Fill(queryDataset, "HOTEL_USED_INFO");

                    /* GENERATE PDF ITINERARY OF THE SELECTED QUERY */
                    double gstRate = Convert.ToDouble(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["gstrate"]);
                    gstRate = gstRate / 100;
                    double profitMargin = Convert.ToDouble(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["profitmargin"]);
                    profitMargin = profitMargin / 100;
                    double multiplyFactor = (1.0 + gstRate) * (1.0 + profitMargin);
                    Debug.WriteLine("GST RATE = " + gstRate.ToString() + " and PROFIT MARGIN = " + profitMargin.ToString() + "AND MULTIPLY FACTOR = " + multiplyFactor.ToString());
                    Document document = new Document();
                    document.Info.Title = "ITINERARY FOR " + DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString();
                    document.Info.Author = "PANJADOTCOM";

                    /* now cange the style of the document */
                    MyPdfDocuments.DefineStyles(document);

                    /* add section to document */
                    Section section = document.AddSection();

                    /* now add image at the top of the page */
                    Table table = null;
                    Column column = null;
                    double columnWidth;
                    int columnCount = 2;
                    Row row = null;
                    int rowsCount = 0;
                    int personCount = 0;
                    string imagePath = saveFileDialogItinerary.FileName + "logo.png";
                    Properties.Resources.ExcursionHolidaysLogo.Save(imagePath);
                    table = section.AddTable();
                    table.Borders.Visible = false;
                    table.Borders.Width = 0.75;
                    column = table.AddColumn(Unit.FromCentimeter(3));
                    column.Format.Alignment = ParagraphAlignment.Left;
                    column = table.AddColumn(Unit.FromCentimeter(16));
                    column.Format.Alignment = ParagraphAlignment.Right;
                    row = table.AddRow();
                    rowsCount++;
                    row.VerticalAlignment = VerticalAlignment.Center;
                    MigraDoc.DocumentObjectModel.Shapes.Image image = row.Cells[0].AddImage(imagePath);
                    image.Width = "3cm";
                    MyPdfDocuments.WriteAgencyAddressDetails(row.Cells[1], 20, 10);
                    table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.Transparent);
                    rowsCount = columnCount = 0;

                    /* now add summary of the tour in tabular form */
                    string fileContent;
                    
                    fileContent = "SUMMARY";
                    Paragraph paragraph = section.AddParagraph(fileContent, "Heading2");

                    table = section.AddTable();
                    table.Borders.Visible = true;
                    table.Borders.Width = 0.5;
                    table.Borders.Color = Colors.SkyBlue;
                    columnCount = 4;
                    columnWidth = (21.0 - 2.0) / columnCount;
                    for (int index = 0; index < columnCount; index += 2)
                    {
                        column = table.AddColumn(Unit.FromCentimeter(columnWidth - 1));
                        column.Format.Alignment = ParagraphAlignment.Left;
                        column = table.AddColumn(Unit.FromCentimeter(columnWidth + 1));
                        column.Format.Alignment = ParagraphAlignment.Left;
                    }
                    row = table.AddRow();
                    rowsCount++;
                    row.VerticalAlignment = VerticalAlignment.Center;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("Tour Reference", "Heading3");
                    paragraph = row.Cells[1].AddParagraph();
                    paragraph.AddFormattedText(DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString());
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("Customer Name", "Heading3");
                    paragraph = row.Cells[3].AddParagraph();
                    paragraph.AddFormattedText(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["name"].ToString());
                    row = table.AddRow();
                    rowsCount++;
                    row.VerticalAlignment = VerticalAlignment.Center;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("Tour Name", "Heading3");
                    paragraph = row.Cells[1].AddParagraph();
                    paragraph.AddFormattedText(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["place"].ToString());
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("No of Days", "Heading3");
                    double noOfnights = (DateTime.Parse(DataGrdVuAdminQueries.SelectedRows[0].Cells["toDate"].Value.ToString()) -
                        DateTime.Parse(DataGrdVuAdminQueries.SelectedRows[0].Cells["fromDate"].Value.ToString())).TotalDays;
                    paragraph = row.Cells[3].AddParagraph();
                    paragraph.AddFormattedText(noOfnights.ToString() + " Nights and " + (noOfnights + 1).ToString() + " Days");
                    row = table.AddRow();
                    rowsCount++;
                    row.VerticalAlignment = VerticalAlignment.Center;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("No of Person", "Heading3");
                    paragraph = row.Cells[1].AddParagraph();
                    paragraph.AddFormattedText(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["adults"].ToString() + " Adult, " +
                        queryDataset.Tables["SELECTED_QUERY"].Rows[0]["children"].ToString() + " Child and " +
                        queryDataset.Tables["SELECTED_QUERY"].Rows[0]["babies"].ToString() + " Infant");
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("No of Room", "Heading3");
                    paragraph = row.Cells[3].AddParagraph();
                    paragraph.AddFormattedText(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["roomcount"].ToString());
                    row = table.AddRow();
                    rowsCount++;
                    row.VerticalAlignment = VerticalAlignment.Center;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("Meals", "Heading3");
                    paragraph = row.Cells[1].AddParagraph();
                    paragraph.AddFormattedText(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["meal"].ToString());
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("Our Courtesy", "Heading3");
                    paragraph = row.Cells[3].AddParagraph();
                    paragraph.AddFormattedText("1 Water botel per day");
                    row = table.AddRow();
                    rowsCount++;
                    row.VerticalAlignment = VerticalAlignment.Center;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("Vehicle", "Heading3");
                    paragraph = row.Cells[1].AddParagraph();
                    paragraph.AddFormattedText(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["vehicalcategory"].ToString());
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("Train/Flight", "Heading3");
                    paragraph = row.Cells[3].AddParagraph();
                    if (queryDataset.Tables["QUERY_FLIGHT_INFO"].Rows.Count > 0)
                    {
                        paragraph.AddFormattedText("YES");
                    }
                    else
                    {
                        paragraph.AddFormattedText("NO");
                    }
                    row = table.AddRow();
                    rowsCount++;
                    row.VerticalAlignment = VerticalAlignment.Center;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("Arrive", "Heading3");
                    paragraph = row.Cells[1].AddParagraph();
                    paragraph.AddFormattedText(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["arrivalcity"].ToString());
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("Departure", "Heading3");
                    paragraph = row.Cells[3].AddParagraph();
                    paragraph.AddFormattedText(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["departurecity"].ToString());
                    row = table.AddRow();
                    rowsCount++;
                    row.VerticalAlignment = VerticalAlignment.Center;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("Tour Start", "Heading3");
                    paragraph = row.Cells[1].AddParagraph();
                    paragraph.AddFormattedText(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["fromdate"].ToString());
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("Tour End", "Heading3");
                    paragraph = row.Cells[3].AddParagraph();
                    paragraph.AddFormattedText(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["todate"].ToString());
                    row = table.AddRow();
                    rowsCount++;
                    row.VerticalAlignment = VerticalAlignment.Center;
                    paragraph = row.Cells[0].AddParagraph();
                    paragraph.AddFormattedText("Guide", "Heading3");
                    paragraph = row.Cells[1].AddParagraph();
                    paragraph.AddFormattedText("As per itinerary");
                    paragraph = row.Cells[2].AddParagraph();
                    paragraph.AddFormattedText("Validity", "Heading3");
                    paragraph = row.Cells[3].AddParagraph();
                    paragraph.AddFormattedText("One month before tour start date");
                    table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 0.5, Colors.SkyBlue);
                    rowsCount = columnCount = 0;

                    /* Add itinerary in the section below */
                    fileContent = "ITINERARY";
                    paragraph = section.AddParagraph(fileContent, "Heading2");
                    double amount = 0;
                    /* add day wise narration */
                    string tourIncContent = "";
                    foreach (DataRow item in queryDataset.Tables["QUERY_DAY_INFO"].Rows)
                    {
                        string hdr = "Day " + item["dayno"].ToString() + ": " + item["narrationhdr"].ToString() + "";
                        string content = item["narration"].ToString() + "";
                        tourIncContent = tourIncContent + item["tourinclusions"].ToString() + "\n";
                        MyPdfDocuments.WriteHdrContentParagraph(section, hdr, content);
                        amount = amount + Convert.ToDouble(item["additionalcost"]);
                    }

                    foreach (DataRow item in queryDataset.Tables["QUERY_TRAVEL_INFO"].Rows)
                    {
                        amount = amount + (Convert.ToDouble(item["pricepercar"]) * Convert.ToDouble(item["carcount"]));
                    }

                    personCount = Convert.ToInt32(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["adults"].ToString())
                        + Convert.ToInt32(queryDataset.Tables["SELECTED_QUERY"].Rows[0]["children"].ToString());

                    /* add gst rate and profitmargin in amount first. */

                    Int32 extraAmountPerPerson = Convert.ToInt32(amount / personCount);

                    if (personCount == 1)
                    {
                        columnCount = 2;
                    }
                    else if (personCount == 2)
                    {
                        columnCount = 3;
                    }
                    else if (personCount > 2)
                    {
                        columnCount = 5;
                    }
                    else
                    {
                        columnCount = 0;
                    }
                    rowsCount = 0;
                    if (columnCount > 0)
                    {
                        columnWidth = (21.0 - 2.0) / columnCount;
                        table = section.AddTable();
                        table.Borders.Visible = true;
                        table.Borders.Width = 0.75;
                        for (int index = 0; index < columnCount; index++)
                        {
                            column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                            column.Format.Alignment = ParagraphAlignment.Center;
                        }
                        row = table.AddRow();
                        rowsCount++;
                        row.Shading.Color = Colors.PaleVioletRed;
                        row.Cells[0].AddParagraph("CATEGORY/PER PERSON RATES");
                        row.Cells[1].AddParagraph("SINGLE/NO SHARING");
                        if (columnCount > 2)
                        {
                            row.Cells[2].AddParagraph("DOUBLE SHARING");
                        }
                        if (columnCount > 3)
                        {
                            row.Cells[3].AddParagraph("EXTRA ADULT/CHILD WITH BED");
                            row.Cells[4].AddParagraph("CHILD WITH NO BED (5 - 12 YRS)");
                        }

                        var hotelRateMatrix = new Int32[4, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
                        foreach (DataRow item in queryDataset.Tables["QUERY_HOTEL_INFO"].Rows)
                        {
                            if (string.Equals(item["hotelrating"].ToString(), "BASIC"))
                            {
                                hotelRateMatrix[0, 0]++;
                                hotelRateMatrix[0, 1] += Convert.ToInt32(item["singlebedprice"]);
                                hotelRateMatrix[0, 2] += (Convert.ToInt32(item["doublebedprice"]) / 2);
                                hotelRateMatrix[0, 3] += Convert.ToInt32(item["extrabedprice"]);
                            }
                            else if (string.Equals(item["hotelrating"].ToString(), "3 STAR"))
                            {
                                hotelRateMatrix[1, 0]++;
                                hotelRateMatrix[1, 1] += Convert.ToInt32(item["singlebedprice"]);
                                hotelRateMatrix[1, 2] += (Convert.ToInt32(item["doublebedprice"]) / 2);
                                hotelRateMatrix[1, 3] += Convert.ToInt32(item["extrabedprice"]);
                            }
                            else if (string.Equals(item["hotelrating"].ToString(), "4 STAR"))
                            {
                                hotelRateMatrix[2, 0]++;
                                hotelRateMatrix[2, 1] += Convert.ToInt32(item["singlebedprice"]);
                                hotelRateMatrix[2, 2] += (Convert.ToInt32(item["doublebedprice"]) / 2);
                                hotelRateMatrix[2, 3] += Convert.ToInt32(item["extrabedprice"]);
                            }
                            else if (string.Equals(item["hotelrating"].ToString(), "5 STAR"))
                            {
                                hotelRateMatrix[3, 0]++;
                                hotelRateMatrix[3, 1] += Convert.ToInt32(item["singlebedprice"]);
                                hotelRateMatrix[3, 2] += (Convert.ToInt32(item["doublebedprice"]) / 2);
                                hotelRateMatrix[3, 3] += Convert.ToInt32(item["extrabedprice"]);
                            }
                        }

                        for (int index = 0; index < 4; index++)
                        {
                            if (hotelRateMatrix[index, 0] > 0)
                            {
                                string hotelRating = "";
                                switch (index)
                                {
                                    case 0:
                                        hotelRating = "BASIC";
                                        break;
                                    case 1:
                                        hotelRating = "3 STAR";
                                        break;
                                    case 2:
                                        hotelRating = "4 STAR";
                                        break;
                                    case 3:
                                        hotelRating = "5 STAR";
                                        break;
                                    default:
                                        hotelRating = "UNKNOWN";
                                        break;
                                }
                                row = table.AddRow();
                                rowsCount++;
                                if ((rowsCount % 2) == 0)
                                {
                                    row.Shading.Color = Colors.PaleTurquoise;
                                }
                                else
                                {
                                    row.Shading.Color = Colors.PapayaWhip;
                                }
                                row.Cells[0].AddParagraph(hotelRating);
                                hotelRateMatrix[index, 1] += Convert.ToInt32(extraAmountPerPerson);
                                amount = Convert.ToDouble(hotelRateMatrix[index, 1]) * multiplyFactor;
                                row.Cells[1].AddParagraph(Convert.ToInt32(amount).ToString());
                                if (columnCount > 2)
                                {
                                    hotelRateMatrix[index, 2] += Convert.ToInt32(extraAmountPerPerson);
                                    amount = Convert.ToDouble(hotelRateMatrix[index, 2]) * multiplyFactor;
                                    row.Cells[2].AddParagraph(Convert.ToInt32(amount).ToString());
                                }
                                if (columnCount > 3)
                                {
                                    hotelRateMatrix[index, 3] += Convert.ToInt32(extraAmountPerPerson);
                                    amount = Convert.ToDouble(hotelRateMatrix[index, 3]) * multiplyFactor;
                                    row.Cells[3].AddParagraph(Convert.ToInt32(amount).ToString());
                                    amount = Convert.ToDouble(extraAmountPerPerson) * multiplyFactor;
                                    row.Cells[4].AddParagraph(Convert.ToInt32(amount).ToString());
                                }
                            }
                        }
                        table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.Black);
                    }
                    /* add hotel rates in tabular form */
                    int hotelRowsCount = rowsCount;
                    /* add flight information in the itenary */
                    rowsCount = 0;
                    amount = 0;
                    foreach (DataRow item in queryDataset.Tables["QUERY_FLIGHT_INFO"].Rows)
                    {
                        if (rowsCount == 0)
                        {
                            paragraph = section.AddParagraph("AIR FARE PER PERSON EXTRA", "Heading3");
                            columnCount = 5;
                            columnWidth = (21.0 - 2.0) / columnCount;

                            table = section.AddTable();
                            table.Borders.Visible = true;
                            table.Borders.Width = 0.75;
                            for (int index = 0; index < columnCount; index++)
                            {
                                column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                                column.Format.Alignment = ParagraphAlignment.Center;
                            }
                            row = table.AddRow();
                            rowsCount++;
                            row.Shading.Color = Colors.PaleGoldenrod;
                            row.Cells[0].AddParagraph("DATE");
                            row.Cells[1].AddParagraph("FROM");
                            row.Cells[2].AddParagraph("TO");
                            row.Cells[3].AddParagraph("FLIGHT NO");
                            row.Cells[4].AddParagraph("AMOUNT PER PERSON");
                        }
                        row = table.AddRow();
                        rowsCount++;
                        if ((rowsCount % 2) == 0)
                        {
                            row.Shading.Color = Colors.PaleTurquoise;
                        }
                        else
                        {
                            row.Shading.Color = Colors.PapayaWhip;
                        }
                        row.Cells[0].AddParagraph(item["date"].ToString());
                        row.Cells[0].VerticalAlignment = VerticalAlignment.Center;
                        row.Cells[1].AddParagraph(item["fromcity"].ToString().ToUpper());
                        row.Cells[1].VerticalAlignment = VerticalAlignment.Center;
                        row.Cells[2].AddParagraph(item["tocity"].ToString().ToUpper());
                        row.Cells[2].VerticalAlignment = VerticalAlignment.Center;
                        row.Cells[3].AddParagraph(item["flightnumber"].ToString().ToUpper());
                        row.Cells[3].VerticalAlignment = VerticalAlignment.Center;
                        amount = amount + Convert.ToDouble(item["rateperticket"].ToString());

                    }
                    if (rowsCount > 0)
                    {
                        table.Rows[1].Cells[4].MergeDown = rowsCount - 2;
                        amount = amount * multiplyFactor;
                        table.Rows[1].Cells[4].AddParagraph(Convert.ToInt32(amount).ToString());
                        table.Rows[1].Cells[4].Shading.Color = Colors.WhiteSmoke;
                        table.Rows[1].Cells[4].VerticalAlignment = VerticalAlignment.Center;
                        table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.Black);
                    }

                    /* add notes in the document */
                    MyPdfDocuments.WriteItineraryLastStaticDetails(section, tourIncContent);

                    /* now change cloumn count to rows count;*/
                    var hotelusedMatrix = new int[4, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

                    foreach (DataRow item in queryDataset.Tables["HOTEL_USED_INFO"].Rows)
                    {
                        if (string.Equals(item["hotelrating"].ToString(), "BASIC"))
                        {
                            hotelusedMatrix[0, 0]++;
                        }
                        else if (string.Equals(item["hotelrating"].ToString(), "3 STAR"))
                        {
                            hotelusedMatrix[1, 0]++;
                        }
                        else if (string.Equals(item["hotelrating"].ToString(), "4 STAR"))
                        {
                            hotelusedMatrix[2, 0]++;
                        }
                        else if (string.Equals(item["hotelrating"].ToString(), "5 STAR"))
                        {
                            hotelusedMatrix[3, 0]++;
                        }
                    }
                    if (hotelRowsCount > 0)
                    {
                        columnCount = hotelRowsCount;
                        rowsCount = 0;
                        int columnIndex = 0;
                        string lastCity = "";
                        foreach (DataRow item in queryDataset.Tables["HOTEL_USED_INFO"].Rows)
                        {
                            if (rowsCount == 0)
                            {
                                paragraph = section.AddParagraph("HOTEL INFORMATION", "Heading3");
                                columnWidth = (21.0 - 2.0) / columnCount;

                                table = section.AddTable();
                                table.Borders.Visible = true;
                                table.Borders.Width = 0.75;
                                for (int index = 0; index < columnCount; index++)
                                {
                                    column = table.AddColumn(Unit.FromCentimeter(columnWidth));
                                    column.Format.Alignment = ParagraphAlignment.Center;
                                }
                                row = table.AddRow();
                                rowsCount++;
                                columnIndex = 1;
                                row.Shading.Color = Colors.PaleGoldenrod;
                                row.Cells[0].AddParagraph("HOTEL USED");
                                if (hotelusedMatrix[0, 0] > 0)
                                {
                                    row.Cells[columnIndex].AddParagraph("BASIC");
                                    hotelusedMatrix[0, 1] = columnIndex;
                                    columnIndex++;
                                }
                                if (hotelusedMatrix[1, 0] > 0)
                                {
                                    row.Cells[columnIndex].AddParagraph("3 STAR");
                                    hotelusedMatrix[1, 1] = columnIndex;
                                    columnIndex++;
                                }
                                if (hotelusedMatrix[2, 0] > 0)
                                {
                                    row.Cells[columnIndex].AddParagraph("4 STAR");
                                    hotelusedMatrix[2, 1] = columnIndex;
                                    columnIndex++;
                                }
                                if (hotelusedMatrix[3, 0] > 0)
                                {
                                    row.Cells[columnIndex].AddParagraph("5 STAR");
                                    hotelusedMatrix[3, 1] = columnIndex;
                                }
                            }
                            if (!lastCity.Equals(item["hotelcity"].ToString()))
                            {
                                row = table.AddRow();
                                rowsCount++;
                                row.VerticalAlignment = VerticalAlignment.Center;
                                row.Cells[0].AddParagraph("IN " + item["hotelcity"].ToString());
                                lastCity = item["hotelcity"].ToString();
                            }
                            columnIndex = 0;
                            if (string.Equals(item["hotelrating"].ToString(), "BASIC"))
                            {
                                columnIndex = hotelusedMatrix[0, 1];
                            }
                            else if (string.Equals(item["hotelrating"].ToString(), "3 STAR"))
                            {
                                columnIndex = hotelusedMatrix[1, 1];
                            }
                            else if (string.Equals(item["hotelrating"].ToString(), "4 STAR"))
                            {
                                columnIndex = hotelusedMatrix[2, 1];
                            }
                            else if (string.Equals(item["hotelrating"].ToString(), "5 STAR"))
                            {
                                columnIndex = hotelusedMatrix[3, 1];
                            }
                            row.Cells[columnIndex].AddParagraph(item["hotelname"].ToString() + "(" + item["roomtype"].ToString() + ")");
                        }
                        if (rowsCount > 0)
                        {
                            table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.Black);
                        }
                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////
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

                    /*/////////////////////////////PDF OF ITENARY CREATED AND SAVED//////////////////////////////////////////////////*/
                    MySqlCommand mySqlCommand = frmMysqlConnection.CreateCommand();
                    MySqlTransaction mySqlTransaction = frmMysqlConnection.BeginTransaction();
                    mySqlCommand.Connection = frmMysqlConnection;
                    mySqlCommand.Transaction = mySqlTransaction;
                    mySqlCommand.CommandType = CommandType.Text;
                    mySqlCommand.CommandText = "UPDATE `queries` SET " +
                    "`querylastupdatetime` = NOW(), " +
                    "`querycurrentstate` = " + Properties.Resources.queryStageMailed + " " +
                    "WHERE " +
                    "queryid = " + DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString();
                    mySqlCommand.Prepare();

                    try
                    {
                        mySqlCommand.ExecuteNonQuery();
                        mySqlTransaction.Commit();
                    }
                    catch (Exception errquery)
                    {
                        MessageBox.Show("Error while executing insert query because:\n" + errquery.Message);
                    }

                    try
                    {
                        frmMysqlConnection.Close();
                    }
                    catch (Exception errConnClose)
                    {
                        MessageBox.Show("Error in Closing mysql connection because : " + errConnClose.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Wrong argument passed", "Wrong argument", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please load Queries First", "Load Queries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
