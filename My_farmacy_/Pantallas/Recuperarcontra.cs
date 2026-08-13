using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_farmacy_;
using My_farmacy_.ClasesSQL;
using Npgsql;

namespace My_farmacy_
{
    public partial class Recuperarcontra : Form
    {
        string correo;
        string usuario;
        string codigor;

        ClasesSQL.LoginSQL len = new ClasesSQL.LoginSQL();
        
        public Recuperarcontra()
        {
            InitializeComponent();
        }
        //jtogsurhbedznrqg   -> codigo backer
        Random r = new Random();
        private DateTime horaactual;
        private void btnrecuperar_Click(object sender, EventArgs e)
        {
            correo = txtcorreo.Text;
            codigor =r.Next(100000,999999).ToString();
            NpgsqlConnection nn = len.conexion();
            NpgsqlCommand ll = new NpgsqlCommand("select username from users where correo = '" + correo + "'", nn);
            NpgsqlDataReader cc = ll.ExecuteReader();
            if (cc.Read() == true)
            {
                usuario = cc.GetString(0);
                var cn = new Conexion();
                cn.enviar(correo, usuario, codigor);
                horaactual = DateTime.Now;
               
            }
            else
            {
                MessageBox.Show("Lo sentimos, no tiene cuenta con nosotros.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cc.Close();
            nn.Close();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            loging ll = new loging();
            ll.Show();
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea salir de la aplicación?", "AVISO DE CIERRE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private bool verfifi()
        {
            TimeSpan diferencia = horaactual - DateTime.Now;
            if (diferencia.TotalMinutes > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
           if (verfifi())
            {
                if (txtcodigo.Text == codigor)
                {
                    MessageBox.Show("Su codigo es correcto.");
                    pnlcodigo.Visible = false;
                    pnlnuerva.Visible = true;

                }
                else
                {
                    MessageBox.Show("Su codigo es incorrecto.");
                }
            }
           else
            {
                MessageBox.Show("El código ya no es valido.");
            }
        }

        private void Recuperarcontra_Load(object sender, EventArgs e)
        {
            pnlnuerva.Visible=false;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = len.conexion();
            NpgsqlCommand cmd = new NpgsqlCommand("update users set passwords = '" + textBox2.Text + "' where correo = '" + correo + "'", cn);
            NpgsqlDataReader reader = cmd.ExecuteReader(); 
            MessageBox.Show("La contreseña se guardo correctamente.");
            reader.Close();
            cn.Close();
            pnlnuerva.Visible = false;
            txtcorreo.Enabled = false;
            btnrecuperar.Enabled = false;
            

        }
    }
    
}
