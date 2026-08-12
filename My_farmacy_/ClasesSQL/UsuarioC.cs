using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_farmacy_.ClasesSQL
{
    internal class UsuarioC
    {
        public int idusuario {  get; set; }
        public string nombre { get; set; }
        public string clave { get; set; }
        public string correo {  get; set; }
        public int telefono { get; set; }
        public int idrol {  get; set; }
        public string usuario { get; set; }
        public bool estado {  get; set; }
    }
}
