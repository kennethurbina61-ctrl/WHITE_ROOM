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
    public partial class Compras : Form
    {
        int subtotalP = 0, iva = 0, total = 0, subt = 0, idcompra = 0;
        int userid = 0;
        int proveid = 0;
        int numeroF;
        string pro;
        string metodo;
        string fecha;
        string user;
        string fechaR;
        public Compras(string user)
        {
            InitializeComponent();
            txtusuario.Text = user;
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            txtfecahregistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            llenarcombo();
            panel4.Enabled = false;
            panel6.Enabled = false;
        }
        PgAdmin pg = new PgAdmin();

        private void llenarcombo()
        {
            NpgsqlConnection cn = pg.conexion();
            NpgsqlCommand cmd = new NpgsqlCommand("select nombre from productos", cn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CBproducto.Items.Add(dr[0]);
            }
            dr.Close();
            NpgsqlCommand pv = new NpgsqlCommand("select nombre from proveedores", cn);
            NpgsqlDataReader pr = pv.ExecuteReader();
            while (pr.Read())
            {
                cbprov.Items.Add(pr[0]);
            }
            pr.Close();
            cn.Close();
            

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            panel4.Enabled = true; panel1.Enabled = false;
            userid = 0; proveid = 0; numeroF = Convert.ToInt32(txtnumerofactura.Text);
            pro = cbprov.Text;
            metodo = CBmetodo.Text;
            fecha= txtfecha.Text;
            user = txtusuario.Text;
            fechaR = txtfecahregistro.Text;
            NpgsqlConnection cn = pg.conexion();
            NpgsqlDataAdapter us = new NpgsqlDataAdapter("select idusuario from usuario where username= '" + user + "'", cn);
            DataTable dt = new DataTable();
            us.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                userid = Convert.ToInt32(dt.Rows[0]["idusuario"]);
            }
            NpgsqlDataAdapter pr = new NpgsqlDataAdapter("select idproveedores from proveedores where nombre= '" + pro + "'", cn);
            DataTable dp = new DataTable();
            pr.Fill(dp);
            if (dp.Rows.Count > 0)
            {
                proveid = Convert.ToInt32(dp.Rows[0]["idproveedores"]);
            }
            NpgsqlCommand cmd = new NpgsqlCommand("insert into compras (idproveedores, idusuario, nfactura, fecha_co, fecha_re, metodo) values ('" + proveid + "', '" + userid + "', '" + numeroF + "', '" + fecha + "', '" + fechaR + "', '" + metodo + "') returning idcompra;", cn);
            NpgsqlDataReader cd = cmd.ExecuteReader();
            if (cd.Read())
            {
                idcompra = cd.GetInt32(0);
            }
            MessageBox.Show("Rellene los datos para completar la compra.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cd.Close();
            txtidcompra.Text = idcompra.ToString();
            cn.Close();
        }
        

        private void btnagregar_Click(object sender, EventArgs e)
        {
            //Agregar al data
            int idproducto = 0;
            string producto = CBproducto.Text, cantidad = txtcantidad.Text, precio_c = txtcompra.Text, precio_v = txtventa.Text, metodo_p=CBmetodo.Text;
            subtotalP = Convert.ToInt32(cantidad) * Convert.ToInt32(precio_c);
            dtcategorias.Rows.Add(producto, cantidad, precio_c, precio_v, subtotalP, metodo_p);
            iva += Convert.ToInt32(subtotalP * 0.15);
            subt += Convert.ToInt32(subtotalP);
            total += Convert.ToInt32(subtotalP * 1.15);
            panel6.Enabled = true;
            lbliva.Text = iva.ToString();
            lbltotal.Text = total.ToString();
            lblsubtotal.Text = subt.ToString();
            int lote = Convert.ToInt32(txtlote.Text);

            //Agregar_detalle
            NpgsqlConnection cn = pg.conexion();
            NpgsqlDataAdapter pr = new NpgsqlDataAdapter("select idproductos from productos where nombre = '" + CBproducto.Text + "'", cn);
            DataTable dt = new DataTable();
            pr.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                idproducto = Convert.ToInt32(dt.Rows[0]["idproductos"]);
            }
            NpgsqlCommand cmd = new NpgsqlCommand("insert into detalle_compra (idcompra, idproductos, idlote, cantidad, precio_c, precio_v, subtotal) values ('" + idcompra + "', '" + idproducto + "', '" + lote + "' , '" + cantidad + "','" + precio_c + "', '" + precio_v + "', '" + subtotalP + "') ", cn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("Producto agregado");
            dr.Close();
            cn.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            NpgsqlConnection cn = pg.conexion();
            NpgsqlCommand cmd = new NpgsqlCommand("update compras set subtotal = '" + subt + "', iva = '" + iva + "', total= '" + total + "' where idcompra = '" + idcompra + "'", cn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("El registro se guardo correctamente.");
            dr.Close();
            cn.Close();
        }
    }
}
