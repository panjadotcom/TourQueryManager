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
using MigraDoc.DocumentObjectModel.Shapes;
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

        private static double GetTextHeight(XGraphics gfx, string text, XFont xFont, double rectWidth)
        {
            var fontHeight = xFont.GetHeight();
            var absoluteTextHeight = gfx.MeasureString(text, xFont).Height;
            var absoluteTextWidth = gfx.MeasureString(text, xFont).Width;

            if (absoluteTextWidth > rectWidth)
            {
                var linesToAdd = (int)Math.Ceiling(absoluteTextWidth / 290) - 1;
                return absoluteTextHeight + linesToAdd * (fontHeight);
            }
            return absoluteTextHeight;
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

                    /* add day wise narration */
                    foreach (DataRow item in queryDataset.Tables["QUERY_HOTEL_INFO"].Rows)
                    {
                        string hdr = "Day " + item["dayno"].ToString() + ": " + item["narrationhdr"].ToString() + "";
                        string content = item["narration"].ToString() + "";
                        MyPdfDocuments.WriteHdrContentParagraph(section, hdr, content);
                    }

                    /* add notes in the document */
                    MyPdfDocuments.WriteNoteParagraph(section);
                    MyPdfDocuments.WriteNotIncludedParagraph(section);
                    MyPdfDocuments.WriteImportantFactsParagraph(section);
                    MyPdfDocuments.WritePaymentPolicyParagraph(section);

                    PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always);
                    renderer.Document = document;
                    renderer.RenderDocument();
                    try
                    {
                        /* try to save file */
                        renderer.PdfDocument.Save(saveFileDialogItinerary.FileName);
                        Process.Start(saveFileDialogItinerary.FileName);
                        System.IO.File.Delete(imagePath);
                    }
                    catch (Exception errSave)
                    {
                        MessageBox.Show("Error in saving file " + saveFileDialogItinerary.FileName + " because " + errSave.Message);
                        Debug.WriteLine("Error in saving file " + saveFileDialogItinerary.FileName + " because " + errSave.Message);
                    }
                    finally
                    {
                        renderer.PdfDocument.Close();
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
