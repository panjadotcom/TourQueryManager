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
    public partial class FrmHotelsPage : Form
    {
        static string mysqlConnectionString = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection mySqlConnection = new MySqlConnection(mysqlConnectionString);
        static Int32 hotelId = 0;
        public FrmHotelsPage()
        {
            InitializeComponent();
        }

        private void FrmHotelsPage_Load(object sender, EventArgs e)
        {
            /*do Something while loading form */
            CmbBoxSector_Reload();
            DataSet dataSet = new DataSet();
            DataTable dataTable = dataSet.Tables.Add("STAR_RATING");
            dataTable.Columns.Add("INDEX");
            dataTable.Columns.Add("STAR");
            DataRow dataRow = dataTable.NewRow();
            dataRow["INDEX"] = "0";
            dataRow["STAR"] = "SELECT HOTEL RATING";
            dataTable.Rows.Add(dataRow);
            dataRow = dataTable.NewRow();
            dataRow["INDEX"] = "1";
            dataRow["STAR"] = "BASIC";
            dataTable.Rows.Add(dataRow);
            dataRow = dataTable.NewRow();
            dataRow["INDEX"] = "2";
            dataRow["STAR"] = "3 STAR";
            dataTable.Rows.Add(dataRow);
            dataRow = dataTable.NewRow();
            dataRow["INDEX"] = "3";
            dataRow["STAR"] = "4 STAR";
            dataTable.Rows.Add(dataRow);
            dataRow = dataTable.NewRow();
            dataRow["INDEX"] = "4";
            dataRow["STAR"] = "5 STAR";
            dataTable.Rows.Add(dataRow);
            CmbBoxStarRating.DataSource = dataTable;
            CmbBoxStarRating.ValueMember = "INDEX";
            CmbBoxStarRating.DisplayMember = "STAR";
            CmbBoxStarRating.SelectedIndex = 0;
            //CmbBoxStarRating.SelectedValue = 0;
            dataTable = dataSet.Tables.Add("SEASON");
            dataTable.Columns.Add("INDEX");
            dataTable.Columns.Add("SEASON");
            dataRow = dataTable.NewRow();
            dataRow["INDEX"] = "0";
            dataRow["SEASON"] = "SELECT SEASON";
            dataTable.Rows.Add(dataRow);
            dataRow = dataTable.NewRow();
            dataRow["INDEX"] = "1";
            dataRow["SEASON"] = "OFF SEASON";
            dataTable.Rows.Add(dataRow);
            dataRow = dataTable.NewRow();
            dataRow["INDEX"] = "2";
            dataRow["SEASON"] = "PEAK SEASON";
            dataTable.Rows.Add(dataRow);
            CmbBoxSeasonType.DataSource = dataTable;
            CmbBoxSeasonType.ValueMember = "INDEX";
            CmbBoxSeasonType.DisplayMember = "SEASON";
            CmbBoxSeasonType.SelectedIndex = 0;
            //CmbBoxSeasonType.SelectedValue = 0;
        }

        private void CmbBoxSector_Reload()
        {
            CmbBoxSector.SelectedValue = 0;
            CmbBoxSector.DataSource = null;
            CmbBoxSector.Text = "";
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception errConnOpen)
            {
                MessageBox.Show("Error in opening mysql connection because " + errConnOpen.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
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
                    dataRow["hotelarea"] = "";
                    dataSet.Tables["HOTEL_AREA"].Rows.InsertAt(dataRow, 0);
                    CmbBoxSector.DataSource = dataSet.Tables["HOTEL_AREA"];
                    CmbBoxSector.ValueMember = "hotelarea";
                    CmbBoxSector.DisplayMember = "hotelarea";
                    CmbBoxSector.SelectedIndex = 0;
                    CmbBoxSector.SelectedValue = 0;
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
            }

            CmbBoxSector.Text = "SELECT SECTOR";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmbBoxSector_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((CmbBoxSector.SelectedIndex == 0) || (CmbBoxSector.SelectedValue == null))
            {
                CmbBoxCity.SelectedValue = 0;
                CmbBoxCity.DataSource = null;
                CmbBoxCity.Text = "";
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
            }
            
            string selectQueryString = "SELECT DISTINCT `hotelcity` FROM `hotelinfo` WHERE `hotelarea` = '"+ CmbBoxSector.SelectedValue.ToString() + "' ORDER BY `hotelcity`";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQueryString, mySqlConnection);
            DataSet dataSet = new DataSet();
            try
            {
                mySqlDataAdapter.Fill(dataSet, "HOTEL_CITY");
                if (dataSet != null)
                {
                    DataRow dataRow = dataSet.Tables["HOTEL_CITY"].NewRow();
                    dataRow["hotelcity"] = "";
                    dataSet.Tables["HOTEL_CITY"].Rows.InsertAt(dataRow, 0);
                    CmbBoxCity.DataSource = dataSet.Tables["HOTEL_CITY"];
                    CmbBoxCity.ValueMember = "hotelcity";
                    CmbBoxCity.DisplayMember = "hotelcity";
                    CmbBoxCity.SelectedIndex = 0;
                    CmbBoxCity.SelectedValue = 0;
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

        private void CmbBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((CmbBoxCity.SelectedIndex == 0) || (CmbBoxCity.SelectedValue == null))
            {
                CmbBoxHotelName.SelectedValue = 0;
                CmbBoxHotelName.DataSource = null;
                CmbBoxHotelName.Text = "";
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
            }

            string selectQueryString = "SELECT DISTINCT `hotelname` FROM `hotelinfo` " +
                "WHERE " +
                "`hotelarea` = '" + CmbBoxSector.SelectedValue.ToString() + "' " +
                "AND `hotelcity` = '" + CmbBoxCity.SelectedValue.ToString() + "' " +
                "ORDER BY `hotelname`";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQueryString, mySqlConnection);
            DataSet dataSet = new DataSet();
            try
            {
                mySqlDataAdapter.Fill(dataSet, "HOTEL_NAME");
                if (dataSet != null)
                {
                    DataRow dataRow = dataSet.Tables["HOTEL_NAME"].NewRow();
                    dataRow["hotelname"] = "";
                    dataSet.Tables["HOTEL_NAME"].Rows.InsertAt(dataRow, 0);
                    CmbBoxHotelName.DataSource = dataSet.Tables["HOTEL_NAME"];
                    CmbBoxHotelName.ValueMember = "hotelname";
                    CmbBoxHotelName.DisplayMember = "hotelname";
                    CmbBoxHotelName.SelectedIndex = 0;
                    CmbBoxHotelName.SelectedValue = 0;
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

        private void CmbBoxHotelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotelId = 0;
            if ((CmbBoxHotelName.SelectedIndex == 0) || (CmbBoxHotelName.SelectedValue == null))
            {
                CmbBoxRoomType.SelectedValue = 0;
                CmbBoxRoomType.DataSource = null;
                CmbBoxRoomType.Text = "";
                CmbBoxYear.SelectedValue = 0;
                CmbBoxYear.DataSource = null;
                CmbBoxYear.Text = "";
                CmbBoxStarRating.SelectedIndex = 0;
                CmbBoxSeasonType.SelectedIndex = 0;
                TxtBoxAddres.Text = "";
                TxtBoxExtraInfo.Text = "";
                TxtBoxContact.Text = "";
                TxtBoxEmail.Text = "";
                TxtBoxPhone.Text = "";
                MskdTxtBoxMobile.Text = "";
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
            }

            string selectQueryString = "SELECT * FROM `hotelinfo` " +
                "WHERE " +
                "`hotelarea` = '" + CmbBoxSector.SelectedValue.ToString() + "' " +
                "AND `hotelcity` = '" + CmbBoxCity.SelectedValue.ToString() + "' " +
                "AND `hotelname` = '" + CmbBoxHotelName.SelectedValue.ToString() + "' " +
                "ORDER BY `idhotelinfo`";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQueryString, mySqlConnection);
            DataSet dataSet = new DataSet();

            try
            {
                mySqlDataAdapter.Fill(dataSet, "HOTEL_INFO");
                if (dataSet != null)
                {
                    /* data obtained now fill in fields */
                    for (int index = 0; index < CmbBoxStarRating.Items.Count; index++)
                    {
                        if (String.Equals(CmbBoxStarRating.GetItemText(CmbBoxStarRating.Items[index]), dataSet.Tables["HOTEL_INFO"].Rows[0]["hotelrating"].ToString(), StringComparison.OrdinalIgnoreCase))
                        {
                            CmbBoxStarRating.SelectedIndex = index;
                            break;
                        }
                    }
                    TxtBoxAddres.Text = dataSet.Tables["HOTEL_INFO"].Rows[0]["hoteladdress"].ToString();
                    TxtBoxExtraInfo.Text = dataSet.Tables["HOTEL_INFO"].Rows[0]["hotelextrainfo"].ToString();
                    TxtBoxContact.Text = dataSet.Tables["HOTEL_INFO"].Rows[0]["contact"].ToString();
                    TxtBoxEmail.Text = dataSet.Tables["HOTEL_INFO"].Rows[0]["hotelemail"].ToString();
                    TxtBoxPhone.Text = dataSet.Tables["HOTEL_INFO"].Rows[0]["hotelphone"].ToString();
                    MskdTxtBoxMobile.Text = dataSet.Tables["HOTEL_INFO"].Rows[0]["hotelmobile"].ToString();
                    hotelId = Convert.ToInt32(dataSet.Tables["HOTEL_INFO"].Rows[0]["idhotelinfo"]);

                    /* now try to read room type */
                    selectQueryString = "SELECT DISTINCT `roomtype` FROM `hotelrates` " +
                        "WHERE " +
                        "`idhotelinfo` = " + dataSet.Tables["HOTEL_INFO"].Rows[0]["idhotelinfo"].ToString() + " " +
                        "ORDER BY `roomtype`";
                    mySqlDataAdapter.SelectCommand.CommandText = selectQueryString;
                    mySqlDataAdapter.Fill(dataSet, "ROOM_TYPE");
                    DataRow dataRow = dataSet.Tables["ROOM_TYPE"].NewRow();
                    dataRow["roomtype"] = "";
                    dataSet.Tables["ROOM_TYPE"].Rows.InsertAt(dataRow, 0);
                    CmbBoxRoomType.DataSource = dataSet.Tables["ROOM_TYPE"];
                    CmbBoxRoomType.ValueMember = "roomtype";
                    CmbBoxRoomType.DisplayMember = "roomtype";
                    CmbBoxRoomType.SelectedIndex = 0;
                    CmbBoxRoomType.SelectedValue = 0;
                    /* now try to read year */
                    selectQueryString = "SELECT DISTINCT `seasonyear` FROM `hotelrates` " +
                        "WHERE " +
                        "`idhotelinfo` = " + dataSet.Tables["HOTEL_INFO"].Rows[0]["idhotelinfo"].ToString() + " " +
                        "ORDER BY `seasonyear`";
                    mySqlDataAdapter.SelectCommand.CommandText = selectQueryString;
                    mySqlDataAdapter.Fill(dataSet, "SEASON_YEAR");
                    dataRow = dataSet.Tables["SEASON_YEAR"].NewRow();
                    dataRow["seasonyear"] = "";
                    dataSet.Tables["SEASON_YEAR"].Rows.InsertAt(dataRow, 0);
                    CmbBoxYear.DataSource = dataSet.Tables["SEASON_YEAR"];
                    CmbBoxYear.ValueMember = "seasonyear";
                    CmbBoxYear.DisplayMember = "seasonyear";
                    CmbBoxYear.SelectedIndex = 0;
                    CmbBoxYear.SelectedValue = 0;
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

        private void Update_hotelrates_fields()
        {
            if ((CmbBoxRoomType.SelectedIndex == 0) || (CmbBoxSeasonType.SelectedIndex == 0) || (CmbBoxYear.SelectedIndex == 0))
            {
                TxtBoxApaiPriceDouble.Text = "";
                TxtBoxApaiPriceExtBed.Text = "";
                TxtBoxApaiPriceSingle.Text = "";
                TxtBoxCpaiPriceDouble.Text = "";
                TxtBoxCpaiPriceExtBed.Text = "";
                TxtBoxCpaiPriceSingle.Text = "";
                TxtBoxEpaiPriceDouble.Text = "";
                TxtBoxEpaiPriceExtBed.Text = "";
                TxtBoxEpaiPriceSingle.Text = "";
                TxtBoxMapaiPriceDouble.Text = "";
                TxtBoxMapaiPriceExtBed.Text = "";
                TxtBoxMapaiPriceSingle.Text = "";
                return;
            }
            if ((CmbBoxRoomType.SelectedValue == null) || (CmbBoxSeasonType.SelectedValue == null) || (CmbBoxYear.SelectedValue == null))
            {
                TxtBoxApaiPriceDouble.Text = "";
                TxtBoxApaiPriceExtBed.Text = "";
                TxtBoxApaiPriceSingle.Text = "";
                TxtBoxCpaiPriceDouble.Text = "";
                TxtBoxCpaiPriceExtBed.Text = "";
                TxtBoxCpaiPriceSingle.Text = "";
                TxtBoxEpaiPriceDouble.Text = "";
                TxtBoxEpaiPriceExtBed.Text = "";
                TxtBoxEpaiPriceSingle.Text = "";
                TxtBoxMapaiPriceDouble.Text = "";
                TxtBoxMapaiPriceExtBed.Text = "";
                TxtBoxMapaiPriceSingle.Text = "";
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
            }

            /* Check code below this line needs to be reviewed */
            string selectQueryString = "SELECT * FROM `hotelrates` " +
                "WHERE " +
                "`roomtype` = '" + CmbBoxRoomType.SelectedValue.ToString() + "' " +
                "AND `seasontype` = '" + CmbBoxSeasonType.Text + "' " +
                "AND `seasonyear` = '" + CmbBoxYear.SelectedValue.ToString() + "' " +
                "AND `idhotelinfo` = '" + hotelId.ToString() + "' " +
                "ORDER BY `idhotelrates`";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQueryString, mySqlConnection);
            DataSet dataSet = new DataSet();

            try
            {
                mySqlDataAdapter.Fill(dataSet, "HOTEL_RATE");
                if (dataSet != null)
                {
                    /* data obtained now fill in fields */
                    if (dataSet.Tables["HOTEL_RATE"].Rows.Count > 0)
                    {
                        TxtBoxApaiPriceDouble.Text = dataSet.Tables["HOTEL_RATE"].Rows[0]["mealapaipricedouble"].ToString();
                        TxtBoxApaiPriceExtBed.Text = dataSet.Tables["HOTEL_RATE"].Rows[0]["mealapaipriceextbed"].ToString();
                        TxtBoxApaiPriceSingle.Text = dataSet.Tables["HOTEL_RATE"].Rows[0]["mealapaipricesingle"].ToString();
                        TxtBoxCpaiPriceDouble.Text = dataSet.Tables["HOTEL_RATE"].Rows[0]["mealcpaipricedouble"].ToString();
                        TxtBoxCpaiPriceExtBed.Text = dataSet.Tables["HOTEL_RATE"].Rows[0]["mealcpaipriceextbed"].ToString();
                        TxtBoxCpaiPriceSingle.Text = dataSet.Tables["HOTEL_RATE"].Rows[0]["mealcpaipricesingle"].ToString();
                        TxtBoxEpaiPriceDouble.Text = dataSet.Tables["HOTEL_RATE"].Rows[0]["mealepaipricedouble"].ToString();
                        TxtBoxEpaiPriceExtBed.Text = dataSet.Tables["HOTEL_RATE"].Rows[0]["mealepaipriceextbed"].ToString();
                        TxtBoxEpaiPriceSingle.Text = dataSet.Tables["HOTEL_RATE"].Rows[0]["mealepaipricesingle"].ToString();
                        TxtBoxMapaiPriceDouble.Text = dataSet.Tables["HOTEL_RATE"].Rows[0]["mealmapaipricedouble"].ToString();
                        TxtBoxMapaiPriceExtBed.Text = dataSet.Tables["HOTEL_RATE"].Rows[0]["mealmapaipriceextbed"].ToString();
                        TxtBoxMapaiPriceSingle.Text = dataSet.Tables["HOTEL_RATE"].Rows[0]["mealmapaipricesingle"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No data present in database for" +
                            "\nYear = " + CmbBoxYear.Text + "" +
                            "\nSeason = " + CmbBoxSeasonType.Text +
                            "\nRoom Type = " + CmbBoxRoomType.Text +
                            "\nin hotel = " + CmbBoxHotelName.Text ,
                            "Warning!!! NO DATA PRESENT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        TxtBoxApaiPriceDouble.Text = "";
                        TxtBoxApaiPriceExtBed.Text = "";
                        TxtBoxApaiPriceSingle.Text = "";
                        TxtBoxCpaiPriceDouble.Text = "";
                        TxtBoxCpaiPriceExtBed.Text = "";
                        TxtBoxCpaiPriceSingle.Text = "";
                        TxtBoxEpaiPriceDouble.Text = "";
                        TxtBoxEpaiPriceExtBed.Text = "";
                        TxtBoxEpaiPriceSingle.Text = "";
                        TxtBoxMapaiPriceDouble.Text = "";
                        TxtBoxMapaiPriceExtBed.Text = "";
                        TxtBoxMapaiPriceSingle.Text = "";
                    }
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

        private void CmbBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* do something when Room type is selected */
            Update_hotelrates_fields();
        }

        private void CmbBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_hotelrates_fields();
        }

        private void CmbBoxSeasonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_hotelrates_fields();
        }

        private bool Validate_Values_For_Insertion()
        {
            bool result = true;
            string errorListString = "Following errors are there in the Form:";
            /* validate hotelarea */
            if(String.Equals("", CmbBoxSector.Text, StringComparison.OrdinalIgnoreCase))
            {
                errorListString += "\nHotel area is empty";
                result = false;
            }
            /* validate hotelcity*/
            if (String.Equals("", CmbBoxCity.Text, StringComparison.OrdinalIgnoreCase))
            {
                errorListString += "\nHotel City is empty";
                result = false;
            }
            /* validate hotelname*/
            if (String.Equals("", CmbBoxHotelName.Text, StringComparison.OrdinalIgnoreCase))
            {
                errorListString += "\nHotel name is empty";
                result = false;
            }
            /* validate rating*/
            if (String.Equals("", CmbBoxStarRating.Text, StringComparison.OrdinalIgnoreCase))
            {
                errorListString += "\nHotel Star rating is empty";
                result = false;
            }
            if(CmbBoxStarRating.SelectedIndex == 0)
            {
                errorListString += "\nHotel star rating is not selected";
                result = false;
            }
            /* validate address*/
            if (String.Equals("", TxtBoxAddres.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxAddres.Text = "NOT FILLED";
            }
            /* validate extra info*/
            if (String.Equals("", TxtBoxExtraInfo.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxExtraInfo.Text = "NOT FILLED";
            }
            /* validate contact*/
            if (String.Equals("", TxtBoxContact.Text, StringComparison.OrdinalIgnoreCase))
            {
                errorListString += "\nHotel Contact is empty";
                result = false;
            }
            /* validate email*/
            if (String.Equals("", TxtBoxEmail.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxEmail.Text = "NOT FILLED";
            }
            /* validate phone*/
            if (String.Equals("", TxtBoxPhone.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxPhone.Text = "NOT FILLED";
            }
            /* validate mobile*/
            if (String.Equals("", MskdTxtBoxMobile.Text, StringComparison.OrdinalIgnoreCase))
            {
                errorListString += "\nHotel Mobile is empty";
                result = false;
            }
            else if (MskdTxtBoxMobile.Text.Length != 10)
            {
                errorListString += "\nMobile number(" + MskdTxtBoxMobile.Text + ") is not in proper format";
                result = false;
            }
            
            /* validate roomtype*/
            if (String.Equals("", CmbBoxRoomType.Text, StringComparison.OrdinalIgnoreCase))
            {
                errorListString += "\nHotel Room type is empty";
                result = false;
            }
            /* validate season type*/
            if (String.Equals("", CmbBoxSeasonType.Text, StringComparison.OrdinalIgnoreCase))
            {
                errorListString += "\nSeason type is empty";
                result = false;
            }
            if(CmbBoxSeasonType.SelectedIndex == 0)
            {
                errorListString += "\nSeason type is not selected";
                result = false;
            }
            /* validate year*/
            if (String.Equals("", CmbBoxYear.Text, StringComparison.OrdinalIgnoreCase))
            {
                errorListString += "\nSeason year is empty";
                result = false;
            }
            else if(CmbBoxYear.Text.Length != 4)
            {
                errorListString += "\nSeason year(" + CmbBoxYear.Text + ") is not in proper format";
                result = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(CmbBoxYear.Text);
                }
                catch ( Exception errorDigit)
                {
                    errorListString += "\nSeason year(" + CmbBoxYear.Text + ") error = " + errorDigit.Message;
                    result = false;
                }
            }
            
            /*************************** validate pricess **************************************/
            if (String.Equals("", TxtBoxEpaiPriceSingle.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxEpaiPriceSingle.Text = "0";
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtBoxEpaiPriceSingle.Text);
                }
                catch (Exception errorDigit)
                {
                    errorListString += "\nPRICE(" + TxtBoxEpaiPriceSingle.Text + ") error = " + errorDigit.Message;
                    result = false;
                }
            }
            if (String.Equals("", TxtBoxEpaiPriceDouble.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxEpaiPriceDouble.Text = "0";
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtBoxEpaiPriceDouble.Text);
                }
                catch (Exception errorDigit)
                {
                    errorListString += "\nPRICE(" + TxtBoxEpaiPriceDouble.Text + ") error = " + errorDigit.Message;
                    result = false;
                }
            }
            if (String.Equals("", TxtBoxEpaiPriceExtBed.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxEpaiPriceExtBed.Text = "0";
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtBoxEpaiPriceExtBed.Text);
                }
                catch (Exception errorDigit)
                {
                    errorListString += "\nPRICE(" + TxtBoxEpaiPriceExtBed.Text + ") error = " + errorDigit.Message;
                    result = false;
                }
            }
            if (String.Equals("", TxtBoxCpaiPriceSingle.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxCpaiPriceSingle.Text = "0";
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtBoxCpaiPriceSingle.Text);
                }
                catch (Exception errorDigit)
                {
                    errorListString += "\nPRICE(" + TxtBoxCpaiPriceSingle.Text + ") error = " + errorDigit.Message;
                    result = false;
                }
            }
            if (String.Equals("", TxtBoxCpaiPriceDouble.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxCpaiPriceDouble.Text = "0";
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtBoxCpaiPriceDouble.Text);
                }
                catch (Exception errorDigit)
                {
                    errorListString += "\nPRICE(" + TxtBoxCpaiPriceDouble.Text + ") error = " + errorDigit.Message;
                    result = false;
                }
            }
            if (String.Equals("", TxtBoxCpaiPriceExtBed.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxCpaiPriceExtBed.Text = "0";
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtBoxCpaiPriceExtBed.Text);
                }
                catch (Exception errorDigit)
                {
                    errorListString += "\nPRICE(" + TxtBoxCpaiPriceExtBed.Text + ") error = " + errorDigit.Message;
                    result = false;
                }
            }
            if (String.Equals("", TxtBoxMapaiPriceSingle.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxMapaiPriceSingle.Text = "0";
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtBoxMapaiPriceSingle.Text);
                }
                catch (Exception errorDigit)
                {
                    errorListString += "\nPRICE(" + TxtBoxMapaiPriceSingle.Text + ") error = " + errorDigit.Message;
                    result = false;
                }
            }
            if (String.Equals("", TxtBoxMapaiPriceDouble.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxMapaiPriceDouble.Text = "0";
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtBoxMapaiPriceDouble.Text);
                }
                catch (Exception errorDigit)
                {
                    errorListString += "\nPRICE(" + TxtBoxMapaiPriceDouble.Text + ") error = " + errorDigit.Message;
                    result = false;
                }
            }
            if (String.Equals("", TxtBoxMapaiPriceExtBed.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxMapaiPriceExtBed.Text = "0";
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtBoxMapaiPriceExtBed.Text);
                }
                catch (Exception errorDigit)
                {
                    errorListString += "\nPRICE(" + TxtBoxMapaiPriceExtBed.Text + ") error = " + errorDigit.Message;
                    result = false;
                }
            }
            if (String.Equals("", TxtBoxApaiPriceSingle.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxApaiPriceSingle.Text = "0";
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtBoxApaiPriceSingle.Text);
                }
                catch (Exception errorDigit)
                {
                    errorListString += "\nPRICE(" + TxtBoxApaiPriceSingle.Text + ") error = " + errorDigit.Message;
                    result = false;
                }
            }
            if (String.Equals("", TxtBoxApaiPriceDouble.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxApaiPriceDouble.Text = "0";
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtBoxApaiPriceDouble.Text);
                }
                catch (Exception errorDigit)
                {
                    errorListString += "\nPRICE(" + TxtBoxApaiPriceDouble.Text + ") error = " + errorDigit.Message;
                    result = false;
                }
            }
            if (String.Equals("", TxtBoxApaiPriceExtBed.Text, StringComparison.OrdinalIgnoreCase))
            {
                TxtBoxApaiPriceExtBed.Text = "0";
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtBoxApaiPriceExtBed.Text);
                }
                catch (Exception errorDigit)
                {
                    errorListString += "\nPRICE(" + TxtBoxApaiPriceExtBed.Text + ") error = " + errorDigit.Message;
                    result = false;
                }
            }
            if (!result)
            {
                MessageBox.Show(errorListString, "Error in Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            /* insert or update the fields in the datbase */
            if(!Validate_Values_For_Insertion())
            {
                return;
            }
            string mysqlInsertQueryString = "INSERT INTO `hotelinfo` ( " +
                "`hotelarea`, " +
                "`hotelcity`, " +
                "`hotelname`, " +
                "`hotelrating`, " +
                "`hoteladdress`, " +
                "`hotelextrainfo`, " +
                "`contact`, " +
                "`hotelemail`, " +
                "`hotelphone`, " +
                "`hotelmobile` " +
                ") VALUES ( " +
                "@hotelarea, " +
                "@hotelcity, " +
                "@hotelname, " +
                "@hotelrating, " +
                "@hoteladdress, " +
                "@hotelextrainfo, " +
                "@contact, " +
                "@hotelemail, " +
                "@hotelphone, " +
                "@hotelmobile " +
                ") ON DUPLICATE KEY UPDATE " +
                "`hotelrating` = @hotelrating, " +
                "`hoteladdress` = @hoteladdress, " +
                "`hotelextrainfo` = @hotelextrainfo, " +
                "`contact` = @contact, " +
                "`hotelemail` = @hotelemail, " +
                "`hotelphone` = @hotelphone, " +
                "`hotelmobile` = @hotelmobile " +
                "";
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception errConnOpen)
            {
                MessageBox.Show("Error in opening mysql connection because " + errConnOpen.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.Connection = mySqlConnection;
            mySqlCommand.Transaction = mySqlConnection.BeginTransaction();
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.CommandText = mysqlInsertQueryString;
            mySqlCommand.Prepare();
            mySqlCommand.Parameters.AddWithValue("@hotelarea", "Text");
            mySqlCommand.Parameters.AddWithValue("@hotelcity", "Text");
            mySqlCommand.Parameters.AddWithValue("@hotelname", "Text");
            mySqlCommand.Parameters.AddWithValue("@hotelrating", "Text");
            mySqlCommand.Parameters.AddWithValue("@hoteladdress", "Text");
            mySqlCommand.Parameters.AddWithValue("@hotelextrainfo", "Text");
            mySqlCommand.Parameters.AddWithValue("@contact", "Text");
            mySqlCommand.Parameters.AddWithValue("@hotelemail", "Text");
            mySqlCommand.Parameters.AddWithValue("@hotelphone", "Text");
            mySqlCommand.Parameters.AddWithValue("@hotelmobile", "Text");
            mySqlCommand.Parameters["@hotelarea"].Value = CmbBoxSector.Text;
            mySqlCommand.Parameters["@hotelcity"].Value = CmbBoxCity.Text;
            mySqlCommand.Parameters["@hotelname"].Value = CmbBoxHotelName.Text;
            mySqlCommand.Parameters["@hotelrating"].Value = CmbBoxStarRating.Text;
            mySqlCommand.Parameters["@hoteladdress"].Value = TxtBoxAddres.Text;
            mySqlCommand.Parameters["@hotelextrainfo"].Value = TxtBoxExtraInfo.Text;
            mySqlCommand.Parameters["@contact"].Value = TxtBoxContact.Text;
            mySqlCommand.Parameters["@hotelemail"].Value = TxtBoxEmail.Text;
            mySqlCommand.Parameters["@hotelphone"].Value = TxtBoxPhone.Text;
            mySqlCommand.Parameters["@hotelmobile"].Value = MskdTxtBoxMobile.Text;
            bool result = false;
            int returnedValue = 0;
            try
            {
                returnedValue = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Insert query executed with result = " + returnedValue.ToString(), "Result Insert query", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = true;
            }
            catch (Exception errinsertquery)
            {
                MessageBox.Show("Error in updating database because " + errinsertquery.Message, "Error DB UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (result)
                {
                    mySqlCommand.Transaction.Commit();
                }
                else
                {
                    mySqlCommand.Transaction.Rollback();
                }
            }
            catch (Exception errCommit)
            {
                Debug.WriteLine("Error in commiting or rolbacking because : " + errCommit.Message);
            }

            /* now update price */
            mysqlInsertQueryString = "INSERT INTO `hotelrates` ( " +
                "`idhotelinfo`, " +
                "`roomtype`, " +
                "`seasontype`, " +
                "`seasonyear`, " +
                "`mealepaipricesingle`, " +
                "`mealepaipricedouble`, " +
                "`mealepaipriceextbed`, " +
                "`mealcpaipricesingle`, " +
                "`mealcpaipricedouble`, " +
                "`mealcpaipriceextbed`, " +
                "`mealmapaipricesingle`, " +
                "`mealmapaipricedouble`, " +
                "`mealmapaipriceextbed`, " +
                "`mealapaipricesingle`, " +
                "`mealapaipricedouble`, " +
                "`mealapaipriceextbed` ) " +
                "VALUES ( " +
                "(SELECT `idhotelinfo` FROM `hotelinfo` WHERE `hotelarea` = @hotelarea AND `hotelcity` = @hotelcity AND `hotelname` = @hotelname), " +
                "@roomtype, " +
                "@seasontype, " +
                "@seasonyear, " +
                "@mealepaipricesingle, " +
                "@mealepaipricedouble, " +
                "@mealepaipriceextbed, " +
                "@mealcpaipricesingle, " +
                "@mealcpaipricedouble, " +
                "@mealcpaipriceextbed, " +
                "@mealmapaipricesingle, " +
                "@mealmapaipricedouble, " +
                "@mealmapaipriceextbed, " +
                "@mealapaipricesingle, " +
                "@mealapaipricedouble, " +
                "@mealapaipriceextbed ) " +
                "ON DUPLICATE KEY UPDATE " +
                "`mealepaipricesingle` = @mealepaipricesingle, " +
                "`mealepaipricedouble` = @mealepaipricedouble, " +
                "`mealepaipriceextbed` = @mealepaipriceextbed, " +
                "`mealcpaipricesingle` = @mealcpaipricesingle, " +
                "`mealcpaipricedouble` = @mealcpaipricedouble, " +
                "`mealcpaipriceextbed` = @mealcpaipriceextbed, " +
                "`mealmapaipricesingle` = @mealmapaipricesingle, " +
                "`mealmapaipricedouble` = @mealmapaipricedouble, " +
                "`mealmapaipriceextbed` = @mealmapaipriceextbed, " +
                "`mealapaipricesingle` = @mealapaipricesingle, " +
                "`mealapaipricedouble` = @mealapaipricedouble, " +
                "`mealapaipriceextbed` = @mealapaipriceextbed " +
                "";
            mySqlCommand.CommandText = mysqlInsertQueryString;
            mySqlCommand.Prepare();
            mySqlCommand.Parameters.AddWithValue("@roomtype", "Text");
            mySqlCommand.Parameters.AddWithValue("@seasontype", "Text");
            mySqlCommand.Parameters.AddWithValue("@seasonyear", "Text");
            mySqlCommand.Parameters.AddWithValue("@mealepaipricesingle", 1);
            mySqlCommand.Parameters.AddWithValue("@mealepaipricedouble", 1);
            mySqlCommand.Parameters.AddWithValue("@mealepaipriceextbed", 1);
            mySqlCommand.Parameters.AddWithValue("@mealcpaipricesingle", 1);
            mySqlCommand.Parameters.AddWithValue("@mealcpaipricedouble", 1);
            mySqlCommand.Parameters.AddWithValue("@mealcpaipriceextbed", 1);
            mySqlCommand.Parameters.AddWithValue("@mealmapaipricesingle", 1);
            mySqlCommand.Parameters.AddWithValue("@mealmapaipricedouble", 1);
            mySqlCommand.Parameters.AddWithValue("@mealmapaipriceextbed", 1);
            mySqlCommand.Parameters.AddWithValue("@mealapaipricesingle", 1);
            mySqlCommand.Parameters.AddWithValue("@mealapaipricedouble", 1);
            mySqlCommand.Parameters.AddWithValue("@mealapaipriceextbed", 1);
            mySqlCommand.Parameters["@roomtype"].Value = CmbBoxRoomType.Text;
            mySqlCommand.Parameters["@seasontype"].Value = CmbBoxSeasonType.Text;
            mySqlCommand.Parameters["@seasonyear"].Value = CmbBoxYear.Text;
            mySqlCommand.Parameters["@mealepaipricesingle"].Value = Convert.ToInt32(TxtBoxEpaiPriceSingle.Text);
            mySqlCommand.Parameters["@mealepaipricedouble"].Value = Convert.ToInt32(TxtBoxEpaiPriceDouble.Text);
            mySqlCommand.Parameters["@mealepaipriceextbed"].Value = Convert.ToInt32(TxtBoxEpaiPriceExtBed.Text);
            mySqlCommand.Parameters["@mealcpaipricesingle"].Value = Convert.ToInt32(TxtBoxCpaiPriceSingle.Text);
            mySqlCommand.Parameters["@mealcpaipricedouble"].Value = Convert.ToInt32(TxtBoxCpaiPriceDouble.Text);
            mySqlCommand.Parameters["@mealcpaipriceextbed"].Value = Convert.ToInt32(TxtBoxCpaiPriceExtBed.Text);
            mySqlCommand.Parameters["@mealmapaipricesingle"].Value = Convert.ToInt32(TxtBoxMapaiPriceSingle.Text);
            mySqlCommand.Parameters["@mealmapaipricedouble"].Value = Convert.ToInt32(TxtBoxMapaiPriceDouble.Text);
            mySqlCommand.Parameters["@mealmapaipriceextbed"].Value = Convert.ToInt32(TxtBoxMapaiPriceExtBed.Text);
            mySqlCommand.Parameters["@mealapaipricesingle"].Value = Convert.ToInt32(TxtBoxApaiPriceSingle.Text);
            mySqlCommand.Parameters["@mealapaipricedouble"].Value = Convert.ToInt32(TxtBoxApaiPriceDouble.Text);
            mySqlCommand.Parameters["@mealapaipriceextbed"].Value = Convert.ToInt32(TxtBoxApaiPriceExtBed.Text);
            mySqlCommand.Transaction = mySqlConnection.BeginTransaction();
            result = false;
            returnedValue = 0;
            try
            {
                returnedValue = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Insert query executed with result = " + returnedValue.ToString(), "Result Insert query", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = true;
            }
            catch (Exception errinsertquery)
            {
                MessageBox.Show("Error in updating database because " + errinsertquery.Message, "Error DB UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (result)
                {
                    mySqlCommand.Transaction.Commit();
                }
                else
                {
                    mySqlCommand.Transaction.Rollback();
                }
            }
            catch (Exception errCommit)
            {
                Debug.WriteLine("Error in commiting or rolbacking because : " + errCommit.Message);
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
            CmbBoxSector_Reload();
        }
    }
}
