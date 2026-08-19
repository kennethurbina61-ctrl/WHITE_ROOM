using MailKit.Net.Smtp;
using MimeKit;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_farmacy_.ClasesSQL
{
    public class Conexion
    {
        Random rand = new Random();

        //ixno lmyo dptp byeb
        public void enviar(string destinatario, string usuario, string codigo)
        {
            var mailmessege = new MimeMessage();
            mailmessege.From.Add(new MailboxAddress("Farmacias praga", "suportmyfarmacy@gmail.com"));
            mailmessege.To.Add(new MailboxAddress(usuario, destinatario));
            mailmessege.Subject = "El usuario " + usuario + " solicito recuperacion de contraseña.";
            mailmessege.Body = new TextPart("Plain")
            {
                Text = "Hola, " + usuario + " Solicitaste recuperar tu contraseña, cambia tu contraseña con este codigo. su codigo es " + codigo + " el codigo es valido solo por 2 minutos."
            };

            using (var smptclient = new SmtpClient())
            {
                smptclient.Connect("smtp.gmail.com", 465, true);
                smptclient.Authenticate("suportmyfarmacy@gmail.com", "olkq javf mbae faia");
                smptclient.Send(mailmessege);
                smptclient.Disconnect(true);
            }

            MessageBox.Show("El mensaje se envio correctamente.");
        }

    }
}
