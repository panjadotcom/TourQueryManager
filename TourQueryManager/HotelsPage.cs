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
        public FrmHotelsPage()
        {
            InitializeComponent();
        }

        private void FrmHotelsPage_Load(object sender, EventArgs e)
        {
            /*do Something while loading form */
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
                if(dataSet != null)
                {
                    CmbBoxSector.DataSource = dataSet.Tables["HOTEL_AREA"];
                    CmbBoxSector.ValueMember = "hotelarea";
                    CmbBoxSector.DisplayMember = "hotelarea";
                }
            }
            catch(Exception errSelectQry)
            {
                MessageBox.Show("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
                Debug.WriteLine("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
            }
            dataRow = dataSet.Tables["HOTEL_AREA"].NewRow();
            dataRow["hotelarea"] = "SELECT SECTOR";
            dataSet.Tables["HOTEL_AREA"].Rows.InsertAt(dataRow, 0);
            CmbBoxSector.SelectedIndex = 0;
            try
            {
                mySqlConnection.Close();
            }
            catch (Exception errConnClose)
            {
                MessageBox.Show("Error in Closing mysql connection because " + errConnClose.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            DataTable dataTable = dataSet.Tables.Add("STAR_RATING");
            dataTable.Columns.Add("INDEX");
            dataTable.Columns.Add("STAR");
            dataRow = dataTable.NewRow();
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
            CmbBoxStarRating.SelectedValue = 0;
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
                CmbBoxCity.Text = "SELECT SECTOR FIRST";
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
                    dataRow["hotelcity"] = "SELECT CITY";
                    dataSet.Tables["HOTEL_CITY"].Rows.InsertAt(dataRow, 0);
                    CmbBoxCity.DataSource = dataSet.Tables["HOTEL_CITY"];
                    CmbBoxCity.ValueMember = "hotelcity";
                    CmbBoxCity.DisplayMember = "hotelcity";
                    CmbBoxCity.SelectedIndex = 0;
                }
            }
            catch (Exception errSelectQry)
            {
                MessageBox.Show("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
                Debug.WriteLine("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
            }
            //DataRow dataRow = dataSet.Tables["HOTEL_CITY"].NewRow();
            //dataRow["hotelcity"] = "SELECT CITY";
            //dataSet.Tables["HOTEL_CITY"].Rows.InsertAt(dataRow, 0);
            //CmbBoxCity.SelectedIndex = 0;
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
                CmbBoxHotelName.Text = "SELECT CITY FIRST";
                //MessageBox.Show("Error City 1");
                return;
            }
            //if (CmbBoxCity.SelectedValue == null)
            //{
            //    CmbBoxHotelName.SelectedValue = 0;
            //    //MessageBox.Show("Error City 2");
            //    return;
            //}
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
                    dataRow["hotelname"] = "SELECT HOTEL";
                    dataSet.Tables["HOTEL_NAME"].Rows.InsertAt(dataRow, 0);
                    CmbBoxHotelName.DataSource = dataSet.Tables["HOTEL_NAME"];
                    CmbBoxHotelName.ValueMember = "hotelname";
                    CmbBoxHotelName.DisplayMember = "hotelname";
                    CmbBoxHotelName.SelectedIndex = 0;
                }
            }
            catch (Exception errSelectQry)
            {
                MessageBox.Show("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
                Debug.WriteLine("Error in query = " + selectQueryString + " because of " + errSelectQry.Message);
            }
            //DataRow dataRow = dataSet.Tables["HOTEL_NAME"].NewRow();
            //dataRow["hotelname"] = "SELECT HOTEL";
            //dataSet.Tables["HOTEL_NAME"].Rows.InsertAt(dataRow, 0);
            //CmbBoxHotelName.SelectedIndex = 0;
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
            if ((CmbBoxHotelName.SelectedIndex == 0) || (CmbBoxHotelName.SelectedValue == null))
            {
                CmbBoxStarRating.SelectedValue = 0;
                CmbBoxStarRating.Text = "SELECT HOTEL FIRST";
                //MessageBox.Show("Error City 1");
                return;
            }
            //if (CmbBoxCity.SelectedValue == null)
            //{
            //    CmbBoxHotelName.SelectedValue = 0;
            //    //MessageBox.Show("Error City 2");
            //    return;
            //}
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
                    CmbBoxStarRating.Text = dataSet.Tables["HOTEL_INFO"].Rows[0]["hotelrating"].ToString();
                    TxtBoxAddres.Text = dataSet.Tables["HOTEL_INFO"].Rows[0]["hoteladdress"].ToString();
                    TxtBoxExtraInfo.Text = dataSet.Tables["HOTEL_INFO"].Rows[0]["hotelextrainfo"].ToString();
                    TxtBoxContact.Text = dataSet.Tables["HOTEL_INFO"].Rows[0]["contact"].ToString();
                    TxtBoxEmail.Text = dataSet.Tables["HOTEL_INFO"].Rows[0]["hotelemail"].ToString();
                    TxtBoxPhone.Text = dataSet.Tables["HOTEL_INFO"].Rows[0]["hotelphone"].ToString();
                    MskdTxtBoxMobile.Text = dataSet.Tables["HOTEL_INFO"].Rows[0]["hotelmobile"].ToString();
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
    }
}
