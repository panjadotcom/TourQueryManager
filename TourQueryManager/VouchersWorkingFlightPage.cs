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
    public partial class FrmVouchersWorkingFlightPage : Form
    {
        static string queryId;
        static string mysqlConnStr = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection mySqlConnection = new MySqlConnection(mysqlConnStr);
        MySqlDataAdapter mysqlDataAdaptor = new MySqlDataAdapter();
        DataSet dataSet = null;
        MySqlCommand command = new MySqlCommand();
        public FrmVouchersWorkingFlightPage(string argv)
        {
            InitializeComponent();
            queryId = argv;
        }

        private void FrmVouchersWorkingFlightPage_Load(object sender, EventArgs e)
        {
            Text = "UPDATING FLIGHT INFORMATION FOR " + queryId;
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



            dataSet = new DataSet();
            string mysqlSelectQueryStr = "SELECT * FROM `finalizedqueries` WHERE `queryid` = '" + queryId + "'";
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
            txtBoxRequirement.Text = querydetails;
            mysqlSelectQueryStr = "SELECT * FROM `flightbookinginfo` WHERE `queryid` = '" + queryId + "'";
            command.Connection = mySqlConnection;
            command.CommandText = mysqlSelectQueryStr;
            try
            {
                mysqlDataAdaptor.SelectCommand = command;
                mysqlDataAdaptor.Fill(dataSet, "CURRENT_BOOKING_DATA");
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
            }
            try
            {
                dataGridViewCurrentStatus.DataSource = dataSet.Tables["CURRENT_BOOKING_DATA"];
                dataGridViewCurrentStatus.ClearSelection();
                if (dataGridViewCurrentStatus.Rows.Count > 0)
                {
                    BtnDelete.Enabled = true;
                }
                else
                {
                    BtnDelete.Enabled = false;
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
            txtBoxPnr.Text = "";
            numericUpDownPassangerCount.Value = 0;
            dateTimePickerIssueDate.Value = DateTime.Today;
            dateTimePickerIssueDate.MaxDate = DateTime.Today;
            txtBoxFlightNo.Text = "";
            txtBoxFlightClass.Text = "";
            txtBoxAircraftNo.Text = "";
            txtBoxDeptAirport.Text = "";
            txtBoxDeptTerminal.Text = "";
            txtBoxArrAirPort.Text = "";
            txtBoxArrTerminal.Text = "";
            dateTimePickerArrDate.Value = DateTime.Today;
            dateTimePickerArrTime.Value = DateTime.Now;
            dateTimePickerDeptDate.Value = DateTime.Today;
            dateTimePickerDeptTime.Value = DateTime.Now;
            checkBoxConnectingFlight.Checked = false;
            comboBoxFlightStatus.Text = "";
            txtBoxAirlineRef.Text = "";
            txtBoxMeal.Text = "";
            txtBoxBaggageLimit.Text = "";
            numericUpDownStops.Value = 0;
            txtBoxFare.Text = "";
            txtBoxGst.Text = "";
            txtBoxSurcharge.Text = "";
            txtBoxTotalPrice.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Exiting flight vouchers form");
            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string mysqlInsertQueryString = "";
            bool isSuccessResult = true;
            int idbookinginfo;
            try
            {
                idbookinginfo = Convert.ToInt32(dataGridViewCurrentStatus.SelectedRows[0].Cells["idflightbookinginfo"].Value);
            }
            catch (Exception errSelectedIndex)
            {
                Debug.WriteLine("Error in Deleting Rows because : " + errSelectedIndex.Message);
                return;
            }
            
            DialogResult dialogResult = MessageBox.Show("FLIGHT rows needs to be deleted for idflightbookinginfo = " + idbookinginfo.ToString(), "DELETE ROW FROM FLIGHT BOOKING INFO TABLE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Debug.WriteLine("DELETING ROW DATA FROM HOTEL BOOKING INFO TABLE ");
            }
            else
            {
                Debug.WriteLine("NOT DELETING ROW DATA FROM HOTEL BOOKING INFO TABLE ");
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
            mySqlCommand.Parameters.AddWithValue("@var_idflightbookinginfo", 1);
            mySqlCommand.Parameters["@var_idflightbookinginfo"].Value = idbookinginfo;

            string table = "flightbookinginfo";
            // prepare insert query for working day
            mysqlInsertQueryString = "DELETE FROM `" + table + "` WHERE `idflightbookinginfo` = @var_idflightbookinginfo";
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
            FrmVouchersWorkingFlightPage_Load(null, null);
        }

        private void numericUpDownPassangerCount_ValueChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(numericUpDownPassangerCount.Value);
            if (index == 0)
            {
                dataGridViewPassangerDetails.Rows.Clear();
                return;
            }
            if (dataGridViewPassangerDetails.Rows.Count > index)
            {
                /* needs to delete last row */
                for (int counter = dataGridViewPassangerDetails.Rows.Count - 1; counter >= index; counter--)
                {
                    dataGridViewPassangerDetails.Rows.RemoveAt(counter);
                }
                
                return;
            }
            if (dataGridViewPassangerDetails.Rows.Count < index)
            {
                /* needs to add a row */
                for (int counter = dataGridViewPassangerDetails.Rows.Count; counter < index; counter++)
                {
                    dataGridViewPassangerDetails.Rows.Add();
                }
                
                return;
            }
        }

        private void AmountTextChanged(object sender, EventArgs e)
        {
            int amount = 0;
            try
            {
                if (txtBoxFare.Text.Equals(""))
                {
                    Debug.WriteLine("txtBoxFare value is empty");
                }
                else
                {
                    amount = amount + Convert.ToInt32(txtBoxFare.Text);
                }
                if (txtBoxGst.Text.Equals(""))
                {
                    Debug.WriteLine("txtBoxGst value is empty");
                }
                else
                {
                    amount = amount + Convert.ToInt32(txtBoxGst.Text);
                }
                if (txtBoxSurcharge.Text.Equals(""))
                {
                    Debug.WriteLine("txtBoxSurcharge value is empty");
                }
                else
                {
                    amount = amount + Convert.ToInt32(txtBoxSurcharge.Text);
                }
                txtBoxTotalPrice.Text = amount.ToString();
            }
            catch (Exception errAmount)
            {
                MessageBox.Show("Only numeric values are valid \n Error is " + errAmount.Message , "AMOUNT NOT VALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxTotalPrice.Text = "PRICE NOT VALID";
            }
        }

        private bool ValidateInputFields()
        {
            bool result = true;
            string errorString = "Following Error occurs\n";
            if (txtBoxPnr.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "PNR FIELD IS EMPTY.\n";
            }

            if (numericUpDownPassangerCount.Value == 0)
            {
                result = false;
                errorString = errorString + "PASSANGERS LIST IS EMPTY.\n";
            }
            else
            {
                for (int index = 0; index < numericUpDownPassangerCount.Value; index++)
                {
                    if (dataGridViewPassangerDetails.Rows[index].Cells[0].Value == null)
                    {
                        result = false;
                        errorString = errorString + "Passanger name in index " + index.ToString() + " is empty.\n";
                    }
                    if (dataGridViewPassangerDetails.Rows[index].Cells[2].Value == null)
                    {
                        result = false;
                        errorString = errorString + "Passanger ticket no. in index " + index.ToString() + " is empty.\n";
                    }
                    if (dataGridViewPassangerDetails.Rows[index].Cells[3].Value == null)
                    {
                        dataGridViewPassangerDetails.Rows[index].Cells[3].Value = "-";
                    }
                }
            }

            if (txtBoxFlightNo.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "Flight number is empty.\n";
            }

            if (txtBoxFlightClass.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "Flight class field is empty.\n";
            }

            if (txtBoxAircraftNo.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "Aircraft number is empty.\n";
            }

            if (txtBoxDeptAirport.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "Departure airport name is empty.\n";
            }

            if (txtBoxArrAirPort.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "Arrival airport is empty.\n";
            }

            if (comboBoxFlightStatus.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "Flight status is empty.\n";
            }

            if (txtBoxBaggageLimit.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "Baggage limit field is empty. \"Write 0 if not required\" \n";
            }

            if (txtBoxMeal.Text.Equals(""))
            {
                txtBoxMeal.Text = "0 Platter";
            }

            if (txtBoxFare.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "Fare field is empty. \"Write 0 if not required\" \n";
            }

            if (txtBoxGst.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "Gst is empty. \"Write 0 if not required\" \n";
            }

            if (txtBoxSurcharge.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "Surcharge is empty. \"Write 0 if not required\" \n";
            }

            if (!result)
            {
                MessageBox.Show(errorString, "ERROR IN VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
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
            
            string table = "flightbookinginfo";
            // prepare insert query for flight
            mysqlInsertQueryString = "INSERT INTO `" + table + "` ( " +
                "`queryid`, " +
                "`pnr`, " +
                "`issuedate`, " +
                "`passangername`, " +
                "`ticketnumber`, " +
                "`ffy`, " +
                "`amountfare`, " +
                "`amountgst`, " +
                "`amountsurcharge`, " +
                "`flightinfo`, " +
                "`departureinfo`, " +
                "`arrivalinfo`, " +
                "`statusinfo` " +
                ") VALUES ( " +
                "@var_queryid, " +
                "@var_pnr, " +
                "@var_issuedate, " +
                "@var_passangername, " +
                "@var_ticketnumber, " +
                "@var_ffy, " +
                "@var_amountfare, " +
                "@var_amountgst, " +
                "@var_amountsurcharge, " +
                "@var_flightinfo, " +
                "@var_departureinfo, " +
                "@var_arrivalinfo, " +
                "@var_statusinfo " +
                ")";
            mySqlCommand.CommandText = mysqlInsertQueryString;
            mySqlCommand.Prepare();
            string passangernames = "";
            string ticketnumbers = "";
            string ffys = "";
            string seatnos = "";
            for (int index = 0; index < dataGridViewPassangerDetails.RowCount; index++)
            {
                if (index == 0)
                {
                    /* first entry of the column */
                    passangernames = dataGridViewPassangerDetails.Rows[index].Cells[0].Value.ToString();
                    if (dataGridViewPassangerDetails.Rows[index].Cells[1].Value != null)
                    {
                        seatnos = dataGridViewPassangerDetails.Rows[index].Cells[1].Value.ToString();
                    }
                    ticketnumbers = dataGridViewPassangerDetails.Rows[index].Cells[2].Value.ToString();
                    ffys = dataGridViewPassangerDetails.Rows[index].Cells[3].Value.ToString();
                }
                else
                {
                    passangernames = passangernames + "," + dataGridViewPassangerDetails.Rows[index].Cells[0].Value.ToString();
                    if (dataGridViewPassangerDetails.Rows[index].Cells[1].Value != null)
                    {
                        seatnos = seatnos + "," + dataGridViewPassangerDetails.Rows[index].Cells[1].Value.ToString();
                    }
                    ticketnumbers = ticketnumbers + "," + dataGridViewPassangerDetails.Rows[index].Cells[2].Value.ToString();
                    ffys = ffys + "," + dataGridViewPassangerDetails.Rows[index].Cells[3].Value.ToString();
                }
            }
            mySqlCommand.Parameters.AddWithValue("@var_queryid", "Text");
            mySqlCommand.Parameters["@var_queryid"].Value = queryId;
            mySqlCommand.Parameters.AddWithValue("@var_pnr", "Text");
            mySqlCommand.Parameters["@var_pnr"].Value = txtBoxPnr.Text;
            mySqlCommand.Parameters.AddWithValue("@var_issuedate", "Text");
            mySqlCommand.Parameters["@var_issuedate"].Value = dateTimePickerIssueDate.Value.ToString("yyyy-MM-dd");
            mySqlCommand.Parameters.AddWithValue("@var_passangername", "Text");
            mySqlCommand.Parameters["@var_passangername"].Value = passangernames;
            mySqlCommand.Parameters.AddWithValue("@var_ticketnumber", "Text");
            mySqlCommand.Parameters["@var_ticketnumber"].Value = ticketnumbers;
            mySqlCommand.Parameters.AddWithValue("@var_ffy", "Text");
            mySqlCommand.Parameters["@var_ffy"].Value = ffys;
            mySqlCommand.Parameters.AddWithValue("@var_amountfare", 1);
            mySqlCommand.Parameters["@var_amountfare"].Value = Convert.ToInt32(txtBoxFare.Text);
            mySqlCommand.Parameters.AddWithValue("@var_amountgst", 1);
            mySqlCommand.Parameters["@var_amountgst"].Value = Convert.ToInt32(txtBoxGst.Text);
            mySqlCommand.Parameters.AddWithValue("@var_amountsurcharge", 1);
            mySqlCommand.Parameters["@var_amountsurcharge"].Value = Convert.ToInt32(txtBoxSurcharge.Text);
            mySqlCommand.Parameters.AddWithValue("@var_flightinfo", "Text");
            string flightinfo = txtBoxFlightNo.Text + "\n" + txtBoxFlightClass.Text + "\n" + txtBoxAircraftNo.Text;
            mySqlCommand.Parameters["@var_flightinfo"].Value = flightinfo;
            mySqlCommand.Parameters.AddWithValue("@var_departureinfo", "Text");
            string departureinfo = txtBoxDeptAirport.Text;
            if (!txtBoxDeptTerminal.Text.Equals(""))
            {
                departureinfo = departureinfo + "\n" + txtBoxDeptTerminal.Text;
            }
            departureinfo = departureinfo + "\n" + dateTimePickerDeptTime.Value.ToString("h:mm tt, ") + dateTimePickerDeptDate.Value.ToString("ddd, dd/MMM/yyyy");
            mySqlCommand.Parameters["@var_departureinfo"].Value = departureinfo;
            mySqlCommand.Parameters.AddWithValue("@var_arrivalinfo", "Text");
            string arrivalinfo = txtBoxArrAirPort.Text;
            if (!txtBoxArrTerminal.Text.Equals(""))
            {
                arrivalinfo = arrivalinfo + "\n" + txtBoxArrTerminal.Text; 
            }
            arrivalinfo = arrivalinfo + "\n" + dateTimePickerArrTime.Value.ToString("h:mm tt, ") + dateTimePickerDeptDate.Value.ToString("ddd, dd/MMM/yyyy");
            mySqlCommand.Parameters["@var_arrivalinfo"].Value = arrivalinfo;
            mySqlCommand.Parameters.AddWithValue("@var_statusinfo", "Text");
            string statusinfo = comboBoxFlightStatus.Text;
            statusinfo = statusinfo + "\nTotal Baggage:" + txtBoxBaggageLimit.Text;
            statusinfo = statusinfo + "\nTotal Meal:" + txtBoxMeal.Text;
            if (!seatnos.Equals(""))
            {
                statusinfo = statusinfo + "\nSeat No:" + seatnos;
            }
            if (numericUpDownStops.Value == 0)
            {
                statusinfo = statusinfo + "\nNon Stop";
            }
            else if(numericUpDownStops.Value == 1)
            {
                statusinfo = statusinfo + "\n1 Stop";
            }
            else
            {
                statusinfo = statusinfo + "\n" + numericUpDownStops.Value.ToString() + " Stops";
            }
            mySqlCommand.Parameters["@var_statusinfo"].Value = statusinfo;

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
            if (checkBoxConnectingFlight.Checked)
            {
                txtBoxFlightNo.Text = "";
                txtBoxFlightClass.Text = "";
                txtBoxAircraftNo.Text = "";
                txtBoxDeptAirport.Text = txtBoxArrAirPort.Text;
                txtBoxArrAirPort.Text = "";
                txtBoxDeptTerminal.Text = txtBoxArrTerminal.Text;
                txtBoxArrTerminal.Text = "";
                dateTimePickerDeptDate.Value = dateTimePickerArrDate.Value;
                dateTimePickerDeptTime.Value = dateTimePickerArrTime.Value;
                comboBoxFlightStatus.Text = "";
                txtBoxMeal.Text = "";
                numericUpDownStops.Value = 0;
                txtBoxFare.Text = "0";
                txtBoxGst.Text = "0";
                txtBoxSurcharge.Text = "0";
                for (int index = 0; index < dataGridViewPassangerDetails.RowCount; index++)
                {
                    dataGridViewPassangerDetails.Rows[index].Cells[1].Value = null;
                }
                checkBoxConnectingFlight.Checked = false;
            }
            else
            {
                FrmVouchersWorkingFlightPage_Load(null, null);
            }
        }
    }
}
