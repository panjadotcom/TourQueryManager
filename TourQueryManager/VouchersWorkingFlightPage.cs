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
    public partial class FrmVouchersWorkingFlightPage : Form
    {
        static string queryId;
        public FrmVouchersWorkingFlightPage(string argv)
        {
            InitializeComponent();
            queryId = argv;
        }

        private void FrmVouchersWorkingFlightPage_Load(object sender, EventArgs e)
        {
            Text = "UPDATING FLIGHT INFORMATION FOR " + queryId;
        }
    }
}
