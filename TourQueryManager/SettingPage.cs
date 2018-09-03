using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TourQueryManager
{
    public partial class FrmSettingPage : Form
    {
        public FrmSettingPage()
        {
            InitializeComponent();
        }

        private void UpdateConnectionString(object sender, EventArgs e)
        {
            string connectionString = "";
            if (txtBoxDbSrvrIp.Text.Length > 0)
            {
                connectionString = "server=" + txtBoxDbSrvrIp.Text;
            }
            if (txtBoxDbSrvrPort.Text.Length > 0)
            {
                if (connectionString.Length > 0)
                {
                    connectionString = connectionString + ";port=" + txtBoxDbSrvrPort.Text;
                }
                else
                {
                    connectionString = "port=" + txtBoxDbSrvrPort.Text;
                }
            }
            if (txtBoxDbUsrName.Text.Length > 0)
            {
                if (connectionString.Length > 0)
                {
                    connectionString = connectionString + ";user id=" + txtBoxDbUsrName.Text;
                }
                else
                {
                    connectionString = "user id=" + txtBoxDbUsrName.Text;
                }
            }
            if (txtBoxDbPasswd.Text.Length > 0)
            {
                if (connectionString.Length > 0)
                {
                    connectionString = connectionString + ";password=" + txtBoxDbPasswd.Text;
                }
                else
                {
                    connectionString = "password=" + txtBoxDbPasswd.Text;
                }
            }
            if (txtBoxDatabase.Text.Length > 0)
            {
                if (connectionString.Length > 0)
                {
                    connectionString = connectionString + ";database=" + txtBoxDatabase.Text;
                }
                else
                {
                    connectionString = "database=" + txtBoxDatabase.Text;
                }
            }
            if (connectionString.Length > 0)
            {
                txtBoxConnString.Text = connectionString + ";SslMode=none";
            }
            else
            {
                txtBoxConnString.Text = "";
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.mysqlConnStr = txtBoxConnString.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("New Connection String Saved.");
        }

        private void FrmSettingPage_Load(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.mysqlConnStr;
            //server=10.0.2.2;user id=pky;password=pky123;persistsecurityinfo=True;database=tourquerymanagement;SslMode=none
            txtBoxConnString.Text = connectionString;
            string[] tokens = connectionString.Split(';');
            foreach (var token in tokens)
            {
                if (token.Contains("server="))
                {
                    txtBoxDbSrvrIp.Text = token.Substring("server=".Length);
                }
                if (token.Contains("user id="))
                {
                    txtBoxDbUsrName.Text = token.Substring("user id=".Length);
                }
                if (token.Contains("password="))
                {
                    txtBoxDbPasswd.Text = token.Substring("password=".Length);
                }
                if (token.Contains("port="))
                {
                    txtBoxDbSrvrPort.Text = token.Substring("port=".Length);
                }
                if (token.Contains("database="))
                {
                    txtBoxDatabase.Text = token.Substring("database=".Length);
                }
            }
        }

        private void BtnTstConn_Click(object sender, EventArgs e)
        {
            string mysqlConnStr = txtBoxConnString.Text;
            MySqlConnection mysqlConn = new MySqlConnection(mysqlConnStr);
            try
            {
                mysqlConn.Open();
                try
                {
                    mysqlConn.Close();
                    MessageBox.Show("Databse connected successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception errclose)
                {
                    MessageBox.Show("connection cannot be closed because " + errclose.Message + "", "Error in Closing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception erropen)
            {
                MessageBox.Show("connection cannot be opened because " + erropen.Message + "", "Error in opening", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Closing settings without updating the connection string", "Setting Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
