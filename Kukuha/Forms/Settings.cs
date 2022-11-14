using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace Kukuha
{
    public partial class Settings : Form
    {
        // TODO Полезные ссылки: GitHub, YouTube, подумай ???
        readonly string AutoRunPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Microsoft\Windows\Start Menu\Programs\Startup\Kukuha.lnk");
        readonly Staff staff = new Staff();
        readonly Paths paths = new Paths();

        public Settings()
        {
            InitializeComponent();

            // устанавливаем иконку
            this.Icon = Icon.ExtractAssociatedIcon((Directory.GetCurrentDirectory() + @"\icon.ico"));

            // смотрим текущие настройки по автозапуску
            IsAutoRun.Checked = Properties.Settings.Default.IsAutoRunCheck;

            // смотрим текущие настройки по проверке обновлений
            IsUpdateCheck.Checked = Properties.Settings.Default.IsUpdateCheck;

            // смотрим текущие настройки по скрытию при запуске
            switch (Properties.Settings.Default.IsHideOnStart)
            {
                case FormWindowState.Minimized:
                    IsHideOnLoad.Checked = true;
                    break;
                default:
                    IsHideOnLoad.Checked = false;
                    break;
            }

            VoiceChange.SelectedItem = VoiceChange.Items[Properties.Settings.Default.Voice];
        }

        /// <summary>
        /// Включение автозагрузки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// Включение проверки обновлений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsUpdateCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (IsUpdateCheck.Checked == true)
            {
                Properties.Settings.Default.IsUpdateCheck = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.IsUpdateCheck = false;
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// NOTE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsHideOnLoad_CheckedChanged(object sender, EventArgs e)
        {
            Kukuha Main = this.Owner as Kukuha;
            if (IsHideOnLoad.Checked)
            {
                Properties.Settings.Default.IsHideOnStart = FormWindowState.Minimized;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.IsHideOnStart = FormWindowState.Normal;
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// NOTE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VoiceChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Voice = VoiceChange.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// NOTE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPhrase_Click(object sender, EventArgs e)
        {
            int Voice = Properties.Settings.Default.Voice;

            OpenFileDialog AddSound = new OpenFileDialog
            {
                Multiselect = false,
                Title = "Добавление фраз для уведомлений",
                Filter = "Audio files(*.mp3, *.wav, *.aac, *.flac, *.wav, *.ogg)|*.mp3;*.wav;*.aac;*.flac;*.wav;*.ogg|All files(*.*)|*.*"
            };

            if (AddSound.ShowDialog() == DialogResult.Cancel)
                return;

            // количество файлов в папке. путь минус последние три символа - путь к папке
            int filesNumber = System.IO.Directory.GetFiles(paths.randomMainPath[0].Substring(0, paths.randomMainPath[0].Length - 3)).Length;
            string path = paths.randomMainPath[Voice] + "d" + filesNumber.ToString("00") + Path.GetExtension(AddSound.FileName);
            System.IO.File.Copy(AddSound.FileName, path);

            AddSound.RestoreDirectory = true;
        }

        /// <summary>
        /// Настроить отправку сообщений о предложения/проблемах в работе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportOrSuggestion_Click(object sender, EventArgs e)
        {
            Mail FormRepSug = new Mail
            {
                Owner = this
            };
            FormRepSug.ShowDialog();
        }
    }
}
