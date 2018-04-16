using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TourQueryManager
{
    public partial class FrmEditQueryPage : Form
    {
        static string mysqlConnStr = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection frmEditQueryMysqlConn = new MySqlConnection(mysqlConnStr);
        MySqlTransaction frmEditQueryMysqlTransaction = null;
        MySqlDataAdapter frmEditQueryMysqlDataAdaptor = null;
        DataSet frmEditQueryDataSet = null;
        bool updateQueryFlag = false;
        public FrmEditQueryPage()
        {
            InitializeComponent();
        }

        private void FrmEditQueryPage_Load(object sender, EventArgs e)
        {
            /* This will be called during loading the form */
            try
            {
                frmEditQueryMysqlConn.Open();
            }
            catch ( Exception erropen)
            {
                MessageBox.Show("connection cannot be opened because " + erropen.Message + "");
                Close();
            }
            cmbboxQueryId.Enabled = false;
            frmEditQueryDataSet = new DataSet();
            string userSelectMysqlQueryString = "SELECT `userid`, `username`, `name` FROM `appusers` WHERE `userid` > 1 ORDER BY `userid`";
            string clientSelectMysqlQueryString = "SELECT `clientid`, `name` FROM `clients` ORDER BY `clientid`";
            try
            {
                frmEditQueryMysqlDataAdaptor = new MySqlDataAdapter(userSelectMysqlQueryString, frmEditQueryMysqlConn);
                frmEditQueryMysqlDataAdaptor.Fill(frmEditQueryDataSet, "USER_COMBO_BOX");
                frmEditQueryMysqlDataAdaptor = new MySqlDataAdapter(clientSelectMysqlQueryString, frmEditQueryMysqlConn);
                frmEditQueryMysqlDataAdaptor.Fill(frmEditQueryDataSet, "CLIENT_COMBO_BOX");
                if(frmEditQueryDataSet != null)
                {
                    cmbboxClientId.DataSource = frmEditQueryDataSet.Tables["CLIENT_COMBO_BOX"];
                    cmbboxClientId.ValueMember = "clientid";
                    cmbboxClientId.DisplayMember = "name";
                    cmbboxUserId.DataSource = frmEditQueryDataSet.Tables["USER_COMBO_BOX"];
                    cmbboxUserId.ValueMember = "userid";
                    cmbboxUserId.DisplayMember = "username";
                }
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
            }
        }

        private void FrmEditQueryPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* this will be called during closing of the form page */
            try
            {
                frmEditQueryMysqlConn.Close();
            }
            catch (Exception erropen)
            {
                MessageBox.Show("connection cannot be closed because " + erropen.Message + "");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /* generate insert query and upload into database */
            string mysqlInsertQueryStr;
            MySqlCommand btnUpdateMysqlCommand = frmEditQueryMysqlConn.CreateCommand();
            frmEditQueryMysqlTransaction = frmEditQueryMysqlConn.BeginTransaction();
            btnUpdateMysqlCommand.Connection = frmEditQueryMysqlConn;
            btnUpdateMysqlCommand.Transaction = frmEditQueryMysqlTransaction;
            btnUpdateMysqlCommand.CommandType = CommandType.Text;
            DateTime date;
            if (updateQueryFlag)
            {
                mysqlInsertQueryStr = "UPDATE `queries` SET" +
                    " `clientid` = @clientid_var," +
                    " `userid` = @userid_var," +
                    " `place` = @place_var," +
                    " `destinationcovered` = @destinationcovered_var," +
                    " `fromdate` = @fromdate_var," +
                    " `todate` = @todate_var," +
                    " `adults` = @adults_var," +
                    " `children` = @children_var," +
                    " `babies` = @babies_var," +
                    " `roomcount` = @roomcount_var," +
                    " `meal` = @meal_var," +
                    " `hotelcategory` = @hotelcategory_var," +
                    " `arrivaldate` = @arrivaldate_var," +
                    " `departuredate` = @departuredate_var," +
                    " `arrivalcity` = @arrivalcity_var," +
                    " `departurecity` = @departurecity_var," +
                    " `vehicalcategory` = @vehicalcategory_var," +
                    " `requirement` = @requirement_var," +
                    " `budget` = @budget_var," +
                    " `note` = @note_var" +
                    " WHERE" +
                    " `queryid` = @queryid_var";
            }
            else
            {
                mysqlInsertQueryStr = "INSERT INTO `queries` ( `queryid`, `clientid`, `userid`, `place`, `destinationcovered`, `fromdate`, `todate`, `adults`, `children`, `babies`, `roomcount`, `meal`, `hotelcategory`, `arrivaldate`, `departuredate`, `arrivalcity`, `departurecity`, `vehicalcategory`, `requirement`, `budget`, `note` ) "
                    + "VALUES ( @queryid_var, @clientid_var, @userid_var, @place_var, @destinationcovered_var, @fromdate_var, @todate_var, @adults_var, @children_var, @babies_var, @roomcount_var,@meal_var, @hotelcategory_var, @arrivaldate_var, @departuredate_var, @arrivalcity_var, @departurecity_var, @vehicalcategory_var, @requirement_var, @budget_var, @note_var )";
            }
            btnUpdateMysqlCommand.CommandText = mysqlInsertQueryStr;
            btnUpdateMysqlCommand.Prepare();
            btnUpdateMysqlCommand.Parameters.AddWithValue("@queryid_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@clientid_var", 1);
            btnUpdateMysqlCommand.Parameters.AddWithValue("@userid_var", 1);
            btnUpdateMysqlCommand.Parameters.AddWithValue("@place_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@destinationcovered_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@fromdate_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@todate_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@adults_var", 1);
            btnUpdateMysqlCommand.Parameters.AddWithValue("@children_var", 1);
            btnUpdateMysqlCommand.Parameters.AddWithValue("@babies_var", 1);
            btnUpdateMysqlCommand.Parameters.AddWithValue("@roomcount_var", 1);
            btnUpdateMysqlCommand.Parameters.AddWithValue("@meal_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@hotelcategory_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@arrivaldate_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@departuredate_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@arrivalcity_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@departurecity_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@vehicalcategory_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@requirement_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@budget_var", 1);
            btnUpdateMysqlCommand.Parameters.AddWithValue("@note_var", "Text");

            if (string.Equals(cmbboxClientId.Text, "", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("ClientId field cannot be empty");
                return;
            }
            else
            {
                btnUpdateMysqlCommand.Parameters["@clientid_var"].Value = cmbboxClientId.SelectedValue;// cmbboxClientId.SelectedIndex;
            }

            if (string.Equals(cmbboxUserId.Text, "", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("userid field cannot be empty");
                return;
            }
            else
            {
                btnUpdateMysqlCommand.Parameters["@userid_var"].Value = cmbboxUserId.SelectedValue;
                
            }

            if (string.Equals(txtboxPlace.Text, "", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Place field cannot be empty");
                return;
            }
            else
            {
                btnUpdateMysqlCommand.Parameters["@place_var"].Value = txtboxPlace.Text;
            }

            btnUpdateMysqlCommand.Parameters["@destinationcovered_var"].Value = txtboxDstnCvrd.Text;

            date = dttmpckrFromDate.Value;
            btnUpdateMysqlCommand.Parameters["@fromdate_var"].Value = date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString();

            date = dttmpckrToDate.Value;
            btnUpdateMysqlCommand.Parameters["@todate_var"].Value = date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString();

            btnUpdateMysqlCommand.Parameters["@adults_var"].Value = nmbrUpDwnPersonAdult.Value;

            btnUpdateMysqlCommand.Parameters["@children_var"].Value = nmbrUpDwnPersonChild.Value;

            btnUpdateMysqlCommand.Parameters["@babies_var"].Value = nmbrUpDwnPersonInfnt.Value;

            btnUpdateMysqlCommand.Parameters["@roomcount_var"].Value = nmbrUpDwnRoomCount.Value;

            bool mealRadioBtnChkFlag = true;
            foreach( var grpboxMealControl in grpboxMeal.Controls)
            {
                RadioButton mealRadioBtn = grpboxMealControl as RadioButton;
                if( ( mealRadioBtn != null ) && ( mealRadioBtn.Checked ) )
                {
                    btnUpdateMysqlCommand.Parameters["@meal_var"].Value = mealRadioBtn.Text;
                    mealRadioBtnChkFlag = false;
                }
            }
            if(mealRadioBtnChkFlag)
            {
                btnUpdateMysqlCommand.Parameters["@meal_var"].Value = "No Meal";
            }

            string hotelCtgryString = "";
            bool hotelCtgryFirstFlag = true;
            foreach(var grpboxHtlCtgryCtrl in grpboxHtlCtgry.Controls)
            {
                CheckBox htlCtgryChkBox = grpboxHtlCtgryCtrl as CheckBox;
                if ((htlCtgryChkBox != null) && (htlCtgryChkBox.Checked))
                {
                    if (hotelCtgryFirstFlag)
                    {
                        hotelCtgryString += htlCtgryChkBox.Text;
                        hotelCtgryFirstFlag = false;
                    }
                    else
                    {
                        hotelCtgryString += " and ";
                        hotelCtgryString += htlCtgryChkBox.Text;
                    }
                }
            }
            btnUpdateMysqlCommand.Parameters["@hotelcategory_var"].Value = hotelCtgryString;

            date = dttmpkrArvlDate.Value;
            btnUpdateMysqlCommand.Parameters["@arrivaldate_var"].Value = date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString();

            date = dttmpkrDptrDate.Value;
            btnUpdateMysqlCommand.Parameters["@departuredate_var"].Value = date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString();

            btnUpdateMysqlCommand.Parameters["@arrivalcity_var"].Value = txtboxArvlCity.Text;

            btnUpdateMysqlCommand.Parameters["@departurecity_var"].Value = txtboxDptrCity.Text;

            btnUpdateMysqlCommand.Parameters["@vehicalcategory_var"].Value = cmbboxVehicleCtgry.Text;

            bool rqmntRadioBtnChkFlag = true;
            foreach (var grpboxRqmntControl in grpboxRqmnt.Controls)
            {
                RadioButton rqmntRadioBtn = grpboxRqmntControl as RadioButton;
                if ((rqmntRadioBtn != null) && (rqmntRadioBtn.Checked))
                {
                    btnUpdateMysqlCommand.Parameters["@requirement_var"].Value = rqmntRadioBtn.Text;
                    rqmntRadioBtnChkFlag = false;
                }
            }
            if (rqmntRadioBtnChkFlag)
            {
                btnUpdateMysqlCommand.Parameters["@requirement_var"].Value = "Hotel Only";
            }

            btnUpdateMysqlCommand.Parameters["@budget_var"].Value = Convert.ToUInt32(txtboxBudget.Text);

            btnUpdateMysqlCommand.Parameters["@note_var"].Value = txtboxNote.Text;

            string queryIdStr;
            if (updateQueryFlag)
            {
                queryIdStr = cmbboxQueryId.Text;
            }
            else
            {
                DateTime today = DateTime.Now;
                queryIdStr = "5136"
                    + today.Year.ToString()
                    + today.Month.ToString()
                    + today.Day.ToString()
                    + cmbboxClientId.SelectedValue.ToString()
                    + cmbboxUserId.SelectedValue.ToString()
                    + today.Hour.ToString()
                    + today.Minute.ToString();
            }
            btnUpdateMysqlCommand.Parameters["@queryid_var"].Value = queryIdStr;

            /* now update in database */
            try
            {
                int result = btnUpdateMysqlCommand.ExecuteNonQuery();
                MessageBox.Show("Query Executed. with result = " + result.ToString() );
                frmEditQueryMysqlTransaction.Commit();
            }
            catch(Exception errquery)
            {
                MessageBox.Show("Error while executing insert query because:\n" + errquery.Message);
            }
        }

        private void lnklblModifyQuery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* this method will be used to reset the fields
             * and populate query id from database server
             * enable disable other fields accordingly
             */
            lnklblModifyQuery.Enabled = false;
            lnklblModifyQuery.Visible = false;
            btnLoadQuery.Enabled = true;
            btnLoadQuery.Visible = true;
            btnDeleteQuery.Enabled = true;
            btnDeleteQuery.Visible = true;
            updateQueryFlag = true;

            frmEditQueryDataSet = new DataSet();
            string queryIdSelectMysqlQueryString = "SELECT `queryno`, `queryid` FROM `queries` WHERE `queryno` > 1 ORDER BY `queryno`";
            try
            {
                frmEditQueryMysqlDataAdaptor = new MySqlDataAdapter(queryIdSelectMysqlQueryString, frmEditQueryMysqlConn);
                frmEditQueryMysqlDataAdaptor.Fill(frmEditQueryDataSet, "QUERYID_COMBO_BOX");
                if (frmEditQueryDataSet != null)
                {
                    cmbboxQueryId.DataSource = frmEditQueryDataSet.Tables["QUERYID_COMBO_BOX"];
                    cmbboxQueryId.ValueMember = "queryno";
                    cmbboxQueryId.DisplayMember = "queryid";
                }
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
            }

            /* reset the form */
            cmbboxClientId.Text = "";
            cmbboxUserId.Text = "";
            cmbboxVehicleCtgry.Text = "";
            txtboxArvlCity.Text = "";
            txtboxBudget.Text = "";
            txtboxDptrCity.Text = "";
            txtboxDstnCvrd.Text = "";
            txtboxNote.Text = "";
            txtboxPlace.Text = "";
            nmbrUpDwnPersonAdult.Value = 0;
            nmbrUpDwnPersonChild.Value = 0;
            nmbrUpDwnPersonInfnt.Value = 0;
            nmbrUpDwnRoomCount.Value = 0;
            chkBox1Star.Checked = false;
            chkBox2Star.Checked = false;
            chkBox3Star.Checked = false;
            chkBox4Star.Checked = false;
            chkBox5Star.Checked = false;
            radioBtnMealBrkfstDnr.Checked = false;
            radioBtnMealBrkfstLnchDnr.Checked = false;
            radioBtnMealBrkfstOnly.Checked = false;
            radioBtnMealNoMeal.Checked = false;
            radioBtnRqmntHtlOnly.Checked = false;
            radioBtnRqmntTourPkg.Checked = false;
            radioBtnRqmntTourPlusFlight.Checked = false;
            radioBtnRqmntTrnsprtOnly.Checked = false;
        }

        private void btnDeleteQuery_Click(object sender, EventArgs e)
        {
            if (string.Equals(txtboxPlace.Text, ""))
            {
                MessageBox.Show("Form is Empty. Please Select and load query first");
                return;
            }
            MySqlCommand btnDeleteMysqlCommand = frmEditQueryMysqlConn.CreateCommand();
            MySqlTransaction btnDeleteMysqlTransaction = frmEditQueryMysqlConn.BeginTransaction();
            btnDeleteMysqlCommand.Connection = frmEditQueryMysqlConn;
            btnDeleteMysqlCommand.Transaction = btnDeleteMysqlTransaction;
            btnDeleteMysqlCommand.CommandType = CommandType.Text;
            /* delete the selected query entry from the database */
            string mysqlDeleteQueryStr = "DELETE FROM `queries`" +
                " WHERE" +
                " `queryid` = @queryid_var";
            btnDeleteMysqlCommand.CommandText = mysqlDeleteQueryStr;
            btnDeleteMysqlCommand.Prepare();
            btnDeleteMysqlCommand.Parameters.AddWithValue("@queryid_var", "Text");
            btnDeleteMysqlCommand.Parameters["@queryid_var"].Value = cmbboxQueryId.Text;

            try
            {
                int result = btnDeleteMysqlCommand.ExecuteNonQuery();
                MessageBox.Show("Query Executed. with result = " + result.ToString());
                frmEditQueryMysqlTransaction.Commit();
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Error while executing delete query because:\n" + errquery.Message);
            }
        }

        private void btnLoadQuery_Click(object sender, EventArgs e)
        {
            /* load data from Database from query table using queryid */
            frmEditQueryDataSet = new DataSet();
            string queryDataSelectMysqlQueryString = "SELECT" +
                " `clientid`," +
                " `userid`," +
                " `place`," +
                " `destinationcovered`," +
                " `fromdate`," +
                " `todate`," +
                " `adults`," +
                " `children`," +
                " `babies`," +
                " `roomcount`," +
                " `meal`," +
                " `hotelcategory`," +
                " `arrivaldate`," +
                " `departuredate`," +
                " `arrivalcity`" +
                " `departurecity`," +
                " `vehicalcategory`," +
                " `requirement`," +
                " `budget`," +
                " `note`" +
                " FROM `queries` WHERE `queryid` = " + cmbboxQueryId.DisplayMember;
            try
            {
                frmEditQueryMysqlDataAdaptor = new MySqlDataAdapter(queryDataSelectMysqlQueryString, frmEditQueryMysqlConn);
                frmEditQueryMysqlDataAdaptor.Fill(frmEditQueryDataSet, "QUERYID_FULL_FORM");
                if (frmEditQueryDataSet != null)
                {
                    /* data read from database now write down to page */
                    string queriesColumnStr;

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["clientid"].ToString();
                    cmbboxClientId.SelectedValue = Convert.ToUInt32(queriesColumnStr);

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["userid"].ToString();
                    cmbboxUserId.SelectedValue = Convert.ToUInt32(queriesColumnStr);

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["place"].ToString();
                    txtboxPlace.Text = queriesColumnStr;

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["destinationcovered"].ToString();
                    txtboxDstnCvrd.Text = queriesColumnStr;

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["fromdate"].ToString();
                    dttmpckrFromDate.Value = DateTime.Parse(queriesColumnStr);

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["todate"].ToString();
                    dttmpckrToDate.Value = DateTime.Parse(queriesColumnStr);

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["adults"].ToString();
                    nmbrUpDwnPersonAdult.Value = Convert.ToUInt32(queriesColumnStr);

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["children"].ToString();
                    nmbrUpDwnPersonChild.Value = Convert.ToUInt32(queriesColumnStr);

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["babies"].ToString();
                    nmbrUpDwnPersonInfnt.Value = Convert.ToUInt32(queriesColumnStr);

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["roomcount"].ToString();
                    nmbrUpDwnRoomCount.Value = Convert.ToUInt32(queriesColumnStr);

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["meal"].ToString();
                    foreach (var grpboxMealControl in grpboxMeal.Controls)
                    {
                        if (grpboxMealControl is RadioButton mealRadioBtn)
                        {
                            if (string.Equals(mealRadioBtn.Text, queriesColumnStr))
                            {
                                mealRadioBtn.Checked = true;
                                break;
                            }
                        }
                    }

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["hotelcategory"].ToString();
                    foreach(var chkboxHtlCtgryCtrl in grpboxHtlCtgry.Controls)
                    {
                        if(chkboxHtlCtgryCtrl is CheckBox checkBoxHtlCtgry)
                        {
                            if(queriesColumnStr.Contains(checkBoxHtlCtgry.Text))
                            {
                                checkBoxHtlCtgry.Checked = true;
                            }
                        }
                    }

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["arrivaldate"].ToString();
                    dttmpkrArvlDate.Value = DateTime.Parse(queriesColumnStr);

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["departuredate"].ToString();
                    dttmpkrDptrDate.Value = DateTime.Parse(queriesColumnStr);

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["arrivalcity"].ToString();
                    txtboxArvlCity.Text = queriesColumnStr;

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["departurecity"].ToString();
                    txtboxDptrCity.Text = queriesColumnStr;

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["vehicalcategory"].ToString();
                    cmbboxVehicleCtgry.SelectedText = queriesColumnStr;

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["requirement"].ToString();
                    foreach (var grpboxRqmntControl in grpboxRqmnt.Controls)
                    {
                        if (grpboxRqmntControl is RadioButton rqmntRadioBtn)
                        {
                            if (string.Equals(rqmntRadioBtn.Text, queriesColumnStr))
                            {
                                rqmntRadioBtn.Checked = true;
                                break;
                            }
                        }
                    }

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["budget"].ToString();
                    txtboxBudget.Text = queriesColumnStr;

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["note"].ToString();
                    txtboxNote.Text = queriesColumnStr;
                }
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
            }
        }
    }
}
