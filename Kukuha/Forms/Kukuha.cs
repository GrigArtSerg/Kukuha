using System;
using System.Net;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;

// NOTE Покопаться с варнингами: не хочу видеть вары к классам, но хочу - к их содержимому (методам !)

// NOTE Тесты LOL ???

namespace Kukuha
{
    public partial class Kukuha : Form
    {
        readonly VersionControl version = new VersionControl();
        readonly Paths paths = new Paths();

        /// <summary>
        /// таймер
        /// </summary>
        readonly System.Windows.Forms.Timer timer01 = new System.Windows.Forms.Timer();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = Properties.Settings.Default.IsHideOnStart;

            if (Properties.Settings.Default.IsUpdateCheck)
            {
                UpdateCheck();
            }

            timer01.Interval = 1000;
            timer01.Tick += new EventHandler(Timer1_Tick);
            timer01.Start();
            
            Version.Text = "v" + version.version.ToString();
        }

        /// <summary>
        /// Проверка наличия обновлений
        /// </summary>
        private void UpdateCheck()
        {
            WebClient Client = new WebClient();

            if (!Client.DownloadString(version.VersionPath).Contains(version.version.ToString()))
            {
                MessageBox.Show("Обнаружена новая версия Kukuha","Kukuha обновилась" );

                Updation Upd = new Updation();
                Upd.ShowDialog();
            }
        }

        //Таймер по КД раз в секунду перерисовывает текст
        /// <summary>
        /// NOTE
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
                PlayTheTime(DateTime.Now.Hour.ToString("00"));
                //Добавочная рандомная фигня (минуты 00, секунды 03)
                Thread.Sleep(3000);
                PlayTheRandomAction();
            }
        }

        /// <summary>
        /// Воспроизведение времени
        /// </summary>
        /// <param name="hoursNow">воспроизведение времени</param>
        public void PlayTheTime(string hoursNow)
        {
            /// <summary>
            /// проигрыватель звука времени
            /// </summary>
            SoundPlayer sayTime = new SoundPlayer();

            string path = paths.timeMainPath + hoursNow + ".wav";

            if (Int32.Parse(hoursNow) >= 48)
            {

                int hh = Int32.Parse(hoursNow) - 48;
                hoursNow = hh.ToString("00");
                path = paths.timeMainPath + hoursNow + ".wav";

            } else if (Int32.Parse(hoursNow) >= 24)
            {

                int hh = Int32.Parse(hoursNow) - 24;
                hoursNow = hh.ToString("00");
                path = paths.timeMainPath + hoursNow + ".wav";

            }             

            sayTime.SoundLocation = path;
            sayTime.Play();

        }

        /// <summary>
        /// воспроизведение дополнительного звука
        /// </summary>
        public void PlayTheRandomAction() /*actionNow Надо юзать как ориентир для фраз или нахер?*/
        {
            int Voice = Properties.Settings.Default.Voice;

            int filesNumber = System.IO.Directory.GetFiles(paths.randomMainPath[0].Substring(0, paths.randomMainPath[0].Length - 3)).Length; // количество файлов в папке. путь минус последние три символа - путь к папке

            Random rnd = new Random();

            SoundPlayer sayRandom = new SoundPlayer();

            string numOfFile = rnd.Next(filesNumber).ToString("00"); /*рандом из количества файлов*/

            string path = paths.randomMainPath[0] + "d" + numOfFile + ".wav";

            //fixme
            Console.WriteLine($"{numOfFile} of {filesNumber} at {path}");

            sayRandom.SoundLocation = path;
            try { 
                sayRandom.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// загрузка 
        /// </summary>
        public Kukuha()
        {
            InitializeComponent();

            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00");

            this.Icon = Icon.ExtractAssociatedIcon((Directory.GetCurrentDirectory() + @"\icon.ico"));
        }

        #region Кнопачке
        private void TestButton_Click(object sender, EventArgs e)
        {
            Test test = new Test
            {
                Owner = this
            };
            test.ShowDialog();
        }

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
