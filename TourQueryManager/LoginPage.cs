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
    public partial class FrmLoginPage : Form
    {
        static string mysqlConnStr = Properties.Settings.Default.mysqlConnStr;
        MySqlConnection frmLoginMysqlConn = new MySqlConnection(mysqlConnStr);
        MySqlDataAdapter frmLoginMysqlDataAdaptor = null;
        DataSet frmLoginDataSet = null;
        public FrmLoginPage()
        {
            InitializeComponent();
        }

        private void FrmLoginPage_Load(object sender, EventArgs e)
        {
            try
            {
                frmLoginMysqlConn.Open();
            }
            catch(Exception erropen)
            {
                MessageBox.Show("connection cannot be opened because " + erropen.Message + "");
            }
            string mysqlDataReadStr = "SELECT userid, username, password FROM appusers order by userid";
            frmLoginDataSet = new DataSet();
            frmLoginMysqlDataAdaptor = new MySqlDataAdapter(mysqlDataReadStr, frmLoginMysqlConn);
            try
            {
                frmLoginMysqlDataAdaptor.Fill(frmLoginDataSet, "COMBO_BOX");
                if( frmLoginDataSet != null )
                {
                    cmbboxUsername.DataSource = frmLoginDataSet.Tables["COMBO_BOX"];
                    cmbboxUsername.ValueMember = "userid";
                    cmbboxUsername.DisplayMember = "username";
                }
            }
            catch(Exception comboerr)
            {
                MessageBox.Show("Combo Box cannot be Initialize " + comboerr.Message + "\n\n\n Provide Proper Details of the Database");
            }
            cmbboxUsername.SelectedValue = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Validate_login();
        }

        private void Validate_login()
        {
            if (frmLoginDataSet != null)
            {
                int counter = cmbboxUsername.SelectedIndex;
                if (counter < 0)
                {
                    MessageBox.Show("Error in login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool areEqualUsername = string.Equals(frmLoginDataSet.Tables["COMBO_BOX"].Rows[counter]["username"].ToString(), cmbboxUsername.Text);
                if (areEqualUsername)
                {
                    bool areEqualPassword = string.Equals(frmLoginDataSet.Tables["COMBO_BOX"].Rows[counter]["password"].ToString(), txtboxPassword.Text); ;
                    if (areEqualPassword)
                    {
                        if (counter == 0)
                        {
                            Debug.WriteLine("Password Matched for " + cmbboxUsername.Text);
                            FrmAdminPage frmAdminPage = new FrmAdminPage();
                            Hide();
                            frmAdminPage.ShowDialog();
                            Close();
                        }
                        else
                        {
                            Debug.WriteLine("Password Matched for " + cmbboxUsername.Text);
                            FrmUserPage frmUserPage = new FrmUserPage(Convert.ToUInt32(cmbboxUsername.SelectedValue));
                            Hide();
                            frmUserPage.ShowDialog();
                            Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password Not Matched for " + cmbboxUsername.Text);
                    }
                }
            }
        }

        private void FrmLoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmLoginMysqlConn.Close();
            }
            catch(Exception errclose)
            {
                MessageBox.Show("connection cannot be closed because " + errclose.Message + "");
            }
        }

        private void cmbboxUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxPassword.Text = "";
        }

        private void txtboxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Validate_login();
            }
        }

        private void PctrBoxSetting_DoubleClick(object sender, EventArgs e)
        {
            Debug.WriteLine("Setting change icon clicked.");
            FrmSettingPage frmSettingPage = new FrmSettingPage();
            Hide();
            frmSettingPage.ShowDialog();
            MessageBox.Show("Restart this application to load the Changed setting.");
            Close();
        }
    }
}
