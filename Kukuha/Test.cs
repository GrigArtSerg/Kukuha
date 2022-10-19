using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Kukuha
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();

            this.Icon = Icon.ExtractAssociatedIcon((Directory.GetCurrentDirectory() + @"\icon.ico"));
        }

        #region Кнопачке
        private void TestTimeBtn_Click(object sender, EventArgs e)
        {
            Kukuha Main = this.Owner as Kukuha;
            string tempText = Main.label1.Text;

            tempText = tempText.Substring(0, tempText.Length - 3);
            Main.PlayTheTime(tempText);
        }

        private void TestRandomBtn_Click(object sender, EventArgs e)
        {
            Kukuha Main = this.Owner as Kukuha;
            Main.PlayTheRandomAction();
        }
        #endregion
    }
}
