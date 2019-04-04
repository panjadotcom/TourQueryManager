using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TourQueryManager
{
    public partial class FrmAdminPage : Form
    {
        public FrmAdminPage()
        {
            InitializeComponent();
        }

        private void FrmAdminPage_Load(object sender, EventArgs e)
        {
            /* this will be used in case of loading page of Admin screen */
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            /* load the new screen for creating new user */
            FrmEditUserPage frmEditUserPage = new FrmEditUserPage("User");
            Hide();
            frmEditUserPage.ShowDialog();
            Show();
        }

        private void btnCreateQuery_Click(object sender, EventArgs e)
        {
            /* load the new screen to create the new Query */
            FrmQueryOptionsPage frmQuery = new FrmQueryOptionsPage();
            Hide();
            frmQuery.ShowDialog();
            Show();
        }
        
        private void btnCreateAgent_Click(object sender, EventArgs e)
        {
            /* load the new screen for creating new user */
            FrmEditUserPage frmEditUserPage = new FrmEditUserPage("Agent");
            Hide();
            frmEditUserPage.ShowDialog();
            Show();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            /* load the new screen of reports options */
            FrmReportsOptionPage form = new FrmReportsOptionPage();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void BtnBackUpRestore_Click(object sender, EventArgs e)
        {
            /* do backuprestore of the database*/
            
            Button button = sender as Button;
            string command;
            string path = Properties.Settings.Default.mysqlWorkingDirectory;
            if (Directory.Exists(path))
            {
                if (!File.Exists(path + "\\mysql.exe"))
                {
                    MessageBox.Show("File : \"" + path + "\\mysql.exe\" not exists. \n Install MySql client first then retry.\n OR \n Change MySql directory path in Settings.", "MySql file not exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!File.Exists(path + "\\mysqldump.exe"))
                {
                    MessageBox.Show("File : \"" + path + "\\mysqldump.exe\" not exists. \n Install MySql client first then retry.\n OR \n Change MySql directory path in Settings.", "MySql file not exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Path : \"" + path + "\" not exists. \n Install MySql client first then retry.\n OR \n Change MySql directory path in Settings.", "MySql Path not exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = Properties.Settings.Default.mysqlConnStr;
            string server = "";
            string userId = "";
            string passwd = "";
            string port = "";
            string database = "";
            //server=10.0.2.2;user id=pky;password=pky123;persistsecurityinfo=True;database=tourquerymanagement;SslMode=none
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
            if (button == BtnBackUp)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "MySql Script(*.sql)|*.sql";
                saveFileDialog.DefaultExt = "sql";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    command = "mysqldump -u " + userId + " -p" + passwd + " -h " + server + " -P " + port + " " + database + " > \"" + saveFileDialog.FileName + "\"";
                }
                else
                {
                    return;
                }
            }
            else if (button == BtnRestore)
            {
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
            }
            else
            {
                MessageBox.Show("Error in Button", "Wrong Button pressed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
    }
}
