using My_farmacy_.ClasesSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos SQL|*.backup";
            open.Title = "Selecciona el script SQL";

            if (open.ShowDialog() == DialogResult.OK)
            {
                txtreceptor.Text = open.FileName;
            }
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            string rutaArchivo = txtreceptor.Text.Trim();
            if (string.IsNullOrEmpty(rutaArchivo) || !File.Exists(rutaArchivo))
            {
                MessageBox.Show("Selecciona un archivo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult conf = MessageBox.Show("Estas seguro que quieres restaurar? NOTA: perdera todos los archivos actuales",
                    "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (conf == DialogResult.Yes)
                {
                    bool exito = resp.restaurarRespaldo(rutaArchivo);
                    if (exito)
                    {
                        MessageBox.Show("Base de datos restaurada, exito!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtreceptor.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Error al intentar restaurar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
