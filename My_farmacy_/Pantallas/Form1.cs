using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Npgsql;
using My_farmacy_.ClasesSQL;
//using Npgsql;

namespace My_farmacy_
{
    public partial class loging : Form
    {
        

        public loging()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void loging_Load(object sender, EventArgs e)
        {
            panelcontenedor.BackColor = Color.FromArgb(128, 0, 0, 0);
        }

        private void txtcontrasena_Enter(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "Ingrese su contraseña")
            {
                txtcontrasena.Text = "";
                txtcontrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtcontrasena_Leave(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "")
            {
                txtcontrasena.Text = "Ingrese su contraseña";
                txtcontrasena.UseSystemPasswordChar = false;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
           if ( txtusuario.Text == "")
            {
                txtusuario.Text = "Ingrese su usuario";
            }
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Ingrese su usuario")
            {
                txtusuario.Text = "";
            }
        }

        private void loging_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panellogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

     

        private void panellogear_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login()
        {
            bool estado;
            ClasesSQL.LoginSQL kk = new ClasesSQL.LoginSQL();
            NpgsqlConnection cnx = kk.conexion();
            //Lo que hace esto es juntar y comparar el id rol y con la misma tabla para asi poder extraer el nombre del rol
            NpgsqlCommand cm = new NpgsqlCommand(
             "SELECT u.username, u.passwords, u.estado, r.nombre AS rol " +
             "FROM users u " +
             "JOIN rol r ON u.idrol = r.idrol " +
             "WHERE u.username= '" + txtusuario.Text + "' AND u.passwords= '" + txtcontrasena.Text + "'", cnx);
            NpgsqlDataReader dr = cm.ExecuteReader();
           
            if (dr.Read())
            {
                string es = dr["estado"].ToString();
                if (es == "True")
                {
                    string usuario = txtusuario.Text;
                    MessageBox.Show("Bienvenido al sistema " + usuario + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string rol = dr["rol"].ToString();
                    Principal pp = new Principal(rol, usuario);
                    pp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario esta inactivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtusuario.Text = "Ingrese su usuario";
                    txtcontrasena.Text = "Ingrese su contraseña";
                    txtcontrasena.UseSystemPasswordChar = false;
                }
                
            }
            else
            {
                MessageBox.Show("El usuario y/o la contraseña es incorrecta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusuario.Text = "Ingrese su usuario";
                txtcontrasena.Text = "Ingrese su contraseña";
                txtcontrasena.UseSystemPasswordChar = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
                    login();
         
          
        }

        private void linkrecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperarcontra rc = new Recuperarcontra();
            rc.Show();
            this.Hide();
        }
    }
}
