using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail; 

namespace My_farmacy_.SentMail
{
    class EnviarGm : ClaseRecuperar
    {
        public EnviarGm()
        {
            remetenteCorreo = "suportmyfarmacy@gmail.com";
            password = "ixno lmyo dptp byeb";
            host = "smpt.gmail.com";
            port = 465;
            ssl = true;
            intializaciont();
        }
    }
}
