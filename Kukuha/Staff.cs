using System;
using System.IO;

namespace Kukuha
{
    class Staff
    {
        public int GetVoiceFromSettings(string voice)
        {
            switch (voice)
            {
                case "RandomSoundsArthas":
                    return 1;
                default:
                    return 0;
            }

        }

        public  string SetVoiceToSettings(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 1:
                    return "RandomSoundsArthas";
                default:
                    return "RandomSoundsMaximBot";
            }
        }
    }
    
    class VersionControl
    {
        /// <summary>
        /// номер версии приложения
        /// </summary>
        public readonly Version version = new Version("1.6.5");

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
        public readonly string VersionPath = "https://pastebin.com/abrDfmwL";

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
    }

    class Paths
    {
        /// <summary>
        /// путь к звукам времени
        /// </summary>
        public readonly string timeMainPath = Directory.GetCurrentDirectory() + @"\TimeSounds\sp";

        /// <summary>
        /// путь к дополнительным звукам
        /// </summary>
        // NOTE поменять каталоги
        public string[] randomMainPath = new string[2];

        public Paths()
        {
            randomMainPath[0] = Directory.GetCurrentDirectory() + @"\RandomSoundsGoogleMan\sp";
            randomMainPath[1] = Directory.GetCurrentDirectory() + @"\RandomSoundsArthas\sp";
        }
                                                      
    }
}
