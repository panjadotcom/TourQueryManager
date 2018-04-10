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
    public partial class FrmLoginPage : Form
    {
        static string mysqlConnStr = TourQueryManager.Properties.Settings.Default.mysqlConnStr;
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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (frmLoginDataSet != null)
            {
                int counter = cmbboxUsername.SelectedIndex;
                Boolean areEqualUsername = String.Equals(frmLoginDataSet.Tables["COMBO_BOX"].Rows[counter]["username"].ToString(), cmbboxUsername.Text, StringComparison.OrdinalIgnoreCase);
                if ( areEqualUsername )
                {
                    Boolean areEqualPassword = String.Equals(frmLoginDataSet.Tables["COMBO_BOX"].Rows[counter]["password"].ToString(), txtboxPassword.Text, StringComparison.OrdinalIgnoreCase); ;
                    if ( areEqualPassword )
                    {
                        if (counter == 0)
                        {
                            MessageBox.Show("Password Matched for Admin");
                        }
                        else
                        {
                            MessageBox.Show("Password Matched for user");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Password Not Matched");
                    }   
                }
            }
        }
    }
}
