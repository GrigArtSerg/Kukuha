using System;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using System.Windows.Forms;

namespace Kukuha
{
    public partial class Mail : Form
    {
        /// <summary>
        /// Адрес почты приложения
        /// </summary>
        string MailAddress = "KukuhaApp@yandex.ru";
        
        /// <summary>
        /// Пароль почты отправления
        /// </summary>
        string MailPassword = "wixteivkzuiemtqm";

        public Mail()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            MimeMessage Message = new MimeMessage();

            Message.From.Add(new MailboxAddress("KukuhaApp", MailAddress));
            Message.To.Add(MailboxAddress.Parse(MailAddress));

            Message.Subject = SubjectText.Text;

            Message.Body = new TextPart("plain")
            {
                Text = MessageText.Text,
            };

            SmtpClient Client = new SmtpClient();

            try
            {
                Client.Connect("smtp.yandex.ru", 465, true);
                Client.Authenticate(MailAddress, MailPassword);
                Client.Send(Message);

                MessageBox.Show("Сообщение отправлено!", "Отправка сообщения");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сообщение не отправлено! \n" + ex.Message, "Ошибка отправки сообщения");
                throw;
            }
            finally
            {
                Client.Disconnect(true);
                Client.Dispose();
            }

            this.Close();
        }
    }
}
