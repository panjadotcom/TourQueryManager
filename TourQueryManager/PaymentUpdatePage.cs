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
    public partial class FrmPaymentUpdatePage : Form
    {
        static string queryId;
        static string mysqlConnStr = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection mySqlConnection = new MySqlConnection(mysqlConnStr);

        public FrmPaymentUpdatePage(string argv)
        {
            InitializeComponent();
            queryId = argv;
        }

        private void FrmPaymentUpdatePage_Load(object sender, EventArgs e)
        {
            Text = "UPDATE PAYMENT INFORMATION FOR " + queryId;
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
            string mysqlSelectQueryStr = "SELECT `idledger`, `transactionid`, `transactiontime`, `transactionmode`, `transactionamount`, `note` FROM `ledger` WHERE `queryid` = '" + queryId + "'";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            DataSet dataSet = new DataSet();
            MySqlCommand command = new MySqlCommand();
            command.Connection = mySqlConnection;
            command.CommandText = mysqlSelectQueryStr;
            try
            {
                mySqlDataAdapter.SelectCommand = command;
                mySqlDataAdapter.Fill(dataSet, "CURRENT_PAYMENT_DATA");
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
            }
            mysqlSelectQueryStr = "SELECT `totalcost` FROM `finalizedqueries` WHERE `queryid` = '" + queryId + "'";
            command.Connection = mySqlConnection;
            command.CommandText = mysqlSelectQueryStr;
            try
            {
                mySqlDataAdapter.SelectCommand = command;
                mySqlDataAdapter.Fill(dataSet, "TOTAL_COST");
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
            }
            try
            {
                dataGridViewCurrentStatus.DataSource = dataSet.Tables["CURRENT_PAYMENT_DATA"];
                dataGridViewCurrentStatus.Columns["note"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewCurrentStatus.ClearSelection();
                if (dataGridViewCurrentStatus.Rows.Count > 0)
                {
                    BtnDelete.Enabled = true;
                }
                else
                {
                    BtnDelete.Enabled = false;
                }
                if (dataSet.Tables["TOTAL_COST"].Rows.Count == 0)
                {
                    txtBoxTotalTourCost.Text = "0";
                }
                else
                {
                    txtBoxTotalTourCost.Text = dataSet.Tables["TOTAL_COST"].Rows[0][0].ToString();
                }
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
            txtBoxNote.Text = "";
            txtBoxTransactionAmount.Text = "";
            txtBoxTransactionId.Text = "";
            comboBoxTransactionMode.SelectedIndex = 0;
            dateTimePickerTransactionDate.Value = DateTime.Today;
            dateTimePickerTransactionTime.Value = DateTime.Now;
            int totalPayment = 0;
            for (int index = 0; index < dataGridViewCurrentStatus.RowCount; index++)
            {
                totalPayment += Convert.ToInt32(dataGridViewCurrentStatus.Rows[index].Cells["transactionamount"].Value);
            }
            txtBoxTotalPayment.Text = totalPayment.ToString();
            if (Convert.ToInt32(txtBoxTotalTourCost.Text) == Convert.ToInt32(txtBoxTotalPayment.Text))
            {
                if (totalPayment == 0)
                {
                    Debug.WriteLine("No entry of price yet. thus not changing colour of the text");
                }
                else
                {
                    txtBoxTotalPayment.BackColor = Color.LightGreen;
                    txtBoxTotalTourCost.BackColor = Color.LightGreen;
                }
            }
            else if(Convert.ToInt32(txtBoxTotalTourCost.Text) > Convert.ToInt32(txtBoxTotalPayment.Text))
            {
                txtBoxTotalPayment.BackColor = Color.Red;
                txtBoxTotalTourCost.BackColor = Color.Orange;
            }
            else
            {
                txtBoxTotalPayment.BackColor = Color.Orange;
                txtBoxTotalTourCost.BackColor = Color.Red;
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
            if (txtBoxNote.Text.Equals(""))
            {
                txtBoxNote.Text = "NOT FILLED";
            }

            if (txtBoxTransactionAmount.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "Payment amount is empty.\n";
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtBoxTransactionAmount.Text);
                }
                catch (Exception errPrice)
                {
                    errorString = errorString + "INCORRECT Payment amount (error = " + errPrice.Message + ")";
                }
            }

            if (txtBoxTransactionId.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "Payment Id field is empty.\n";
            }

            if (comboBoxTransactionMode.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "transaction mode is not selected.\n";
            }
            else if (comboBoxTransactionMode.SelectedIndex == 0)
            {
                result = false;
                errorString = errorString + "transaction mode is not selected.\n";
            }
            DateTime dateTime = DateTime.Parse(dateTimePickerTransactionDate.Value.ToString("yyyy-MM-dd") + " " + dateTimePickerTransactionTime.Value.ToString("HH:mm:ss"));
            if (dateTime >= DateTime.Now)
            {
                result = false;
                errorString = errorString + "Transaction time cannot be greator than current time.\n";
            }
            //txtBoxNote.Text = DateTime.Now.ToString() + "\r\n" + dateTime.ToString();
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
            //return;
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

            string table = "ledger";
            // prepare insert query for flight
            mysqlInsertQueryString = "INSERT INTO `" + table + "` ( " +
                "`queryid`, " +
                "`transactionid`, " +
                "`transactiontime`, " +
                "`transactionmode`, " +
                "`transactionamount`, " +
                "`note` " +
                ") VALUES ( " +
                "@var_queryid, " +
                "@var_transactionid, " +
                "@var_transactiontime, " +
                "@var_transactionmode, " +
                "@var_transactionamount, " +
                "@var_note " +
                ") ON DUPLICATE KEY UPDATE " +
                "`queryid` = @var_queryid, " +
                "`transactionid` = @var_transactionid, " +
                "`transactiontime` = @var_transactiontime, " +
                "`transactionmode` = @var_transactionmode, " +
                "`transactionamount` = @var_transactionamount, " +
                "`note` = @var_note " +
                "";
            mySqlCommand.CommandText = mysqlInsertQueryString;
            mySqlCommand.Prepare();
            mySqlCommand.Parameters.AddWithValue("@var_queryid", "Text");
            mySqlCommand.Parameters["@var_queryid"].Value = queryId;
            mySqlCommand.Parameters.AddWithValue("@var_transactionid", "Text");
            mySqlCommand.Parameters["@var_transactionid"].Value = txtBoxTransactionId.Text;
            mySqlCommand.Parameters.AddWithValue("@var_transactiontime", "Text");
            mySqlCommand.Parameters["@var_transactiontime"].Value = dateTimePickerTransactionDate.Value.ToString("yyyy-MM-dd") + " " + dateTimePickerTransactionTime.Value.ToString("HH:mm:ss");
            mySqlCommand.Parameters.AddWithValue("@var_transactionmode", "Text");
            mySqlCommand.Parameters["@var_transactionmode"].Value = comboBoxTransactionMode.Text;
            mySqlCommand.Parameters.AddWithValue("@var_transactionamount", 1);
            mySqlCommand.Parameters["@var_transactionamount"].Value = Convert.ToInt32(txtBoxTransactionAmount.Text);
            mySqlCommand.Parameters.AddWithValue("@var_note", "Text");
            mySqlCommand.Parameters["@var_note"].Value = txtBoxNote.Text;
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
            FrmPaymentUpdatePage_Load(null, null);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string mysqlInsertQueryString = "";
            bool isSuccessResult = true;
            int idledger;
            try
            {
                idledger = Convert.ToInt32(dataGridViewCurrentStatus.SelectedRows[0].Cells["idledger"].Value);
            }
            catch (Exception errSelectedIndex)
            {
                MessageBox.Show("Error in Deleting Rows because : " + errSelectedIndex.Message);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Payment rows needs to be deleted for idledger = " + idledger.ToString(), "DELETE ROW FROM PAYMENT LEDGER TABLE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Debug.WriteLine("DELETING ROW DATA FROM LEDGER TABLE ");
            }
            else
            {
                Debug.WriteLine("NOT DELETING ROW DATA FROM LEDGER TABLE ");
                return;
            }
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
            mySqlCommand.Parameters.AddWithValue("@var_idledger", 1);
            mySqlCommand.Parameters["@var_idledger"].Value = idledger;

            string table = "ledger";
            // prepare insert query for working day
            mysqlInsertQueryString = "DELETE FROM `" + table + "` WHERE `idledger` = @var_idledger";
            mySqlCommand.CommandText = mysqlInsertQueryString;
            mySqlCommand.Prepare();
            try
            {
                int result = mySqlCommand.ExecuteNonQuery();
                Debug.WriteLine("Query Executed for rows deletion from " + table + ". with result = " + result.ToString());
            }
            catch (Exception errquery)
            {
                isSuccessResult = false;
                MessageBox.Show("Error while executing for rows deletion from " + table + " because:\n" + errquery.Message, "Error in inserting", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            FrmPaymentUpdatePage_Load(null, null);
        }

        private void dataGridViewCurrentStatus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCurrentStatus.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                txtBoxTransactionId.Text = dataGridViewCurrentStatus.SelectedRows[0].Cells["transactionid"].Value.ToString();
                txtBoxTransactionAmount.Text = dataGridViewCurrentStatus.SelectedRows[0].Cells["transactionamount"].Value.ToString();
                txtBoxNote.Text = dataGridViewCurrentStatus.SelectedRows[0].Cells["note"].Value.ToString();
                comboBoxTransactionMode.Text = dataGridViewCurrentStatus.SelectedRows[0].Cells["transactionmode"].Value.ToString();
                dateTimePickerTransactionDate.Value = DateTime.Parse(dataGridViewCurrentStatus.SelectedRows[0].Cells["transactiontime"].Value.ToString());
                dateTimePickerTransactionTime.Value = DateTime.Parse(dataGridViewCurrentStatus.SelectedRows[0].Cells["transactiontime"].Value.ToString());
            }
            catch (Exception errSelectedIndex)
            {
                MessageBox.Show("Error in Deleting Rows because : " + errSelectedIndex.Message);
                return;
            }
        }
    }
}
