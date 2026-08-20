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
    public partial class Reportescompras : Form
    {
        PgAdmin pg = new PgAdmin();

        public Reportescompras()
        {
            InitializeComponent();
        }
        //Falta cambiar la base de datosx

        private void Reportescompras_Load(object sender, EventArgs e)
        {
            llenar();
        }
        string fechaC;
        string fechaF;
        string idcompra;
        private void llenar()
        {
            //NEcesito corregir el error de la fecha
            NpgsqlConnection cn = pg.conexion();
            NpgsqlCommand cmd = new NpgsqlCommand("select c.idcompra, p.nombre as proveedores, u.username as usuario, c.nfactura, c.fecha_co, c.fecha_re, c.metodo, c.subtotal, c.iva, c.total, c.nlote from compras c join proveedores p on c.idproveedores = p.idproveedores join usuario u on c.idusuario = u.idusuario", cn);
            NpgsqlDataReader r = cmd.ExecuteReader();
            dtcompras.Rows.Clear();
            while (r.Read())
            {
                DateTime ff = r.GetDateTime(4);
                fechaC = ff.ToString("dd-MM-yyyy");
                DateTime nn = r.GetDateTime(5);
                fechaF = nn.ToString("dd-MM-yyyy");
                dtcompras.Rows.Add(r[0], r[3], r[2], r[6], fechaC, fechaF, r[7], r[8], r[9], r[1], r[10]);
            }
            r.Close();
            cn.Close();
        }

        private void dtcompras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idcompra = dtcompras.SelectedCells[0].Value.ToString();
            Detallecompra cc = new Detallecompra(idcompra);
            cc.Show();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //bton buscar, necesetito qque me salgan todos los registros de una sola fecha ya que solo me sale uno
            NpgsqlConnection cn = pg.conexion();
            NpgsqlCommand cmd = new NpgsqlCommand("select c.idcompra, c.metodo, p.nombre as proveedores, c.n_factura, c.fecha_f, c.fecha_r, u.username as users, c.subtotal, c.iva, c.total, c.nlote from compras c join proveedores p on c.idpro = p.idpro join users u on c.userid = u.userid where c.fecha_r = '" + txtfecha.Text + "'", cn);
            NpgsqlDataReader r = cmd.ExecuteReader();
            dtcompras.Rows.Clear();
            if (r.Read())
            {
                dtcompras.Rows.Add(r[0], r[3], r[2], r[6], fechaC, fechaF, r[7], r[8], r[9], r[1], r[10]);
            }
            r.Close();
            cn.Close();
            //Necesito buscar por proveedores y por usuarios con las mismas caracteristicas de buscar con fecha de registros
            //Necesito validar todas las pantallas.
        }
    }
}
