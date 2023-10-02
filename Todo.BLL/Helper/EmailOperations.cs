using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Todo.BLL.Helper
{
    public class EmailOperations
    {
        public static void SendEmail(string username,string password,string emailadres , string topic , string content)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("ornekdeneme_123@hotmail.com");
            mail.To.Add(new MailAddress(emailadres,username));
            mail.Subject = topic;
            mail.Body = content;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.office365.com";
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("ornekdeneme_123@hotmail.com", "ornekdeneme123");
            client.EnableSsl = true;
            client.Send(mail);
        }
    }
}
