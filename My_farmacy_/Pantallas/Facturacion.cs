using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_farmacy_.Pantallas
{
    public partial class Facturacion : Form
    {
        public bool facturacionE = true;
    //  public bool completo = true;
      public event Action<bool> completo;
        public Facturacion()
        {
            InitializeComponent();
            CBmetodopago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            facturacionE = false;
            this.Close();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            GBtarjeta.Visible = false;
        }

        private void CBmetodopago_TextChanged(object sender, EventArgs e)
        {
            if (CBmetodopago.Text == "Eféctivo")
            {
                GBefectivo.Visible = true;
                GBtarjeta.Visible = false;
            }
            else if(CBmetodopago.Text == "Tarjeta")
            {
                GBefectivo.Visible = false;
                GBtarjeta.Visible = true;
            }
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Quieres imprimir una factura?", "Imprimir Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                completo?.Invoke(false);
                facturacionE = false;
                this.Close();
            }
        }
    }
}
