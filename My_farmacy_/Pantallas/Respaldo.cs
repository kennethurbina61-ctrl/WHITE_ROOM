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

namespace My_farmacy_.Pantallas
{
    public partial class Respaldo : Form
    {
        RespaldoBD resp = new RespaldoBD();
        string user;
        public Respaldo()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            PanelCrear.Visible = true;
            Crearrespaldo.Visible = false;
        }

        private void cargarR()
        {
            var lista = resp.ObtenerListaRespaldo();
            tabla.DataSource = null;
            tabla.DataSource = lista;
            if (tabla.Columns["RutaCompleta"] != null)
            {
                tabla.Columns["RutaCompleta"].Visible = false;
            }
        }

        private void btncrearpanel_Click(object sender, EventArgs e)
        {
            string nombreRespaldo = txtnombreresapaldo.Text.Trim();
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
               
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            PanelCrear.Visible = false;
            Crearrespaldo.Visible = true;
        }

        private void btnselecionar_Click(object sender, EventArgs e)
        {
            PanelArchivo.Visible = true;
            pnlrestaurar.Visible = false;
        }

        private void btnexitArchivo_Click(object sender, EventArgs e)
        {
            PanelArchivo.Visible = false;
            pnlrestaurar.Visible = true;
        }

        private void Respaldo_Load(object sender, EventArgs e)
        {
            cargarR();
        }
    }
}
