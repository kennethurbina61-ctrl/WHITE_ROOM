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
using MailKit.Search;
using System.Security.Cryptography.X509Certificates;


namespace My_farmacy_.Pantallas
{
    public partial class Ventas : Form
    {
        
        //solo hace falta categoria y agregar
        string nombres;
        string Nclientes;
        string usuario;
        int subtotalPP;
        //Estas variables son para evtar abrir una subpantalla teniendo esta abierta y tambien para preguntar si no has completado la venta.
        public bool cerrarV { get; set; }
        public int codigoVenta { get; set; }
        public bool ProduV { get; set; }
        public bool facturar = false;
        public bool cliente = false;
        bool agregadoR;
        //Para las ecuaciones
        int TotalF, IVAF , SubtotalF;
        int iva = 0, SubtotalP = 0;
        PgAdmin pg = new PgAdmin();
        int idcliente, idproducto, stock; bool clienteBD = false;
        int telefono;
        //creamos el objeto para ingresar los datos
      //  RecibirDF f = new RecibirDF();
        public Ventas(string usuarioP)
        {
            InitializeComponent();
            autocompletar();
            txttelefono.Enabled = false;
            lblusuario.Text = usuarioP;
        }
        public void llamarU(string usuarioP)
        {
            lblusuario.Text = usuarioP.ToString();
        }
        private void btnfacturar_Click(object sender, EventArgs e)
        {
            Facturacion rr = new Facturacion();
            if (facturar == true)
            {
                MessageBox.Show("La panatalla de factura ya esta cargada.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                facturar = true;
                rr.FormClosed += (s, args) =>
                {
                    facturar = rr.facturacionE;
                };
                //aqui recibe el evento luego de presionarlo
                rr.completo += (completo) =>
                {
                    cerrarV = completo;
                    Recargar();

                };
                usuario = lblusuario.Text;
                rr.SetDato(TotalF, SubtotalF, IVAF, Nclientes, usuario);
                rr.Show();
            }
        }
        private void lkagregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SubCliente ss = new SubCliente();
            if (cliente == true)
            {
                MessageBox.Show("La panatalla de clientes ya esta cargada.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cliente = true;
                ss.FormClosed += (s, args) =>
                {
                    cliente = ss.clienteR;
                };
                ss.Show();
            }
                
        }
        //calcular el stock
        List<inventario> inventario = new List<inventario>(); 
        private void calcularStiock()
        {
            inventario.Clear();
            CBproducto.DataSource = null;
            CBproducto.DisplayMember = null;
            CBproducto.ValueMember = null;
            CBproducto.Items.Clear();
            NpgsqlConnection cn = pg.conexion();
            using (NpgsqlCommand cmd = new NpgsqlCommand("Select p.nombre as productos, c.nombre as categoria, i.stock_actual, i.precio_compra from inventario i join productos p on i.idproducto = p.idproductos join categorias c on p.idcategoria = c.idcategoria", cn))
            using (NpgsqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    inventario.Add(new inventario 
                    {
                        producto = rd.GetString(0),
                        categoria = rd.GetString(1),
                        stock_actual = rd.GetInt32(2),
                        precio_venta = rd.GetInt32(3)
                    });

                }
                CBproducto.DataSource = inventario;
                CBproducto.DisplayMember = $"{nombres}";
                CBproducto.ValueMember = "producto";
            }
            cn.Close();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcliente.Text))
            {
                cerrarV = true;
                NpgsqlConnection cn = pg.conexion();
                NpgsqlCommand comandocliente = new NpgsqlCommand("select idcliente, telefono from clientes where nombre= '" + txtcliente.Text + "'", cn);
                NpgsqlDataReader rdid = comandocliente.ExecuteReader();
                if (rdid.Read())
                {
                    idcliente = rdid.GetInt32(0);
                    MessageBox.Show( ""+idcliente+ "");
                    txttelefono.Text = rdid["telefono"].ToString();
                    clienteBD = true;
                }
                else
                {
                    MessageBox.Show("No se encontro ningun cliente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                rdid.Close();
                if (clienteBD == true)
                {
                    txtcliente.Enabled = false;
                    txttelefono.Enabled = false;
                    NpgsqlCommand cmd = new NpgsqlCommand("insert into venta (idcliente) values ('" + idcliente + "') returning idventa;", cn);
                    NpgsqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        codigoVenta = rd.GetInt32(0);
                        MessageBox.Show("Agregue productos a la venta.", "SISTEMA DE VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    btnagregar.Enabled = true;
                    btneliminar.Enabled = true;
                    btniniciar.Enabled = false;
                    panel4.Enabled = true;
                    Nclientes = txtcliente.Text;
                    cn.Close();
                }
                cn.Close();
            }
            else
            {
                MessageBox.Show("Introduzca un cliente para continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
           
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            panel4.Enabled = false;
            panel2.Enabled = false;
            btnagregar.Enabled = false;
            btneliminar.Enabled = false;
            calcularStiock();
        }

        void autocompletar()
        {
            NpgsqlConnection cn = pg.conexion();
            DataTable dt = new DataTable();
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            NpgsqlDataAdapter productos = new NpgsqlDataAdapter("select nombre from clientes", cn);
            productos.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(dt.Rows[i]["nombre"].ToString());
            }
            txtcliente.AutoCompleteCustomSource = lista;
            cn.Close();
        }

        private void txtcliente_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnrecargar_Click(object sender, EventArgs e)
        {
            autocompletar();
        }
        private void Recargar()
        {
            txtcantidad.Text = "0"; CBproducto.Text = ""; lblcategiria.Text = "Categoria"; lblprecio.Text = "0.00"; lblstock.Text = "0"; lblsubtotal.Text = "0.00";
            lblfinalsubtotal.Text = "0.00"; lbliva.Text = "0.00"; lbltotal.Text = "0.00"; txtcliente.Text = ""; txttelefono.Text = "";
            dtventas.Rows.Clear(); clienteBD = false;
            panel1.Enabled = true; txttelefono.Enabled = false; panel4.Enabled = false;  panel2.Enabled = false; btnagregar.Enabled = false; btneliminar.Enabled = false; txtcliente.Enabled = true;
        }
        private void limpiar()
        {
            txtcantidad.Text = "0"; CBproducto.Text = ""; lblcategiria.Text = "Categoria"; lblprecio.Text = "0.00"; lblstock.Text = "0"; lblsubtotal.Text = "0.00";
         
        }

        List<RecibirDF> productosLista = new List<RecibirDF>();
        private void btnagregar_Click(object sender, EventArgs e)
        {
            //variables con F son datos de la factura final
            Facturacion ff = new Facturacion();
            NpgsqlConnection cn = pg.conexion();
            string producto = CBproducto.Text, categoria = lblcategiria.Text;
            int cantidad = Convert.ToInt32(txtcantidad.Text); decimal precio = 0; 
           if (!string.IsNullOrEmpty(CBproducto.Text))
            {
                if(Convert.ToInt32(txtcantidad.Text) > 0)
                {
                    if(lblstock.Text == "No disponible" || cantidad > stock)
                    {
                        MessageBox.Show("El producto "+producto+" no esta en stock", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        ProduV = true;
                        DataTable dt = new DataTable();
                        NpgsqlDataAdapter dtP = new NpgsqlDataAdapter("select idproductos from productos where nombre = '" + CBproducto.Text + "'", cn);
                        dtP.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {

                            idproducto = Convert.ToInt32(dt.Rows[0]["idproductos"]);
                            precio = Convert.ToInt32(lblprecio.Text);
                            NpgsqlCommand cmd = new NpgsqlCommand("Insert into detalle_venta (idventa, cantidad, precio_venta, idproductos) values ("+codigoVenta+", "+cantidad+", "+precio+", "+idproducto+")", cn);
                            NpgsqlDataReader rd = cmd.ExecuteReader();
                            SubtotalP = Convert.ToInt32((cantidad * Convert.ToInt32(precio)) * 1.15);
                            iva = Convert.ToInt32((cantidad * Convert.ToInt32(precio)) * 0.15);
                            dtventas.Rows.Add(producto, cantidad, categoria, precio, iva, SubtotalP);
                            panel2.Enabled = true;
                            SubtotalF += Convert.ToInt32(cantidad) * Convert.ToInt32(precio);
                            IVAF += iva;
                            lbliva.Text=IVAF.ToString("N2");
                            lblfinalsubtotal.Text = SubtotalF.ToString("N2");
                            TotalF += SubtotalP;
                            lbltotal.Text = TotalF.ToString("N2");
                            RecibirDF dd = new RecibirDF();
                            dd.productos = CBproducto.Text;
                            dd.usuario = lblusuario.Text;
                            dd.cliente = txtcliente.Text;
                            dd.subtotal = Convert.ToDouble(lblfinalsubtotal.Text); dd.iva = Convert.ToDouble(lbliva.Text); dd.cantidad = Convert.ToDouble(txtcantidad.Text);
                            dd.total = Convert.ToDouble(lbltotal.Text); dd.precio = Convert.ToDouble(lblprecio.Text);
                            productosLista.Add(dd);
                            ff.llenarList(productosLista);
                            cn.Close();
                            calcularStiock();
                            limpiar();


                        }
                        else
                        {
                            MessageBox.Show("No existe " + CBproducto.Text + " en nuestro inventario.", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                   
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("La catidad tiene que ser mayor a 0.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    cn.Close();
                }
                cn.Close();
            }
            else
            {
                MessageBox.Show("Introduzca un producto valido.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                cn.Close();
            }
        }

        private void txtcantidad_Leave(object sender, EventArgs e)
        {
            if (txtcantidad.Text == "")
            {
                txtcantidad.Text = "0";
            }
        }

        private void txtcantidad_Enter(object sender, EventArgs e)
        {
            if(txtcantidad.Text == "0")
            {
                txtcantidad.Text = "";
            }
        }
        ErrorProvider er = new ErrorProvider();

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcantidad.Text))
            {
                if (lblprecio.Text != "0.00")
                {
                    int precio = Convert.ToInt32(lblprecio.Text);
                    int cantidad = Convert.ToInt32(txtcantidad.Text);
                    subtotalPP = (cantidad * precio);
                    lblsubtotal.Text = subtotalPP.ToString("N2");
                }
                else
                {

                }
            }
            else
            {
                lblsubtotal.Text = "0.00";
            }
        }

        private void txtcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool vl = Validaciones.sololetras(e);
            if (!vl)
            {
                er.SetError(txtcliente, "Solo se permiten letras.");
            }
            else
            {
                er.Clear();
            }
        }

        private void CBproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBproducto.Text == "")
            {

            }
            else
            {
                inventario selec = (inventario)CBproducto.SelectedItem;
                string categoria = Convert.ToString($"{selec.categoria}");
                stock = Convert.ToInt32($"{selec.stock_actual}");
                string productos = CBproducto.SelectedItem.ToString();
                lblcategiria.Text = categoria;
                lblstock.ForeColor = Color.Gray;
                lblprecio.Text = $"{selec.precio_venta}";
                int precio = Convert.ToInt32(lblprecio.Text);
                int cantidad = Convert.ToInt32(txtcantidad.Text);
                subtotalPP = (cantidad * precio);
                lblsubtotal.Text = subtotalPP.ToString("N2");
                if (stock <= 0)
                {
                    lblstock.Text = "No disponible";
                    lblstock.ForeColor = Color.Red;
                }
                else
                {
                    lblstock.Text = stock.ToString();
                }
            }
          
           
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool vl = Validaciones.solonumeros(e);
            if (!vl)
            {
                er.SetError(txtcantidad,"Solo se permiten numeros.");
            }
            else
            {
                er.Clear();
            }
        }
    }
}
