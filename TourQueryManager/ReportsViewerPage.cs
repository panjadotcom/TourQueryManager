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
using DocumentFormat.OpenXml;
using SpreadsheetLight;

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
                DataTable dataTable = new DataTable();
                dataTable = dataGridViewReports.DataSource as DataTable;
                SLDocument document = new SLDocument();

                int iStartRowIndex = 1;
                int iStartColumnIndex = 1;

                document.ImportDataTable(iStartRowIndex, iStartColumnIndex, dataTable, true);

                // The next part is optional, but it shows how you can set a table on your
                // data based on your DataTable's dimensions.

                // + 1 because the header row is included
                // - 1 because it's a counting thing, because the start row is counted.
                int iEndRowIndex = iStartRowIndex + dataTable.Rows.Count + 1 - 1;
                // - 1 because it's a counting thing, because the start column is counted.
                int iEndColumnIndex = iStartColumnIndex + dataTable.Columns.Count - 1;

                SLTable table = document.CreateTable(iStartRowIndex, iStartColumnIndex, iEndRowIndex, iEndColumnIndex);
                table.SetTableStyle(SLTableStyleTypeValues.Medium17);
                table.HasTotalRow = true;
                document.InsertTable(table);
                document.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("File " + saveFileDialog.FileName + " Saved", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
