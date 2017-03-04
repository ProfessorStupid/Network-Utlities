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
                    new MenuItem("Network Proformance"),
                    new MenuItem("Options"),
                    new MenuItem("Exit", exit)
                }),
                Visible = true
            };
        }

        // Exit Function - Set as an event handler
        void exit(object sender, EventArgs e)
        {
            // Make the icon not visible before exiting the program
            trayIcon.Visible = false;
            System.Environment.Exit(0);
        }
    }
}
