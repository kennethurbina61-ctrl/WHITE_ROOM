using My_farmacy_.ClasesSQL;
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
    public partial class Categorias : Form
    {
        PgAdmin pg = new PgAdmin();
        public Categorias()
        {
            InitializeComponent();
        }
        public void llenar()
        {
            NpgsqlConnection cn = pg.conexion();
            NpgsqlCommand cmd = new NpgsqlCommand("Select idcategoria, nombre, descripcion from categorias", cn);
            NpgsqlDataReader nn = cmd.ExecuteReader();
            dtcategorias.Rows.Clear();
            while (nn.Read())
            {
                
                    dtcategorias.Rows.Add(nn[0], nn[1], nn[2]);
            }
            nn.Close();
            cn.Close();

        }
        private void Categorias_Load(object sender, EventArgs e)
        {
            llenar();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection ag = pg.conexion();
            NpgsqlCommand cmd = new NpgsqlCommand("Insert into categorias (nombre, descripcion) values ('" + txtnombre.Text + "', '" + txtdescripcion.Text + "')", ag);
            cmd.ExecuteNonQuery();
            ag.Close();
            llenar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
