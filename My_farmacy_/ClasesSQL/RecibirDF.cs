using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_farmacy_.ClasesSQL
{
    public class RecibirDF
    {
        public double subtotal;
        public  double iva;
        public double total;
        public double efectivo;
        public double dolares;
        public double coordobas;
        public double cambio;
        public double cambiodolar;
        public double precio;
        public double cantidad;

        /* --------------------------*/

        public string productos {  get; set; }
        public string cliente;
        public string usuario;
    }
}
