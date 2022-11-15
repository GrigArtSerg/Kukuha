using System;

namespace Kukuha
{
    class VersionControl
    {
        /// <summary>
        /// номер версии приложения
        /// </summary>
        static public readonly Version version = new Version("1.6.5");

        /// <summary>
        /// получение версии приложения
        /// </summary>
        static public Version GetVersion
        {
            get
            {
                return version;
            }
        }

        /// <summary>
        /// онлайн адреса версии
        /// </summary>
        static public readonly string VersionPath = "https://pastebin.com/abrDfmwL";

        /// <summary>
        /// получение адреса версии
        /// </summary>
        static public string GetVersionPath
        {
            get
            {
                return VersionPath;
            }
        }
    }
}
