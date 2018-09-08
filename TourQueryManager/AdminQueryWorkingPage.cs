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

namespace TourQueryManager
{
    public partial class FrmAdminQueryWorkingPage : Form
    {
        bool openVoucherPage = false;
        static string frmArgStr;
        static string mysqlConnectionString = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection frmMysqlConnection = new MySqlConnection(mysqlConnectionString);

        /* following are some contant strings to be used for printing in itenary as it is */
        static string itenaryAvailablityNote = "Note:" +
            "\n     Subject to weather conditions and availability of Ferry Tickets and other Conditions, the itinerary may be shuffled." +
            " Please contact for Final Itinerary at the time of Check In." +
            "\n     Confirmation will be subject to availability at the time of Booking (No Rooms Blocked)" +
            "\n     Rates subject to change if the Hotel or the Room category quoted is not available at the time of Booking";
        static string itenaryNotIncludedNote = "The Tour Cost does not include:" +
            "\n     Cost for supplementary service, optional Tours, Up-gradation Charges, Guide, Additional Sightseeing entrance fees." +
            "\n     Cost for Airfare, Train fare, Insurance Premiums, Rafting Charges." +
            "\n     Cost for service provided on a personal request." +
            "\n     Cost for personal expenses such as laundry, bottled water, soft drinks, incidentals, porter charges, tips etc." +
            "\n     Activity charges, Scuba, Jet Ski, Snorkeling etc., until and unless mentioned in the inclusions" +
            "\n     Cost for any other service not mentioned under the “Cost Includes” head." +
            "\n     Difference in cost arising due to change in Taxes by the Government which will have to be collected directly ON ARRIVAL." +
            "\n     Difference in cost arising due to extra usage of vehicle, other than scheduled & mentioned in the itinerary." +
            "\n     Difference in cost arising due to mishaps, political unrest, natural calamities like - landslides, road blockage, etc." +
            "\n      In such case extra will have to be paid on the spot by the guest directly." +
            "\n     Camera Fee ( Still or Movie)";
        static string itenaryImportantFacts = "Important Facts for Traveler’s:" +
            "\n     Please carry original ID proof (Voter ID card/Pass-port/Driving License/etc.) for security purpose & hotel policy." +
            "\n     We need following for process your booking Guest Name & Contact Number. Naming List with gender& Age." +
            "\n     High season surcharge will be applicable for every booking on 16th Oct – 25th Oct during Durga Puja & Diwali, 20th Dec – 5th Jan during X-Mass & New Year & during Holi (as per date)." +
            "\n     In high season, no refund will be applicable within 30 days of the tours start date. (Normal cancellation policy will not applicable on those dates.)" +
            "\n     For high season booking, 50% payment must be done in the time of confirmation & rest of the amount must be cleared 30 days before of the tour start date.";
        static string itenaryPaymentPolicy = "Payment Policy:" +
            "\n    1) Any confirmation is subject to an advance deposit of 50% of the package cost and has to be paid immediately, after that we can process the booking." +
            "\n    2) Balance Payment has to be made in advance and must be paid & as per time limit given at the time of confirmation." +
            "\n    3) Payments can be remitted through any of the following Banks and is subject to realization.";

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
                    //MessageBox.Show("Generating ITINERARY FOR : \n" +
                    //DataGrdVuAdminQueries.SelectedRows[0].Cells["AssignedDate"].Value.ToString() + "\n" +
                    //DataGrdVuAdminQueries.SelectedRows[0].Cells["QueryId"].Value.ToString() + "\n" +
                    //DataGrdVuAdminQueries.SelectedRows[0].Cells["Location"].Value.ToString() + "\n" +
                    //DataGrdVuAdminQueries.SelectedRows[0].Cells["fromDate"].Value.ToString() + "\n" +
                    //DataGrdVuAdminQueries.SelectedRows[0].Cells["toDate"].Value.ToString() + "\n");
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
                    mySqlDataAdapter.Fill(queryDataset, "QUERY_HOTEL_INFO");

