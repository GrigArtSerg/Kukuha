using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

// NOTE Покопаться с варнингами: не хочу видеть вары к классам, но хочу - к их содержимому (методам !)

// NOTE Тесты LOL ???

namespace Kukuha
{
    /// <summary>
    /// Управление содержимым формы
    /// </summary>
    public partial class Kukuha : Form
    {
        /// <summary>
        /// таймер
        /// </summary>
        readonly System.Windows.Forms.Timer timer01 = new System.Windows.Forms.Timer();

        /// <summary>
        /// загрузка 
        /// </summary>
        public Kukuha()
        {
            InitializeComponent();

            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00");

            this.Icon = Icon.ExtractAssociatedIcon((Directory.GetCurrentDirectory() + @"\icon.ico"));

            this.WindowState = Properties.Settings.Default.IsHideOnStart;

            if (Properties.Settings.Default.IsUpdateCheck)
            {
                Staff.UpdateCheck();
            }
        }

        /// <summary>
        /// Старт таймера + упрадвение содержимым формы по загрузке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            timer01.Interval = 1000;
            timer01.Tick += new EventHandler(Timer1_Tick);
            timer01.Start();

            Version.Text = "v" + VersionControl.version.ToString();
        }

        /// <summary>
        /// Раз в секунду при синхронизации и раз в минуту после перерисовывает текст
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Second.ToString("00") == "00")
                timer01.Interval = 60 * 1000;
            else timer01.Interval = 1000;

            //Записываем время
            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00");

            //Точное время (минуты 00, секунды 00)
            if (DateTime.Now.Minute.ToString("00") == "00" && DateTime.Now.Second.ToString("00") == "00")
            {
                Staff.PlayTheTime(DateTime.Now.Hour.ToString("00"));
                //Добавочная рандомная фигня (минуты 00, секунды 03)
                Thread.Sleep(3000);
                Staff.PlayTheRandomAction();
            }
        }

        #region Кнопачке
        /// <summary>
        /// Кнопка к тестам звуков
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestButton_Click(object sender, EventArgs e)
        {
            Test test = new Test
            {
                Owner = this
            };
            test.ShowDialog();
        }

        /// <summary>
        /// Кнопка к меню настроек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings
            {
                Owner = this
            };
            settings.ShowDialog();
        }
        #endregion
    }
}
