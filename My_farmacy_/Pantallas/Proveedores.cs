using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_farmacy_.ClasesSQL;
using Npgsql;

namespace My_farmacy_
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }
        PgAdmin pg = new PgAdmin();

       private bool vacios()
        {
            var vacios = !string.IsNullOrEmpty(txtnombre.Text) && !string.IsNullOrEmpty(txtcorreo.Text) && !string.IsNullOrEmpty(txtdescripcion.Text)
                && !string.IsNullOrEmpty(txtdireccio.Text) && !string.IsNullOrEmpty(txttelefono.Text) && !string.IsNullOrEmpty(txtnewfecha.Text)
                && !string.IsNullOrEmpty(cbestado.Text);

            if (vacios)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void llenar()
        {
            NpgsqlConnection cx = pg.conexion();
            NpgsqlCommand cmd = new NpgsqlCommand("select idproveedores, nombre, telefono, correo, direccion, fecha_registro, estado, descripcion from proveedores", cx);
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dtproveedores.Rows.Clear();
            while(rd.Read())
            {
                string est;
                bool estado = Convert.ToBoolean(rd[6]);
                if (estado == true)
                {
                    est = "Activo";
                }
                else
                {
                    est = "Inactivo";
                }
                    dtproveedores.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[7], est);
            }
            rd.Close();
            cx.Close();
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
          if (vacios())
            {
                string nombre = txtnombre.Text;
                string telefono = txttelefono.Text;
                string email = txtcorreo.Text;
                string fecha = txtnewfecha.Text;
                string direc = txtdireccio.Text;
                string descr = txtdescripcion.Text;
                bool estado;

                if (cbestado.Text == "Activo")
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                NpgsqlConnection cn = pg.conexion();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into proveedores (nombre, telefono, correo, direccion, fecha_registro, estado, descripcion) values ('" + nombre + "', '" + telefono + "', '" + email + "', '" + direc + "',  '" + fecha + "', '" + estado + "', '" + descr + "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se guardo correctamente.");
                cn.Close();
                llenar();
            }
          else
            {
                MessageBox.Show("No puede dejar campos en blanco.");
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            llenar();
        }
        ErrorProvider ee = new ErrorProvider();
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.sololetras(e))
            {
                ee.SetError(txtnombre, "Solo se permiten letras.");
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.solonumeros(e))
            {
                ee.SetError(txttelefono, "Solo permiten numeros.");
            }
            else if (txttelefono.TextLength >= 8)
            {
                ee.SetError(txttelefono, "No se permiten mas de 8 numeros.");
            }
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
          
        }

        private void txtnewfecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.solonumeros(e))
            {
                ee.SetError(txtnewfecha, "Solo permiten numeros.");
            }
        }
    }
}
