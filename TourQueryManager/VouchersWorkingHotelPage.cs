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
    public partial class FrmVouchersWorkingHotelPage : Form
    {
        static string queryId;
        static string mysqlConnStr = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection mySqlConnection = new MySqlConnection(mysqlConnStr);
        MySqlDataAdapter mysqlDataAdaptor = new MySqlDataAdapter();
        DataSet dataSet = null;
        MySqlCommand command = new MySqlCommand();
        public FrmVouchersWorkingHotelPage(string argv)
        {
            InitializeComponent();
            queryId = argv;
        }

        private void FrmVouchersWorkingHotelPage_Load(object sender, EventArgs e)
        {
            Text = "UPDATING HOTEL INFORMATION FOR " + queryId;
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
            string mysqlSelectQueryStr = "SELECT * FROM `queries` WHERE `queryid` = " + queryId + "";
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
            querydetails = querydetails + "QUERY START DATE = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["querystartdate"].ToString();
            querydetails = querydetails + "\r\nPLACE = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["place"].ToString();
            querydetails = querydetails + "\r\nDESTINATION COVERED = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["destinationcovered"].ToString();
            querydetails = querydetails + "\r\nFROM DATE = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["fromdate"].ToString();
            querydetails = querydetails + "\r\nTO DATE = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["todate"].ToString();
            querydetails = querydetails + "\r\nADULTS = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["adults"].ToString();
            querydetails = querydetails + "\r\nCHILDREN = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["children"].ToString();
            querydetails = querydetails + "\r\nBABIES = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["babies"].ToString();
            querydetails = querydetails + "\r\nROOM COUNT = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["roomcount"].ToString();
            querydetails = querydetails + "\r\nMEAL = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["meal"].ToString();
            querydetails = querydetails + "\r\nHOTEL CATEGORY = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["hotelcategory"].ToString();
            querydetails = querydetails + "\r\nARRIVAL DATE = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["arrivaldate"].ToString();
            querydetails = querydetails + "\r\nDEPARTURE DATE = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["departuredate"].ToString();
            querydetails = querydetails + "\r\nARRIVAL CITY = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["arrivalcity"].ToString();
            querydetails = querydetails + "\r\nDEPARTURE CITY = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["departurecity"].ToString();
            querydetails = querydetails + "\r\nVEHICAL CATEGORY = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["vehicalcategory"].ToString();
            querydetails = querydetails + "\r\nREQUIREMENT = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["requirement"].ToString();
            querydetails = querydetails + "\r\nBUDGET = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["budget"].ToString();
            querydetails = querydetails + "\r\nNOTE = " + dataSet.Tables["QUERYID_DATA"].Rows[0]["note"].ToString();
            querydetails = querydetails + "";
            txtBoxRequirement.Text = querydetails;
            mysqlSelectQueryStr = "SELECT * FROM `hotelbookinginfo` WHERE `queryid` = " + queryId + "";
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
            CmbboxWrkngHtlSector_Reload();
            numericUpDownRoomCount.Value = 0;
            txtBoxConfirmedBy.Text = "";
            txtBoxConfirmationId.Text = "";
            txtBoxLeadPsngrName.Text = "";
            txtBoxBookingPrice.Text = "";
            numericUpDownAdults.Value = 0;
            numericUpDownChildren.Value = 0;
            numericUpDownInfants.Value = 0;
            dateTimePickerCheckInDate.Value = DateTime.Today;
            dateTimePickerPickUp.Value = DateTime.Parse("00:00:00");
            dateTimePickerDropOff.Value = DateTime.Parse("00:00:00");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Exiting Form");
            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string mysqlInsertQueryString = "";
            bool isSuccessResult = true;
            int idbookinginfo;
            try
            {
                idbookinginfo = Convert.ToInt32(dataGridViewCurrentStatus.SelectedRows[0].Cells["idhotelbookinginfo"].Value);
            }
            catch (Exception errSelectedIndex)
            {
                MessageBox.Show("Error in Deleting Rows because : " + errSelectedIndex.Message);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Hotel rows needs to be deleted for idhotelbookinginfo = " + idbookinginfo.ToString(), "DELETE ROW FROM HOTEL BOOKING INFO TABLE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            mySqlCommand.Parameters.AddWithValue("@var_idhotelbookinginfo", 1);
            mySqlCommand.Parameters["@var_idhotelbookinginfo"].Value = idbookinginfo;

            string table = "hotelbookinginfo";
            // prepare insert query for working day
            mysqlInsertQueryString = "DELETE FROM `" + table + "` WHERE `idhotelbookinginfo` = @var_idhotelbookinginfo";
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
            FrmVouchersWorkingHotelPage_Load(null, null);
        }

        private void CmbboxWrkngHtlSector_Reload()
        {
            CmbboxWrkngHtlSector.SelectedValue = 0;
            CmbboxWrkngHtlSector.DataSource = null;
            CmbboxWrkngHtlSector.Text = "";
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

            string selectQueryString = "SELECT DISTINCT `hotelarea` FROM `hotelinfo` ORDER BY `hotelarea`";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQueryString, mySqlConnection);
            DataSet dataSet = new DataSet();
            DataRow dataRow;
            try
            {
                mySqlDataAdapter.Fill(dataSet, "HOTEL_AREA");
                if (dataSet != null)
                {
                    dataRow = dataSet.Tables["HOTEL_AREA"].NewRow();
                    dataRow["hotelarea"] = "SELECT SECTOR";
                    dataSet.Tables["HOTEL_AREA"].Rows.InsertAt(dataRow, 0);
                    CmbboxWrkngHtlSector.DataSource = dataSet.Tables["HOTEL_AREA"];
                    CmbboxWrkngHtlSector.ValueMember = "hotelarea";
                    CmbboxWrkngHtlSector.DisplayMember = "hotelarea";
                    CmbboxWrkngHtlSector.SelectedIndex = 0;
                    //CmbboxWrkngHtlSector.SelectedValue = 0;
                }
            }
            catch (Exception errSelectQry)
            {
                MessageBox.Show("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
                Debug.WriteLine("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
            }
            try
            {
                mySqlConnection.Close();
            }
            catch (Exception errConnClose)
            {
                MessageBox.Show("Error in Closing mysql connection because " + errConnClose.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            CmbboxWrkngHtlSector.Text = "SELECT SECTOR";
            //BtnUpdate.Enabled = false;
        }

        private void CmbboxWrkngHtlSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((CmbboxWrkngHtlSector.SelectedIndex == 0) || (CmbboxWrkngHtlSector.SelectedValue == null))
            {
                CmbboxWrkngHtlLocation.SelectedValue = 0;
                CmbboxWrkngHtlLocation.DataSource = null;
                CmbboxWrkngHtlLocation.Text = "";
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

            string selectQueryString = "SELECT DISTINCT `hotelcity` FROM `hotelinfo` WHERE `hotelarea` = '" + CmbboxWrkngHtlSector.SelectedValue.ToString() + "' ORDER BY `hotelcity`";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQueryString, mySqlConnection);
            DataSet dataSet = new DataSet();
            try
            {
                mySqlDataAdapter.Fill(dataSet, "HOTEL_CITY");
                if (dataSet != null)
                {
                    DataRow dataRow = dataSet.Tables["HOTEL_CITY"].NewRow();
                    dataRow["hotelcity"] = "SELECT CITY";
                    dataSet.Tables["HOTEL_CITY"].Rows.InsertAt(dataRow, 0);
                    CmbboxWrkngHtlLocation.DataSource = dataSet.Tables["HOTEL_CITY"];
                    CmbboxWrkngHtlLocation.ValueMember = "hotelcity";
                    CmbboxWrkngHtlLocation.DisplayMember = "hotelcity";
                    CmbboxWrkngHtlLocation.SelectedIndex = 0;
                    //CmbboxWrkngHtlLocation.SelectedValue = 0;
                }
            }
            catch (Exception errSelectQry)
            {
                MessageBox.Show("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
                Debug.WriteLine("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
            }
            try
            {
                mySqlConnection.Close();
            }
            catch (Exception errConnClose)
            {
                MessageBox.Show("Error in opening mysql connection because " + errConnClose.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void CmbboxWrkngHtlLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((CmbboxWrkngHtlLocation.SelectedIndex == 0) || (CmbboxWrkngHtlLocation.SelectedValue == null))
            {
                CmbboxWrkngHtlHotelRating.SelectedValue = 0;
                CmbboxWrkngHtlHotelRating.DataSource = null;
                CmbboxWrkngHtlHotelRating.Text = "";
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

            string selectQueryString = "SELECT DISTINCT `hotelrating` FROM `hotelinfo`  WHERE `hotelarea` = '" + CmbboxWrkngHtlSector.Text + "' AND `hotelcity` = '" + CmbboxWrkngHtlLocation.Text + "'  ORDER BY `hotelrating`";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQueryString, mySqlConnection);
            DataSet dataSet = new DataSet();
            try
            {
                mySqlDataAdapter.Fill(dataSet, "HOTEL_RATING");
                if (dataSet != null)
                {
                    DataRow dataRow = dataSet.Tables["HOTEL_RATING"].NewRow();
                    dataRow["hotelrating"] = "SELECT HOTEL RATING";
                    dataSet.Tables["HOTEL_RATING"].Rows.InsertAt(dataRow, 0);
                    CmbboxWrkngHtlHotelRating.DataSource = dataSet.Tables["HOTEL_RATING"];
                    CmbboxWrkngHtlHotelRating.ValueMember = "hotelrating";
                    CmbboxWrkngHtlHotelRating.DisplayMember = "hotelrating";
                    CmbboxWrkngHtlHotelRating.SelectedIndex = 0;
                    //CmbboxWrkngHtlHotelRating.SelectedValue = 0;
                }
            }
            catch (Exception errSelectQry)
            {
                MessageBox.Show("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
                Debug.WriteLine("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
            }
            try
            {
                mySqlConnection.Close();
            }
            catch (Exception errConnClose)
            {
                MessageBox.Show("Error in opening mysql connection because " + errConnClose.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void CmbboxWrkngHtlHotelRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((CmbboxWrkngHtlHotelRating.SelectedIndex == 0) || (CmbboxWrkngHtlHotelRating.SelectedValue == null))
            {
                CmbboxWrkngHtlHotel.SelectedValue = 0;
                CmbboxWrkngHtlHotel.DataSource = null;
                CmbboxWrkngHtlHotel.Text = "";
                dataGridViewHotelList.DataSource = null;
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
            string seasonyear = "2018"; //dateTimePickerWorkingArrivalDate.Value.ToString("yyyy");
            string selectQueryString = null;
            MySqlDataAdapter mySqlDataAdapter = null;
            DataSet dataSet = new DataSet();
            try
            {
                selectQueryString = "SELECT `idhotelinfo`, `hotelname` FROM `hotelinfo`  WHERE `hotelarea` = '" + CmbboxWrkngHtlSector.Text + "' AND `hotelcity` = '" + CmbboxWrkngHtlLocation.Text + "' AND `hotelrating` = '" + CmbboxWrkngHtlHotelRating.Text + "'  ORDER BY `hotelname`";
                mySqlDataAdapter = new MySqlDataAdapter(selectQueryString, mySqlConnection);
                mySqlDataAdapter.Fill(dataSet, "HOTEL_NAME");
                selectQueryString = "SELECT " +
                    "`T1`.hotelname AS `HOTEL NAME`, " +
                    "`T2`.roomtype AS `ROOM TYPE`, " +
                    "`T2`.seasontype AS `SEASON`, " +
                    "`T2`.mealepaipricesingle AS `EPAI SINGLE`, " +
                    "`T2`.mealepaipricedouble AS `EPAI DOUBLE`, " +
                    "`T2`.mealepaipriceextbed AS `EPAI TRIPLE`, " +
                    "`T2`.mealcpaipricesingle AS `CPAI SINGLE`, " +
                    "`T2`.mealcpaipricedouble AS `CPAI DOUBLE`, " +
                    "`T2`.mealcpaipriceextbed AS `CPAI TRIPLE`, " +
                    "`T2`.mealmapaipricesingle AS `MAPAI SINGLE`, " +
                    "`T2`.mealmapaipricedouble AS `MAPAI DOUBLE`, " +
                    "`T2`.mealmapaipriceextbed AS `MAPAI TRIPLE`, " +
                    "`T2`.mealapaipricesingle AS `APAI SINGLE`, " +
                    "`T2`.mealapaipricedouble AS `APAI DOUBLE`, " +
                    "`T2`.mealapaipriceextbed AS `APAI TRIPLE` " +
                    "FROM `hotelinfo` AS `T1` INNER JOIN `hotelrates` AS `T2` ON `T1`.`idhotelinfo` = `T2`.`idhotelinfo` " +
                    "WHERE `hotelarea` = '" + CmbboxWrkngHtlSector.Text + "' " +
                    "AND `hotelcity` = '" + CmbboxWrkngHtlLocation.Text + "' " +
                    "AND `hotelrating` = '" + CmbboxWrkngHtlHotelRating.Text + "' " +
                    "AND `seasonyear` = " + seasonyear + " " +
                    "ORDER BY `hotelname`";
                mySqlDataAdapter = new MySqlDataAdapter(selectQueryString, mySqlConnection);
                mySqlDataAdapter.Fill(dataSet, "HOTEL_RATE_LIST");
                if (dataSet != null)
                {
                    DataRow dataRow = dataSet.Tables["HOTEL_NAME"].NewRow();
                    dataRow["idhotelinfo"] = 0;
                    dataRow["hotelname"] = "SELECT HOTEL";
                    dataSet.Tables["HOTEL_NAME"].Rows.InsertAt(dataRow, 0);
                    CmbboxWrkngHtlHotel.DataSource = dataSet.Tables["HOTEL_NAME"];
                    CmbboxWrkngHtlHotel.ValueMember = "idhotelinfo";
                    CmbboxWrkngHtlHotel.DisplayMember = "hotelname";
                    CmbboxWrkngHtlHotel.SelectedIndex = 0;
                    dataGridViewHotelList.DataSource = dataSet.Tables["HOTEL_RATE_LIST"];
                    //CmbboxWrkngHtlHotel.SelectedValue = 0;
                }
            }
            catch (Exception errSelectQry)
            {
                MessageBox.Show("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
                Debug.WriteLine("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
            }
            try
            {
                mySqlConnection.Close();
            }
            catch (Exception errConnClose)
            {
                MessageBox.Show("Error in opening mysql connection because " + errConnClose.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void CmbboxWrkngHtlHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((CmbboxWrkngHtlHotel.SelectedIndex == 0) || (CmbboxWrkngHtlHotel.SelectedValue == null))
            {
                CmbboxWrkngHtlRoomType.SelectedValue = 0;
                CmbboxWrkngHtlRoomType.DataSource = null;
                CmbboxWrkngHtlRoomType.Text = "";
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

            string seasonyear = "2018"; //dateTimePickerWorkingArrivalDate.Value.ToString("yyyy");
            string selectQueryString = "SELECT DISTINCT `roomtype` FROM `hotelrates` WHERE " +
                "`idhotelinfo` = " + CmbboxWrkngHtlHotel.SelectedValue + " " +
                "AND `seasonyear` = " + seasonyear + " ORDER BY `roomtype`";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQueryString, mySqlConnection);
            DataSet dataSet = new DataSet();
            try
            {
                mySqlDataAdapter.Fill(dataSet, "HOTEL_ROOM_TYPE");
                if (dataSet != null)
                {
                    string zeroIndexString = "";
                    if (dataSet.Tables["HOTEL_ROOM_TYPE"].Rows.Count == 0)
                    {
                        zeroIndexString = "NOT EXIST FOR " + seasonyear;
                    }
                    else
                    {
                        zeroIndexString = "SELECT ROOM TYPE";
                    }
                    DataRow dataRow = dataSet.Tables["HOTEL_ROOM_TYPE"].NewRow();
                    dataRow["roomtype"] = zeroIndexString;
                    dataSet.Tables["HOTEL_ROOM_TYPE"].Rows.InsertAt(dataRow, 0);
                    CmbboxWrkngHtlRoomType.DataSource = dataSet.Tables["HOTEL_ROOM_TYPE"];
                    CmbboxWrkngHtlRoomType.ValueMember = "roomtype";
                    CmbboxWrkngHtlRoomType.DisplayMember = "roomtype";
                    CmbboxWrkngHtlRoomType.SelectedIndex = 0;
                    //CmbboxWrkngHtlRoomType.SelectedValue = 0;
                }
            }
            catch (Exception errSelectQry)
            {
                MessageBox.Show("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
                Debug.WriteLine("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
            }
            try
            {
                mySqlConnection.Close();
            }
            catch (Exception errConnClose)
            {
                MessageBox.Show("Error in opening mysql connection because " + errConnClose.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void CmbboxWrkngHtlRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbboxWrkngHtlMealPlan.Items.Clear();
            if ((CmbboxWrkngHtlRoomType.SelectedIndex == 0) || (CmbboxWrkngHtlRoomType.SelectedValue == null))
            {
                CmbboxWrkngHtlMealPlan.Text = "";
                //BtnUpdate.Enabled = false;
                return;
            }
            CmbboxWrkngHtlMealPlan.Items.AddRange(new String[] { "SELECT MEAL TYPE", "EPAI", "CPAI", "MAPAI", "APAI" });
            CmbboxWrkngHtlMealPlan.SelectedIndex = 0;
        }

        private void CmbboxWrkngHtlMealPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((CmbboxWrkngHtlMealPlan.SelectedIndex == 0)/* || (CmbboxWrkngHtlMealPlan.SelectedValue == null)*/)
            {
                //BtnUpdate.Enabled = false;
                return;
            }
            //BtnUpdate.Enabled = true;
        }

        private void dateTimePickerCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerCheckOutDate.MinDate = dateTimePickerCheckInDate.Value;
        }

        private bool ValidateInputFields()
        {
            bool result = true;
            string errorString = "Following Error occurs\n";
            if ((CmbboxWrkngHtlMealPlan.SelectedIndex == 0) || CmbboxWrkngHtlMealPlan.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "MEAL PLAN IS NOT SELECTED.\n";
            }

            if (txtBoxConfirmedBy.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "CONFIRMED BY FIELD IS EMPTY.\n";
            }

            if (numericUpDownRoomCount.Value == 0)
            {
                result = false;
                errorString = errorString + "ROOM COUNT IS 0.\n";
            }

            if (txtBoxConfirmationId.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "CONFIRMATION ID FIELD IS EMPTY.\n";
            }

            if (txtBoxLeadPsngrName.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "LEAD PASSANGER FIELD IS EMPTY.\n";
            }

            if (txtBoxBookingPrice.Text.Equals(""))
            {
                result = false;
                errorString = errorString + "BOOKING PRICE FIELD IS EMPTY.\n";
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtBoxBookingPrice.Text);
                }
                catch (Exception errPrice)
                {
                    errorString = errorString + "INCORRECT BOOKING PRICE (error = " + errPrice.Message + ")";
                }
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

            string table = "hotelbookinginfo";
            // prepare insert query for flight
            mysqlInsertQueryString = "INSERT INTO `" + table + "` ( " +
                "`queryid`, " +
                "`idconfirmation`, " +
                "`idhotelinfo`, " +
                "`confirmby`, " +
                "`checkindate`, " +
                "`checkoutdate`, " +
                "`bookingprice`, " +
                "`leadpassangername`, " +
                "`roomtype`, " +
                "`mealplan`, " +
                "`countroom`, " +
                "`countadults`, " +
                "`countchildren`, " +
                "`countinfants` " +
                ") VALUES ( " +
                "@var_queryid, " +
                "@var_idconfirmation, " +
                "@var_idhotelinfo, " +
                "@var_confirmby, " +
                "@var_checkindate, " +
                "@var_checkoutdate, " +
                "@var_bookingprice, " +
                "@var_leadpassangername, " +
                "@var_roomtype, " +
                "@var_mealplan, " +
                "@var_countroom, " +
                "@var_countadults, " +
                "@var_countchildren, " +
                "@var_countinfants " +
                ")";
            mySqlCommand.CommandText = mysqlInsertQueryString;
            mySqlCommand.Prepare();
            mySqlCommand.Parameters.AddWithValue("@var_queryid", "Text");
            mySqlCommand.Parameters["@var_queryid"].Value = queryId;
            mySqlCommand.Parameters.AddWithValue("@var_idconfirmation", "Text");
            mySqlCommand.Parameters["@var_idconfirmation"].Value = txtBoxConfirmationId.Text;
            mySqlCommand.Parameters.AddWithValue("@var_idhotelinfo", 1);
            mySqlCommand.Parameters["@var_idhotelinfo"].Value = CmbboxWrkngHtlHotel.SelectedValue;
            mySqlCommand.Parameters.AddWithValue("@var_confirmby", "Text");
            mySqlCommand.Parameters["@var_confirmby"].Value = txtBoxConfirmedBy.Text;
            mySqlCommand.Parameters.AddWithValue("@var_checkindate", "Text");
            mySqlCommand.Parameters["@var_checkindate"].Value = dateTimePickerCheckInDate.Value.ToString("yyyy-MM-dd") +
                " " + dateTimePickerPickUp.Value.ToString("HH:mm:ss");
            mySqlCommand.Parameters.AddWithValue("@var_checkoutdate", "Text");
            mySqlCommand.Parameters["@var_checkoutdate"].Value = dateTimePickerCheckOutDate.Value.ToString("yyyy-MM-dd") +
                " " + dateTimePickerDropOff.Value.ToString("HH:mm:ss");
            mySqlCommand.Parameters.AddWithValue("@var_bookingprice", 1);
            mySqlCommand.Parameters["@var_bookingprice"].Value = Convert.ToInt32(txtBoxBookingPrice.Text);
            mySqlCommand.Parameters.AddWithValue("@var_leadpassangername", "Text");
            mySqlCommand.Parameters["@var_leadpassangername"].Value = txtBoxLeadPsngrName.Text;
            mySqlCommand.Parameters.AddWithValue("@var_roomtype", "Text");
            mySqlCommand.Parameters["@var_roomtype"].Value = CmbboxWrkngHtlRoomType.Text;
            mySqlCommand.Parameters.AddWithValue("@var_mealplan", "Text");
            mySqlCommand.Parameters["@var_mealplan"].Value = CmbboxWrkngHtlMealPlan.Text;
            mySqlCommand.Parameters.AddWithValue("@var_countroom", 1);
            mySqlCommand.Parameters["@var_countroom"].Value = numericUpDownRoomCount.Value;
            mySqlCommand.Parameters.AddWithValue("@var_countadults", 1);
            mySqlCommand.Parameters["@var_countadults"].Value = numericUpDownAdults.Value;
            mySqlCommand.Parameters.AddWithValue("@var_countchildren", 1);
            mySqlCommand.Parameters["@var_countchildren"].Value = numericUpDownChildren.Value;
            mySqlCommand.Parameters.AddWithValue("@var_countinfants", 1);
            mySqlCommand.Parameters["@var_countinfants"].Value = numericUpDownInfants.Value;

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
            FrmVouchersWorkingHotelPage_Load(null, null);
        }
    }
}
