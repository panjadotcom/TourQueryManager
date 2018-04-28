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

namespace TourQueryManager
{
    public partial class FrmQueryWorkingPage : Form
    {
        Excel.Application xlsAppWorkingHotel;
        Excel.Workbook xlsWorkbookWorkingHotel;
        Excel.Worksheet xlsWorksheetWorkingHotel;
        Excel.Range xlsRangeWorkingHotel;
        static string queryIdWorking = null;
        public FrmQueryWorkingPage(string queryId)
        {
            InitializeComponent();
            queryIdWorking = queryId;
        }

        private void FrmQueryWorkingPage_Load(object sender, EventArgs e)
        {
            /* data to be initialized when loading page */
            Text = "Working on QUERYID (" + queryIdWorking + ")";
            txtboxQueryDetails.Text = "Working on QUERYID (" + queryIdWorking + ")";
            xlsAppWorkingHotel = new Excel.Application();
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
            }

            CmbboxWrkngHtlMealPlan.DataSource = dataTableHotelMealPlan;
            CmbboxWrkngHtlMealPlan.DisplayMember = "MEAL_PLAN";
            CmbboxWrkngHtlMealPlan.ValueMember = "MEAL_RATE";
            CmbboxWrkngHtlMealPlan.SelectedIndex = 0;

            /* Check extra bed present or not*/
            value = (xlsRangeWorkingHotel.Cells[hotelRowIndex, 10] as Excel.Range).Value2;
            if (value == null)
            {
                numericUpDownExtraBed.Enabled = false;
            }
            else
            {
                numericUpDownExtraBed.Enabled = true;
            }

            /* Check extra meal present or not*/
            value = (xlsRangeWorkingHotel.Cells[hotelRowIndex, 11] as Excel.Range).Value2;
            if (value == null)
            {
                numericUpDownExtraMeal.Enabled = false;
            }
            else
            {
                numericUpDownExtraMeal.Enabled = true;
            }
        }

        private void buttonHotelAddRow_Click(object sender, EventArgs e)
        {
            /* populate data in the datagrid view */
            int hotelRowIndex = Convert.ToInt32(CmbboxWrkngHtlHotel.SelectedValue);
            if (hotelRowIndex < 3)
            {
                MessageBox.Show("Select Hotel first");
                return;
            }
            if (Convert.ToInt32(CmbboxWrkngHtlMealPlan.SelectedValue) < 1)
            {
                MessageBox.Show("Select Meal plan first");
                return;
            }
            int index = dataGrdVuWorkingHotels.Rows.Add();
            dataGrdVuWorkingHotels.Rows[index].Cells["DAYS"].Value = "DAY " + index.ToString();
            dataGrdVuWorkingHotels.Rows[index].Cells["Sector"].Value = CmbboxWrkngHtlSector.Text;
            dataGrdVuWorkingHotels.Rows[index].Cells["Location"].Value = CmbboxWrkngHtlLocation.Text;
            dataGrdVuWorkingHotels.Rows[index].Cells["Hotel"].Value = CmbboxWrkngHtlHotel.Text; ;
            dataGrdVuWorkingHotels.Rows[index].Cells["RoomType"].Value = "NOT DECLARED YET";
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
    }
}
