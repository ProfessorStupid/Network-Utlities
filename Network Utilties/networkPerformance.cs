using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Network_Utilties
{
    class networkPerformance
    {
        public static void launchGUI()
        {
            Console.WriteLine("GUI Launched");
            networkPerformanceGUI gui = new networkPerformanceGUI();
            gui.Show();
        }
        
        public static string pingAddress(string ip = "8.8.8.8")
        {
            Ping pi = new Ping();
            return pi.Send(ip).ToString();            
        }
    }

    public class networkPerformanceGUI : Form
    {
        public networkPerformanceGUI()
        {
            Console.WriteLine("GUI Initialsed");
            Text = "Test";
            Size = new System.Drawing.Size(200, 200);

            Label pingTitleLabel = new Label();
            pingTitleLabel.Text = "Ping";

            Label pingResultLabel = new Label();
            pingResultLabel.Text = networkPerformance.pingAddress();
            CenterToScreen();
        }


    }
}
