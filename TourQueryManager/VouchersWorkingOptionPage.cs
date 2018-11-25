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
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace TourQueryManager
{
    public partial class FrmVouchersWorkingOptionPage : Form
    {
        static string queryId;
        static string mysqlConnStr = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection mySqlConnection = new MySqlConnection(mysqlConnStr);
        public FrmVouchersWorkingOptionPage(string argv)
        {
            InitializeComponent();
            queryId = argv;
        }

        private void FrmVouchersWorkingOptionPage_Load(object sender, EventArgs e)
        {
            Text = "WORKING VOUCHERS FOR " + queryId;
            lblQueryInfo.Text = "UPDATE HOTEL AND FLIGHT INFORMATION FOR " + queryId;
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception erropen)
            {
                MessageBox.Show("connection cannot be opened because " + erropen.Message + "");
                Close();
                return;
            }

            MySqlDataAdapter mysqlDataAdaptor = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            DataSet dataSet = new DataSet();
            string mysqlSelectQueryStr = "SELECT * FROM `finalizedqueries` WHERE `queryid` = " + queryId + "";
            command.Connection = mySqlConnection;
            command.CommandText = mysqlSelectQueryStr;
            try
            {
                mysqlDataAdaptor.SelectCommand = command;

                mysqlDataAdaptor.Fill(dataSet, "QUERYID_DATA");
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
            }
            string querydetails = "";
            querydetails = querydetails + "INSTRUCTIONS = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["specialinstructions"].ToString();
            querydetails = querydetails + "";
            txtBoxQueryDetails.Text = querydetails;
            mysqlSelectQueryStr = "SELECT * FROM `flightbookinginfo` WHERE `queryid` = " + queryId + "";
            command.Connection = mySqlConnection;
            command.CommandText = mysqlSelectQueryStr;
            try
            {
                mysqlDataAdaptor.SelectCommand = command;
                mysqlDataAdaptor.Fill(dataSet, "FLIGHT_BOOKING_DATA");
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
            }
            mysqlSelectQueryStr = "SELECT * FROM `hotelbookinginfo` WHERE `queryid` = " + queryId + "";
            command.Connection = mySqlConnection;
            command.CommandText = mysqlSelectQueryStr;
            try
            {
                mysqlDataAdaptor.SelectCommand = command;
                mysqlDataAdaptor.Fill(dataSet, "HOTEL_BOOKING_DATA");
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
            }
            try
            {
                dataGridViewFlightInformation.DataSource = dataSet.Tables["FLIGHT_BOOKING_DATA"];
                dataGridViewFlightInformation.ClearSelection();
                dataGridViewHotelInformation.DataSource = dataSet.Tables["HOTEL_BOOKING_DATA"];
                dataGridViewHotelInformation.ClearSelection();
            }
            catch (Exception errDataSet)
            {
                MessageBox.Show("Error in assigning data to datase because " + errDataSet.Message + "");
            }
            try
            {
                mySqlConnection.Close();
            }
            catch (Exception errConnClose)
            {
                MessageBox.Show("Error in opening mysql connection because " + errConnClose.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnUpdateFlightInfo_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Updating Flight information in Database");
            FrmVouchersWorkingFlightPage frmVouchersWorkingFlightPage = new FrmVouchersWorkingFlightPage(queryId);
            Hide();
            frmVouchersWorkingFlightPage.ShowDialog();
            Show();
            FrmVouchersWorkingOptionPage_Load(null, null);
        }

        private void BtnUpdateHotelInfo_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Updating Hotel information in Database");
            FrmVouchersWorkingHotelPage frmVouchersWorkingHotelPage = new FrmVouchersWorkingHotelPage(queryId);
            Hide();
            frmVouchersWorkingHotelPage.ShowDialog();
            Show();
            FrmVouchersWorkingOptionPage_Load(null, null);
        }

        private bool ValidateInputFields()
        {
            bool result = true;
            string errorString = "Following Error occurs\n";
            int hotelDataCount = dataGridViewHotelInformation.RowCount;
            int flightDataCount = dataGridViewFlightInformation.RowCount;
            if ((hotelDataCount == 0) && (flightDataCount == 0))
            {
                result = false;
                errorString = errorString + "NO DATA PRESENT FOR HOTEL AS WELL AS FLIGHT";
            }
            if (!result)
            {
                MessageBox.Show(errorString, "ERROR IN VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void BtnFinishedVoucherWorking_Click(object sender, EventArgs e)
        {
            if (!ValidateInputFields())
            {
                return;
            }
            /* will be done updation here*/
            bool isSuccessResult = true;
try
            {
                mySqlConnection.Open();
            }
            catch (Exception errConnOpen)
            {
                MessageBox.Show("Error in opening mysql connection because " + errConnOpen.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            MySqlTransaction mySqlTransaction = mySqlConnection.BeginTransaction();
            mySqlCommand.Connection = mySqlConnection;
            mySqlCommand.Transaction = mySqlTransaction;
            mySqlCommand.CommandType = CommandType.Text;
            string mysqlUpdateQueryString = "UPDATE `queries` SET " +
                    "`querylastupdatetime` = NOW(), " +
                    "`querycurrentstate` = @var_querycurrentstate " +
                    "WHERE " +
                    "`queryid` = @var_queryid";
            mySqlCommand.CommandText = mysqlUpdateQueryString;
            mySqlCommand.Prepare();
            mySqlCommand.Parameters.AddWithValue("@var_querycurrentstate", 1);
            mySqlCommand.Parameters["@var_querycurrentstate"].Value = Convert.ToInt32(Properties.Resources.queryStageVoucherCompleted);
            mySqlCommand.Parameters.AddWithValue("@var_queryid", "Text");
            mySqlCommand.Parameters["@var_queryid"].Value = queryId;
            try
            {
                int result = mySqlCommand.ExecuteNonQuery();
                Debug.WriteLine("Query Executed for insertion in table queries. with result = " + result.ToString());
            }
            catch (Exception errquery)
            {
                isSuccessResult = false;
                MessageBox.Show("Error while executing for insertion in table queries because:\n" + errquery.Message, "Error in inserting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (isSuccessResult)
                {
                    mySqlTransaction.Commit();
                }
                else
                {
                    mySqlTransaction.Rollback();
                    mySqlTransaction.Dispose();
                }
            }
            catch (Exception errcommit)
            {
                MessageBox.Show("Error in commiting the transaction because:\n" + errcommit.Message, "Error in Commiting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                mySqlConnection.Close();
            }
            catch (Exception errConnClose)
            {
                MessageBox.Show("Error in opening mysql connection because " + errConnClose.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /* exit from this form */
            Close();
        }
    }
}
