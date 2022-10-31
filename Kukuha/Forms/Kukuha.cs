using System;
using System.Net;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;

// чтобы жрать ещё меньше ресов, надо КД таймера сделать раз в минуту, а для синхронизации при запуске КД делать соотв, чтобы синхронилось на 00мин

namespace Kukuha
{
    public partial class Kukuha : Form
    {
        /// <summary>
        /// номер версии приложения
        /// </summary>
        readonly Version version = new Version("1.6.4");

        /// <summary>
        /// получение версии приложения
        /// </summary>
        public Version GetVersion
        {
            get
            {
                return version;
            }
        }

        /// <summary>
        /// онлайн адреса версии
        /// </summary>
        readonly string VersionPath = "https://pastebin.com/abrDfmwL";

        /// <summary>
        /// получение адреса версии
        /// </summary>
        public string GetVersionPath
        {
            get
            {
                return VersionPath;
            }
        }

        /// <summary>
        /// путь к звукам времени
        /// </summary>
        public readonly string timeMainPath = Directory.GetCurrentDirectory() + @"\TimeSounds\sp";
        /// <summary>
        /// путь к дополнительным звукам
        /// </summary>
        public readonly string randomMainPath = Directory.GetCurrentDirectory() + @"\RandomSounds\sp";

        /// <summary>
        /// таймер
        /// </summary>
        readonly System.Windows.Forms.Timer timer01 = new System.Windows.Forms.Timer();
        
        /// <summary>
        /// рандомайзер
        /// </summary>
        readonly Random rnd = new Random();

        /// <summary>
        /// проигрыватель звука времени
        /// </summary>
        readonly SoundPlayer sayTime = new SoundPlayer();

        /// <summary>
        /// проигрыватель дополнительного звука
        /// </summary>
        readonly SoundPlayer sayRandom = new SoundPlayer();

        /// <summary>
        /// веб-улиент для обновления
        /// </summary>
        readonly WebClient Client = new WebClient();

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateCheck();

            timer01.Interval = 1000;
            timer01.Tick += new EventHandler(Timer1_Tick);
            timer01.Start();
            
            Version.Text = "v" + version.ToString();
        }

        /// <summary>
        /// Проверка наличия обновлений
        /// </summary>
        private void UpdateCheck()
        {
            if (!Client.DownloadString(VersionPath).Contains(version.ToString()))
            {
                MessageBox.Show("Обнаружена новая версия Kukuha","Kukuha обновилась" );

                Updation Upd = new Updation();
                Upd.ShowDialog();
            }
        }

        //Таймер по КД раз в секунду перерисовывает текст
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
            
            string path = timeMainPath + hoursNow + ".wav";

            if (Int32.Parse(hoursNow) >= 48)
            {

                int hh = Int32.Parse(hoursNow) - 48;
                hoursNow = hh.ToString("00");
                path = timeMainPath + hoursNow + ".wav";

            } else if (Int32.Parse(hoursNow) >= 24)
            {

                int hh = Int32.Parse(hoursNow) - 24;
                hoursNow = hh.ToString("00");
                path = timeMainPath + hoursNow + ".wav";

            }             

            sayTime.SoundLocation = path;
            sayTime.Play();

        }

        /// <summary>
        /// воспроизведение дополнительного звука
        /// </summary>
        public void PlayTheRandomAction() /*actionNow Надо юзать как ориентир для фраз или нахер?*/
        {
            int error = 0;
            int filesNumber = System.IO.Directory.GetFiles(randomMainPath.Substring(0, randomMainPath.Length - 3)).Length; // количество файлов в папке. путь минус последние три символа - путь к папке

            string numOfFile = rnd.Next(filesNumber).ToString("00"); /*рандом из количества файлов*/

            //fixme
            Console.WriteLine(numOfFile  + " of " + filesNumber);

            string path = randomMainPath + "d" + numOfFile + ".wav";

            sayRandom.SoundLocation = path;
            try
            {
                sayRandom.Play();
            }
            catch
            {
                if (error < 5)
                {
                    PlayTheRandomAction();
                    error++;
                }
                else MessageBox.Show("Воспроизведение дополнительного звука невозможно \n Возможно,были добавлены файлы, не являющиеся звуковыми", "Kukuha Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Test test = new Test();
            test.Owner = this;
            test.ShowDialog();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Owner = this;
            settings.ShowDialog();
        }
        #endregion
    }
}
