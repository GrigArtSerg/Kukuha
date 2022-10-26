using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Kukuha
{
    public partial class Updation : Form
    {
        public Updation()
        {
            InitializeComponent();

            this.Icon = Icon.ExtractAssociatedIcon((Directory.GetCurrentDirectory() + @"\icon.ico"));

        }

        private void OpenUpdate_Click(object sender, EventArgs e)
        {
            // System.Diagnostics.Process.Start("https://disk.yandex.ru/d/OSjaORWMyr4YDA");
            try
            {
                ProcessStartInfo ProcessInfo = new System.Diagnostics.ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = "KukuhaUpdater.exe",
                    Verb = "runas"
                };
                Process.Start(ProcessInfo);

                File.Delete("KukuhaNew.exe");
            }
            catch
            {
                Console.WriteLine(Directory.GetCurrentDirectory());

                foreach (string file in Directory.GetFiles(Directory.GetCurrentDirectory()))
                {
                    Console.WriteLine(file);
                }
            }

            Application.Exit();
        }

        private void CloseUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
