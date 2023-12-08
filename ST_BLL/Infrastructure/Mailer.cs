using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ST_BLL.Infrastructure
{
    public class Mailer(SmtpClient smtpClient, Mailer.MailerConfig mailerConfig)
    {
        public class MailerConfig
        {
            public required string Server { get; init; }
            public required int Port { get; init; }
            public required string Username { get; init; }
            public required string Password { get; init; }
        }
        
        public void Send(string to, string subject, string message) 
        {
            throw new NotImplementedException();
        }
    }
}
