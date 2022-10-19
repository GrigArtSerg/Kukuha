using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Kukuha
{
    public partial class FormRepSug : Form
    {
        readonly string Login = "KukuhaApp";

        readonly string Pass = "bzajtetruwelkscu";
        public FormRepSug()
        {
            InitializeComponent();

            this.Icon = Icon.ExtractAssociatedIcon((Directory.GetCurrentDirectory() + @"\icon.ico"));
        }

        /// <summary>
        /// Настроить отправку сообщений о предложения/проблемах в работе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Send_Click(object sender, EventArgs e)
        {
            /*
            string mail = Login + "@yandex.ru";
            Ans.Text = mail;

            MailAddress MailFrom = new MailAddress(mail, "App");
            MailAddress MailTo = new MailAddress("grig.art.serg@yandex.ru");

            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.UseDefaultCredentials = false;

                smtp.Credentials = new NetworkCredential(Login, Pass);
                smtp.Port = 465;
                smtp.Host = "smtp.yandex.ru";
                smtp.EnableSsl = true;

                MailMessage Message = new MailMessage(MailFrom, MailTo)
                {
                    Subject = "ReportOrSuggestion",
                    Body = MessageText.Text,
                    BodyEncoding = System.Text.Encoding.UTF8
                };

                smtp.Send(Message);
            }

            Ans.Text = "Сообщение отправлено";
            //this.Close();
            */
        }
    }
}
