using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace Kukuha
{
    public partial class Settings : Form
    {

        string AutoRunPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Microsoft\Windows\Start Menu\Programs\Startup\Kukuha.lnk");

        public Settings()
        {
            InitializeComponent();

            this.Icon = Icon.ExtractAssociatedIcon((Directory.GetCurrentDirectory() + @"\icon.ico"));

            if (System.IO.File.Exists(AutoRunPath))
            {
                IsAutoRun.Checked = true;
            }
        }

        private void AddPhrase_Click(object sender, EventArgs e)
        {
            Kukuha Main = this.Owner as Kukuha;

            OpenFileDialog AddSound = new OpenFileDialog();
            AddSound.Multiselect = false;
            AddSound.Title = "Добавление фраз для уведомлений";
            AddSound.Filter = "Audio files(*.mp3, *.wav, *.aac, *.flac, *.wav, *.ogg)|*.mp3;*.wav;*.aac;*.flac;*.wav;*.ogg|All files(*.*)|*.*";
            
            if (AddSound.ShowDialog() == DialogResult.Cancel)
                return;
        
            int filesNumber = System.IO.Directory.GetFiles(Main.randomMainPath.Substring(0, Main.randomMainPath.Length - 3)).Length; // количество файлов в папке. путь минус последние три символа - путь к папке
            string path = Main.randomMainPath + "d" + filesNumber.ToString("00") + Path.GetExtension(AddSound.FileName);
            System.IO.File.Copy(AddSound.FileName, path);

            AddSound.RestoreDirectory = true;
        }

        private void IsAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAutoRun.Checked == true)
            {
                WshShell Shell = new WshShell();
                IWshShortcut Shortcut = (IWshShortcut)Shell.CreateShortcut(AutoRunPath);

                Shortcut.Description = "Ярлык дял Kukuha";
                //Shortcut.TargetPath = Directory.GetCurrentDirectory() + @"\Kukuha.exe";

                Shortcut.TargetPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                Shortcut.WorkingDirectory = Environment.CurrentDirectory;
                //Shortcut.WorkingDirectory = Directory.GetCurrentDirectory();

                Shortcut.Save();

                //Microsoft.Win32.RegistryKey Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);
                //Key.SetValue("Kukuha", AutoRunPath);
            }
            else
            {
                if (System.IO.File.Exists(AutoRunPath))
                {
                    System.IO.File.Delete(AutoRunPath);
                }
            }
        }

        /// <summary>
        /// Настроить отправку сообщений о предложения/проблемах в работе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportOrSuggestion_Click(object sender, EventArgs e)
        {
            /*
            FormRepSug FormRepSug = new FormRepSug();
            FormRepSug.Owner = this;
            FormRepSug.ShowDialog();
            */
        }
    }
}
