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
    public partial class FrmUserPage : Form
    {
        static UInt32 frmUserId;
        bool openWorkingPage = false;
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
                MessageBox.Show("Data Row selected : \n" +
                    DataGrdVuUserQueries.SelectedRows[0].Cells["AssignedDate"].Value.ToString() + "\n" +
                    DataGrdVuUserQueries.SelectedRows[0].Cells["QueryId"].Value.ToString() + "\n" +
                    DataGrdVuUserQueries.SelectedRows[0].Cells["Location"].Value.ToString() + "\n" +
                    DataGrdVuUserQueries.SelectedRows[0].Cells["fromDate"].Value.ToString() + "\n" +
                    DataGrdVuUserQueries.SelectedRows[0].Cells["toDate"].Value.ToString() + "\n" );
                if (openWorkingPage)
                {
                    FrmQueryWorkingPage frmQueryWorkingPage = new FrmQueryWorkingPage(DataGrdVuUserQueries.SelectedRows[0].Cells["QueryId"].Value.ToString());
                    Hide();
                    frmQueryWorkingPage.ShowDialog();
                    Show();
                }
            }
            else
            {
                MessageBox.Show("Please load Queries First", "Load Queries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnAssignQueries_Click(object sender, EventArgs e)
        {
            DataGrdVuUserQueriesLoad(BtnAssignQueries.Text);
            openWorkingPage = true;
        }

        private void DataGrdVuUserQueriesLoad(string buttonClicked)
        {
            string mysqlSelectQuery = null;
            if (string.Equals(buttonClicked, BtnAssignQueries.Text, StringComparison.OrdinalIgnoreCase))
            {
                mysqlSelectQuery = "SELECT `queryid`, `place`, `fromdate`, `todate`, `querystartdate` " +
                "FROM `queries` WHERE " +
                "`userid` = " + frmUserId.ToString() + " " +
                "AND `querycurrentstate` = " + Properties.Resources.queryStageGenerated;
            }
            else if (string.Equals(buttonClicked, BtnCompletedQueries.Text, StringComparison.OrdinalIgnoreCase))
            {
                mysqlSelectQuery = "SELECT `queryid`, `place`, `fromdate`, `todate`, `querystartdate` " +
                "FROM `queries` WHERE " +
                "`userid` = " + frmUserId.ToString() + " " +
                "AND `querycurrentstate` > " + Properties.Resources.queryStageGenerated;
            }
            else
            {
                MessageBox.Show("Wrong method invoked");
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
                DataGrdVuUserQueries.Rows.Clear();
                if (queryDataset != null)
                {
                    foreach (DataRow item in queryDataset.Tables["ASSIGNED_QUERIES"].Rows)
                    {
                        int index = DataGrdVuUserQueries.Rows.Add();
                        DataGrdVuUserQueries.Rows[index].Cells["QueryId"].Value = item["queryid"].ToString();
                        DataGrdVuUserQueries.Rows[index].Cells["fromDate"].Value = item["fromdate"].ToString();
                        DataGrdVuUserQueries.Rows[index].Cells["toDate"].Value = item["todate"].ToString();
                        DataGrdVuUserQueries.Rows[index].Cells["Location"].Value = item["place"].ToString();
                        DataGrdVuUserQueries.Rows[index].Cells["AssignedDate"].Value = item["querystartdate"].ToString(); ;
                    }
                }
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

        private void BtnCompletedQueries_Click(object sender, EventArgs e)
        {
            DataGrdVuUserQueriesLoad(BtnCompletedQueries.Text);
            openWorkingPage = false;
        }
    }
}
