using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace TourQueryManager
{
    public partial class FrmReportsViewerPage : Form
    {
        static string queryString;
        static string connectionString = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
        public FrmReportsViewerPage(string argv)
        {
            InitializeComponent();
            queryString = argv;
        }

        private void FrmReportsViewerPage_Load(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception errConnOpen)
            {
                MessageBox.Show("Error in opening mysql connection because : " + errConnOpen.Message);
                //Close();
                return;
            }
            MySqlDataAdapter mysqlDataAdaptor = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            DataSet dataSet = new DataSet();
            command.Connection = mySqlConnection;
            command.CommandText = queryString;
            try
            {
                mysqlDataAdaptor.SelectCommand = command;

                mysqlDataAdaptor.Fill(dataSet, "REPORTS_DATA");
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
                //Close();
                return;
            }
            try
            {
                dataGridViewReports.DataSource = dataSet.Tables["REPORTS_DATA"];
            }
            catch (Exception errDataSet)
            {
                MessageBox.Show("Error in assigning data to datase because " + errDataSet.Message + "");
                //Close();
                return;
            }
            try
            {
                mySqlConnection.Close();
            }
            catch (Exception errConnClose)
            {
                MessageBox.Show("Error in opening mysql connection because " + errConnClose.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Close();
                return;
            }
            dataGridViewReports.ClearSelection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExportToExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application application;
                Excel.Workbook workbook;
                Excel.Worksheet worksheet;
                object misvalue = System.Reflection.Missing.Value;
                application = new Excel.Application();
                workbook = application.Workbooks.Add(misvalue);
                worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "EXPORTED FROM GRID";
                /* write header text to file */
                for (int index = 0; index < dataGridViewReports.ColumnCount; index++)
                {
                    worksheet.Cells[1, index + 1] = dataGridViewReports.Columns[index].HeaderText;
                }

                /* write bodu text to file */
                for (int rowIndex = 0; rowIndex < dataGridViewReports.RowCount; rowIndex++)
                {
                    for (int columnIndex = 0; columnIndex < dataGridViewReports.ColumnCount; columnIndex++)
                    {
                        worksheet.Cells[rowIndex + 2, columnIndex + 1] = dataGridViewReports.Rows[rowIndex].Cells[columnIndex].Value.ToString();
                    }
                }

                try
                {
                    workbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue, misvalue);
                }
                catch (Exception errFileSave)
                {
                    MessageBox.Show("Error in Saving" + errFileSave.Message, "File Cannot be Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                workbook.Close(true, misvalue, misvalue);
                application.Quit();
                MyPdfDocuments.releaseObject(worksheet);
                MyPdfDocuments.releaseObject(workbook);
                MyPdfDocuments.releaseObject(application);
                MessageBox.Show("File " + saveFileDialog.FileName + " Saved", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
