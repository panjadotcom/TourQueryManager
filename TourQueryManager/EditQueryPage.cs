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
using System.Diagnostics;

namespace TourQueryManager
{
    public partial class FrmEditQueryPage : Form
    {
        static string mysqlConnStr = Properties.Settings.Default.mysqlConnStr;
        static string queryActivityFlagStr = null;
        MySqlConnection frmEditQueryMysqlConn = new MySqlConnection(mysqlConnStr);
        MySqlTransaction frmEditQueryMysqlTransaction = null;
        MySqlDataAdapter frmEditQueryMysqlDataAdaptor = null;
        DataSet frmEditQueryDataSet = null;
        bool updateQueryFlag = false;

        public FrmEditQueryPage(string queryActivityFlag)
        {
            InitializeComponent();
            queryActivityFlagStr = queryActivityFlag;
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
            frmEditQueryDataSet = new DataSet();
            string userSelectMysqlQueryString = "SELECT `userid`, `username`, `name` FROM `appusers` WHERE `userid` > 1 ORDER BY `userid`";
            string agentSelectMysqlQueryString = "SELECT `agentid`, `name` FROM `agents` ORDER BY `agentid`";
            string querySelectMysqlQueryString = null;
            if (string.Equals(queryActivityFlagStr, "NEW QUERY"))
            {
                querySelectMysqlQueryString = "SELECT `queryid` FROM `queries` WHERE " +
                    "`queryno` = 0 " +
                    "AND `querycurrentstate` = " + Properties.Resources.queryStageGenerated + " " +
                    "ORDER BY `queryno`";
                btnUpdate.Text = "INSERT";
            }
            else if (string.Equals(queryActivityFlagStr, "UPDATE RAW QUERY"))
            {
                querySelectMysqlQueryString = "SELECT `queryid` FROM `queries` WHERE " +
                    "`queryno` > 0 " +
                    "AND `querycurrentstate` >= " + Properties.Resources.queryStageGenerated + " " +
                    "AND `querycurrentstate` <= " + Properties.Resources.queryStageMailed + " " +
                    "ORDER BY `queryno`";
                btnUpdate.Text = "EXIT";
            }
            /*else if (string.Equals(queryActivityFlagStr, "FINALIZE OFFER"))
            {
                querySelectMysqlQueryString = "SELECT `queryid` FROM `queries` WHERE `queryno` > 0 AND `querycurrentstate` = " + Properties.Resources.queryStageMailed.ToString() + " ORDER BY `queryno`";
                btnUpdate.Text = "EXIT";
            }
            else if (string.Equals(queryActivityFlagStr, "UPDATE ACCEPTED OFFER"))
            {
                querySelectMysqlQueryString = "SELECT `queryid` FROM `queries` WHERE `queryno` > 0 AND `querycurrentstate` = " + Properties.Resources.queryStageDealDone.ToString() + " ORDER BY `queryno`";
                btnUpdate.Text = "EXIT";
            }*/
            else
            {
                Close();
                return;
            }
            try
            {
                frmEditQueryMysqlDataAdaptor = new MySqlDataAdapter(userSelectMysqlQueryString, frmEditQueryMysqlConn);
                frmEditQueryMysqlDataAdaptor.Fill(frmEditQueryDataSet, "USER_COMBO_BOX");
                frmEditQueryMysqlDataAdaptor = new MySqlDataAdapter(agentSelectMysqlQueryString, frmEditQueryMysqlConn);
                frmEditQueryMysqlDataAdaptor.Fill(frmEditQueryDataSet, "AGENT_COMBO_BOX");
                frmEditQueryMysqlDataAdaptor = new MySqlDataAdapter(querySelectMysqlQueryString, frmEditQueryMysqlConn);
                frmEditQueryMysqlDataAdaptor.Fill(frmEditQueryDataSet, "QUERY_COMBO_BOX");
                if (frmEditQueryDataSet != null)
                {
                    cmbboxAgentId.DataSource = frmEditQueryDataSet.Tables["AGENT_COMBO_BOX"];
                    cmbboxAgentId.ValueMember = "agentid";
                    cmbboxAgentId.DisplayMember = "name";
                    cmbboxUserId.DataSource = frmEditQueryDataSet.Tables["USER_COMBO_BOX"];
                    cmbboxUserId.ValueMember = "userid";
                    cmbboxUserId.DisplayMember = "username";
                    DataRow dataRow = frmEditQueryDataSet.Tables["QUERY_COMBO_BOX"].NewRow();
                    if (string.Equals(queryActivityFlagStr, "NEW QUERY"))
                    {
                        dataRow["queryid"] = "NEW QUERY";
                    }
                    else
                    {
                        if (frmEditQueryDataSet.Tables["QUERY_COMBO_BOX"].Rows.Count == 0)
                        {
                            MessageBox.Show("No Data present in the database to " + queryActivityFlagStr, "No Data present", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataRow["queryid"] = "NO QUERY PRESENT";
                            /* Close this form as form is useless in this case */
                            Close();
                        }
                        else
                        {
                            dataRow["queryid"] = "SELECT QUERY";
                        }
                        
                    }
                    frmEditQueryDataSet.Tables["QUERY_COMBO_BOX"].Rows.InsertAt(dataRow, 0);
                    cmbboxQueryId.DataSource = frmEditQueryDataSet.Tables["QUERY_COMBO_BOX"];
                    cmbboxQueryId.ValueMember = "queryid";
                    cmbboxQueryId.DisplayMember = "queryid";
                    cmbboxQueryId.SelectedIndex = 0;
                    //cmbboxQueryId.SelectedValue = 0;
                }
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Query cannot be executed because " + errquery.Message + "");
            }
            cmbboxUserId.SelectedValue = 0;
            cmbboxAgentId.SelectedValue = 0;
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
            if (string.Equals(btnUpdate.Text, "EXIT"))
            {
                Close();
                return;
            }
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
                    " `agentid` = @agentid_var," +
                    " `userid` = @userid_var," +
                    " `profitmargin` = @profitmargin_var," +
                    " `gstrate` = @gstrate_var," +
                    " `name` = @name_var," +
                    " `contact` = @contact_var," +
                    " `place` = @place_var," +
                    " `querylastupdatetime` = NOW()," +
                    " `querycurrentstate` = " + Properties.Resources.queryStageGenerated + "," +
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
                mysqlInsertQueryStr = "INSERT INTO `queries` ( " +
                    "`queryid`, " +
                    "`agentid`, " +
                    "`userid`, " +
                    "`profitmargin`, " +
                    "`gstrate`, " +
                    "`name`, " +
                    "`contact`, " +
                    "`querystartdate`, " +
                    "`querylastupdatetime`, " +
                    "`querycurrentstate`, " +
                    "`place`, " +
                    "`destinationcovered`, " +
                    "`fromdate`, " +
                    "`todate`, " +
                    "`adults`, " +
                    "`children`, " +
                    "`babies`, " +
                    "`roomcount`, " +
                    "`meal`, " +
                    "`hotelcategory`, " +
                    "`arrivaldate`, " +
                    "`departuredate`, " +
                    "`arrivalcity`, " +
                    "`departurecity`, " +
                    "`vehicalcategory`, " +
                    "`requirement`, " +
                    "`budget`, " +
                    "`note` ) " +
                    "VALUES ( " +
                    "@queryid_var, " +
                    "@agentid_var, " +
                    "@userid_var, " +
                    "@profitmargin_var, " +
                    "@gstrate_var, " +
                    "@name_var, " +
                    "@contact_var, " +
                    "CURDATE(), " +
                    "NOW(), " +
                    Properties.Resources.queryStageGenerated + ", " +
                    "@place_var, " +
                    "@destinationcovered_var, " +
                    "@fromdate_var, " +
                    "@todate_var, " +
                    "@adults_var, " +
                    "@children_var, " +
                    "@babies_var, " +
                    "@roomcount_var, " +
                    "@meal_var, " +
                    "@hotelcategory_var, " +
                    "@arrivaldate_var, " +
                    "@departuredate_var, " +
                    "@arrivalcity_var, " +
                    "@departurecity_var, " +
                    "@vehicalcategory_var, " +
                    "@requirement_var, " +
                    "@budget_var, " +
                    "@note_var )";
            }
            btnUpdateMysqlCommand.CommandText = mysqlInsertQueryStr;
            btnUpdateMysqlCommand.Prepare();
            btnUpdateMysqlCommand.Parameters.AddWithValue("@queryid_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@agentid_var", 1);
            btnUpdateMysqlCommand.Parameters.AddWithValue("@userid_var", 1);
            btnUpdateMysqlCommand.Parameters.AddWithValue("@profitmargin_var", 1);
            btnUpdateMysqlCommand.Parameters.AddWithValue("@gstrate_var", 1);
            btnUpdateMysqlCommand.Parameters.AddWithValue("@name_var", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@contact_var", "Text");
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

            if (string.Equals(txtBoxMargin.Text, "", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Profit margin field cannot be empty");
                frmEditQueryMysqlTransaction.Dispose();
                lblMargin.ForeColor = Color.Red;
                return;
            }
            else
            {
                try
                {
                    btnUpdateMysqlCommand.Parameters["@profitmargin_var"].Value = Convert.ToUInt32(txtBoxMargin.Text);
                }
                catch (Exception errmargin)
                {
                    MessageBox.Show("Error in margin : " + errmargin.Message + "");
                    frmEditQueryMysqlTransaction.Dispose();
                    lblMargin.ForeColor = Color.Red;
                    return;
                }
            }

            if (string.Equals(txtBoxGST.Text, "", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("GST field cannot be empty");
                frmEditQueryMysqlTransaction.Dispose();
                lblGST.ForeColor = Color.Red;
                return;
            }
            else
            {
                try
                {
                    btnUpdateMysqlCommand.Parameters["@gstrate_var"].Value = Convert.ToUInt32(txtBoxGST.Text);
                }
                catch (Exception errmargin)
                {
                    MessageBox.Show("Error in GST : " + errmargin.Message + "");
                    frmEditQueryMysqlTransaction.Dispose();
                    lblGST.ForeColor = Color.Red;
                    return;
                }
            }

            if (string.Equals(cmbboxAgentId.Text, "", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("agentId field cannot be empty");
                frmEditQueryMysqlTransaction.Dispose();
                lblAgentId.ForeColor = Color.Red;
                return;
            }
            else
            {
                btnUpdateMysqlCommand.Parameters["@agentid_var"].Value = cmbboxAgentId.SelectedValue;
            }

            if (string.Equals(cmbboxUserId.Text, "", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("userid field cannot be empty");
                frmEditQueryMysqlTransaction.Dispose();
                lblUserId.ForeColor = Color.Red;
                return;
            }
            else
            {
                btnUpdateMysqlCommand.Parameters["@userid_var"].Value = cmbboxUserId.SelectedValue;
                
            }

            if (string.Equals(txtboxClientName.Text, "", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Name field cannot be empty");
                frmEditQueryMysqlTransaction.Dispose();
                lblClientName.ForeColor = Color.Red;
                return;
            }
            else
            {
                btnUpdateMysqlCommand.Parameters["@name_var"].Value = txtboxClientName.Text;
            }

            if (string.Equals(txtboxClientContact.Text, "", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Contact field cannot be empty");
                frmEditQueryMysqlTransaction.Dispose();
                lblClientContact.ForeColor = Color.Red;
                return;
            }
            else
            {
                btnUpdateMysqlCommand.Parameters["@contact_var"].Value = txtboxClientContact.Text;
            }

            if (string.Equals(txtboxClientContact.Text, "", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Place Field cannot be empty");
                frmEditQueryMysqlTransaction.Dispose();
                lblPlace.ForeColor = Color.Red;
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
                btnUpdateMysqlCommand.Parameters["@meal_var"].Value = "NOT PROVIDED";
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
            btnUpdateMysqlCommand.Parameters["@arrivaldate_var"].Value = date.Hour.ToString() + ":" + date.Minute.ToString() + ":" + date.Second.ToString();

            date = dttmpkrDptrDate.Value;
            btnUpdateMysqlCommand.Parameters["@departuredate_var"].Value = date.Hour.ToString() + ":" + date.Minute.ToString() + ":" + date.Second.ToString();

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
                btnUpdateMysqlCommand.Parameters["@requirement_var"].Value = "NOT SELECTED";
            }

            if (string.Equals(txtboxBudget.Text, "", StringComparison.OrdinalIgnoreCase))
            {
                btnUpdateMysqlCommand.Parameters["@budget_var"].Value = Convert.ToUInt32("0");
            }
            else
            {
                btnUpdateMysqlCommand.Parameters["@budget_var"].Value = Convert.ToUInt32(txtboxBudget.Text);
            }
            
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
                    + cmbboxAgentId.SelectedValue.ToString()
                    + cmbboxUserId.SelectedValue.ToString()
                    + today.Hour.ToString()
                    + today.Minute.ToString();
                cmbboxQueryId.Text = queryIdStr;
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
            Close();
        }
        
        private void btnDeleteQuery_Click(object sender, EventArgs e)
        {
            if (string.Equals(txtboxPlace.Text, ""))
            {
                MessageBox.Show("Form is Empty. Please Select and load query first");
                return;
            }
            if (string.Equals(txtboxClientName.Text, ""))
            {
                MessageBox.Show("Form is Empty. Please Select and load query first");
                return;
            }
            if (string.Equals(txtboxClientContact.Text, ""))
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
                btnDeleteMysqlTransaction.Commit();
            }
            catch (Exception errquery)
            {
                MessageBox.Show("Error while executing delete query because:\n" + errquery.Message);
            }
        }

        private void dttmpckrFromDate_ValueChanged(object sender, EventArgs e)
        {
            /* update the minimum value of the to with current selected date */
            dttmpckrToDate.MinDate = dttmpckrFromDate.Value;
        }

        private void dttmpckrToDate_ValueChanged(object sender, EventArgs e)
        {
            /* update maximum value for from date with selected date */
            //dttmpckrFromDate.MaxDate = dttmpckrToDate.Value;
        }

        private void cmbboxQueryId_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* load data from Database from query table using queryid */
            /* reset the form */
            cmbboxUserId.SelectedValue = 0;
            cmbboxAgentId.SelectedValue = 0;
            txtBoxGST.Text = "";
            txtBoxMargin.Text = "";
            cmbboxVehicleCtgry.Text = "";
            txtboxArvlCity.Text = "";
            txtboxBudget.Text = "";
            txtboxDptrCity.Text = "";
            txtboxDstnCvrd.Text = "";
            txtboxNote.Text = "";
            txtboxPlace.Text = "";
            txtboxClientContact.Text = "";
            txtboxClientName.Text = "";
            nmbrUpDwnPersonAdult.Value = 0;
            nmbrUpDwnPersonChild.Value = 0;
            nmbrUpDwnPersonInfnt.Value = 0;
            nmbrUpDwnRoomCount.Value = 0;
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
            dttmpckrFromDate.Value = DateTime.Now;
            dttmpckrToDate.Value = DateTime.Now;
            dttmpkrArvlDate.Value = DateTime.Now;
            dttmpkrDptrDate.Value = DateTime.Now;
            if ((cmbboxQueryId.SelectedIndex == 0) || (cmbboxQueryId.SelectedValue == null))
            {
                btnDeleteQuery.Enabled = false;
                btnDeleteQuery.Visible = false;
                updateQueryFlag = false;
                if (string.Equals(queryActivityFlagStr, "NEW QUERY"))
                {
                    btnUpdate.Text = "INSERT";
                }
                else
                {
                    btnUpdate.Text = "EXIT";
                }
                return;
            }
            btnDeleteQuery.Enabled = true;
            btnDeleteQuery.Visible = true;
            updateQueryFlag = true;
            btnUpdate.Text = "UPDATE";
            frmEditQueryDataSet = new DataSet();
            string queryDataSelectMysqlQueryString = "SELECT * FROM `queries` WHERE `queryid` = " + cmbboxQueryId.Text;
            Debug.WriteLine("Query string is " + queryDataSelectMysqlQueryString);
            try
            {
                frmEditQueryMysqlDataAdaptor = new MySqlDataAdapter(queryDataSelectMysqlQueryString, frmEditQueryMysqlConn);
                frmEditQueryMysqlDataAdaptor.Fill(frmEditQueryDataSet, "QUERYID_FULL_FORM");
                if (frmEditQueryDataSet != null)
                {
                    /* data read from database now write down to page */
                    string queriesColumnStr;
                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["agentid"].ToString();
                    cmbboxAgentId.SelectedValue = Convert.ToInt32(queriesColumnStr);

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["userid"].ToString();
                    cmbboxUserId.SelectedValue = Convert.ToInt32(queriesColumnStr);

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["profitmargin"].ToString();
                    txtBoxMargin.Text = queriesColumnStr;

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["gstrate"].ToString();
                    txtBoxGST.Text = queriesColumnStr;

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["name"].ToString();
                    txtboxClientName.Text = queriesColumnStr;

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["contact"].ToString();
                    txtboxClientContact.Text = queriesColumnStr;

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
                        RadioButton mealRadioBtn = grpboxMealControl as RadioButton;
                        if (mealRadioBtn != null)
                        {
                            if (string.Equals(mealRadioBtn.Text, queriesColumnStr))
                            {
                                mealRadioBtn.Checked = true;
                                break;
                            }
                        }
                    }

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["hotelcategory"].ToString();
                    foreach (var grpboxHtlCtgryCtrl in grpboxHtlCtgry.Controls)
                    {
                        CheckBox htlCtgryChkBox = grpboxHtlCtgryCtrl as CheckBox;
                        if (htlCtgryChkBox != null)
                        {
                            if (queriesColumnStr.Contains(htlCtgryChkBox.Text))
                            {
                                htlCtgryChkBox.Checked = true;
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
                    cmbboxVehicleCtgry.Text = queriesColumnStr;

                    queriesColumnStr = frmEditQueryDataSet.Tables["QUERYID_FULL_FORM"].Rows[0]["requirement"].ToString();
                    foreach (var grpboxRqmntControl in grpboxRqmnt.Controls)
                    {
                        RadioButton rqmntRadioBtn = grpboxRqmntControl as RadioButton;
                        if (rqmntRadioBtn != null)
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
