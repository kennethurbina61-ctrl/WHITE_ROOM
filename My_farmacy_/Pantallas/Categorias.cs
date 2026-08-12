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
        string conex = "Server=localhost;Port=5432;User Id=postgres;Password=DIOS TE AMA2.0;Database=MyFarmacy;";
        public Categorias()
        {
            InitializeComponent();
        }
        public void llenar()
        {
            string estado;
            bool eso;
            NpgsqlConnection cn = new NpgsqlConnection(conex);
            cn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select idcat, nombre, descripcion, estado from categorias", cn);
            NpgsqlDataReader nn = cmd.ExecuteReader();
            dtcategorias.Rows.Clear();
            while (nn.Read())
            {
                eso = Convert.ToBoolean(nn[3]);
                if(eso == true)
                {
                    estado = "Activo";
                }
                else
                {
                    estado = "Inactivo";
                }
                    dtcategorias.Rows.Add(nn[0], nn[1], nn[2], estado);
            }
            nn.Close();

        }
        private void Categorias_Load(object sender, EventArgs e)
        {
            llenar();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            bool estado;
            if (cbestadoR.Text == "Activo")
            {
                estado = true;
            }
            else
            {
                estado= false;
            }
            NpgsqlConnection ag = new NpgsqlConnection(conex);
            ag.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Insert into categorias (nombre, descripcion, estado) values ('" + txtnombre.Text + "', '" + txtdescripcion.Text + "', '" + estado + "')", ag);
            cmd.ExecuteNonQuery();
            ag.Close();
            llenar();
        }
    }
}
