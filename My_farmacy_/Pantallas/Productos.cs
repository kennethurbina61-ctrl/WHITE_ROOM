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

namespace My_farmacy_
{
    public partial class Productos : Form
    {
        string conex = "Server=localhost;Port=5432;User Id=postgres;Password=DIOS TE AMA2.0;Database=MyFarmacy;";
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
            NpgsqlConnection cn = new NpgsqlConnection(conex);
            cn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select p.idproductos, c.nombre as categorias, p.nombre, p.descripcion, p.estado from productos p join categorias c on p.idcat = c.idcat", cn);
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

            NpgsqlConnection np = new NpgsqlConnection(conex);
            np.Open();
            NpgsqlCommand chn = new NpgsqlCommand("select nombre from categorias", np);
            NpgsqlDataReader nn = chn.ExecuteReader();
            cbcategoria.Items.Clear();
            while (nn.Read())
            {
                cbcategoria.Items.Add(nn[0]);
            }
            nn.Close();

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

            NpgsqlConnection cn = new NpgsqlConnection (conex); cn.Open();
            NpgsqlDataAdapter ct = new NpgsqlDataAdapter("select idcat from categorias where nombre = '" + categoria + "'", cn);
            DataTable dt = new DataTable();
            ct.Fill(dt);
            int idcat = 0;
            if(dt.Rows.Count > 0)
            {
                idcat = Convert.ToInt32(dt.Rows[0]["idcat"]);
            }
            NpgsqlCommand cmd = new NpgsqlCommand("insert into productos(idcat, nombre, descripcion, estado)  values ('" + idcat + "', '" + nombre + "', '" + descripcion + "', '" + estado + "')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Producto guardado correctamente.");
            cn.Close();
            llenar();
        }
    }
}
