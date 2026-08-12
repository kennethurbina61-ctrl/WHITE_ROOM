using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace My_farmacy_
{
    public abstract class ClaseRecuperar
    {
        private SmtpClient smtpClient;
        protected string remetenteCorreo {  get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool  ssl { get; set; }//sertificado de seguridad

        protected void intializaciont()
        {
            smtpClient = new SmtpClient();
            smtpClient.Host = host;
            smtpClient.Credentials = new NetworkCredential(remetenteCorreo, password);
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void setmail(string subject, string body, List<string> destinatorio)
        {
            var mailmessege = new MailMessage();
            try
            {
                mailmessege.From = new MailAddress(remetenteCorreo);
                foreach (string mail in destinatorio)
                {
                    mailmessege.To.Add(mail);
                }
               mailmessege.Subject = subject;
                mailmessege.Body = body;
                mailmessege.Priority = MailPriority.Normal;
                smtpClient.Send(mailmessege);
            }
            catch (Exception ex)
            {

            }
            finally { mailmessege.Dispose();
                smtpClient.Dispose();
            }

        }
        
    }
}
