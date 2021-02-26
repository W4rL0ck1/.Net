using System;
using System.Net.Mail;
using MediumHangfire;

namespace Hangfire.Services
{
    public class MailSender
    {
        public static void MailSenderService()
        {
            //Dont forget to insert your personal data on settings.cs 
            var smtpClient = new SmtpClient("smtp.outlook.com")
            {
                Port = 587,
                Credentials = new System.Net.NetworkCredential(Settings.SenderMail, Settings.SenderPassword),
                EnableSsl = true
            };

            var title = "Desafio Hangfire - Envio de email a cada 1 hora.";
            var date = DateTime.Now;
            var dateFormated = String.Format("{0:R}", date);

            smtpClient.Send(Settings.SenderMail, Settings.ReceiverMail, title, $"Olá seu corno! voce foi chifrado na data e hora a seguir : {dateFormated}\n Um Homem sem chifres é um Homem Indefeso!\n Faça já parte do maior clube de chifrudos do Brasil!");
        }
    }
}