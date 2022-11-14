using System;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using System.Windows.Forms;

namespace Kukuha
{
    public partial class Mail : Form
    {
        // TODO Добавить поле для ввода почты на которую прислать ответ
        public Mail()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            MimeMessage Message = new MimeMessage();

            Message.From.Add(new MailboxAddress("KukuhaApp", Properties.Settings.Default.MailAddress));
            Message.To.Add(MailboxAddress.Parse(Properties.Settings.Default.MailAddress));

            Message.Subject = SubjectText.Text;

            Message.Body = new TextPart("plain")
            {
                Text = MessageText.Text,
            };

            SmtpClient Client = new SmtpClient();

            try
            {
                Client.Connect("smtp.yandex.ru", 465, true);
                Client.Authenticate(Properties.Settings.Default.MailAddress, Properties.Settings.Default.MailPassword);
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
