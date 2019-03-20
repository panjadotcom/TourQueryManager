using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourQueryManager
{
    public partial class FrmReportsOptionPage : Form
    {
        FrmReportsViewerPage reportsViewerPage = null;

        public FrmReportsOptionPage()
        {
            InitializeComponent();
        }

        private void Close_Opened_Form()
        {
            if (reportsViewerPage != null)
            {
                reportsViewerPage.Close();
            }
        }

        private void All_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            string queryString = null;
            
            /* check menu item and call report page*/
            if (toolStripMenuItem == allLedgerToolStripMenuItem)
            {
                queryString = "SELECT * FROM ledger ORDER BY idledger";
            }
            else if (toolStripMenuItem == allAgentsToolStripMenuItem)
            {
                queryString = "SELECT * FROM agents ORDER BY agentid";
            }
            else if (toolStripMenuItem == allUsersToolStripMenuItem)
            {
                queryString = "SELECT * FROM appusers ORDER BY userid";
            }
            else if (toolStripMenuItem == allQueriesToolStripMenuItem)
            {
                queryString = "SELECT * FROM queries ORDER BY queryno";
            }
            else
            {
                MessageBox.Show("Error in menu");
                return;
            }
            Close_Opened_Form();
            reportsViewerPage = new FrmReportsViewerPage(queryString);
            reportsViewerPage.WindowState = FormWindowState.Maximized;
            reportsViewerPage.MdiParent = this;
            reportsViewerPage.Show();
        }

        private void SelectiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close_Opened_Form();
        }
    }
}
