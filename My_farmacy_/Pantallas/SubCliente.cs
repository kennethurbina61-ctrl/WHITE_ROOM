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
using Npgsql;

namespace My_farmacy_.Pantallas
{
    public partial class SubCliente : Form
    {
        PgAdmin sql = new PgAdmin();
        bool estado;
        public SubCliente()
        {
            InitializeComponent();
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (cbestado.Text == "Activo")
            {
                estado = true;
            }
            else if (cbestado.Text == "Inactivo")
            {
                estado= false;
            }
            NpgsqlConnection cn = sql.conexion();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into clientes (nombre, direccion, telefono, correo, estado) values ('" + txtnombre.Text + "', '" + txtdireccion.Text + "', '" + txttelefono.Text + "', '" + txtcorreo.Text + "', '" + estado + "')", cn);
            NpgsqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Cliente agregado correctamente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show("Cliente agregado correctamente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            rd.Close();
            cn.Close();
        }
    }
}
