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

        private void QueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            string queryString = null;

            /* check menu item and call report page*/
            if (toolStripMenuItem == confirmedQueriesToolStripMenuItem)
            {
                queryString = "SELECT * FROM queries where querycurrentstate > " + Properties.Resources.queryStageRejected + " ORDER BY queryno";
            }
            else if (toolStripMenuItem == notConfirmedQueriesToolStripMenuItem)
            {
                queryString = "SELECT * FROM queries where querycurrentstate <= " + Properties.Resources.queryStageRejected + " ORDER BY queryno";
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

        private void LedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            string queryString = null;

            /* check menu item and call report page*/
            if (toolStripMenuItem == perQueriesLedgerToolStripMenuItem)
            {
                queryString = "select `T2`.queryid AS `QUERYID`, `T1`.totalcost as `TRIP COST`, SUM(`T2`.transactionamount) AS `AMOUNT DEPOSITED` from " +
                    "`finalizedqueries` as `T1` right join " +
                    "`ledger` as `T2` on " +
                    "`T1`.`queryid` = `T2`.`queryid` " +
                    "group by `T2`.`queryid`";
            }
            else if (toolStripMenuItem == pendingPaymentsLedgerToolStripMenuItem)
            {
                queryString = "select queryid as `QUERYID`, tripcost as `TRIP COST`, deposited as `AMOUNT DEPOSITED` from " +
                    "(select `T2`.queryid as queryid, " +
                    "`T1`.totalcost as tripcost, " +
                    "SUM(`T2`.transactionamount) as deposited " +
                    "from `finalizedqueries` as `T1` " +
                    "right join `ledger` as `T2` " +
                    "on `T1`.`queryid` = `T2`.`queryid` " +
                    "group by `T2`.`queryid`) as tablejoined " +
                    "where tripcost is not null and tripcost >" +
                    " deposited";
            }
            else if (toolStripMenuItem == advancePaymentsLedgerToolStripMenuItem)
            {
                queryString = "select queryid as `QUERYID`, tripcost as `TRIP COST`, deposited as `AMOUNT DEPOSITED` from " +
                    "(select `T2`.queryid as queryid, " +
                    "`T1`.totalcost as tripcost, " +
                    "SUM(`T2`.transactionamount) as deposited " +
                    "from `finalizedqueries` as `T1` " +
                    "right join `ledger` as `T2` " +
                    "on `T1`.`queryid` = `T2`.`queryid` " +
                    "group by `T2`.`queryid`) as tablejoined " +
                    "where tripcost is null or tripcost < deposited";
            }
            else if (toolStripMenuItem == completedPaymentsLedgerToolStripMenuItem)
            {
                queryString = "select queryid as `QUERYID`, tripcost as `TRIP COST`, deposited as `AMOUNT DEPOSITED` from " +
                    "(select `T2`.queryid as queryid, " +
                    "`T1`.totalcost as tripcost, " +
                    "SUM(`T2`.transactionamount) as deposited " +
                    "from `finalizedqueries` as `T1` " +
                    "right join `ledger` as `T2` " +
                    "on `T1`.`queryid` = `T2`.`queryid` " +
                    "group by `T2`.`queryid`) as tablejoined " +
                    "where tripcost is not null and tripcost = deposited";
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
    }
}
