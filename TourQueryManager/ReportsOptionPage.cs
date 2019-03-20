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
            else if (toolStripMenuItem == allHotelsToolStripMenuItem)
            {
                queryString = "SELECT " +
                    "`T1`.hotelarea AS `AREA`, " +
                    "`T1`.hotelcity AS `CITY`, " +
                    "`T1`.hotelrating AS `RATING`, " +
                    "`T1`.hotelname AS `HOTEL`, " +
                    "`T2`.roomtype AS `ROOM TYPE`, " +
                    "`T2`.seasontype AS `SEASON`, " +
                    "`T2`.mealepaipricesingle AS `EPAI SNGL`, " +
                    "`T2`.mealepaipricedouble AS `EPAI DBL`, " +
                    "`T2`.mealepaipriceextbed AS `EPAI TRPL`, " +
                    "`T2`.mealcpaipricesingle AS `CPAI SNGL`, " +
                    "`T2`.mealcpaipricedouble AS `CPAI DBL`, " +
                    "`T2`.mealcpaipriceextbed AS `CPAI TRPL`, " +
                    "`T2`.mealmapaipricesingle AS `MAPAI SNGL`, " +
                    "`T2`.mealmapaipricedouble AS `MAPAI DBL`, " +
                    "`T2`.mealmapaipriceextbed AS `MAPAI TRPL`, " +
                    "`T2`.mealapaipricesingle AS `APAI SNGL`, " +
                    "`T2`.mealapaipricedouble AS `APAI DBL`, " +
                    "`T2`.mealapaipriceextbed AS `APAI TRPL` " +
                    "FROM `hotelinfo` AS `T1` INNER JOIN `hotelrates` AS `T2` ON `T1`.`idhotelinfo` = `T2`.`idhotelinfo` " +
                    "WHERE `seasonyear` > 0 " +
                    "ORDER BY `AREA`, `CITY`, `RATING`, `HOTEL`";
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
