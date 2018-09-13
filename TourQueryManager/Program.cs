using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourQueryManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmHotelsPage());
            //Application.Run(new FrmEditQueryPage());
            //Application.Run(new FrmLoginPage());
            Application.Run(new FrmAdminQueryWorkingPage("ITINERARY"));
        }
    }
}
