using System.Net;
using System.Net.Mail;

namespace MicrosoftTeams
{
    public class Service
    {
        private readonly ILogger<Service> logger;  
        public Service(ILogger<Service> logger)
        {
            this.logger = logger;
        }

        public async Task SendEmailDefault()
        {
                    MailAddress from = new MailAddress("charlottemagne@mail.ru", "Tom");
                    MailAddress to = new MailAddress("charlottemagne@mail.ru");
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = "Регистрация на конференцию";
                    m.Body = "Спасибо за регистрацию!";
                    SmtpClient smtp = new SmtpClient("smtp.mail.ru", 2525);
                    smtp.Credentials = new NetworkCredential("charlottemagne@mail.ru", "3bK8CAEGsHU7mvmoTPTt");
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(m);
        }

        public void SendEmailCustom()
        {
            try
            {
                logger.LogInformation("Сообщение отправлено успешно!");
            }
            catch (Exception e)
            {
                logger.LogError(e.GetBaseException().Message);
            }
        }

    }
}
