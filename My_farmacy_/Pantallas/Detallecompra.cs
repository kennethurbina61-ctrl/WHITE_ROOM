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
    public partial class Detallecompra : Form
    {
        string conexx = "Server=localhost;Port=5432;User Id=postgres;Password=DIOS TE AMA2.0;Database=MyFarmacy;";
        int compraid = 0;
        public Detallecompra(string idcompra)
        {
            InitializeComponent();
            compraid = Convert.ToInt32(idcompra);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Detallecompra_Load(object sender, EventArgs e)
        {
            llenar();
        }
        private void llenar()
        {
            NpgsqlConnection nc = new NpgsqlConnection(conexx);
            nc.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select p.nombre as productos, d.precio_c, d.precio_v, d.cantidad, d.subtotal from detalle_compra d join productos p on d.idproductos = p.idproductos where idcompra = '" + compraid + "'",nc);
            NpgsqlDataReader cn = cm.ExecuteReader();
            dtcategorias.Rows.Clear();
            while (cn.Read())
            {
                dtcategorias.Rows.Add(cn[0], cn[3], cn[1], cn[2], cn[4]);
            }
            cn.Close();
        }
    }
}
