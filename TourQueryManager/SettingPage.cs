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
using System.Diagnostics;
using System.IO;

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
            Properties.Settings.Default.mysqlWorkingDirectory = txtBoxMysqlWorkingDirectory.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("MySql details Saved", "MySql details Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Close();
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
            txtBoxMysqlWorkingDirectory.Text = Properties.Settings.Default.mysqlWorkingDirectory;
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
            //MessageBox.Show("Closing settings without updating the connection string", "Setting Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void BtnMysqlWorkingDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = txtBoxMysqlWorkingDirectory.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxMysqlWorkingDirectory.Text = folderBrowserDialog.SelectedPath;
            }
            else
            {
                txtBoxMysqlWorkingDirectory.Text = "Path not selected";
            }
        }

        private void BtnRestoreDatabase_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.mysqlConnStr;
            string server = "";
            string userId = "";
            string passwd = "";
            string port = "";
            string database = "";
            string[] tokens = connectionString.Split(';');
            foreach (var token in tokens)
            {
                if (token.Contains("server="))
                {
                    server = token.Substring("server=".Length);
                }
                if (token.Contains("user id="))
                {
                    userId = token.Substring("user id=".Length);
                }
                if (token.Contains("password="))
                {
                    passwd = token.Substring("password=".Length);
                }
                if (token.Contains("port="))
                {
                    port = token.Substring("port=".Length);
                }
                if (token.Contains("database="))
                {
                    database = token.Substring("database=".Length);
                }
            }
            string command;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MySql Script(*.sql)|*.sql";
            openFileDialog.DefaultExt = "sql";
            openFileDialog.CheckFileExists = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                command = "mysql -u " + userId + " -p" + passwd + " -h " + server + " -P " + port + " " + database + " < \"" + openFileDialog.FileName + "\"";
            }
            else
            {
                return;
            }
            string path = Properties.Settings.Default.mysqlWorkingDirectory;
            if (Directory.Exists(path))
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WorkingDirectory = path;
                process.Start();
                StreamReader streamReader = process.StandardOutput;
                StreamWriter streamWriter = process.StandardInput;
                streamWriter.WriteLine(command);
                streamWriter.Close();
                process.WaitForExit();
                process.Close();
            }
            else
            {
                MessageBox.Show("DIrectory Not Exists", "Directory not exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
