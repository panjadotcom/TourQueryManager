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
    public partial class FrmEditUserPage : Form
    {
        static string mysqlConnStr = TourQueryManager.Properties.Settings.Default.mysqlConnStr;
        static string userAgentFlagStr = null;
        static bool isAgentFlag;
        MySqlConnection frmEditUserMysqlConn = new MySqlConnection(mysqlConnStr);
        MySqlTransaction frmEditUserMysqlTransaction = null;

        public FrmEditUserPage(string userAgentFlag)
        {
            InitializeComponent();
            userAgentFlagStr = userAgentFlag;
        }

        private void FrmEditUserPage_Load(object sender, EventArgs e)
        {
            /* invoke functions for loading form */
            if(string.Equals(userAgentFlagStr, "Agent", StringComparison.OrdinalIgnoreCase))
            {
                isAgentFlag = true;
                lblUsername.Enabled = false;
                lblUsername.Visible = false;
                txtboxUsername.Enabled = false;
                txtboxUsername.Visible = false;
                lblPassword.Enabled = false;
                lblPassword.Visible = false;
                txtboxPassword.Enabled = false;
                txtboxPassword.Visible = false;
                lblUserId.Text = "AgentId";
                Text = "New Agent";
            }
            else
            {
                isAgentFlag = false;
            }
            try
            {
                frmEditUserMysqlConn.Open();
            }
            catch(Exception erropen)
            {
                MessageBox.Show("connection cannot be opened because " + erropen.Message + "");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /* this btn will update entry in the database */
            frmEditUserMysqlTransaction = frmEditUserMysqlConn.BeginTransaction();
            MySqlCommand btnUpdateMysqlCommand = frmEditUserMysqlConn.CreateCommand();
            btnUpdateMysqlCommand.Connection = frmEditUserMysqlConn;
            btnUpdateMysqlCommand.Transaction = frmEditUserMysqlTransaction;
            try
            {
                /*INSERT INTO `tourquerymanagement`.`appusers` (`username`, `password`, `name`, `phone`, `email`, `information`) VALUES ('Administrator', 'Password', 'Administrator', '1234567890', 'admin@office.123', 'Admin Account of the company');*/
                if (isAgentFlag)
                {
                    btnUpdateMysqlCommand.CommandText = "INSERT INTO `agents` ( `name`, `phone`, `email`, `information` )"
                        + " VALUES ( '" + txtboxName.Text + "', '" + txtboxPhone.Text + "', '" + txtboxEmailId.Text + "', '" + txtboxInfo.Text + "' ) ";
                }
                else
                {
                    btnUpdateMysqlCommand.CommandText = "INSERT INTO `appusers` ( `username`, `password`, `name`, `phone`, `email`, `information` )"
                        + " VALUES ( '" + txtboxUsername.Text + "', '" + txtboxPassword.Text + "', '" + txtboxName.Text + "', '" + txtboxPhone.Text + "', '" + txtboxEmailId.Text + "', '" + txtboxInfo.Text + "' ) ";
                }
                MessageBox.Show("Mysql Command is " + btnUpdateMysqlCommand.CommandText );
                btnUpdateMysqlCommand.ExecuteNonQuery();
                frmEditUserMysqlTransaction.Commit();
            }
            catch(Exception errcmd)
            {
                MessageBox.Show("Command not executed because " + errcmd.Message + "");
            }
        }

        private void FrmEditUserPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmEditUserMysqlConn.Close();
            }
            catch(Exception errclose)
            {
                MessageBox.Show("connection cannot be closed because " + errclose.Message + "");
            }
        }
    }
}
