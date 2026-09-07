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
        int subtotalP = 0, iva = 0, total = 0, subt = 0, idcompra = 0, lote = 0, userid = 0, proveid = 0;
        public int iddeatalle { get; set; }
        string numeroF;
        string pro, metodo, fecha, user, fechaR;

        private void txtcompra_Leave(object sender, EventArgs e)
        {

            if (txtcompra.Text == "")
            {
                txtcompra.Text = "0.00";
            }
            else
            {
                if (decimal.TryParse(txtcompra.Text, out decimal valor))
                {
                    txtcompra.Text = valor.ToString("N2");
                }
                else
                {
                    txtcompra.Text = "0.00";
                }
            }
        }

        private void txtventa_Leave(object sender, EventArgs e)
        {
            if (txtventa.Text == "")
            {
                txtventa.Text = "0.00";
            }
            else
            {
                if (decimal.TryParse(txtventa.Text, out decimal valor))
                {
                    txtventa.Text = valor.ToString("N2");
                }
                else
                {
                    txtventa.Text = "0.00";
                }
            }
           
        }

        private void txtcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool val = Validaciones.solonumeros(e);
            if (!val)
            {
                er.SetError(txtcompra, "Solo numeros.");
            }
            else
            {
                er.Clear();
            }
        }

        private void txtventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool val = Validaciones.solonumeros(e);
            if (!val)
            {
                er.SetError(txtventa, "Solo numeros");
            }
            else
            {
                er.Clear();
            }
        }

        ErrorProvider er = new ErrorProvider();

        private void txtcantidad_Leave(object sender, EventArgs e)
        {
            if (txtcantidad.Text == "")
            {
                txtcantidad.Text = "0";
            }
        }

        private void txtcantidad_Enter(object sender, EventArgs e)
        {
            if (txtcantidad.Text == "0")
            {
                txtcantidad.Text = "";
            }
        }

        private void txtcompra_Enter(object sender, EventArgs e)
        {
            if (txtcompra.Text == "0.00")
            {
                txtcompra.Text = "";
            }
        }

        private void txtventa_Enter(object sender, EventArgs e)
        {
            if (txtventa.Text == "0.00")
            {
                txtventa.Text = "";
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool val = Validaciones.solonumeros(e);
            if (!val)
            {
                er.SetError(txtcantidad, "Solo se permiten numeros");
            }
            else
            {
                er.Clear();
            }
            
        }
        private bool vacios()
        {
            var vc = !string.IsNullOrEmpty(txtventa.Text) && !string.IsNullOrEmpty(txtcompra.Text) && !string.IsNullOrEmpty(txtcantidad.Text) && !string.IsNullOrEmpty(txtfechaVen.Text);
            if (vc)
            {
                return true;   
            }
            else
            {
                return false;
            }
        }

        public string codigoCompra { get; set; }  
        public bool cerrar { get; set; }
        public Compras(string user)
        {
            InitializeComponent();
            txtusuario.Text = user;
            CBmetodo.DropDownStyle = ComboBoxStyle.DropDownList;
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
            if (!string.IsNullOrEmpty(txtnumerofactura.Text))
            {
                userid = 0; proveid = 0; numeroF = txtnumerofactura.Text;
                pro = cbprov.Text;
                metodo = CBmetodo.Text;
                fecha = dtpfechaR.Text;
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
                    NpgsqlCommand cmd = new NpgsqlCommand("insert into compras (idproveedores, idusuario, nfactura, fecha_co, fecha_re, metodo) values ('" + proveid + "', '" + userid + "', '" + numeroF + "', '" + fecha + "', '" + fechaR + "', '" + metodo + "') returning idcompra, nlote;", cn);
                    NpgsqlDataReader cd = cmd.ExecuteReader();
                    if (cd.Read())
                    {
                        idcompra = cd.GetInt32(0);
                        lote = cd.GetInt32(1);
                    }
                    MessageBox.Show("Rellene los datos para completar la compra.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblidcompra.Text = idcompra.ToString();
                    lblote.Text = lote.ToString();
                    codigoCompra = idcompra.ToString();
                    cd.Close();
                    panel4.Enabled = true; panel1.Enabled = false;
                    //revisar enviar el cerrar
                    cerrar = true;
                }
                else
                {
                    MessageBox.Show("No hay ningun proveedor registrado como " +pro+ ". por favor busque un nombre valido", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                cn.Close();
            }
            else
            {
                MessageBox.Show("Necesita un numero de factura para continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (vacios())
            {
                int cantidad = Convert.ToInt32(txtcantidad.Text); decimal precio_c = Convert.ToDecimal(txtcompra.Text), precio_v = Convert.ToDecimal(txtventa.Text);
                if (cantidad > 0  && precio_c > 0 && precio_v > 0)
                {
                    //Agregar_detalle
                    NpgsqlConnection cn = pg.conexion();
                    NpgsqlDataAdapter pr = new NpgsqlDataAdapter("select idproductos from productos where nombre = '" + CBproducto.Text + "'", cn);
                    DataTable dt = new DataTable();
                    pr.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        //Agregar al data
                        int idproducto = 0;
                        string producto = CBproducto.Text, metodo_p = CBmetodo.Text, fechaVen = txtfechaVen.Text;
                        subtotalP = Convert.ToInt32(cantidad) * Convert.ToInt32(precio_c);
                        dtcategorias.Rows.Add(producto, cantidad, precio_c, precio_v, subtotalP, metodo_p, fechaVen, lote);
                        iva += Convert.ToInt32(subtotalP * 0.15);
                        subt += Convert.ToInt32(subtotalP);
                        total += Convert.ToInt32(subtotalP * 1.15);
                        panel6.Enabled = true;
                        lbliva.Text = iva.ToString("N2");
                        lbltotal.Text = total.ToString("N2");
                        lblsubtotal.Text = subt.ToString("N2");

                        idproducto = Convert.ToInt32(dt.Rows[0]["idproductos"]);
                        NpgsqlCommand cmd = new NpgsqlCommand("insert into detalle_compra (idcompra, idproductos, cantidad, precio_c, precio_v, subtotal, nlote, fecha_vencimiento) values ('" + idcompra + "', '" + idproducto + "' , '" + cantidad + "','" + precio_c + "', '" + precio_v + "', '" + subtotalP + "', '" + lote + "', '" + fechaVen + "') returning iddetalle;", cn);
                        NpgsqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            iddeatalle = dr.GetInt32(0);
                        }
                        MessageBox.Show("" + CBproducto.Text + " agregado correctamente", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dr.Close();
                        NpgsqlCommand Lot = new NpgsqlCommand("insert into lote (iddetalle, idproductos, cantidad, precio_v) values ("+iddeatalle+", "+idproducto+", "+cantidad+", "+precio_v+")", cn);
                        NpgsqlDataReader lt = Lot.ExecuteReader(); 
                        lt.Close();
                    }
                    else
                    {
                        MessageBox.Show("No hay ningun producto registrado como " + CBproducto.Text + ". Porfavor busque un nombre valido.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese valores mayores que 0.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }
            else
            {
                MessageBox.Show("No puede dejar campos vacios.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void recargar()
        {
            panel4.Enabled = false; panel1.Enabled = true; txtnumerofactura.Text = ""; cbprov.Text = ""; CBproducto.Text = ""; txtfechaVen.Text = ""; txtventa.Text = "0.00";
            txtcantidad.Text = "0"; txtcompra.Text = "0.00"; lblote.Text = "0"; lblidcompra.Text = "0"; lblsubtotal.Text = "0.00"; lbliva.Text = "0.00"; lbltotal.Text = "0.00";
            panel6.Enabled = false; dtcategorias.Rows.Clear();

        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            cerrar = false;
            NpgsqlConnection cn = pg.conexion();
            NpgsqlCommand cmd = new NpgsqlCommand("update compras set subtotal = '" + subt + "', iva = '" + iva + "', total= '" + total + "' where idcompra = '" + idcompra + "'", cn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("La compra se guardo correctamente.", "EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dr.Close();
            cn.Close();
            recargar();

        }
    }
}
