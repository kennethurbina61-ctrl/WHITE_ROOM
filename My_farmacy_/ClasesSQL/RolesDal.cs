using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace My_farmacy_.ClasesSQL
{
    public class RolesDal
    {
        public static int agregar(RolesC prole)
        {
            int retorno = 0;
            ClasesSQL.PgAdmin cc = new ClasesSQL.PgAdmin();
            using (NpgsqlConnection con = cc.conexion())
            {
                NpgsqlCommand comando = new NpgsqlCommand(string.Format("Insert into rol (nombre, estado, descripcion) values ('{0}', '{1}', '{2}')",
                  prole.nombre, prole.estado, prole.descriocion),  con);

                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
            
        }
    }
}
