using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kukuha
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Ssl3;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Kukuha());
        }
    }
}
