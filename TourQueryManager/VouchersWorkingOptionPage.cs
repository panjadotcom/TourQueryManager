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

namespace TourQueryManager
{
    public partial class FrmVouchersWorkingOptionPage : Form
    {
        static string queryId;
        public FrmVouchersWorkingOptionPage(string argv)
        {
            InitializeComponent();
            queryId = argv;
        }

        private void FrmVouchersWorkingOptionPage_Load(object sender, EventArgs e)
        {
            Text = "WORKING VOUCHERS FOR " + queryId;
            lblQueryInfo.Text = "UPDATE HOTEL AND FLIGHT INFORMATION FOR " + queryId;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnUpdateFlightInfo_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Updating Flight information in Database");
            FrmVouchersWorkingFlightPage frmVouchersWorkingFlightPage = new FrmVouchersWorkingFlightPage(queryId);
            Hide();
            frmVouchersWorkingFlightPage.ShowDialog();
            Show();
        }

        private void BtnUpdateHotelInfo_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Updating Hotel information in Database");
            FrmVouchersWorkingHotelPage frmVouchersWorkingHotelPage = new FrmVouchersWorkingHotelPage(queryId);
            Hide();
            frmVouchersWorkingHotelPage.ShowDialog();
            Show();
        }
    }
}
