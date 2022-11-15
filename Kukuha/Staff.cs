using System;
using System.Net;
using System.Windows.Forms;
using System.Media;

namespace Kukuha
{
    class Staff
    {
        static public int GetVoiceFromSettings(string voice)
        {
            switch (voice)
            {
                case "RandomSoundsArthas":
                    return 1;
                default:
                    return 0;
            }

        }

        static public string SetVoiceToSettings(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 1:
                    return "RandomSoundsArthas";
                default:
                    return "RandomSoundsMaximBot";
            }
        }

        /// <summary>
        /// Проверка наличия обновлений
        /// </summary>
        static public void UpdateCheck()
        {
            WebClient Client = new WebClient();

            if (!Client.DownloadString(VersionControl.VersionPath).Contains(VersionControl.version.ToString()))
            {
                MessageBox.Show("Обнаружена новая версия Kukuha", "Kukuha обновилась");

                Updation Upd = new Updation();
                Upd.ShowDialog();
            }
        }

        /// <summary>
        /// воспроизведение дополнительного звука
        /// </summary>
        static public void PlayTheRandomAction() /*actionNow Надо юзать как ориентир для фраз или нахер?*/
        {
            int filesNumber = System.IO.Directory.GetFiles(Paths.randomMainPath[0].Substring(0, Paths.randomMainPath[0].Length - 3)).Length; // количество файлов в папке. путь минус последние три символа - путь к папке

            Random rnd = new Random();

            SoundPlayer sayRandom = new SoundPlayer();

            string numOfFile = rnd.Next(filesNumber).ToString("00"); /*рандом из количества файлов*/

            string path = Paths.randomMainPath[0] + "d" + numOfFile + ".wav";

            //fixme
            Console.WriteLine($"{numOfFile} of {filesNumber} at {path}");

            sayRandom.SoundLocation = path;
            try
            {
                sayRandom.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Воспроизведение времени
        /// </summary>
        /// <param name="hoursNow">воспроизведение времени</param>
        static public void PlayTheTime(string hoursNow)
        {
            SoundPlayer sayTime = new SoundPlayer();

            string path = Paths.timeMainPath + hoursNow + ".wav";

            if (Int32.Parse(hoursNow) >= 48)
            {

                int hh = Int32.Parse(hoursNow) - 48;
                hoursNow = hh.ToString("00");
                path = Paths.timeMainPath + hoursNow + ".wav";

            }
            else if (Int32.Parse(hoursNow) >= 24)
            {

                int hh = Int32.Parse(hoursNow) - 24;
                hoursNow = hh.ToString("00");
                path = Paths.timeMainPath + hoursNow + ".wav";

            }

            sayTime.SoundLocation = path;
            sayTime.Play();

        }
    }
}
