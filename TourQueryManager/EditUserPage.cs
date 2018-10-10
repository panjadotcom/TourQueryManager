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
            string selectMysqlQueryString;
            DataSet dataSet = new DataSet();
            if (isAgentFlag)
            {
                selectMysqlQueryString = "SELECT `agentid` as `id` FROM `agents` ORDER BY `agentid`";
            }
            else
            {
                selectMysqlQueryString = "SELECT `userid` as `id` FROM `appusers` WHERE `userid` > 1 ORDER BY `userid`";
            }
            MySqlDataAdapter mysqlDataAdaptor = new MySqlDataAdapter(selectMysqlQueryString, frmEditUserMysqlConn);
            mysqlDataAdaptor.Fill(dataSet, "ID_COMBO_BOX");
            if (dataSet != null)
            {
                DataRow dataRow = dataSet.Tables["ID_COMBO_BOX"].NewRow();
                dataRow["id"] = "0";
                dataSet.Tables["ID_COMBO_BOX"].Rows.InsertAt(dataRow, 0);
                comboBoxId.DataSource = dataSet.Tables["ID_COMBO_BOX"];
                comboBoxId.ValueMember = "id";
                comboBoxId.DisplayMember = "id";
                comboBoxId.SelectedIndex = 0;
            }
        }

        private bool ValidateUserPage()
        {
            if (!isAgentFlag)
            {
                if (string.Equals(txtboxUsername.Text, ""))
                {
                    MessageBox.Show("Username Field cannot be empty","Username Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (string.Equals(txtboxPassword.Text, ""))
                {
                    MessageBox.Show("Password Field cannot be Empty", "Password Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (string.Equals(txtboxName.Text, ""))
            {
                MessageBox.Show("Name Field cannot be empty", "Name Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.Equals(txtboxPhone.Text, ""))
            {
                //MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxPhone.Text = "NOT FILLED";
            }
            if (string.Equals(txtboxEmailId.Text, ""))
            {
                //MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxEmailId.Text = "NOT FILLED";
            }
            if (string.Equals(txtboxInfo.Text, ""))
            {
                //MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxInfo.Text = "NOT FILLED";
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /* this btn will update entry in the database */
            if (!ValidateUserPage())
            {
                return;
            }
            frmEditUserMysqlTransaction = frmEditUserMysqlConn.BeginTransaction();
            MySqlCommand btnUpdateMysqlCommand = frmEditUserMysqlConn.CreateCommand();
            btnUpdateMysqlCommand.Connection = frmEditUserMysqlConn;
            btnUpdateMysqlCommand.Transaction = frmEditUserMysqlTransaction;
            btnUpdateMysqlCommand.CommandType = CommandType.Text;
            btnUpdateMysqlCommand.Parameters.AddWithValue("@var_id", 1);
            btnUpdateMysqlCommand.Parameters.AddWithValue("@var_username", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@var_password", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@var_name", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@var_phone", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@var_email", "Text");
            btnUpdateMysqlCommand.Parameters.AddWithValue("@var_information", "Text");
            try
            {
                if (string.Equals(btnUpdate.Text, "UPDATE"))
                {
                    if (isAgentFlag)
                    {
                        btnUpdateMysqlCommand.CommandText = "UPDATE `agents` SET `name` = @var_name, `phone` = @var_phone, `email` = @var_email, `information` = @var_information WHERE `agentid` = @var_id";
                    }
                    else
                    {
                        btnUpdateMysqlCommand.CommandText = "UPDATE `appusers` SET `username` = @var_username, `password` = @var_password, `name` = @var_name, `phone` = @var_phone, `email` = @var_email, `information` = @var_information WHERE `userid` = @var_id";
                    }
                }
                else
                {
                    if (isAgentFlag)
                    {
                        btnUpdateMysqlCommand.CommandText = "INSERT INTO `agents` ( `name`, `phone`, `email`, `information` )"
                            + " VALUES ( @var_name, @var_phone, @var_email, @var_information ) ";
                    }
                    else
                    {
                        btnUpdateMysqlCommand.CommandText = "INSERT INTO `appusers` ( `username`, `password`, `name`, `phone`, `email`, `information` )"
                            + " VALUES ( @var_username, @var_password, @var_name, @var_phone, @var_email, @var_information ) ";
                    }
                }
                btnUpdateMysqlCommand.Prepare();
                btnUpdateMysqlCommand.Parameters["@var_id"].Value = Convert.ToInt32(comboBoxId.Text);
                btnUpdateMysqlCommand.Parameters["@var_username"].Value = txtboxUsername.Text;
                btnUpdateMysqlCommand.Parameters["@var_password"].Value = txtboxPassword.Text;
                btnUpdateMysqlCommand.Parameters["@var_name"].Value = txtboxName.Text;
                btnUpdateMysqlCommand.Parameters["@var_phone"].Value = txtboxPhone.Text;
                btnUpdateMysqlCommand.Parameters["@var_email"].Value = txtboxEmailId.Text;
                btnUpdateMysqlCommand.Parameters["@var_information"].Value = txtboxInfo.Text;
                btnUpdateMysqlCommand.ExecuteNonQuery();
                frmEditUserMysqlTransaction.Commit();
                if (isAgentFlag)
                {
                    MessageBox.Show("New Agent " + txtboxName.Text + " created successfully");
                }
                else
                {
                    MessageBox.Show("New User " + txtboxUsername.Text + " created successfully");
                }
                
            }
            catch (Exception errcmd)
            {
                MessageBox.Show("Command not executed because " + errcmd.Message + "");
            }
            Close();
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

        private void comboBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxEmailId.Text = "";
            txtboxInfo.Text = "";
            txtboxName.Text = "";
            txtboxPassword.Text = "";
            txtboxPhone.Text = "";
            txtboxUsername.Text = "";
            if (comboBoxId.SelectedIndex == 0)
            {
                btnUpdate.Text = "CREATE";
                return;
            }
            btnUpdate.Text = "UPDATE";

            string selectMysqlQueryString;
            DataSet dataSet = new DataSet();
            if (isAgentFlag)
            {
                selectMysqlQueryString = "SELECT * FROM `agents` WHERE `agentid` = " + comboBoxId.SelectedValue.ToString();
            }
            else
            {
                selectMysqlQueryString = "SELECT * FROM `appusers` WHERE `userid`  = " + comboBoxId.SelectedValue.ToString();
            }
            MySqlDataAdapter mysqlDataAdaptor = new MySqlDataAdapter(selectMysqlQueryString, frmEditUserMysqlConn);
            mysqlDataAdaptor.Fill(dataSet, "ID_DATA");
            if (dataSet != null)
            {
                txtboxEmailId.Text = dataSet.Tables["ID_DATA"].Rows[0]["email"].ToString();
                txtboxInfo.Text = dataSet.Tables["ID_DATA"].Rows[0]["information"].ToString();
                txtboxName.Text = dataSet.Tables["ID_DATA"].Rows[0]["name"].ToString();
                txtboxPhone.Text = dataSet.Tables["ID_DATA"].Rows[0]["phone"].ToString();
                if (!isAgentFlag)
                {
                    txtboxUsername.Text = dataSet.Tables["ID_DATA"].Rows[0]["username"].ToString();
                    txtboxPassword.Text = dataSet.Tables["ID_DATA"].Rows[0]["password"].ToString();
                }
            }
        }
    }
}
