using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Threading;
using Kukuha;

namespace KukuhaUpdater
{
    class Updater
    {
        static void Main(string[] args)
        {
            string AppPath = Directory.GetCurrentDirectory() + @"\Kukuha.exe";

            WebClient client = new WebClient();

            Kukuha.Kukuha kukuha = new Kukuha.Kukuha();

            Inform("Начало работы");

            File.Delete(Directory.GetCurrentDirectory() + @"\KukuhaNew.exe");

            if (!client.DownloadString(kukuha.GetVersionPath).Contains(kukuha.GetVersion.ToString()))
            {
                if (Process.GetProcessesByName("Kukuha.exe").Length > 0)
                {
                    Replase(client, AppPath);
                }
                else
                {
                    Process[] Kukuhas = Process.GetProcessesByName("Kukuha.exe");
                    foreach (Process process in Kukuhas)
                    {
                        process.Kill();
                    }

                    Replase(client, AppPath);
                }
            }
        }

        private static void Replase(WebClient client, string AppPath)
        {
            client.DownloadFile("https://disk.yandex.ru/d/MKL7fZtgo456Ng", "KukuhaNew.exe");
            Inform("Скачали файл");

            Console.WriteLine(AppPath);
            Console.WriteLine(File.Exists(AppPath));

            File.Delete(AppPath);
            Inform("Удалили старый exe");

            File.Copy("KukuhaNew.exe", "Kukuha.exe");
            Inform("Переименовали скачанный файл");

            System.Diagnostics.Process.Start("Kukuha.exe");

            Console.ReadLine();

            Environment.Exit(0);
        }

        private static void Inform(string info)
        {
            Console.WriteLine(info);

            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);

            foreach(string file in Directory.GetFiles(path))
            {
                Console.WriteLine(file);
            }

            Console.WriteLine();
        }
    }
}
