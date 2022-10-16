using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kukuha
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        #region Кнопачке
        private void testTimeBtn_Click(object sender, EventArgs e)
        {
            Kukuha Main = this.Owner as Kukuha;
            string tempText = Main.label1.Text;

            tempText = tempText.Substring(0, tempText.Length - 3);
            Main.playTheTime(tempText);
        }

        private void testRandomBtn_Click(object sender, EventArgs e)
        {
            Kukuha Main = this.Owner as Kukuha;
            Main.playTheRandomAction();
        }
        #endregion
    }
}
