using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Utilties
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            // Run Program
            Application.Run(new NetworkUtlitiesApp());
        }
    }

    // Class for containing the program
    public class NetworkUtlitiesApp : ApplicationContext
    {
        // Program Icon
        private NotifyIcon trayIcon;

        public NetworkUtlitiesApp()
        {
            // Initialise System Icon
            trayIcon = new NotifyIcon()
            {
                // Create Menu List
                Icon = Network_Utilties.Properties.Resources.appIcon,
                ContextMenu = new ContextMenu(new MenuItem[]
                {
                    new MenuItem("Network Performance", networkPeformance),
                    new MenuItem("Options", programOptions),
                    new MenuItem("Exit", exit)
                }),
                Visible = true
            };
        }

        // Network Performance function
        void networkPeformance(object sender, EventArgs e)
        {
            Application.Run(new networkPerformanceGui());
        }

        // Program options function
        void programOptions(object sender, EventArgs e)
        {
            
        }

        // Exit Function - Set as an event handler
        void exit(object sender, EventArgs e)
        {
            // Make the icon not visible before exiting the program
            trayIcon.Visible = false;
            System.Environment.Exit(0);
        }
    }

    public class networkPerformanceGui : Form
    {
        public networkPerformanceGui()
        {

        }
    }
}
