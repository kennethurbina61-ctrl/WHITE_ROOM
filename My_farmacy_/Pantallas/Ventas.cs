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

namespace My_farmacy_.Pantallas
{
    public partial class Ventas : Form
    {
        //solo hace falta categoria y agregar
        string nombres;
        int subtotalPP;
        public bool cerrarV {  get; set; }
        public int codigoVenta { get; set; }
        public bool ProduV {  get; set; }
        public bool facturar = false;
        public bool cliente = false;
        bool agregadoR;
        PgAdmin pg = new PgAdmin();
        int idcliente, idproducto, stock;
        int telefono;
        public Ventas()
        {
            InitializeComponent();
            autocompletar();
            txttelefono.Enabled = false;
         
            
        }
        Dictionary<string, decimal> precios = new Dictionary<string, decimal>();
        private void combobox()
        {    //necesito hacer  la tabla inventario para ajustar el lote, precios y stock    
            //cambiar aqui, ocupare la tabla detalle_compra, selecionare el nombre as producto para unirlo con el id y tambien seleccionar el precio_v
            NpgsqlConnection cn = pg.conexion();
            NpgsqlCommand cmd = new NpgsqlCommand("select p.nombre as productos, c.precio_v from detalle_compra c JOIN productos p on c.idproductos = p.idproductos", cn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CBproducto.Items.Clear();
                nombres = dr.GetString(0);
                CBproducto.Items.Add(nombres);
                decimal precio = dr.GetDecimal(1);
                precios[nombres] = precio;
            }
            cn.Close();
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
            NpgsqlConnection cn = pg.conexion();
            using (NpgsqlCommand cmd = new NpgsqlCommand("Select p.nombre as productos, i.stock_actual, i.precio_compra from inventario i join productos p on i.idproducto = p.idproductos", cn))
            using (NpgsqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    inventario.Add(new inventario 
                    {
                        producto = rd.GetString(0),
                        stock_actual = rd.GetInt32(1),
                        precio_venta = rd.GetInt32(2)
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
                NpgsqlDataAdapter id = new NpgsqlDataAdapter("select idcliente, telefono from clientes where nombre= '" + txtcliente.Text + "'", cn);
                DataTable dt = new DataTable();
                id.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    idcliente = Convert.ToInt32(dt.Rows[0]["idcliente"]);
                    telefono = Convert.ToInt32(dt.Rows[1]["telefono"]);
                    txttelefono.Text = telefono.ToString();
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
                    panel4.Enabled = true;
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("No se encontro ningun cliente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            //combobox();
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
            panel1.Enabled = true; txttelefono.Enabled = false; panel4.Enabled = false;  panel2.Enabled = false; btnagregar.Enabled = false; btneliminar.Enabled = false; txtcliente.Enabled = true;
        }
        private void limpiar()
        {
            txtcantidad.Text = "0"; CBproducto.Text = ""; lblcategiria.Text = "Categoria"; lblprecio.Text = "0.00"; lblstock.Text = "0"; lblsubtotal.Text = "0.00";
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string producto = CBproducto.Text, categoria = lblcategiria.Text;
            int cantidad = Convert.ToInt32(txtcantidad.Text), stock = 0, precio = 0, SubtotalP = 0;
        //  decimal precio = Convert.ToDecimal(lblprecio);
           if (!string.IsNullOrEmpty(CBproducto.Text))
            {
                if(Convert.ToInt32(txtcantidad.Text) > 0)
                {
                    ProduV = true;
                    DataTable dt = new DataTable();
                    NpgsqlConnection cn = pg.conexion();
                    //aqui tengo que cambiarlo para que soo
                    NpgsqlDataAdapter cmd = new NpgsqlDataAdapter("select idproductos from productos where nombre = '" + CBproducto.Text + "'", cn);
                    cmd.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        panel2.Enabled = true;
                        limpiar();
                        idproducto = Convert.ToInt32(dt.Rows[0]["idproductos"]);
                      //Aun ocupo sacar el precio y stock desde la base de datos con un trigger o desde las programaxion en c# precio = Convert.ToInt32(dt.Rows[1]["precio_v"]);
                        lblprecio.Text = precio.ToString("N2");
                        dtventas.Rows.Add();
                    }
                    else
                    {
                        MessageBox.Show("No existe " + CBproducto.Text + " en nuestro inventario.", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("La catidad tiene que ser mayor a 0.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                
            }
            else
            {
                MessageBox.Show("Introduzca un producto valido.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                int precio = Convert.ToInt32(lblprecio.Text);
                int cantidad = Convert.ToInt32(txtcantidad.Text);
                subtotalPP = (cantidad * precio);
                lblsubtotal.Text = subtotalPP.ToString("N2");
            }
            else
            {
                lblsubtotal.Text = "0.00";
            }
        }

        private void CBproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productos = CBproducto.SelectedItem.ToString();
            if (precios.ContainsKey(productos))
            {
                lblprecio.Text = precios[productos].ToString("N2");
            }

            inventario selec = (inventario)CBproducto.SelectedItem;
            lblstock.Text = $"{selec.stock_actual}";
            lblprecio.Text = $"{selec.precio_venta}";
            int precio = Convert.ToInt32(lblprecio.Text);
            int cantidad = Convert.ToInt32(txtcantidad.Text);
            subtotalPP = (cantidad * precio);
            lblsubtotal.Text = subtotalPP.ToString("N2");
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
