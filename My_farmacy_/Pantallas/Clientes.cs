using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_farmacy_
{
    public partial class Clientes : Form
    {
        string coneccion = "Server=localhost;Port=5432;User Id=postgres;Password=DIOS TE AMA2.0;Database=MyFarmacy;";
        
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Llenar();
        }
        private bool vacios()
        {
            var vl = !string.IsNullOrEmpty(txtdireccion.Text) && !string.IsNullOrEmpty(txtcorreo.Text) &&
                !string.IsNullOrEmpty(txttelefono.Text) &&
                !string.IsNullOrEmpty(cbestado.Text);
            if (vl)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void limpiar()
        {
            txtnombre.Clear(); txtcorreo.Clear(); txtdireccion.Clear(); txttelefono.Clear(); cbestado.Text = "";
        }
        private void Llenar()
        {
            NpgsqlConnection cn = new NpgsqlConnection(coneccion);
            cn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select idcliente, cliente, correo, telefono, direccion, estado from clientes", cn);
            NpgsqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string estado;
                bool es = Convert.ToBoolean(rd[5]);
                if(es == true)
                {
                    estado = "Activo";
                }
                else
                {
                    estado = "Inactivo";
                }

                dtcategorias.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], estado);
            }
            rd.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (vacios())
            {
                NpgsqlConnection bn = new NpgsqlConnection(coneccion);
                bn.Open();
                bool estado;
                if (cbestado.Text == "Activo")
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                NpgsqlCommand cmd = new NpgsqlCommand("insert into clientes (cliente, correo, telefono, direccion, estado) values ('" + txtnombre.Text + "','" + txtcorreo.Text + "' ,'" + txttelefono.Text + "', '" + txtdireccion.Text + "', '" + estado + "')", bn);
                cmd.ExecuteNonQuery();
                bn.Close();
                Llenar();
                limpiar();
            }
            else
            {
                MessageBox.Show("No puede dejar campos vacios.");
            }
           

        }
    }
}
