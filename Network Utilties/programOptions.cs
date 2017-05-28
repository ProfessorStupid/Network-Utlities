using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Utilties
{
    class programOptions
    {
        public static void launchGUI()
        {
            programOptionsGui gui = new programOptionsGui();
            gui.Show();
        }
    }

    public class programOptionsGui : Form
    {
        public programOptionsGui()
        {
            
        }
    }
}
