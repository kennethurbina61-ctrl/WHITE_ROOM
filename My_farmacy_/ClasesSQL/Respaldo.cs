using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace My_farmacy_.ClasesSQL
{
    public class Respaldo
    {   
       private LoginSQL conexionBD;
        private string rutaCarpeta;

        public Respaldo()
        {
            conexionBD = new LoginSQL();
            //Carpeta 'respaldo' se crea automaticamente.
            rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Respaldos");
            
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }
        }

        //crear un respado completo de la base de datos
         public bool CrearRespaldo(string nombre,string usuario, out string ruta)
        {
            ruta = string.Empty;
            try
            {
               string nombreArchivo = $"{nombre}_{DateTime.Now:yyyy-MM-dd_hh-mm-ss}.sql";
                ruta = Path.Combine(rutaCarpeta, nombreArchivo);

                //hacaer el pgabp

                var psi = new ProcessStartInfo
                { 
                    FileName = "pg_dump",
                    Arguments = $"-U {usuario} -F p -b -v -f \"{ruta}\" {nombre}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                var process = Process.Start(psi);
                process.WaitForExit();

                return process.ExitCode == 0;




            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer el respaldo.");
                return false;
            }

        }

        //necesito terminar

    }
}
