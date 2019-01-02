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
    public partial class FrmUserPage : Form
    {
        static UInt32 frmUserId;
        static string mysqlConnectionString = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection frmUserMysqlConnection = new MySqlConnection(mysqlConnectionString);
        public FrmUserPage(UInt32 userId)
        {
            InitializeComponent();
            frmUserId = userId;
        }

        private void DataGrdVuUserQueries_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrdVuUserQueries.Rows.Count > 0)
            {
                /* Open new Form of Working and pass queryId to the working */
                try
                {
                    Debug.WriteLine("Data Row selected For Working Itinerary: \n" +
                        DataGrdVuUserQueries.SelectedRows[0].Cells["AssignedDate"].Value.ToString() + "\n" +
                        DataGrdVuUserQueries.SelectedRows[0].Cells["QueryId"].Value.ToString() + "\n" +
                        DataGrdVuUserQueries.SelectedRows[0].Cells["Location"].Value.ToString() + "\n" +
                        DataGrdVuUserQueries.SelectedRows[0].Cells["fromDate"].Value.ToString() + "\n" +
                        DataGrdVuUserQueries.SelectedRows[0].Cells["toDate"].Value.ToString() + "\n");
                }
                catch (Exception errSelection)
                {
                    Debug.WriteLine("Error in selecting rows. Err Msg = " + errSelection.Message);
                    return;
                }
                if (radioButtonWorkingItinary.Checked)
                {
                    
                    FrmQueryWorkingPage frmQueryWorkingPage = new FrmQueryWorkingPage(DataGrdVuUserQueries.SelectedRows[0].Cells["QueryId"].Value.ToString());
                    Hide();
                    frmQueryWorkingPage.ShowDialog();
                    Show();
                }
                else if (radioButtonWorkingVouchers.Checked)
                //else if (radioButtonCompletedItinerary.Checked)/* this line needs to be deleted after testing */
                {
                    FrmVouchersWorkingOptionPage frmVouchersWorkingOptionPage = new FrmVouchersWorkingOptionPage(DataGrdVuUserQueries.SelectedRows[0].Cells["QueryId"].Value.ToString());
                    Hide();
                    frmVouchersWorkingOptionPage.ShowDialog();
                    Show();
                }
                else
                {
                    Debug.WriteLine("Usefull radio button not selected. thus not doing anything\n");
                }
                DataGrdVuUserQueriesLoad();
            }
            else
            {
                MessageBox.Show("Please load Queries First", "Load Queries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DataGrdVuUserQueriesLoad()
        {
            string mysqlSelectQuery = null;
            bool isColourEnable = false;
            DataGrdVuUserQueries.Rows.Clear();
            if (radioButtonWorkingItinary.Checked)
            {
                mysqlSelectQuery = "SELECT `queryid`, `querycurrentstate`, `place`, `fromdate`, `todate`, `querystartdate` " +
               "FROM `queries` WHERE " +
               "`userid` = " + frmUserId.ToString() + " ";
                mysqlSelectQuery = mysqlSelectQuery +
                "AND `querycurrentstate` = " + Properties.Resources.queryStageGenerated;
                isColourEnable = true;
            }
            else if (radioButtonCompletedItinerary.Checked)
            {
                mysqlSelectQuery = "SELECT `queryid`, `querycurrentstate`, `place`, `fromdate`, `todate`, `querystartdate` " +
               "FROM `queries` WHERE " +
               "`userid` = " + frmUserId.ToString() + " ";
                mysqlSelectQuery = mysqlSelectQuery +
                "AND `querycurrentstate` > " + Properties.Resources.queryStageGenerated + " " +
                "AND `querycurrentstate` < " + Properties.Resources.queryStageRejected;
                isColourEnable = false;
            }
            else if (radioButtonWorkingVouchers.Checked)
            {
                mysqlSelectQuery = "SELECT `T1`.`queryid`, `T1`.`querycurrentstate`, `T1`.`place`, `T1`.`fromdate`, `T1`.`todate`, `T1`.`querystartdate` " +
                    "FROM `queries` as `T1` inner join `finalizedqueries` as `T2` on `T1`.`queryid` = `T2`.`queryid` " +
                    "WHERE " +
                    "`T2`.`userid` = " + frmUserId.ToString() + " " +
                    "AND `T1`.`querycurrentstate` > " + Properties.Resources.queryStageRejected + " " +
                    "AND `T1`.`querycurrentstate` < " + Properties.Resources.queryStageVoucherCompleted;
                isColourEnable = true;
            }
            else if (radioButtonCompletedBooking.Checked)
            {
                mysqlSelectQuery = "SELECT `T1`.`queryid`, `T1`.`querycurrentstate`, `T1`.`place`, `T1`.`fromdate`, `T1`.`todate`, `T1`.`querystartdate` " +
                    "FROM `queries` as `T1` inner join `finalizedqueries` as `T2` on `T1`.`queryid` = `T2`.`queryid` " +
                    "WHERE " +
                    "`T2`.`userid` = " + frmUserId.ToString() + " " +
                    "AND `T1`.`querycurrentstate` = " + Properties.Resources.queryStageVoucherCompleted;
                isColourEnable = false;
            }
            else if (radioButtonAllQueries.Checked)
            {
                mysqlSelectQuery = "SELECT `T1`.`queryid`, `T1`.`querycurrentstate`, `T1`.`place`, `T1`.`fromdate`, `T1`.`todate`, `T1`.`querystartdate` " +
                   "FROM `queries` as `T1` inner join `finalizedqueries` as `T2` " +
                   "on `T1`.`queryid` = `T2`.`queryid` " +
                   "WHERE " +
                   "`T2`.`userid` = " + frmUserId.ToString() + " " +
                   "UNION " +
                   "SELECT `T1`.`queryid`, `T1`.`querycurrentstate`, `T1`.`place`, `T1`.`fromdate`, `T1`.`todate`, `T1`.`querystartdate` " +
                   "FROM `queries` as `T1` " +
                   "WHERE " +
                   "`T1`.`userid` = " + frmUserId.ToString() + " ";
                isColourEnable = false;
            }
            else
            {
                MessageBox.Show("No Option is selected");
                return;
            }

            try
            {
                frmUserMysqlConnection.Open();
            }
            catch (Exception errConnOpen)
            {
                MessageBox.Show("Error in opening mysql connection because : " + errConnOpen.Message);
            }
            
            DataSet queryDataset = new DataSet();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mysqlSelectQuery, frmUserMysqlConnection);
            try
            {
                mySqlDataAdapter.Fill(queryDataset, "ASSIGNED_QUERIES");
                if (queryDataset != null)
                {
                    foreach (DataRow item in queryDataset.Tables["ASSIGNED_QUERIES"].Rows)
                    {
                        int index = DataGrdVuUserQueries.Rows.Add();
                        DataGrdVuUserQueries.Rows[index].Cells["QueryId"].Value = item["queryid"].ToString();
                        DataGrdVuUserQueries.Rows[index].Cells["QueryState"].Value = item["querycurrentstate"].ToString() + " ( " + MyPdfDocuments.PrintCurrentQueryStage(Convert.ToInt32(item["querycurrentstate"])) + " )";
                        DataGrdVuUserQueries.Rows[index].Cells["fromDate"].Value = item["fromdate"].ToString();
                        DataGrdVuUserQueries.Rows[index].Cells["toDate"].Value = item["todate"].ToString();
                        DataGrdVuUserQueries.Rows[index].Cells["Location"].Value = item["place"].ToString();
                        DataGrdVuUserQueries.Rows[index].Cells["AssignedDate"].Value = item["querystartdate"].ToString();
                        double noOfdays = (DateTime.Today - DateTime.Parse(item["querystartdate"].ToString())).TotalDays;
                        if (isColourEnable)
                        {
                            if (noOfdays > 2)
                            {
                                DataGrdVuUserQueries.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else if (noOfdays > 1)
                            {
                                DataGrdVuUserQueries.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                            }
                        }
                    }
                }
                DataGrdVuUserQueries.Sort(QueryState, ListSortDirection.Ascending);
                DataGrdVuUserQueries.ClearSelection();
            }
            catch (Exception errQuery)
            {
                MessageBox.Show("Error in executing command because : " + errQuery.Message);
            }
            try
            {
                frmUserMysqlConnection.Close();
            }
            catch (Exception errConnClose)
            {
                MessageBox.Show("Error in Closing mysql connection because : " + errConnClose.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void BtnHotelInfo_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Updating Hotel information in Database");
            FrmHotelsPage frmHotelsPage = new FrmHotelsPage();
            Hide();
            frmHotelsPage.ShowDialog();
            Show();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                //MessageBox.Show("Selection changed in radio button " + radioButton.Text, "Selection Changed in Radio Button", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGrdVuUserQueriesLoad();
            }
        }

        private void FrmUserPage_Load(object sender, EventArgs e)
        {
            radioButtonWorkingItinary.Checked = true;
        }
    }
}
