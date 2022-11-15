using System.IO;

namespace Kukuha
{
    class Paths
    {
        /// <summary>
        /// путь к звукам времени
        /// </summary>
        static public readonly string timeMainPath = Directory.GetCurrentDirectory() + @"\TimeSounds\sp";

        /// <summary>
        /// путь к дополнительным звукам
        /// </summary>
        // NOTE поменять каталоги
        static public string[] randomMainPath = new string[2] { Directory.GetCurrentDirectory() + @"\RandomSoundsGoogleMan\sp",
                                                                Directory.GetCurrentDirectory() + @"\RandomSoundsArthas\sp"};

        /*Paths()
        {
            randomMainPath[0] = Directory.GetCurrentDirectory() + @"\RandomSoundsGoogleMan\sp";
            randomMainPath[1] = Directory.GetCurrentDirectory() + @"\RandomSoundsArthas\sp";
        }*/

    }
}
