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

namespace TourQueryManager
{
    public partial class FrmFinalizeQueryPage : Form
    {
        static string queryId;
        static string mysqlConnStr = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection mySqlConnection = new MySqlConnection(mysqlConnStr);

        public FrmFinalizeQueryPage(string argv)
        {
            InitializeComponent();
            queryId = argv;
        }

        private void FrmFinalizeQueryPage_Load(object sender, EventArgs e)
        {
            Text = "FINALIZE QUERY ("+ queryId +")";
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

            DataSet dataSet = new DataSet();
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter mysqlDataAdaptor = new MySqlDataAdapter();
            string mysqlSelectQueryStr = "SELECT `userid`, `username`, `name` FROM `appusers` WHERE `userid` > 1 ORDER BY `userid`";
            command.Connection = mySqlConnection;
            command.CommandText = mysqlSelectQueryStr;
            try
            {
                mysqlDataAdaptor.SelectCommand = command;
                mysqlDataAdaptor.Fill(dataSet, "USER_COMBO_BOX");
                DataRow dataRow = dataSet.Tables["USER_COMBO_BOX"].NewRow();
                dataRow["userid"] = "0";
                dataRow["username"] = "select user";
                dataSet.Tables["USER_COMBO_BOX"].Rows.InsertAt(dataRow, 0);
                comboBoxAssignedTo.DataSource = dataSet.Tables["USER_COMBO_BOX"];
                comboBoxAssignedTo.ValueMember = "userid";
                comboBoxAssignedTo.DisplayMember = "username";
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
            }
            mysqlSelectQueryStr = "SELECT * FROM `finalizedqueries` WHERE `queryid` = " + queryId;
            command.Connection = mySqlConnection;
            command.CommandText = mysqlSelectQueryStr;
            try
            {
                mysqlDataAdaptor.SelectCommand = command;
                mysqlDataAdaptor.Fill(dataSet, "FINALIZED_DATA");
                if (dataSet.Tables["FINALIZED_DATA"].Rows.Count == 0)
                {
                    comboBoxAssignedTo.SelectedIndex = 0;
                    txtBoxTotalCost.Text = "";
                    txtBoxSpclInstrsn.Text = "";
                }
                else
                {
                    string queriesColumnStr;
                    queriesColumnStr = dataSet.Tables["FINALIZED_DATA"].Rows[0]["userid"].ToString();
                    comboBoxAssignedTo.SelectedValue = Convert.ToInt32(queriesColumnStr);
                    queriesColumnStr = dataSet.Tables["FINALIZED_DATA"].Rows[0]["totalcost"].ToString();
                    txtBoxTotalCost.Text = queriesColumnStr;
                    queriesColumnStr = dataSet.Tables["FINALIZED_DATA"].Rows[0]["specialinstructions"].ToString();
                    txtBoxSpclInstrsn.Text = queriesColumnStr;
                }
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateInputFields()
        {
            bool result = true;
            string errorString = "Following Error occurs\n";
            if ((comboBoxAssignedTo.SelectedIndex == 0) || comboBoxAssignedTo.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "ASSIGNED TO IS NOT SELECTED.\n";
            }
            if (txtBoxSpclInstrsn.Text.Equals(""))
            {
                txtBoxSpclInstrsn.Text = "NOT FILLED";
            }
            if (txtBoxTotalCost.Text.Equals(""))
            {
                result = false;
                errorString = errorString + " PRICE FIELD IS EMPTY.\n";
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtBoxTotalCost.Text);
                }
                catch (Exception errPrice)
                {
                    errorString = errorString + "INCORRECT PRICE (error = " + errPrice.Message + ")";
                }
            }
            if (!result)
            {
                MessageBox.Show(errorString, "ERROR IN VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputFields())
            {
                return;
            }
            /* will be done updation here*/
            string mysqlInsertQueryString = "";
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

            string table = "finalizedqueries";
            // prepare insert query for flight
            mysqlInsertQueryString = "INSERT INTO `" + table + "` ( " +
                "`queryid`, " +
                "`userid`, " +
                "`totalcost`, " +
                "`specialinstructions` " +
                ") VALUES ( " +
                "@var_queryid, " +
                "@var_userid, " +
                "@var_totalcost, " +
                "@var_specialinstructions " +
                ") ON DUPLICATE KEY UPDATE " +
                "`userid` = @var_userid, " +
                "`totalcost` = @var_totalcost, " +
                "`specialinstructions` = @var_specialinstructions " +
                "";
            mySqlCommand.CommandText = mysqlInsertQueryString;
            mySqlCommand.Prepare();
            mySqlCommand.Parameters.AddWithValue("@var_queryid", "Text");
            mySqlCommand.Parameters["@var_queryid"].Value = queryId;
            mySqlCommand.Parameters.AddWithValue("@var_userid", 1);
            mySqlCommand.Parameters["@var_userid"].Value = comboBoxAssignedTo.SelectedValue;
            mySqlCommand.Parameters.AddWithValue("@var_totalcost", 1);
            mySqlCommand.Parameters["@var_totalcost"].Value = Convert.ToInt32(txtBoxTotalCost.Text);
            mySqlCommand.Parameters.AddWithValue("@var_specialinstructions", "Text");
            mySqlCommand.Parameters["@var_specialinstructions"].Value = txtBoxSpclInstrsn.Text;
            try
            {
                int result = mySqlCommand.ExecuteNonQuery();
                Debug.WriteLine("Query Executed for insertion in table " + table + ". with result = " + result.ToString());
            }
            catch (Exception errquery)
            {
                isSuccessResult = false;
                MessageBox.Show("Error while executing for insertion in table " + table + " because:\n" + errquery.Message, "Error in inserting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (isSuccessResult)
            {
                string mysqlUpdateQueryString = "UPDATE `queries` SET " +
                    "`querylastupdatetime` = NOW(), " +
                    "`querycurrentstate` = @var_querycurrentstate " +
                    "WHERE " +
                    "`queryid` = @var_queryid";
                mySqlCommand.Parameters.AddWithValue("@var_querycurrentstate", 1);
                mySqlCommand.Parameters["@var_querycurrentstate"].Value = Convert.ToInt32(Properties.Resources.queryStageDealDone);
                mySqlCommand.CommandText = mysqlUpdateQueryString;
                mySqlCommand.Prepare();
                try
                {
                    int result = mySqlCommand.ExecuteNonQuery();
                    Debug.WriteLine("Query Executed for insertion in table " + table + ". with result = " + result.ToString());
                }
                catch (Exception errquery)
                {
                    isSuccessResult = false;
                    MessageBox.Show("Error while executing for insertion in table " + table + " because:\n" + errquery.Message, "Error in inserting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
