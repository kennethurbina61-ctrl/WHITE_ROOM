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
        string coneccion = "Server=localhost;Port=5432;User Id=postgres;Password=DIOS TE AMA2.0;Database=MyFarmacy;";
        int userid = 0;
        int proveid = 0;
        string numeroF;
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

        private void llenarcombo()
        {
            NpgsqlConnection cn = new NpgsqlConnection(coneccion);
            cn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select nombre from productos", cn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CBproducto.Items.Add(dr[0]);
            }
            dr.Close();
            //cn.Open();
            NpgsqlCommand pv = new NpgsqlCommand("select nombre from proveedores", cn);
            NpgsqlDataReader pr = pv.ExecuteReader();
            while (pr.Read())
            {
                cbprov.Items.Add(pr[0]);
            }
            pr.Close();
            

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            panel4.Enabled = true; 
            panel1.Enabled = false;
            userid = 0;
            proveid = 0;
            numeroF = txtnumerofactura.Text;
            pro = cbprov.Text;
            metodo = CBmetodo.Text;
            fecha= txtfecha.Text;
            user = txtusuario.Text;
            fechaR = txtfecahregistro.Text;
            NpgsqlConnection cn = new NpgsqlConnection(coneccion); cn.Open();
            NpgsqlDataAdapter us = new NpgsqlDataAdapter("select userid from users where username= '" + user + "'", cn);
            DataTable dt = new DataTable();
            us.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                userid = Convert.ToInt32(dt.Rows[0]["userid"]);
            }
            NpgsqlDataAdapter pr = new NpgsqlDataAdapter("select idpro from proveedores where nombre= '" + pro + "'", cn);
            DataTable dp = new DataTable();
            pr.Fill(dp);
            if (dp.Rows.Count > 0)
            {
                proveid = Convert.ToInt32(dp.Rows[0]["idpro"]);
            }
            NpgsqlCommand cmd = new NpgsqlCommand("insert into compras(metodo, idpro, n_factura, fecha_f, fecha_r, userid) values ('" + metodo + "', '" + proveid + "', '" + numeroF + "', '" + fecha + "', '" + fechaR + "', '" + userid + "') returning idcompra;", cn);
            NpgsqlDataReader cd = cmd.ExecuteReader();
            if (cd.Read())
            {
                idcompra = cd.GetInt32(0);
            }
            MessageBox.Show("Rellene los datos para completar la compra.");
            cd.Close();
            txtidcompra.Text = idcompra.ToString();
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

            //Agregar_detalle
            NpgsqlConnection cn = new NpgsqlConnection(coneccion);
            cn.Open();
            NpgsqlDataAdapter pr = new NpgsqlDataAdapter("select idproductos from productos where nombre = '" + CBproducto.Text + "'", cn);
            DataTable dt = new DataTable();
            pr.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                idproducto = Convert.ToInt32(dt.Rows[0]["idproductos"]);
            }
            NpgsqlCommand cmd = new NpgsqlCommand("insert into detalle_compra (idcompra, idproductos, precio_c, precio_v, cantidad, subtotal) values ('" + idcompra + "', '" + idproducto + "', '" + precio_c + "', '" + precio_v + "', '" + cantidad + "', '" + subtotalP + "') ", cn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("Producto agregado");
            dr.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
            NpgsqlConnection cn = new NpgsqlConnection(coneccion); cn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("update compras set subtotal = '" + subt + "', iva = '" + iva + "', total= '" + total + "' where idcompra = '" + idcompra + "'", cn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("El registro se guardo correctamente.");
            dr.Close();
        }
    }
}