                    /* GENERATE PDF ITINERARY OF THE SELECTED QUERY */
                    Int32 yCordinateUtilized = 0;
                    PdfDocument pdfDocument = new PdfDocument();
                    PdfPage pdfPage = pdfDocument.AddPage();
                    XGraphics xGraphics = XGraphics.FromPdfPage(pdfPage);
                    XFont xFontBody = new XFont("Times New Roman", 11, XFontStyle.Regular);
                    XFont xFontHeader = new XFont("Times New Roman", 15, XFontStyle.Bold);
                    XFont xFontBodyBold = new XFont("Times New Roman", 11, XFontStyle.Bold);
                    XTextFormatter xTextFormatter = new XTextFormatter(xGraphics);
                    XImage image = Properties.Resources.imageExcursionHolidaysLetterHead;
                    xGraphics.DrawImage(image, 0, 0, 605, 95);
                    yCordinateUtilized += 100;
                    string fileContent;
                    double noOfnights = (DateTime.Parse(DataGrdVuAdminQueries.SelectedRows[0].Cells["toDate"].Value.ToString()) -
                        DateTime.Parse(DataGrdVuAdminQueries.SelectedRows[0].Cells["fromDate"].Value.ToString())).TotalDays;
                    fileContent = DataGrdVuAdminQueries.SelectedRows[0].Cells["Location"].Value.ToString() + " Tour\r\n" +
                        noOfnights.ToString() + " Nights and " + (noOfnights+1).ToString() + " Days";
                    XRect xRect = new XRect(40, yCordinateUtilized, 560, 40);
                    yCordinateUtilized += 40;
                    xGraphics.DrawRectangle(XBrushes.White, xRect);
                    xTextFormatter.Alignment = XParagraphAlignment.Center;
                    xTextFormatter.DrawString(fileContent, xFontHeader, XBrushes.Black, xRect, XStringFormat.TopLeft);

                    foreach (DataRow item in queryDataset.Tables["QUERY_HOTEL_INFO"].Rows)
                    {
                        fileContent = "Day " + item["dayno"].ToString() + ": " + item["narrationhdr"].ToString() + "";
                        xRect = new XRect(40, yCordinateUtilized, 560, 10);
                        yCordinateUtilized += 10;
                        xGraphics.DrawRectangle(XBrushes.White, xRect);
                        xTextFormatter.Alignment = XParagraphAlignment.Left;
                        xTextFormatter.DrawString(fileContent, xFontBodyBold, XBrushes.Black, xRect, XStringFormat.TopLeft);
                        fileContent = item["narration"].ToString() + "";
                        xRect = new XRect(40, yCordinateUtilized, 560, 50);
                        yCordinateUtilized += 50;
                        xGraphics.DrawRectangle(XBrushes.White, xRect);
                        xTextFormatter.Alignment = XParagraphAlignment.Left;
                        xTextFormatter.DrawString(fileContent, xFontBody, XBrushes.Black, xRect, XStringFormat.TopLeft);
                    }

                    fileContent = itenaryAvailablityNote + "";
                    xRect = new XRect(40, yCordinateUtilized, 560, 50);
                    yCordinateUtilized += 50;
                    xGraphics.DrawRectangle(XBrushes.White, xRect);
                    xTextFormatter.Alignment = XParagraphAlignment.Left;
                    xTextFormatter.DrawString(fileContent, xFontBody, XBrushes.Black, xRect, XStringFormat.TopLeft);

                    fileContent = itenaryNotIncludedNote + "";
                    xRect = new XRect(40, yCordinateUtilized, 560, 50);
                    yCordinateUtilized += 50;
                    xGraphics.DrawRectangle(XBrushes.White, xRect);
                    xTextFormatter.Alignment = XParagraphAlignment.Left;
                    xTextFormatter.DrawString(fileContent, xFontBody, XBrushes.Black, xRect, XStringFormat.TopLeft);

                    fileContent = itenaryImportantFacts + "";
                    xRect = new XRect(40, yCordinateUtilized, 560, 50);
                    yCordinateUtilized += 50;
                    xGraphics.DrawRectangle(XBrushes.White, xRect);
                    xTextFormatter.Alignment = XParagraphAlignment.Left;
                    xTextFormatter.DrawString(fileContent, xFontBody, XBrushes.Black, xRect, XStringFormat.TopLeft);

                    fileContent = itenaryPaymentPolicy + "";
                    xRect = new XRect(40, yCordinateUtilized, 560, 50);
                    yCordinateUtilized += 50;
                    xGraphics.DrawRectangle(XBrushes.White, xRect);
                    xTextFormatter.Alignment = XParagraphAlignment.Left;
                    xTextFormatter.DrawString(fileContent, xFontBody, XBrushes.Black, xRect, XStringFormat.TopLeft);

                    try
                    {
                        /* try to save file */
                        pdfDocument.Save(saveFileDialogItinerary.FileName);
                    }
                    catch (Exception errSave)
                    {
                        MessageBox.Show("Error in saving file " + saveFileDialogItinerary.FileName + " because " + errSave.Message);
                        Debug.WriteLine("Error in saving file " + saveFileDialogItinerary.FileName + " because " + errSave.Message);
                    }
                    finally
                    {
                        pdfDocument.Close();
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
