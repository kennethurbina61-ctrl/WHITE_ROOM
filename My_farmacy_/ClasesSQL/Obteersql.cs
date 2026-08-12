using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Net.Mail;

namespace My_farmacy_.ClasesSQL
{
    public class Obteersql
    {
        string codigor;
      Random r = new Random();
        public void codigo(string codigo)
        {
            codigo = r.Next(300000, 999999).ToString();
           
        }

        public void confirmar(string confirmar)
        {

        }


    }
}
