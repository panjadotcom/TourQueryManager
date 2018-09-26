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
        bool openVoucherPage = false;
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
            if (string.Equals(argumentString, "ITINERARY", StringComparison.OrdinalIgnoreCase))
            {
                mysqlSelectQuery = "SELECT `queryid`, `place`, `fromdate`, `todate`, `querystartdate` " +
                "FROM `queries` WHERE " +
                "`querycurrentstate` >= " + Properties.Resources.queryStageDoneByUser +
                " AND `querycurrentstate` <= " + Properties.Resources.queryStageMailed;
                openVoucherPage = false;
            }
            else if (string.Equals(argumentString, "VOUCHERS", StringComparison.OrdinalIgnoreCase))
            {
                mysqlSelectQuery = "SELECT `queryid`, `place`, `fromdate`, `todate`, `querystartdate` " +
                "FROM `queries` WHERE " +
                "`querycurrentstate` > " + Properties.Resources.queryStageDoneByUser;
                openVoucherPage = true;
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
                        DataGrdVuAdminQueries.Rows[index].Cells["ToDate"].Value = item["todate"].ToString();
                        DataGrdVuAdminQueries.Rows[index].Cells["Location"].Value = item["place"].ToString();
                        DataGrdVuAdminQueries.Rows[index].Cells["AssignedDate"].Value = item["querystartdate"].ToString();
                    }
                }
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
                if (openVoucherPage)
                {
                    MessageBox.Show("Generating VOUCHERS FOR : \n" +
                    DataGrdVuAdminQueries.SelectedRows[0].Cells["AssignedDate"].Value.ToString() + "\n" +
                    DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString() + "\n" +
                    DataGrdVuAdminQueries.SelectedRows[0].Cells["Location"].Value.ToString() + "\n" +
                    DataGrdVuAdminQueries.SelectedRows[0].Cells["fromDate"].Value.ToString() + "\n" +
                    DataGrdVuAdminQueries.SelectedRows[0].Cells["toDate"].Value.ToString() + "\n");
                    FrmQueryWorkingPage frmQueryWorkingPage = new FrmQueryWorkingPage(DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString());
                    Hide();
                    frmQueryWorkingPage.ShowDialog();
                    Show();
                }
                else
                {
                    if(saveFileDialogItinerary.ShowDialog() == DialogResult.OK)
                    {
                        /* file selected */
                        Debug.WriteLine("OUT FILE SELECTED : " + saveFileDialogItinerary.FileName );
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
                    string imagePath = saveFileDialogItinerary.FileName + "logo.png";
                    Properties.Resources.imageExcursionHolidaysLetterHead.Save(imagePath);
                    MigraDoc.DocumentObjectModel.Shapes.Image image = section.AddImage(imagePath);
                    image.Width = "21cm";
                    image.Left = "-2.4cm";

                    /* now add Header of the file */
                    string fileContent;
                    double noOfnights = (DateTime.Parse(DataGrdVuAdminQueries.SelectedRows[0].Cells["toDate"].Value.ToString()) -
                        DateTime.Parse(DataGrdVuAdminQueries.SelectedRows[0].Cells["fromDate"].Value.ToString())).TotalDays;
                    fileContent = DataGrdVuAdminQueries.SelectedRows[0].Cells["Location"].Value.ToString() + " Tour\r\n" +
                        noOfnights.ToString() + " Nights and " + (noOfnights + 1).ToString() + " Days";
                    Paragraph paragraph = section.AddParagraph(fileContent, "Heading1");

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

                    /* add hotel rates in tabular form */
                    //paragraph = section.AddParagraph("Hotel Information","Heading2");
                    Table table = null;
                    Column column = null;
                    double columnWidth;
                    int columnCount;
                    Row row = null;
                    int rowsCount = 0;
                    int personCount = 0;
                    string hotelIdList = "";

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
                        columnWidth = (21.0 - 5.0) / columnCount;
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
                            hotelIdList = hotelIdList + item["idhotelinfo"].ToString() + ";";
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
                    
                    /* add flight information in the itenary */
                    rowsCount = 0;
                    amount = 0;
                    foreach (DataRow item in queryDataset.Tables["QUERY_FLIGHT_INFO"].Rows)
                    {
                        if (rowsCount == 0)
                        {
                            paragraph = section.AddParagraph("AIR FARE PER PERSON EXTRA", "Heading3");
                            columnCount = 5;
                            columnWidth = (21.0 - 5.0) / columnCount;

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
                    MyPdfDocuments.WriteNoteParagraph(section);
                    string tourIncHdr = "The tour cost includes:";
                    /* edit content of tour inclusion */
                    MyPdfDocuments.WriteHdrContentListingBullets(section, tourIncHdr, tourIncContent);
                    MyPdfDocuments.WriteNotIncludedParagraph(section);
                    MyPdfDocuments.WriteImportantFactsParagraph(section);
                    MyPdfDocuments.WritePaymentPolicyParagraph(section);

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
            }
            else
            {
                MessageBox.Show("Please load Queries First", "Load Queries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
