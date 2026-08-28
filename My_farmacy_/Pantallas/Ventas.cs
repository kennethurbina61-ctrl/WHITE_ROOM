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

namespace My_farmacy_.Pantallas
{
    public partial class Ventas : Form
    {
        public bool cerrarV {  get; set; }
        public int codigoVenta { get; set; }
        public bool facturar = false;
        public bool cliente = false;
        bool agregadoR;
        PgAdmin pg = new PgAdmin();
        int idcliente;
        int telefono;
        public Ventas()
        {
            InitializeComponent();
            autocompletar();
            txttelefono.Enabled = false;
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

        private void btniniciar_Click(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("No se encontro ningun cliente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cn.Close();
        }
        private void Ventas_Load(object sender, EventArgs e)
        {

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
    }
}
