using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            System.Diagnostics.Process.Start("https://disk.yandex.ru/d/OSjaORWMyr4YDA");
            Application.Exit();
        }

        private void CloseUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
