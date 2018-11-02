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
    public partial class FrmVouchersWorkingHotelPage : Form
    {
        static string queryId;
        public FrmVouchersWorkingHotelPage(string argv)
        {
            InitializeComponent();
            queryId = argv;
        }

        private void FrmVouchersWorkingHotelPage_Load(object sender, EventArgs e)
        {
            Text = "UPDATING HOTEL INFORMATION FOR " + queryId;
        }
    }
}
