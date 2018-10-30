using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using System.Threading.Tasks;

namespace Computer_Component_Store.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly SendGridClient sendGridClient;

        public EmailSender(SendGridClient sendGridClient)
        {
            this.sendGridClient = sendGridClient;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            SendGrid.Helpers.Mail.SendGridMessage message = new SendGrid.Helpers.Mail.SendGridMessage
            {
                From = new SendGrid.Helpers.Mail.EmailAddress("admin@ccstore.store.com", "CC Store Admin"),
                Subject = subject,
                HtmlContent = htmlMessage,
                PlainTextContent = htmlMessage
            };
            message.TemplateId = "d-40db81db931445c9bc0cb23ab4d0b7b8";
            message.SetTemplateData(new
            {
                subject,
                body = htmlMessage
            });

           //message.SetClickTracking(false, false);

            message.AddTo(email);
            return this.sendGridClient.SendEmailAsync(message);
        }
    }
}