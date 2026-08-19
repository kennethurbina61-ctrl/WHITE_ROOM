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
    public partial class Productos : Form
    {
        PgAdmin pg = new PgAdmin();
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            llenar();
        }

        private void llenar()
        {
            NpgsqlConnection cn = pg.conexion();
            NpgsqlCommand cmd = new NpgsqlCommand("select p.idproductos, c.nombre as categorias, p.nombre, p.descripcio, p.estado from productos p join categorias c on p.idcategoria = c.idcategoria", cn);
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dtproductos.Rows.Clear();
            while (rd.Read())
            {
                string estado;
                bool est = Convert.ToBoolean(rd[4]);
                if (est == true)
                {
                    estado = "Activo";
                }
                else
                {
                    estado = "Inactivo";
                }
                dtproductos.Rows.Add(rd[0], rd[2], rd[3], rd[1], estado);

            }
            rd.Close();
            cn.Close();

            NpgsqlConnection np = pg.conexion();
            NpgsqlCommand chn = new NpgsqlCommand("select nombre from categorias", np);
            NpgsqlDataReader nn = chn.ExecuteReader();
            cbcategoria.Items.Clear();
            while (nn.Read())
            {
                cbcategoria.Items.Add(nn[0]);
            }
            nn.Close();
            np.Close();

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            bool estado;
            string nombre = txtnombre.Text;
            string categoria = cbcategoria.Text;
            string es = cbestadoP.Text;
            if (es == "Activo")
            {
                estado = true;
            }
            else
            {
                estado = false;
            }
            string descripcion = txtdescripcion.Text;

            NpgsqlConnection cn = pg.conexion();
            NpgsqlDataAdapter ct = new NpgsqlDataAdapter("select idcategoria from categorias where nombre = '" + categoria + "'", cn);
            DataTable dt = new DataTable();
            ct.Fill(dt);
            int idcat = 0;
            if(dt.Rows.Count > 0)
            {
                idcat = Convert.ToInt32(dt.Rows[0]["idcategoria"]);
            }
            NpgsqlCommand cmd = new NpgsqlCommand("insert into productos(idcategoria, nombre, descripcio, estado)  values ('" + idcat + "', '" + nombre + "', '" + descripcion + "', '" + estado + "')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Producto guardado correctamente.");
            cn.Close();
            llenar();
        }
    }
}
