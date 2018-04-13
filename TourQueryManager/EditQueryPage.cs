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
                    cmbboxUserId.DisplayMember = "name";
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
    }
}
