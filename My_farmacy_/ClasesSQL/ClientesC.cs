using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_farmacy_.ClasesSQL
{
    public class ClientesC
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public bool estado { get; set; }
        public string descriocion { get; set; }
        public string fecha { get; set; }


        public ClientesC() { }

        public ClientesC(int sid, string snombre, bool sestado, string sdescripcion, string sfecha)
        {
            this.Id = sid;
            this.nombre = snombre;
            this.estado = sestado;
            this.descriocion = sdescripcion;
            this.fecha = sfecha;
        }
    }
}
