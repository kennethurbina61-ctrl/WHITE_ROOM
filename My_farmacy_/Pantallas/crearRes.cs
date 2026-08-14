using My_farmacy_.ClasesSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static My_farmacy_.ClasesSQL.RespaldoBD;

namespace My_farmacy_.Pantallas
{
    public partial class crearRes : Form
    {
        private RespaldoBD resp = new RespaldoBD();
        string user;
        
        public crearRes(string usuario)
        {
            InitializeComponent();
            user = usuario;
        }

        private void crearRes_Load(object sender, EventArgs e)
        {
            cargarR();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
          
        }

        private void cargarR()
        {
            var lista = resp.ObtenerListaRespaldo();
            tabla.DataSource = null;
            tabla.DataSource = lista;
            if (tabla.Columns["RutaCompleta"] != null )
            {
                tabla.Columns["RutaCompleta"].Visible = false;
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string nombreRespaldo =  txtnombreresapaldo.Text.Trim();
            if (string.IsNullOrEmpty(nombreRespaldo))
            {
                MessageBox.Show("Por favor agregue un nombre.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string rutaFinal;
                bool exito = resp.CrearRespaldo(nombreRespaldo, user, out rutaFinal);

                if (exito)
                {
                    MessageBox.Show("!El respaldo se realizo con exito!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarR(); 
                }
                else
                {
                    MessageBox.Show("No se pudo completar el respaldo del sistema.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
