﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace TourQueryManager
{
    public partial class FrmQueryWorkingPage : Form
    {
     

        static string queryIdWorking = null;
        static string mysqlConnStr = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection mySqlConnection = new MySqlConnection(mysqlConnStr);
        MySqlDataAdapter mysqlDataAdaptor = new MySqlDataAdapter();
        DataSet frmQueryWorkingDataSet = null;
        MySqlCommand command = new MySqlCommand();
        
        public FrmQueryWorkingPage(string queryId)
        {
            InitializeComponent();
            queryIdWorking = queryId;
        }

        
        /// <summary>
        /// This will reset the page 
        /// </summary>
        private void FrmQueryWorkingPage_Refresh()
        {
            CmbboxWrkngHtlSector_Reload();
            dataGridViewRoomsInfo.Rows.Clear();
            dataGridViewRoomsInfo.Refresh();
            btnWorkingAddRoom.Text = "ADD HOTEL ROOM";
            checkBoxTravelDetails.Checked = false;
            grpboxTravelDetails.Enabled = false;
            numericUpDownNoOfCars.Value = 0;
            CmbboxWrkngCarType.SelectedIndex = 0;
            CmbboxWrkngCarPurpose.SelectedIndex = 0;
            txtboxWorkingFlightCost.Text = "0";
            checkBoxFlightDetails.Checked = false;
            groupBoxFlightDetails.Enabled = false;
            txtBoxFlightNo.Text = "";
            txtboxFlightFromCity.Text = "";
            txtboxFlightToCity.Text = "";
            txtBoxFlightPrice.Text = "0";
            chkBoxWorkingGuide.Checked = false;
            chkBoxWorkingSim.Checked = false;
            txtboxWorkingAdditionalCost.Text = "0";
            txtboxNarrationHeader.Text = "";
            txtboxNarration.Text = "";
            txtboxTourInclusions.Enabled = false;
            chkBoxTourInclusions.Checked = false;
        }

        private void FrmQueryWorkingPage_Load(object sender, EventArgs e)
        {
            /* data to be initialized when loading page */
            Text = "Working on QUERYID (" + queryIdWorking + ")";
            
           
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

           
           
            frmQueryWorkingDataSet = new DataSet();
            string mysqlSelectQueryStr = "SELECT * FROM `queries` WHERE `queryid` = " + queryIdWorking + "";
            command.Connection = mySqlConnection;
            command.CommandText = mysqlSelectQueryStr;
            try
            {
                mysqlDataAdaptor.SelectCommand = command;
               
                mysqlDataAdaptor.Fill(frmQueryWorkingDataSet, "QUERYID_DATA");
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
            }
            string querydetails = "";
            querydetails = querydetails + "QUERY START DATE = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["querystartdate"].ToString();
            querydetails = querydetails + "\r\nPLACE = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["place"].ToString();
            querydetails = querydetails + "\r\nDESTINATION COVERED = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["destinationcovered"].ToString();
            querydetails = querydetails + "\r\nFROM DATE = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["fromdate"].ToString();
            querydetails = querydetails + "\r\nTO DATE = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["todate"].ToString();
            querydetails = querydetails + "\r\nADULTS = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["adults"].ToString();
            querydetails = querydetails + "\r\nCHILDREN = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["children"].ToString();
            querydetails = querydetails + "\r\nBABIES = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["babies"].ToString();
            querydetails = querydetails + "\r\nROOM COUNT = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["roomcount"].ToString();
            querydetails = querydetails + "\r\nMEAL = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["meal"].ToString();
            querydetails = querydetails + "\r\nHOTEL CATEGORY = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["hotelcategory"].ToString();
            querydetails = querydetails + "\r\nARRIVAL DATE = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["arrivaldate"].ToString();
            querydetails = querydetails + "\r\nDEPARTURE DATE = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["departuredate"].ToString();
            querydetails = querydetails + "\r\nARRIVAL CITY = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["arrivalcity"].ToString();
            querydetails = querydetails + "\r\nDEPARTURE CITY = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["departurecity"].ToString();
            querydetails = querydetails + "\r\nVEHICAL CATEGORY = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["vehicalcategory"].ToString();
            querydetails = querydetails + "\r\nREQUIREMENT = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["requirement"].ToString();
            querydetails = querydetails + "\r\nBUDGET = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["budget"].ToString();
            querydetails = querydetails + "\r\nNOTE = " + frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["note"].ToString();
            querydetails = querydetails + "";
            txtboxQueryDetails.Text = querydetails;
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
            FrmQueryWorkingPage_Refresh();
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception errReleaseObj)
            {
                Debug.WriteLine("Error in releasing object :: " + errReleaseObj.Message);
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void FrmQueryWorkingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
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
            btnWorkingAddRoom.Enabled = false;
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
            string seasonyear = dateTimePickerWorkingArrivalDate.Value.ToString("yyyy");
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
                    "`T2`.mealcpaipricesingle AS `CPAI SINGLE`, " +
                    "`T2`.mealcpaipricedouble AS `CPAI DOUBLE`, " +
                    "`T2`.mealcpaipriceextbed AS `CPAI TRIPLE`, " +
                    "`T2`.mealepaipricesingle AS `EPAI SINGLE`, " +
                    "`T2`.mealepaipricedouble AS `EPAI DOUBLE`, " +
                    "`T2`.mealepaipriceextbed AS `EPAI TRIPLE`, " +
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

            string seasonyear = dateTimePickerWorkingArrivalDate.Value.ToString("yyyy");
            string selectQueryString = "SELECT DISTINCT `roomtype` FROM `hotelrates` WHERE " +
                "`idhotelinfo` = " + CmbboxWrkngHtlHotel.SelectedValue + " " +
                "AND `seasonyear` = " + seasonyear +" ORDER BY `roomtype`";
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
            if ((CmbboxWrkngHtlRoomType.SelectedIndex == 0) || (CmbboxWrkngHtlRoomType.SelectedValue == null))
            {
                CmbboxWrkngSeasonType.SelectedValue = 0;
                CmbboxWrkngSeasonType.DataSource = null;
                CmbboxWrkngSeasonType.Text = "";
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

            string seasonyear = dateTimePickerWorkingArrivalDate.Value.ToString("yyyy");
            string selectQueryString = "SELECT DISTINCT `seasontype` FROM `hotelrates` WHERE " +
                "`idhotelinfo` = " + CmbboxWrkngHtlHotel.SelectedValue + " " +
                "AND `seasonyear` = " + seasonyear + " " +
                "AND `roomtype` = '" + CmbboxWrkngHtlRoomType.Text +"' " +
                "ORDER BY `seasontype`";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQueryString, mySqlConnection);
            DataSet dataSet = new DataSet();
            try
            {
                mySqlDataAdapter.Fill(dataSet, "HOTEL_SEASON_TYPE");
                if (dataSet != null)
                {
                    string zeroIndexString = "";
                    if (dataSet.Tables["HOTEL_SEASON_TYPE"].Rows.Count == 0)
                    {
                        zeroIndexString = "NOT EXIST FOR " + seasonyear;
                    }
                    else
                    {
                        zeroIndexString = "SELECT SEASON";
                    }
                    DataRow dataRow = dataSet.Tables["HOTEL_SEASON_TYPE"].NewRow();
                    dataRow["seasontype"] = zeroIndexString;
                    dataSet.Tables["HOTEL_SEASON_TYPE"].Rows.InsertAt(dataRow, 0);
                    CmbboxWrkngSeasonType.DataSource = dataSet.Tables["HOTEL_SEASON_TYPE"];
                    CmbboxWrkngSeasonType.ValueMember = "seasontype";
                    CmbboxWrkngSeasonType.DisplayMember = "seasontype";
                    CmbboxWrkngSeasonType.SelectedIndex = 0;
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

        private void CmbboxWrkngSeasonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbboxWrkngHtlMealPlan.Items.Clear();
            if ((CmbboxWrkngSeasonType.SelectedIndex == 0) || (CmbboxWrkngSeasonType.SelectedValue == null))
            {
                CmbboxWrkngHtlMealPlan.Text = "";
                btnWorkingAddRoom.Enabled = false;
                return;
            }
            CmbboxWrkngHtlMealPlan.Items.AddRange(new String[] { "SELECT MEAL TYPE", "EPAI", "CPAI", "MAPAI", "APAI" });
            CmbboxWrkngHtlMealPlan.SelectedIndex = 0;
        }

        private void CmbboxWrkngHtlMealPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((CmbboxWrkngHtlMealPlan.SelectedIndex == 0)/* || (CmbboxWrkngHtlMealPlan.SelectedValue == null)*/)
            {
                btnWorkingAddRoom.Enabled = false;
                return;
            }
            btnWorkingAddRoom.Enabled = true;
        }

        private void btnWorkingAddRoom_Click(object sender, EventArgs e)
        {
            /* check for the uniqueness of the hotel rating */
            for (int index = 0; index < dataGridViewRoomsInfo.RowCount; index++)
            {
                if (string.Equals(dataGridViewRoomsInfo.Rows[index].Cells["hotelRating"].Value.ToString(), CmbboxWrkngHtlHotelRating.Text))
                {
                    MessageBox.Show("Multiple entries for " + CmbboxWrkngHtlHotelRating.Text + " is not allowed.", "Error: multiple entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            /* select rates of the room type depending on the year, selected season, meal plan and roomtype. */
            string mealPlanSelectString = "";
            switch (CmbboxWrkngHtlMealPlan.SelectedIndex)
            {
                case 1:
                    mealPlanSelectString = "`mealepaipricesingle` as `pricesingle`, `mealepaipricedouble` as `pricedouble`, `mealepaipriceextbed` as `priceextbed`";
                    break;
                case 2:
                    mealPlanSelectString = "`mealcpaipricesingle` as `pricesingle`, `mealcpaipricedouble` as `pricedouble`, `mealcpaipriceextbed` as `priceextbed`";
                    break;
                case 3:
                    mealPlanSelectString = "`mealmapaipricesingle` as `pricesingle`, `mealmapaipricedouble` as `pricedouble`, `mealmapaipriceextbed` as `priceextbed`";
                    break;
                case 4:
                    mealPlanSelectString = "`mealapaipricesingle` as `pricesingle`, `mealapaipricedouble` as `pricedouble`, `mealapaipriceextbed` as `priceextbed`";
                    break;
                default:
                    MessageBox.Show("SELECT PROPER MEAL PLAN FIRST", "SELECT MEAL PLAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


            string seasonyear = dateTimePickerWorkingArrivalDate.Value.ToString("yyyy");
            string selectQueryString = "SELECT " + mealPlanSelectString +
                " FROM  `hotelrates`  WHERE " +
                "`idhotelinfo` = " + CmbboxWrkngHtlHotel.SelectedValue + " " +
                "AND `roomtype` = '" + CmbboxWrkngHtlRoomType.Text + "' " +
                "AND `seasontype` = '" + CmbboxWrkngSeasonType.Text + "' " +
                "AND `seasonyear` = '" + seasonyear + "' ";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQueryString, mySqlConnection);
            DataSet dataSet = new DataSet();
            try
            {
                mySqlDataAdapter.Fill(dataSet, "HOTEL_ROOM_RATES");
                if (dataSet != null)
                {
                    if (dataSet.Tables["HOTEL_ROOM_RATES"].Rows.Count > 0)
                    {
                        /* query gets successfully executed */
                        int index = dataGridViewRoomsInfo.Rows.Add();
                        dataGridViewRoomsInfo.Rows[index].Cells["hotelRating"].Value = CmbboxWrkngHtlHotelRating.Text;
                        dataGridViewRoomsInfo.Rows[index].Cells["HotelId"].Value = CmbboxWrkngHtlHotel.SelectedValue.ToString();
                        dataGridViewRoomsInfo.Rows[index].Cells["wrkRoomType"].Value = CmbboxWrkngHtlRoomType.Text;
                        dataGridViewRoomsInfo.Rows[index].Cells["wrkMealPlan"].Value = CmbboxWrkngHtlMealPlan.Text;
                        dataGridViewRoomsInfo.Rows[index].Cells["HotelSingleBedPrice"].Value = dataSet.Tables["HOTEL_ROOM_RATES"].Rows[0]["pricesingle"].ToString();
                        dataGridViewRoomsInfo.Rows[index].Cells["HotelDoubleShairingPrice"].Value = dataSet.Tables["HOTEL_ROOM_RATES"].Rows[0]["pricedouble"].ToString();
                        dataGridViewRoomsInfo.Rows[index].Cells["HotelExtraBedPrice"].Value = dataSet.Tables["HOTEL_ROOM_RATES"].Rows[0]["priceextbed"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Price not present in for\n hotel = " + CmbboxWrkngHtlHotel.Text + 
                            ",\n season = " + CmbboxWrkngSeasonType.Text +
                            " and\n year = " + seasonyear +
                            ".\n PLease check the rates table first", "Price not present", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Price not present in for the selected HOTEL , season, and year. PLease check the rates table first", "Price not present", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // instead of reseting whole sector reset just hotel rating.
            CmbboxWrkngHtlHotelRating.SelectedIndex = 0;
            if (dataGridViewRoomsInfo.Rows.Count > 0)
            {
                btnWorkingAddRoom.Text = "ADD DIFFERENT HOTEL ENTRY FOR SAME DAY";
            }
            else
            {
                btnWorkingAddRoom.Text = "ADD HOTEL ENTRY";
            }
        }

        /// <summary>
        /// this will check for the values present in the form
        /// </summary>
        /// <returns>
        /// true: if all fields are ok.
        /// false: otherwise
        /// </returns>
        private bool ValidateWorkingFields()
        {
            /* validate date */
            if (DateTime.Today >= dateTimePickerWorkingArrivalDate.Value.Date)
            {
                MessageBox.Show("Date cannot be of less than or equal to Today's date", "Error in date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            /* validate no of persons */
            if (numericUpDownNoOfPersons.Value < 1)
            {
                MessageBox.Show("Atleast 1 person is mendatory", "In sufficient person count", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            /* validate rooms in hotel */
            if (dataGridViewRoomsInfo.RowCount < 1)
            {
                MessageBox.Show("Atleast 1 entry is mendatory in Hotel Grid info", "In sufficient hotels count", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            /* validate if travel selected */
            if (checkBoxTravelDetails.Checked)
            {
                if (numericUpDownNoOfCars.Value < 1)
                {
                    MessageBox.Show("Atleast 1 car is mendatory ", "In sufficient car count", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (CmbboxWrkngCarType.SelectedIndex < 1)
                {
                    MessageBox.Show("Select car type first", "Car type not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (CmbboxWrkngCarPurpose.SelectedIndex < 1)
                {
                    MessageBox.Show("Car purpose is not selected", "Car purpose not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.Equals(txtboxWorkingFlightCost.Text, ""))
                {
                    MessageBox.Show("Car cost field is empty", "Car cost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                try
                {
                    if (Convert.ToInt32(txtboxWorkingFlightCost.Text) < 1)
                    {
                        MessageBox.Show("Car cost is 0", "Car cost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception errcost)
                {
                    MessageBox.Show("Car cost field is not proper: " + errcost.Message , "Car cost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            /* check for flights */
            if (checkBoxFlightDetails.Checked)
            {
                if (string.Equals(txtBoxFlightNo.Text, ""))
                {
                    MessageBox.Show("Flight number is not provided", "Flight number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.Equals(txtboxFlightFromCity.Text, ""))
                {
                    MessageBox.Show("Flight from city is not provided", "Flight from city", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.Equals(txtboxFlightToCity.Text, ""))
                {
                    MessageBox.Show("Flight to city is not provided", "Flight to city", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.Equals(txtBoxFlightPrice.Text,""))
                {
                    MessageBox.Show("Flight cost field is not provided", "Flight cost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                try
                {
                    if (Convert.ToInt32(txtBoxFlightPrice.Text) < 1)
                    {
                        MessageBox.Show("Flight cost is 0", "Flight cost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception errcost)
                {
                    MessageBox.Show("Flight cost field is not proper: " + errcost.Message, "Flight cost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // validate extra cost
            try
            {
                if (Convert.ToInt32(txtboxWorkingAdditionalCost.Text) < 1)
                {
                    txtboxWorkingAdditionalCost.Text = "0";
                }
            }
            catch (Exception errcost)
            {
                MessageBox.Show("Additional cost field is not proper: " + errcost.Message, "Additional cost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // validate narration hdr and narration field.
            if (string.Equals(txtboxNarrationHeader.Text, ""))
            {
                MessageBox.Show("Tour day narration header is not provided", "Narration header", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.Equals(txtboxNarration.Text, ""))
            {
                MessageBox.Show("Tour day narration is not provided", "Narration text", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (chkBoxTourInclusions.Checked)
            {
                if (string.Equals(txtboxTourInclusions.Text, ""))
                {
                    MessageBox.Show("Tour inclusion field is not provided", "Flight cost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            // All checked now return success
            return true;
        }

        /// <summary>
        /// This will update the data from working page to database
        /// </summary>
        private bool UpdateDayWorkingInDatabase()
        {
            /* update database */
            bool isSuccessResult = true;
            string mysqlInsertQueryString = "";
            string dateString = dateTimePickerWorkingArrivalDate.Value.ToString("yyyy-MM-dd") +
                " " + dttmpkrWorkingArvlTime.Value.ToString("HH:mm:ss");
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception errConnOpen)
            {
                MessageBox.Show("Error in opening mysql connection because " + errConnOpen.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return false;
            }
            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            MySqlTransaction mySqlTransaction = mySqlConnection.BeginTransaction();
            mySqlCommand.Connection = mySqlConnection;
            mySqlCommand.Transaction = mySqlTransaction;
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.Parameters.AddWithValue("@var_queryid", "Text");
            mySqlCommand.Parameters.AddWithValue("@var_dayno", 1);
            mySqlCommand.Parameters.AddWithValue("@var_date", "Text");
            mySqlCommand.Parameters["@var_queryid"].Value = queryIdWorking;
            mySqlCommand.Parameters["@var_dayno"].Value = Convert.ToInt32(lblDayCounter.Text);
            mySqlCommand.Parameters["@var_date"].Value = dateString;

            // prepare insert query for working day
            mysqlInsertQueryString = "INSERT INTO `queryworkingday` ( " +
                "`queryid`, " +
                "`dayno`, " +
                "`date`, " +
                "`narrationhdr`, " +
                "`narration`, " +
                "`tourinclusions`, " +
                "`sim`, " +
                "`guide`, " +
                "`additionalcost` " +
                ") VALUES ( " +
                "@var_queryid, " +
                "@var_dayno, " +
                "@var_date, " +
                "@var_narrationhdr, " +
                "@var_narration, " +
                "@var_tourinclusions, " +
                "@var_sim, " +
                "@var_guide, " +
                "@var_additionalcost " +
                ")";
            mySqlCommand.CommandText = mysqlInsertQueryString;
            mySqlCommand.Prepare();
            mySqlCommand.Parameters.AddWithValue("@var_narrationhdr", "Text");
            mySqlCommand.Parameters.AddWithValue("@var_narration", "Text");
            mySqlCommand.Parameters.AddWithValue("@var_tourinclusions", "Text");
            mySqlCommand.Parameters.AddWithValue("@var_sim", "Text");
            mySqlCommand.Parameters.AddWithValue("@var_guide", "Text");
            mySqlCommand.Parameters.AddWithValue("@var_additionalcost", 1);

            mySqlCommand.Parameters["@var_narrationhdr"].Value = txtboxNarrationHeader.Text;
            mySqlCommand.Parameters["@var_narration"].Value = txtboxNarration.Text;
            mySqlCommand.Parameters["@var_tourinclusions"].Value = txtboxTourInclusions.Text;
            mySqlCommand.Parameters["@var_sim"].Value = chkBoxWorkingSim.Checked ? "YES" : "NO";
            mySqlCommand.Parameters["@var_guide"].Value = chkBoxWorkingGuide.Checked ? "YES" : "NO";
            mySqlCommand.Parameters["@var_additionalcost"].Value = Convert.ToInt32(txtboxWorkingAdditionalCost.Text);
            try
            {
                int result = mySqlCommand.ExecuteNonQuery();
                Debug.WriteLine("queryworkingday: Query Executed. with result = " + result.ToString(), "Days data insertion success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception errquery)
            {
                isSuccessResult = false;
                MessageBox.Show("queryworkingday:Error while executing insert query because:\n" + errquery.Message, "Error in inserting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // prepare insert query for working hotel
            if (isSuccessResult)
            {
                mysqlInsertQueryString = "INSERT INTO `queryworkinghotel` ( " +
                    "`idqueryworkingday`, " +
                    "`queryid`, " +
                    "`hotelrating`, " +
                    "`idhotelinfo`, " +
                    "`date`, " +
                    "`roomtype`, " +
                    "`mealplan`, " +
                    "`singlebedprice`, " +
                    "`doublebedprice`, " +
                    "`extrabedprice`, " +
                    "`note` " +
                    ") VALUES ( " +
                    "(SELECT `idqueryworkingday` FROM `queryworkingday` WHERE `queryid` = @var_queryid AND `dayno` = @var_dayno), " +
                    "@var_queryid, " +
                    "@var_hotelrating, " +
                    "@var_idhotelinfo, " +
                    "@var_date, " +
                    "@var_roomtype, " +
                    "@var_mealplan, " +
                    "@var_singlebedprice, " +
                    "@var_doublebedprice, " +
                    "@var_extrabedprice, " +
                    "@var_note " +
                    ")";
                mySqlCommand.CommandText = mysqlInsertQueryString;
                mySqlCommand.Prepare();
                mySqlCommand.Parameters.AddWithValue("@var_hotelrating", "Text");
                mySqlCommand.Parameters.AddWithValue("@var_idhotelinfo", 1);
                mySqlCommand.Parameters.AddWithValue("@var_roomtype", "Text");
                mySqlCommand.Parameters.AddWithValue("@var_mealplan", "Text");
                mySqlCommand.Parameters.AddWithValue("@var_singlebedprice", 1);
                mySqlCommand.Parameters.AddWithValue("@var_doublebedprice", 1);
                mySqlCommand.Parameters.AddWithValue("@var_extrabedprice", 1);
                mySqlCommand.Parameters.AddWithValue("@var_note", "Text");
                for (int index = 0; index < dataGridViewRoomsInfo.RowCount; index++)
                {
                    mySqlCommand.Parameters["@var_hotelrating"].Value = dataGridViewRoomsInfo.Rows[index].Cells["hotelRating"].Value.ToString();
                    mySqlCommand.Parameters["@var_idhotelinfo"].Value = Convert.ToInt32(dataGridViewRoomsInfo.Rows[index].Cells["HotelId"].Value.ToString());
                    mySqlCommand.Parameters["@var_roomtype"].Value = dataGridViewRoomsInfo.Rows[index].Cells["wrkRoomType"].Value.ToString();
                    mySqlCommand.Parameters["@var_mealplan"].Value = dataGridViewRoomsInfo.Rows[index].Cells["wrkMealPlan"].Value.ToString();
                    mySqlCommand.Parameters["@var_singlebedprice"].Value = Convert.ToInt32(dataGridViewRoomsInfo.Rows[index].Cells["HotelSingleBedPrice"].Value.ToString());
                    mySqlCommand.Parameters["@var_doublebedprice"].Value = Convert.ToInt32(dataGridViewRoomsInfo.Rows[index].Cells["HotelDoubleShairingPrice"].Value.ToString());
                    mySqlCommand.Parameters["@var_extrabedprice"].Value = Convert.ToInt32(dataGridViewRoomsInfo.Rows[index].Cells["HotelExtraBedPrice"].Value.ToString());
                    mySqlCommand.Parameters["@var_note"].Value = "NOTE:_" + index.ToString() + "_" + dateString + "_" + queryIdWorking;
                    try
                    {
                        int result = mySqlCommand.ExecuteNonQuery();
                        Debug.WriteLine("queryworkinghotel:Query for " + "NOTE:_" + index.ToString() + "_" + dateString + "_" + queryIdWorking + "\nExecuted with result = " + result.ToString(), "Days data insertion success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception errquery)
                    {
                        isSuccessResult = false;
                        MessageBox.Show("queryworkinghotel Query for " + "NOTE:_" + index.ToString() + "_" + dateString + "_" + queryIdWorking + ": Error while executing insert query because:\n" + errquery.Message, "Error in inserting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // prepare travel details if checked
            if (isSuccessResult)
            {
                if (checkBoxTravelDetails.Checked)
                {
                    mysqlInsertQueryString = "INSERT INTO `queryworkingtravel` ( " +
                    "`idqueryworkingday`, " +
                    "`queryid`, " +
                    "`date`, " +
                    "`cartype`, " +
                    "`carcount`, " +
                    "`pricepercar`, " +
                    "`carhirefor`, " +
                    "`note` " +
                    ") VALUES ( " +
                    "(SELECT `idqueryworkingday` FROM `queryworkingday` WHERE `queryid` = @var_queryid AND `dayno` = @var_dayno), " +
                    "@var_queryid, " +
                    "@var_date, " +
                    "@var_cartype, " +
                    "@var_carcount, " +
                    "@var_pricepercar, " +
                    "@var_carhirefor, " +
                    "@var_note " +
                    ")";
                    mySqlCommand.CommandText = mysqlInsertQueryString;
                    mySqlCommand.Prepare();
                    mySqlCommand.Parameters.AddWithValue("@var_cartype", "Text");
                    mySqlCommand.Parameters.AddWithValue("@var_carcount", 1);
                    mySqlCommand.Parameters.AddWithValue("@var_pricepercar", 1);
                    mySqlCommand.Parameters.AddWithValue("@var_carhirefor", "Text");
                    mySqlCommand.Parameters["@var_cartype"].Value = CmbboxWrkngCarType.Text;
                    mySqlCommand.Parameters["@var_carcount"].Value = Convert.ToInt32(numericUpDownNoOfCars.Value);
                    mySqlCommand.Parameters["@var_pricepercar"].Value = Convert.ToInt32(txtboxWorkingFlightCost.Text);
                    mySqlCommand.Parameters["@var_carhirefor"].Value = CmbboxWrkngCarPurpose.Text;
                    mySqlCommand.Parameters["@var_note"].Value = "NOTE for " + queryIdWorking;
                    try
                    {
                        int result = mySqlCommand.ExecuteNonQuery();
                        Debug.WriteLine("queryworkingtravel : Query Executed. with result = " + result.ToString(), "Days data insertion success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception errquery)
                    {
                        isSuccessResult = false;
                        MessageBox.Show("queryworkingtravel : Error while executing insert query because:\n" + errquery.Message, "Error in inserting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // prepare insert query string for flight.
            if (isSuccessResult)
            {
                if (checkBoxFlightDetails.Checked)
                {
                    mysqlInsertQueryString = "INSERT INTO `queryworkingflight` ( " +
                    "`idqueryworkingday`, " +
                    "`queryid`, " +
                    "`date`, " +
                    "`fromcity`, " +
                    "`tocity`, " +
                    "`flightnumber`, " +
                    "`rateperticket`, " +
                    "`personcount`, " +
                    "`note` " +
                    ") VALUES ( " +
                    "(SELECT `idqueryworkingday` FROM `queryworkingday` WHERE `queryid` = @var_queryid AND `dayno` = @var_dayno), " +
                    "@var_queryid, " +
                    "@var_date, " +
                    "@var_fromcity, " +
                    "@var_tocity, " +
                    "@var_flightnumber, " +
                    "@var_rateperticket, " +
                    "@var_personcount, " +
                    "@var_note " +
                    ")";
                    mySqlCommand.CommandText = mysqlInsertQueryString;
                    mySqlCommand.Prepare();
                    mySqlCommand.Parameters.AddWithValue("@var_fromcity", "Text");
                    mySqlCommand.Parameters.AddWithValue("@var_toCity", "Text");
                    mySqlCommand.Parameters.AddWithValue("@var_flightnumber", "Text");
                    mySqlCommand.Parameters.AddWithValue("@var_rateperticket", 1);
                    mySqlCommand.Parameters.AddWithValue("@var_personcount", 1);
                    mySqlCommand.Parameters["@var_fromcity"].Value = txtboxFlightFromCity.Text;
                    mySqlCommand.Parameters["@var_tocity"].Value = txtboxFlightToCity.Text;
                    mySqlCommand.Parameters["@var_flightnumber"].Value = txtBoxFlightNo.Text;
                    mySqlCommand.Parameters["@var_rateperticket"].Value = Convert.ToInt32(txtBoxFlightPrice.Text);
                    mySqlCommand.Parameters["@var_personcount"].Value = Convert.ToInt32(numericUpDownNoOfPersons.Value);
                    mySqlCommand.Parameters["@var_note"].Value = "NOTE for " + queryIdWorking;
                    try
                    {
                        int result = mySqlCommand.ExecuteNonQuery();
                        Debug.WriteLine("queryworkingflight : Query Executed. with result = " + result.ToString(), "Days data insertion success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception errquery)
                    {
                        isSuccessResult = false;
                        MessageBox.Show("queryworkingflight : Error while executing insert query because:\n" + errquery.Message, "Error in inserting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // now commit the changes done in the database.
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
                if (isSuccessResult)
                {
                    mySqlTransaction.Rollback();
                    mySqlTransaction.Dispose();
                }
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
            return isSuccessResult;
        }

        private void buttonHotelAddRow_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePickerWorkingArrivalDate.Value.AddDays(-1).ToString("yyyy-MM-dd"), "Date", MessageBoxButtons.OK, MessageBoxIcon.Hand); return;
            if (ValidateWorkingFields())
            {
                if (UpdateDayWorkingInDatabase())
                {
                    if (string.Equals(lblDayCounter.Text, "1"))
                    {
                        UpdateQueryState(2, dateTimePickerWorkingArrivalDate.Value.ToString("yyyy-MM-dd"));
                        if (numericUpDownNoOfPersons.Value != (Convert.ToInt32(frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["adults"]) + Convert.ToInt32(frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["children"])))
                        {
                            DialogResult dialogResult = MessageBox.Show("Person counts differ from that of query. Update person count in original query", "Person Count Differ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                UpdateQueryState(4, numericUpDownNoOfPersons.Value.ToString());
                            }
                            else
                            {
                                Debug.WriteLine("Person count not updated");
                            }
                        }
                    }
                    int dayNo = Convert.ToInt32(lblDayCounter.Text);
                    /* increament the date and day no.*/
                    lblDayCounter.Text = (dayNo + 1).ToString();
                    DateTime dateTime = dateTimePickerWorkingArrivalDate.Value;
                    dateTimePickerWorkingArrivalDate.Value = dateTime.AddDays(1);
                    dateTimePickerWorkingArrivalDate.Enabled = false;
                    numericUpDownNoOfPersons.Enabled = false;
                    FrmQueryWorkingPage_Refresh();
                }
            }
        }

        private void UpdateQueryState(int caseFlag, string updateString)
        {
            bool isSuccessResult = true;
            string mysqlUpdateQueryString = "";
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
            mySqlCommand.Parameters.AddWithValue("@var_queryid", "Text");
            mySqlCommand.Parameters["@var_queryid"].Value = queryIdWorking;
            

            switch (caseFlag)
            {
                case 1:
                    mysqlUpdateQueryString = "UPDATE `queries` SET " +
                    "`querylastupdatetime` = NOW(), " +
                    "`querycurrentstate` = @var_querycurrentstate " +
                    "WHERE " +
                    "`queryid` = @var_queryid";
                    mySqlCommand.Parameters.AddWithValue("@var_querycurrentstate", 1);
                    mySqlCommand.Parameters["@var_querycurrentstate"].Value = Convert.ToInt32(updateString);
                    break;
                case 2:
                    mysqlUpdateQueryString = "UPDATE `queries` SET " +
                    "`querylastupdatetime` = NOW(), " +
                    "`fromdate` = @var_date " +
                    "WHERE " +
                    "`queryid` = @var_queryid";
                    mySqlCommand.Parameters.AddWithValue("@var_date", "Text");
                    mySqlCommand.Parameters["@var_date"].Value = updateString;
                    break;
                case 3:
                    mysqlUpdateQueryString = "UPDATE `queries` SET " +
                    "`querylastupdatetime` = NOW(), " +
                    "`todate` = @var_date " +
                    "WHERE " +
                    "`queryid` = @var_queryid";
                    mySqlCommand.Parameters.AddWithValue("@var_date", "Text");
                    mySqlCommand.Parameters["@var_date"].Value = updateString;
                    break;
                case 4:
                    mysqlUpdateQueryString = "UPDATE `queries` SET " +
                    "`querylastupdatetime` = NOW(), " +
                    "`adults` = @var_adults, " +
                    "`children` = 0 " +
                    "WHERE " +
                    "`queryid` = @var_queryid";
                    mySqlCommand.Parameters.AddWithValue("@var_adults", 1);
                    mySqlCommand.Parameters["@var_adults"].Value = updateString;
                    break;
                default:
                    mysqlUpdateQueryString = "UPDATE `queries` SET " +
                    "`querylastupdatetime` = NOW() " +
                    "WHERE " +
                    "`queryid` = @var_queryid";
                    break;
            }

            
            mySqlCommand.CommandText = mysqlUpdateQueryString;
            mySqlCommand.Prepare();
            try
            {
                int result = mySqlCommand.ExecuteNonQuery();
                Debug.WriteLine("queryworkingday: Query Executed. with result = " + result.ToString(), "Days data insertion success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception errquery)
            {
                isSuccessResult = false;
                MessageBox.Show("queryworkingday:Error while executing insert query because:\n" + errquery.Message, "Error in inserting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // now commit the changes done in the database.
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
                if (isSuccessResult)
                {
                    mySqlTransaction.Rollback();
                    mySqlTransaction.Dispose();
                }
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

        private void ButtonWorkingDone_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePickerWorkingArrivalDate.Value;
            if (ValidateWorkingFields())
            {
                if (UpdateDayWorkingInDatabase())
                {
                    /* update state of the query to done by user and then close page */
                    Debug.WriteLine("Update query return success");
                    UpdateQueryState(3, dateTime.ToString("yyyy-MM-dd"));
                    UpdateQueryState(1, Properties.Resources.queryStageDoneByUser);
                    Debug.WriteLine("Closing on success");
                    Close();
                    return;
                }
                Debug.WriteLine("Update query return failure");
            }
            Debug.WriteLine("validation return failure");
            DialogResult dialogResult = MessageBox.Show("Finish with previous date?", "Validation Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (string.Equals(lblDayCounter.Text, "1"))
                {
                    MessageBox.Show("This is first date thus work cannot be finished. Press CANCEL butten to cancel");
                }
                else
                {
                    Debug.WriteLine("Finishing with previous date");
                    
                    /* update state of the query to done by user and then close page */
                    UpdateQueryState(3, dateTime.AddDays(-1).ToString("yyyy-MM-dd"));
                    UpdateQueryState(1, Properties.Resources.queryStageDoneByUser);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Update the page and retry.");
            }
        }

        private void ButtonWorkingCancel_Click(object sender, EventArgs e)
        {
            /* exit while deleting everything from working tables related to this queryid */
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
            mySqlCommand.Parameters.AddWithValue("@var_queryid", "Text");
            mySqlCommand.Parameters["@var_queryid"].Value = queryIdWorking;

            // prepare insert query for working day
            string[] tablenames = { "queryworkingflight", "queryworkinghotel", "queryworkingtravel", "queryworkingday"};
            foreach (var table in tablenames)
            {
                mysqlInsertQueryString = "DELETE FROM `"+ table +"` WHERE `queryid` = @var_queryid";
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
                    break;
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
            Close();
        }

        private void numericUpDownExtraBed_ValueChanged(object sender, EventArgs e)
        {
            /* Check for the person count in the query table. if different then ask for update*/
        }

        private void numericUpDownNoOfCars_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownNoOfCars.Value == 0)
            { CmbboxWrkngCarType.Enabled = false;
                CmbboxWrkngCarPurpose.Enabled = false;
            }
            else
            {
                CmbboxWrkngCarType.Enabled = true;
                CmbboxWrkngCarPurpose.Enabled = true;
            }
        }

        private void dateTimePickerWorkingArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            /* check for the starting date in query. if different then ask for update */
        }

        private void checkBoxTravelDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTravelDetails.Checked)
            {
                grpboxTravelDetails.Enabled = true;
            }
            else
            {
                grpboxTravelDetails.Enabled = false;
            }
        }

        private void checkBoxFlightDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFlightDetails.Checked)
            {
                groupBoxFlightDetails.Enabled = true;
            }
            else
            {
                groupBoxFlightDetails.Enabled = false;
            }
        }

        private void chkBoxTourInclusions_CheckedChanged(object sender, EventArgs e)
        {
            txtboxTourInclusions.Enabled = chkBoxTourInclusions.Checked;
        }
    }
}
