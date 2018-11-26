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
    public partial class FrmQueryOptionsPage : Form
    {
        public FrmQueryOptionsPage()
        {
            InitializeComponent();
        }

        private void BtnNewQuery_Click(object sender, EventArgs e)
        {
            /* load the new screen to create the new Query */
            FrmEditQueryPage frmQuery = new FrmEditQueryPage("NEW QUERY");
            Hide();
            frmQuery.ShowDialog();
            Show();
        }

        private void BtnUpdateRawQuery_Click(object sender, EventArgs e)
        {
            /* load the new screen to create the new Query */
            FrmEditQueryPage frmQuery = new FrmEditQueryPage("UPDATE RAW QUERY");
            Hide();
            frmQuery.ShowDialog();
            Show();
        }

        private void BtnGenerateItinerary_Click(object sender, EventArgs e)
        {
            /* this will be used to generated user worked queries */
            FrmAdminQueryWorkingPage frmAdminQueryWorkingPage = new FrmAdminQueryWorkingPage("ITINERARY");
            Hide();
            frmAdminQueryWorkingPage.ShowDialog();
            Show();
        }

        private void BtnFinalizeOffer_Click(object sender, EventArgs e)
        {
            /* load the new screen to create the new Query */
            FrmAdminQueryWorkingPage frmQuery = new FrmAdminQueryWorkingPage("FINALIZE OFFER");
            Hide();
            frmQuery.ShowDialog();
            Show();
        }

        private void BtnUpdateAcceptedQuery_Click(object sender, EventArgs e)
        {
            /* load the new screen to create the new Query */
            FrmAdminQueryWorkingPage frmQuery = new FrmAdminQueryWorkingPage("UPDATE ACCEPTED OFFER");
            Hide();
            frmQuery.ShowDialog();
            Show();
        }

        private void BtnGenerateVouchers_Click(object sender, EventArgs e)
        {
            /* this will be used to generate vouchers and finishing the queries */
            FrmAdminQueryWorkingPage frmAdminQueryWorkingPage = new FrmAdminQueryWorkingPage("VOUCHERS");
            Hide();
            frmAdminQueryWorkingPage.ShowDialog();
            Show();
        }

        private void BtnViewAllQueries_Click(object sender, EventArgs e)
        {
            /* this will be used to view queries */
            FrmAdminQueryWorkingPage frmAdminQueryWorkingPage = new FrmAdminQueryWorkingPage("VIEW ALL");
            Hide();
            frmAdminQueryWorkingPage.ShowDialog();
            Show();
        }
    }
}
