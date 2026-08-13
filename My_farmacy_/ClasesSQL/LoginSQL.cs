using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_farmacy_.ClasesSQL
{
    public class LoginSQL
    {
        NpgsqlConnection cnx = new NpgsqlConnection();

        static string server = "localhost";
        static string bd = "White-Room";
        static string usuario = "postgres";
        static string pasworld = "DIOS TE AMA2.0";
        static string puerto = "5432";

        string cadenaconexion = "server="+server + ";"+ "port="+puerto+ ";" + "user id="+usuario+ ";" + "password=" + pasworld+ ";"+ "database="+ bd+ ";";

        public NpgsqlConnection conexion()
        {
            try
            {
                cnx.ConnectionString = cadenaconexion;
                cnx.Open();

                //Es necesario usando pgagent crear tablas de respaldo?
                //MessageBox.Show("Bienvenido");
            }
            catch(NpgsqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.");
            }
            return cnx;
        }

        Obteersql ob = new Obteersql();
       

    }
}
