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
        MySqlConnection frmEditUserMysqlConn = new MySqlConnection(mysqlConnStr);
        MySqlTransaction frmEditUserMysqlTransaction = null;

        public FrmEditUserPage()
        {
            InitializeComponent();
        }

        private void FrmEditUserPage_Load(object sender, EventArgs e)
        {
            /* invoke functions for loading form */
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
                btnUpdateMysqlCommand.CommandText = "INSERT INTO `appusers` ( `username`, `password`, `name`, `phone`, `email`, `information` )"
                    + " VALUES ( '" + txtboxUsername.Text + "', '" + txtboxPassword.Text + "', '" + txtboxName.Text + "', '" + txtboxPhone.Text + "', '" + txtboxEmailId.Text + "', '" + txtboxInfo.Text + "' ) ";
                MessageBox.Show("Mysql Command is " + btnUpdateMysqlCommand.CommandText );
                btnUpdateMysqlCommand.ExecuteNonQuery();
                frmEditUserMysqlTransaction.Commit();
            }
            catch(Exception errcmd)
            {
                MessageBox.Show("Command not executed because " + errcmd.Message + "");
            }
        }

        private void txtboxPhone_TextChanged(object sender, EventArgs e)
        {
            /* invoked by mistake */
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
