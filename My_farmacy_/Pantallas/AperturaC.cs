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
    public partial class AperturaC : Form
    {

       
        bool clienteBB;
        int TotalP;

        public AperturaC()
        {
            InitializeComponent();

        }

        private void nudInicial_ValueChanged(object sender, EventArgs e)
        {
            
        }
        ErrorProvider er = new ErrorProvider();
        private void nudInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool val = Validaciones.solonumeros(e);
            if (!val)
            {
                er.SetError(nudInicial, "Solo se permiten numeros.");
            }

            else
            {
                er.Clear();
            }
        }

        private void nudDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool val = Validaciones.solonumeros(e);
            if (!val)
            {
                er.SetError(nudInicial, "Solo se permiten numeros.");
            }

            else
            {
                er.Clear();
            }
        }

        private void nudDolar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AperturaC_Load(object sender, EventArgs e)
        {
          
        }
    }
}
