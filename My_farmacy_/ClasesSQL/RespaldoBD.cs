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
    public class RespaldoBD
    {   
       private PgAdmin conexionBD;
        private string rutaCarpeta;

        public RespaldoBD()
        {
            conexionBD = new PgAdmin();
            //Carpeta 'respaldo' se crea automaticamente.
           // rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Respaldos");
            rutaCarpeta = @"C:\Users\HP 15-F0075TG\Desktop\University\Arco del IV semestre\Administracion de base de datos\Respaldos";
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }
        }

        //crear un respado completo de la base de datos
         public bool CrearRespaldo(string nombre,string usuario, out string ruta)
        {
            string user = "postgres";
            string nameBD = "White-Room";
            ruta = string.Empty;
            try
            {
               string nombreArchivo = $"{nombre}_{DateTime.Now:yyyy-MM-dd_hh-mm-ss}.backup";
                ruta = Path.Combine(rutaCarpeta, nombreArchivo);

                //hacaer el pgabp

                var psi = new ProcessStartInfo
                { 
                    FileName = $"C:\\Program Files\\PostgreSQL\\16\\bin\\pg_dump.exe",
                    Arguments = $"-U {user} -F p -b -v -f \"{ruta}\" {nameBD}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };
                psi.EnvironmentVariables["PGPASSWORD"] = "DIOS TE AMA2.0";
                var process = Process.Start(psi);
                process.WaitForExit();
                MessageBox.Show("Se realizo con exito.", "RESPALDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return process.ExitCode == 0;


              

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer el respaldo.");
                return false;
            }

        }

        //restaura la base de datos desde  un archivo .sql  selecccionado
        public bool restaurarRespaldo(string RutaOrigen)
        {
            try
            {
            
                OpenFileDialog open = new OpenFileDialog();
                string user = "postgres";
                string nameBD = "White-Room";
                string port = "5432";
                string host ="localhost";
                var psi = new ProcessStartInfo
                {
                    FileName = @"C:\Program Files\PostgreSQL\16\bin\pg_restore.exe",
                    Arguments =
                    $"-h \"{host}\" " +
                    $"-p {port}" +
                    $"-U \"{user}\" " +
                    $"-d \"{nameBD}\" " +
                    $"--clean " +
                    $"--if-exists " +
                    $"\"{open.FileName}\"",
                    UseShellExecute = false,
                    RedirectStandardError = true
                };
                psi.EnvironmentVariables["PGPASSWORD"] = "DIOS TE AMA2.0";

                var process = Process.Start(psi);
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    MessageBox.Show("Error al restaurar: " + error);
                    return false;
                }

                return true;

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se encontro nada");
                return false;
            }
        }

        public class ModeloRespaldo
        {
            public string NombreRespaldo { get; set; }
            public string RutaCompleta { get; set; }    
            public DateTime FechaCreacion { get; set; }

        }


        //Obtiene la lista de archivos ..sql almacenados en carpeta de respaldo

        public List<ModeloRespaldo> ObtenerListaRespaldo()
        {
            var lista = new List<ModeloRespaldo>();
            if (Directory.Exists(rutaCarpeta))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(rutaCarpeta);
                FileInfo[] archivos = dirInfo.GetFiles("*.sql");

                foreach(FileInfo archivo in archivos)
                {
                    lista.Add(new ModeloRespaldo
                    {
                        NombreRespaldo = archivo.Name,
                        RutaCompleta = archivo.FullName,
                        FechaCreacion = archivo.CreationTime
                    });
                }
            }

            return lista;
        }



    }
}
