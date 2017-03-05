using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Utilties
{
    class networkPerformance : Form
    {
        public static void launchGUI()
        {
            networkPerformanceGUI gui = new networkPerformanceGUI();
            gui.Show();
        }


    }

    public class networkPerformanceGUI : Form
    {
        public networkPerformanceGUI()
        {
            Text = "Test";
            Size = new System.Drawing.Size(200, 200);
            CenterToScreen();
        }
    }
}
