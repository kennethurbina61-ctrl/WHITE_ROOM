using My_farmacy_.ClasesSQL;
using My_farmacy_.Pantallas;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace My_farmacy_
{
    public partial class Principal : Form
    {
        bool flowoanelex;
        PgAdmin pg = new PgAdmin();
        public Principal(string rol, string usuario)
        {
            InitializeComponent();
            lblrol.Text = rol;
            lblusuario.Text = usuario;
        }
        
        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea salir de la aplicación?", "AVISO DE CIERRE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void AbrirForm(object formHijo)
        {

              
            if (panelcontenedor.Controls.Count > 0)
            {
                Form formActual = panelcontenedor.Controls[0] as Form;
                if (formActual != null)
                {
                    if (formActual is Compras compras)
                    {
                        bool cerrar = compras.cerrar;
                        if (cerrar == true)
                        {
                            NpgsqlConnection cn = pg.conexion();
                            string codigo = compras.codigoCompra;
                            DialogResult resultado = MessageBox.Show(
                            "Nota: Si no se finaliza el proceso, los datos seran reiniciados.",
                            "Confirmar acción",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                            );
                            if (resultado == DialogResult.Yes)
                            {
                                formActual.Close();
                                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM compras WHERE idcompra = '" + codigo + "'", cn);
                                NpgsqlDataReader dr = cmd.ExecuteReader();
                                dr.Close();
                                cn.Close();
                            }
                            else
                            {
                                cn.Close();
                                return;
                                  
                            }
                        }

                    }

                }
                panelcontenedor.Controls.Clear();
            }
            Form form = formHijo as Form;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.panelcontenedor.Controls.Add(form);
                this.panelcontenedor.Tag = form;
                form.Show();
                
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkcerrarsesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
         "¿Desea cerrar sesión?",
         "Confirmar cierre de sesión",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question
     );

            if (resultado == DialogResult.Yes)
            {
  
                MessageBox.Show("Sesión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                loging ll = new loging();
                ll.Show();
                this.Close();
            }
            else
                {
               
            }
            
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new UsuariosRol());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); 
            //btnmaximizar.Visible = false;
        }

        private void btncontrolcaja_Click(object sender, EventArgs e)
        {

        }

        private void timerdash_Tick(object sender, EventArgs e)
        {
            if (flowoanelex)
            {
                panelbotones.Width -= 10;
                if (panelbotones.Width == panelbotones.MinimumSize.Width)
                {
                    flowoanelex = false;
                    timerdash.Stop();
                }
            }
            else
            {
                panelbotones.Width += 10;
                if (panelbotones.Width == panelbotones.MaximumSize.Width)
                {
                    flowoanelex = true;
                    timerdash.Stop();
                }
            }

        }

        private void activardash_Click(object sender, EventArgs e)
        {
            timerdash.Start();
        }
        bool rep;
        private void tmreprtes_Tick(object sender, EventArgs e)
        {
            if (rep)
            {
                pnlreportes.Height -= 10;
                if (pnlreportes.Height == pnlreportes.MinimumSize.Height)
                {
                    rep = false;
                    tmreprtes.Stop();
                }
            }
            else
            {
                pnlreportes.Height += 10;
                if (pnlreportes.Height == pnlreportes.MaximumSize.Height)
                {
                    rep = true;
                    tmreprtes.Stop();
                }
            }
        }
        bool caja;
        private void tmcaja_Tick(object sender, EventArgs e)
        {
            if (caja)
            {
                pnlcaja.Height -= 10;
                if (pnlcaja.Height == pnlcaja.MinimumSize.Height)
                {
                    caja = false;
                    tmcaja.Stop();
                }
            }
            else
            {
                pnlcaja.Height += 10;
                if (pnlcaja.Height == pnlcaja.MaximumSize.Height)
                {
                    caja = true;
                    tmcaja.Stop();
                }
            }
        }

        private void btncaja_Click(object sender, EventArgs e)
        {
            tmcaja.Start();
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            tminv.Start();
        }
        bool inve;
        private void tminv_Tick(object sender, EventArgs e)
        {
            if (inve)
            {
                pnlinventario.Height -= 10;
                if (pnlinventario.Height == pnlinventario.MinimumSize.Height)
                {
                   inve = false;
                    tminv.Stop();
                }
            }
            else
            {
                pnlinventario.Height += 10;
                if (pnlinventario.Height == pnlinventario.MaximumSize.Height)
                {
                    inve = true;
                    tminv.Stop();
                }
            }
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            tmreprtes.Start(); 
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            AbrirForm(new Proveedores());
        }

        private void btncategorias_Click(object sender, EventArgs e)
        {
            AbrirForm(new Categorias());
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            AbrirForm(new Productos());
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            string user = lblusuario.Text;
            AbrirForm(new Compras(user));
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            AbrirForm(new Clientes());
        }

        private void btnreportesC_Click(object sender, EventArgs e)
        {
            AbrirForm(new Reportescompras());
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            AbrirForm(new Ventas());
        }

        private void btnrespaldo_Click(object sender, EventArgs e)
        {
            AbrirForm(new Respaldo());
        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
