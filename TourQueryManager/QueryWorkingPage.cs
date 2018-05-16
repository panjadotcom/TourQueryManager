using System;
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
        Excel.Application xlsAppWorkingHotel;
        Excel.Workbook xlsWorkbookWorkingHotel;
        Excel.Worksheet xlsWorksheetWorkingHotel;
        Excel.Range xlsRangeWorkingHotel;
        static string queryIdWorking = null;
        static string mysqlConnStr = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection frmQueryWorkingMysqlConn = new MySqlConnection(mysqlConnStr);
        MySqlTransaction frmQueryWorkingMysqlTransaction = null;
        MySqlDataAdapter frmQueryWorkingMysqlDataAdaptor = null;
        DataSet frmQueryWorkingDataSet = null;

        public FrmQueryWorkingPage(string queryId)
        {
            InitializeComponent();
            queryIdWorking = queryId;
        }

        private void FrmQueryWorkingPage_Load(object sender, EventArgs e)
        {
            /* data to be initialized when loading page */
            Text = "Working on QUERYID (" + queryIdWorking + ")";
            
            xlsAppWorkingHotel = new Excel.Application();
            try
            {
                frmQueryWorkingMysqlConn.Open();
            }
            catch (Exception erropen)
            {
                MessageBox.Show("connection cannot be opened because " + erropen.Message + "");
                Close();
            }
            frmQueryWorkingDataSet = new DataSet();
            string mysqlSelectQueryStr = "SELECT * FROM `queries` WHERE `queryid` = " + queryIdWorking + "";
            try
            {
                frmQueryWorkingMysqlDataAdaptor = new MySqlDataAdapter(mysqlSelectQueryStr, frmQueryWorkingMysqlConn);
                frmQueryWorkingMysqlDataAdaptor.Fill(frmQueryWorkingDataSet, "QUERYID_DATA");
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

            double noOfdays = (DateTime.Parse(frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["todate"].ToString()) -
                DateTime.Parse(frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["fromdate"].ToString())).TotalDays;
            numericUpDownWorkingHotelDayNo.Maximum = Convert.ToDecimal(noOfdays);

            decimal noOfRooms = Convert.ToDecimal(frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["roomcount"]);
            numericUpDownRoomNo.Maximum = noOfRooms;
        }

        private void ButtonSelectHotelExcelFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogForHotelExcel.ShowDialog() == DialogResult.OK)
            {
                Debug.WriteLine("File selected = " + openFileDialogForHotelExcel.FileName );
                try
                {
                    /* try to close already opened workbook and create new */
                    xlsWorkbookWorkingHotel.Close(false, null, null);
                    CmbboxWrkngHtlSector.Items.Clear();
                }
                catch (Exception errXlsClose)
                {
                    Debug.WriteLine("Error in closing excel workbook because " + errXlsClose.Message);
                }

                /* now open and load sheet names in sector */
                xlsWorkbookWorkingHotel = xlsAppWorkingHotel.Workbooks.Open(openFileDialogForHotelExcel.FileName, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                CmbboxWrkngHtlSector.Items.Add("SELECT SECTOR");
                foreach (Excel.Worksheet worksheet in xlsWorkbookWorkingHotel.Worksheets)
                {
                    CmbboxWrkngHtlSector.Items.Add(worksheet.Name);
                }
                CmbboxWrkngHtlSector.SelectedIndex = 0;
            }
            else
            {
                Debug.WriteLine("Error in Selecting file");
            }
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
            /* perform closing operation */
            releaseObject(xlsRangeWorkingHotel);
            releaseObject(xlsWorksheetWorkingHotel);
            try
            {
                xlsWorkbookWorkingHotel.Close(false, null, null);
                xlsAppWorkingHotel.Quit();
            }
            catch (Exception errXlsClosing)
            {
                Debug.WriteLine("Error in closing workbook because " + errXlsClosing.Message);
            }
            releaseObject(xlsWorkbookWorkingHotel);
            releaseObject(xlsAppWorkingHotel);
        }

        private void CmbboxWrkngHtlSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* re-initialize worksheet */
            releaseObject(xlsRangeWorkingHotel);
            releaseObject(xlsWorksheetWorkingHotel);
            CmbboxWrkngHtlLocation.Items.Clear();
            if (CmbboxWrkngHtlSector.SelectedIndex == 0)
            {
                CmbboxWrkngHtlLocation.Text = "--- Select sector first ---";
                return;
            }

            try
            {
                xlsWorksheetWorkingHotel = (Excel.Worksheet)xlsWorkbookWorkingHotel.Worksheets[CmbboxWrkngHtlSector.Text];
                if (string.Equals(xlsWorksheetWorkingHotel.Name, CmbboxWrkngHtlSector.Text, StringComparison.OrdinalIgnoreCase))
                {
                    xlsRangeWorkingHotel = xlsWorksheetWorkingHotel.UsedRange;
                }
                else
                {
                    releaseObject(xlsWorksheetWorkingHotel);
                    MessageBox.Show("Filename mismatched");
                    return;
                }
            }
            catch (Exception errSheetOpening)
            {
                Debug.WriteLine("Error in Loading sheet : " + errSheetOpening.Message);
                MessageBox.Show("Error in Loading sheet : " + errSheetOpening.Message);
            }
            CmbboxWrkngHtlLocation.Items.Add("SELECT LOCATION");
            for (int counter = 1; counter <= xlsRangeWorkingHotel.Rows.Count; counter++)
            {
                Object value = null;

                value = (xlsRangeWorkingHotel.Cells[counter, 1] as Excel.Range).Value2;
                if(value == null)
                {
                    continue;
                }
                else
                {
                    bool duplicate = false;
                    foreach (var item in CmbboxWrkngHtlLocation.Items)
                    {
                        if(string.Equals(item.ToString(),value.ToString(), StringComparison.OrdinalIgnoreCase))
                        {
                            duplicate = true;
                            break;
                        }
                    }
                    if(duplicate)
                    {
                        Debug.WriteLine("City already present in the list " + value.ToString());
                    }
                    else
                    {
                        CmbboxWrkngHtlLocation.Items.Add(value.ToString());
                    }
                }
            }
            CmbboxWrkngHtlLocation.SelectedIndex = 0;
        }

        private void CmbboxWrkngHtlLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* update hotel listing present in the selected location */
            DataSet dataSetHotelListing;
            DataTable dataTableHotelListing;
            DataRow dataRowHotelListing;
            if(CmbboxWrkngHtlLocation.SelectedIndex == 0)
            {
                Debug.WriteLine("City not selected");
                CmbboxWrkngHtlHotel.Text = "--- Select City First ---";
                return;
            }
            dataSetHotelListing = new DataSet("WORKING");
            dataTableHotelListing = dataSetHotelListing.Tables.Add("HOTEL_LIST");
            dataTableHotelListing.Columns.Add("INDEX");
            dataTableHotelListing.Columns.Add("NAME");
            dataRowHotelListing = dataTableHotelListing.NewRow();
            dataRowHotelListing["INDEX"] = "0";
            dataRowHotelListing["NAME"] = "SELECT HOTEL";
            dataTableHotelListing.Rows.Add(dataRowHotelListing);
            for (int counter = 1; counter <= xlsRangeWorkingHotel.Rows.Count; counter++)
            {
                Object value = null;

                value = (xlsRangeWorkingHotel.Cells[counter, 1] as Excel.Range).Value2;
                if (value == null)
                {
                    continue;
                }
                if (string.Equals(value.ToString(), CmbboxWrkngHtlLocation.Text, StringComparison.OrdinalIgnoreCase))
                {
                    /* City Matched thus add hotel in the list */
                    value = (xlsRangeWorkingHotel.Cells[counter, 2] as Excel.Range).Value2;
                    if(value == null)
                    {
                        continue;
                    }

                    dataRowHotelListing = dataTableHotelListing.NewRow();
                    dataRowHotelListing["INDEX"] = counter.ToString();
                    dataRowHotelListing["NAME"] = value.ToString();
                    dataTableHotelListing.Rows.Add(dataRowHotelListing);
                }
                else
                {
                    Debug.WriteLine("Cell City : " + value.ToString() + " not matched with the Selected city : " + CmbboxWrkngHtlLocation.Text);
                }
            }
            CmbboxWrkngHtlHotel.DataSource = dataSetHotelListing.Tables["HOTEL_LIST"];
            CmbboxWrkngHtlHotel.DisplayMember = "NAME";
            CmbboxWrkngHtlHotel.ValueMember = "INDEX";
            CmbboxWrkngHtlHotel.SelectedIndex = 0;
        }

        private void CmbboxWrkngHtlHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Hotel selected not populate room type and meal plan etc */
            bool hotelMealPlanListed = false;
            bool hotelExtraBedListed = false;
            bool hotelExtraMealListed = false;
            if(CmbboxWrkngHtlHotel.SelectedIndex == 0)
            {
                Debug.WriteLine("Hotel not selected ::");
                CmbboxWrkngHtlMealPlan.Text = "--- Select hotel First ---";
                return;
            }
            int hotelRowIndex = Convert.ToInt32(CmbboxWrkngHtlHotel.SelectedValue);
            Debug.WriteLine("Hotel Selected \n" +
                "Selected index = " + CmbboxWrkngHtlHotel.SelectedIndex.ToString() + "\n" +
                "Selected Value(Cell index) = " + CmbboxWrkngHtlHotel.SelectedValue.ToString() + "\n" +
                "Converted hotelRowIndex = " + hotelRowIndex.ToString() + "\n" +
                "Selected Hotel name = " + CmbboxWrkngHtlHotel.Text);
            DataTable dataTableHotelMealPlan = new DataTable("TABLE_MEAL_PLAN");
            DataRow dataRowHotelMealPlan;
            dataTableHotelMealPlan.Columns.Add("MEAL_RATE");
            dataTableHotelMealPlan.Columns.Add("MEAL_PLAN");
            dataRowHotelMealPlan = dataTableHotelMealPlan.NewRow();
            dataRowHotelMealPlan["MEAL_RATE"] = "0";
            dataRowHotelMealPlan["MEAL_PLAN"] = "SELECT MEAL PLAN";
            dataTableHotelMealPlan.Rows.Add(dataRowHotelMealPlan);
            Object value = null;
            /* read meal plan cpai single*/
            value = (xlsRangeWorkingHotel.Cells[hotelRowIndex, 4] as Excel.Range).Value2;
            if(value != null)
            {
                /*value is not empty */
                dataRowHotelMealPlan = dataTableHotelMealPlan.NewRow();
                dataRowHotelMealPlan["MEAL_RATE"] = value.ToString();
                dataRowHotelMealPlan["MEAL_PLAN"] = "CPAI SINGLE";
                dataTableHotelMealPlan.Rows.Add(dataRowHotelMealPlan);
                hotelMealPlanListed = true;
            }

            /* read meal plan cpai Double*/
            value = (xlsRangeWorkingHotel.Cells[hotelRowIndex, 5] as Excel.Range).Value2;
            if (value != null)
            {
                /*value is not empty */
                dataRowHotelMealPlan = dataTableHotelMealPlan.NewRow();
                dataRowHotelMealPlan["MEAL_RATE"] = value.ToString();
                dataRowHotelMealPlan["MEAL_PLAN"] = "CPAI DOUBLE";
                dataTableHotelMealPlan.Rows.Add(dataRowHotelMealPlan);
                hotelMealPlanListed = true;
            }

            /* read meal plan mapai single*/
            value = (xlsRangeWorkingHotel.Cells[hotelRowIndex, 6] as Excel.Range).Value2;
            if (value != null)
            {
                /*value is not empty */
                dataRowHotelMealPlan = dataTableHotelMealPlan.NewRow();
                dataRowHotelMealPlan["MEAL_RATE"] = value.ToString();
                dataRowHotelMealPlan["MEAL_PLAN"] = "MAPAI SINGLE";
                dataTableHotelMealPlan.Rows.Add(dataRowHotelMealPlan);
                hotelMealPlanListed = true;
            }

            /* read meal plan mapai double*/
            value = (xlsRangeWorkingHotel.Cells[hotelRowIndex, 7] as Excel.Range).Value2;
            if (value != null)
            {
                /*value is not empty */
                dataRowHotelMealPlan = dataTableHotelMealPlan.NewRow();
                dataRowHotelMealPlan["MEAL_RATE"] = value.ToString();
                dataRowHotelMealPlan["MEAL_PLAN"] = "MAPAI DOUBLE";
                dataTableHotelMealPlan.Rows.Add(dataRowHotelMealPlan);
                hotelMealPlanListed = true;
            }

            /* read meal plan apai single*/
            value = (xlsRangeWorkingHotel.Cells[hotelRowIndex, 8] as Excel.Range).Value2;
            if (value != null)
            {
                /*value is not empty */
                dataRowHotelMealPlan = dataTableHotelMealPlan.NewRow();
                dataRowHotelMealPlan["MEAL_RATE"] = value.ToString();
                dataRowHotelMealPlan["MEAL_PLAN"] = "APAI SINGLE";
                dataTableHotelMealPlan.Rows.Add(dataRowHotelMealPlan);
                hotelMealPlanListed = true;
            }

            /* read meal plan apai double*/
            value = (xlsRangeWorkingHotel.Cells[hotelRowIndex, 9] as Excel.Range).Value2;
            if (value != null)
            {
                /*value is not empty */
                dataRowHotelMealPlan = dataTableHotelMealPlan.NewRow();
                dataRowHotelMealPlan["MEAL_RATE"] = value.ToString();
                dataRowHotelMealPlan["MEAL_PLAN"] = "APAI DOUBLE";
                dataTableHotelMealPlan.Rows.Add(dataRowHotelMealPlan);
                hotelMealPlanListed = true;
            }

            CmbboxWrkngHtlMealPlan.DataSource = dataTableHotelMealPlan;
            CmbboxWrkngHtlMealPlan.DisplayMember = "MEAL_PLAN";
            CmbboxWrkngHtlMealPlan.ValueMember = "MEAL_RATE";
            CmbboxWrkngHtlMealPlan.SelectedIndex = 0;

            numericUpDownExtraBed.Value = 0;
            numericUpDownExtraMeal.Value = 0;


            /* Check extra bed present or not*/
            value = (xlsRangeWorkingHotel.Cells[hotelRowIndex, 10] as Excel.Range).Value2;
            if (value != null)
            {
                hotelExtraBedListed = true;
            }

            /* Check extra meal present or not*/
            value = (xlsRangeWorkingHotel.Cells[hotelRowIndex, 11] as Excel.Range).Value2;
            if (value != null)
            {
                hotelExtraMealListed = true;
            }

            CmbboxWrkngHtlMealPlan.Enabled = hotelMealPlanListed;
            numericUpDownExtraBed.Enabled = hotelExtraBedListed;
            numericUpDownExtraMeal.Enabled = hotelExtraMealListed;
        }

        private void buttonHotelAddRow_Click(object sender, EventArgs e)
        {
            /* populate data in the datagrid view */
            if (string.Equals("", openFileDialogForHotelExcel.FileName, StringComparison.OrdinalIgnoreCase))
            {
                Debug.WriteLine("buttonHotelAddRow Hotel excel file not selected");
                MessageBox.Show("Select Hotel Excel file first");
                return;
            }
            int hotelRowIndex = Convert.ToInt32(CmbboxWrkngHtlHotel.SelectedValue);
            if (hotelRowIndex < 3)
            {
                Debug.WriteLine("buttonHotelAddRow Hotel name not selected");
                MessageBox.Show("Select Hotel first");
                return;
            }
            if (Convert.ToInt32(CmbboxWrkngHtlMealPlan.SelectedValue) < 1)
            {
                Debug.WriteLine("buttonHotelAddRow Meal plan not selected");
                MessageBox.Show("Select Meal plan first");
                return;
            }
            /* check for the days count */
            /*
            int index = dataGrdVuWorkingHotels.RowCount;
            double noOfdays = (DateTime.Parse(frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["todate"].ToString()) - 
                DateTime.Parse(frmQueryWorkingDataSet.Tables["QUERYID_DATA"].Rows[0]["fromdate"].ToString())).TotalDays;
            if(index >= noOfdays)
            {
                Debug.WriteLine("Hotel listing for all days are done");
                MessageBox.Show("Hotel listing for all days are done");
                return;
            }
            else
            {
                Debug.WriteLine("Total days = " + noOfdays.ToString() + " and worked days count is " + index.ToString());
            }
            */
            int index = dataGrdVuWorkingHotels.Rows.Add();
            dataGrdVuWorkingHotels.Rows[index].Cells["DAYS"].Value = numericUpDownWorkingHotelDayNo.Value.ToString();
            dataGrdVuWorkingHotels.Rows[index].Cells["Sector"].Value = CmbboxWrkngHtlSector.Text;
            dataGrdVuWorkingHotels.Rows[index].Cells["Location"].Value = CmbboxWrkngHtlLocation.Text;
            dataGrdVuWorkingHotels.Rows[index].Cells["Hotel"].Value = CmbboxWrkngHtlHotel.Text; ;
            dataGrdVuWorkingHotels.Rows[index].Cells["RoomType"].Value = "NOT DECLARED YET";
            dataGrdVuWorkingHotels.Rows[index].Cells["RoomNo"].Value = numericUpDownRoomNo.Value.ToString();
            dataGrdVuWorkingHotels.Rows[index].Cells["MealPlan"].Value = CmbboxWrkngHtlMealPlan.Text;
            dataGrdVuWorkingHotels.Rows[index].Cells["ExtraBed"].Value = numericUpDownExtraBed.Value.ToString();
            dataGrdVuWorkingHotels.Rows[index].Cells["ExtraMeal"].Value = numericUpDownExtraMeal.Value.ToString();

            /* Check extra bed present or not*/
            Int32 extraMealPrice;
            Int32 extraBedPrice;
            Object value = null;
            value = (xlsRangeWorkingHotel.Cells[hotelRowIndex, 10] as Excel.Range).Value2;
            if (value == null)
            {
                extraBedPrice = 0;
            }
            else
            {
                extraBedPrice = Convert.ToInt32(value.ToString());
            }
            extraBedPrice = extraBedPrice * Convert.ToInt32(numericUpDownExtraBed.Value);

            /* Check extra meal present or not*/
            value = (xlsRangeWorkingHotel.Cells[hotelRowIndex, 11] as Excel.Range).Value2;
            if (value == null)
            {
                extraMealPrice = 0;
            }
            else
            {
                extraMealPrice = Convert.ToInt32(value.ToString());
            }
            extraMealPrice = extraMealPrice * Convert.ToInt32(numericUpDownExtraMeal.Value);

            Int32 hotelPrice = Convert.ToInt32(CmbboxWrkngHtlMealPlan.SelectedValue) + extraMealPrice + extraBedPrice;

            dataGrdVuWorkingHotels.Rows[index].Cells["HotelPrice"].Value = hotelPrice.ToString();
        }

        private void ButtonWorkingDone_Click(object sender, EventArgs e)
        {
            /* upload data of work done in the database */
            int hotelWorkingRowsCount = dataGrdVuWorkingHotels.RowCount;
            if(hotelWorkingRowsCount < 1)
            {
                MessageBox.Show("Working area is empty.");
                return;
            }
            bool querySuccess = true;
            MySqlCommand mySqlCommandButtonWorkingDone = frmQueryWorkingMysqlConn.CreateCommand();
            frmQueryWorkingMysqlTransaction = frmQueryWorkingMysqlConn.BeginTransaction();
            mySqlCommandButtonWorkingDone.Connection = frmQueryWorkingMysqlConn;
            mySqlCommandButtonWorkingDone.Transaction = frmQueryWorkingMysqlTransaction;
            mySqlCommandButtonWorkingDone.CommandType = CommandType.Text;
            string mysqlInsertQueryStr = "INSERT INTO `queryworkinghotel` ( " +
                "`queryid`, " +
                "`dayno`, " +
                "`roomno`, " +
                "`area`, " +
                "`city`, " +
                "`hotel`, " +
                "`roomtype`, " +
                "`mealplan`," +
                "`extrabed`, " +
                "`extrameal`, " +
                "`price` ) " +
                "VALUES ( " +
                "@queryid_var, " +
                "@dayno_var, " +
                "@roomno_var, " +
                "@area_var, " +
                "@city_var, " +
                "@hotel_var, " +
                "@roomtype_var, " +
                "@mealplan_var, " +
                "@extrabed_var, " +
                "@extrameal_var, " +
                "@price_var )";
            mySqlCommandButtonWorkingDone.CommandText = mysqlInsertQueryStr;
            mySqlCommandButtonWorkingDone.Prepare();
            mySqlCommandButtonWorkingDone.Parameters.AddWithValue("@queryid_var", "Text");
            mySqlCommandButtonWorkingDone.Parameters.AddWithValue("@dayno_var", 1);
            mySqlCommandButtonWorkingDone.Parameters.AddWithValue("@roomno_var", 1);
            mySqlCommandButtonWorkingDone.Parameters.AddWithValue("@area_var", "Text");
            mySqlCommandButtonWorkingDone.Parameters.AddWithValue("@city_var", "Text");
            mySqlCommandButtonWorkingDone.Parameters.AddWithValue("@hotel_var", "Text");
            mySqlCommandButtonWorkingDone.Parameters.AddWithValue("@roomtype_var", "Text");
            mySqlCommandButtonWorkingDone.Parameters.AddWithValue("@mealplan_var", "Text");
            mySqlCommandButtonWorkingDone.Parameters.AddWithValue("@extrabed_var", 1);
            mySqlCommandButtonWorkingDone.Parameters.AddWithValue("@extrameal_var", 1);
            mySqlCommandButtonWorkingDone.Parameters.AddWithValue("@price_var", 1);
            for (int index = 0; index < hotelWorkingRowsCount; index++)
            {
                /* insert row data in database */
                mySqlCommandButtonWorkingDone.Parameters["@queryid_var"].Value = queryIdWorking;
                mySqlCommandButtonWorkingDone.Parameters["@dayno_var"].Value = Convert.ToInt32(dataGrdVuWorkingHotels.Rows[index].Cells["DAYS"].Value);
                mySqlCommandButtonWorkingDone.Parameters["@roomno_var"].Value = Convert.ToInt32(dataGrdVuWorkingHotels.Rows[index].Cells["RoomNo"].Value);
                mySqlCommandButtonWorkingDone.Parameters["@area_var"].Value = dataGrdVuWorkingHotels.Rows[index].Cells["Sector"].Value.ToString();
                mySqlCommandButtonWorkingDone.Parameters["@city_var"].Value = dataGrdVuWorkingHotels.Rows[index].Cells["Location"].Value.ToString();
                mySqlCommandButtonWorkingDone.Parameters["@hotel_var"].Value = dataGrdVuWorkingHotels.Rows[index].Cells["Hotel"].Value.ToString();
                mySqlCommandButtonWorkingDone.Parameters["@mealplan_var"].Value = dataGrdVuWorkingHotels.Rows[index].Cells["MealPlan"].Value.ToString();
                mySqlCommandButtonWorkingDone.Parameters["@extrabed_var"].Value = Convert.ToInt32(dataGrdVuWorkingHotels.Rows[index].Cells["ExtraBed"].Value);
                mySqlCommandButtonWorkingDone.Parameters["@extrameal_var"].Value = Convert.ToInt32(dataGrdVuWorkingHotels.Rows[index].Cells["ExtraMeal"].Value);
                mySqlCommandButtonWorkingDone.Parameters["@price_var"].Value = Convert.ToInt32(dataGrdVuWorkingHotels.Rows[index].Cells["HotelPrice"].Value);
                try
                {
                    mySqlCommandButtonWorkingDone.ExecuteNonQuery();
                    
                }
                catch (Exception errquery)
                {
                    MessageBox.Show("Error while executing insert query because:\n" + errquery.Message);
                    querySuccess = false;
                    break;
                }
            }
            if(querySuccess)
            {
                MessageBox.Show("Query Executed successfully now changing query status");
                mysqlInsertQueryStr = "UPDATE `queries` SET " +
                    "`querylastupdatetime` = NOW(), " +
                    "`querycurrentstate` = " + Properties.Resources.queryStageDoneByUser + " " +
                    "WHERE " +
                    "queryid = " + queryIdWorking;
                mySqlCommandButtonWorkingDone.CommandText = mysqlInsertQueryStr;
                mySqlCommandButtonWorkingDone.Prepare();
                try
                {
                    mySqlCommandButtonWorkingDone.ExecuteNonQuery();

                }
                catch (Exception errquery)
                {
                    MessageBox.Show("Error while executing insert query because:\n" + errquery.Message);
                    querySuccess = false;
                }
            }
            try
            {
                if (querySuccess)
                {
                    frmQueryWorkingMysqlTransaction.Commit();
                }
                else
                {
                    frmQueryWorkingMysqlTransaction.Rollback();
                }
            }
            catch (Exception errcommit)
            {
                MessageBox.Show("Error while executing insert query because:\n" + errcommit.Message);
            }
            MessageBox.Show("Work for Query id = " + queryIdWorking + " is done successfully ");
            Close();
        }

        private void ButtonWorkingCancel_Click(object sender, EventArgs e)
        {
            /* exit without doing anything*/
            Close();
        }
    }
}
