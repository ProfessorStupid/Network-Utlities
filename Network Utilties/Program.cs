﻿using System;
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

            Application.Run(new NetworkUtlitiesApp());
        }
    }

    public class NetworkUtlitiesApp : ApplicationContext
    {
        private NotifyIcon trayIcon;

        public NetworkUtlitiesApp()
        {
            trayIcon = new NotifyIcon()
            {
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

        void exit(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            System.Environment.Exit(0);
        }
    }
}
