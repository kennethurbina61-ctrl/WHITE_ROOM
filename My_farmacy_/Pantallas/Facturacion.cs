using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using My_farmacy_.ClasesSQL;

namespace My_farmacy_.Pantallas
{
    public partial class Facturacion : Form
    {
        public bool facturacionE = true;
        public event Action<bool> completo;
        double totalrecibido = 0, total, iva, subtotal, dolares = 0, cambio = 0, coordobas = 0, cambioDolar = 0;
        double TotalEfectivo;
        RecibirDF ff = new RecibirDF();
        List<RecibirDF> listaPP = new List<RecibirDF>();
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

        public void SetDato(int total, int sub, int iva, string cliente, string usuario)
        {
            LBLtotalpagar.Text = total.ToString("N2");
            LBiva.Text = iva.ToString("N2");
            LBsubtotal.Text = sub.ToString("N2");
            lblcliente.Text = cliente;
            lblcajero.Text = usuario;
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {

        }

        public void llenarList(List<RecibirDF> product)
        {
            List<RecibirDF> listaPP = product;
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
            listaPP.Add(ff);
            //crear lista para obtener los datos de la clase recibiraDF
            double faltante;
            if (CBmetodopago.Text == "Eféctivo")
            {
                if (totalrecibido > 0)
                {
                    TotalEfectivo = totalrecibido;
                    total = Convert.ToDouble(LBLtotalpagar.Text);
                    if (totalrecibido >= total)
                    {
                        DialogResult dr = MessageBox.Show("Quieres imprimir una factura?", "Imprimir Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            //Aqui se crea la ruta donde guardaremos las facturas.
                            FileStream fac = new FileStream($@"C:\Users\HP 15-F0075TG\Desktop\University\Arco del IV semestre\Programacion de escritorio\Facturas-Farmmacia\{lblcliente.Text}.pdf", FileMode.Create);
                            //El tamaño del pdff
                            Document doc = new Document(PageSize.LETTER,5,5,7,7);
                            //Cree el pdf con los parametros ya mencionados
                            PdfWriter pf = PdfWriter.GetInstance(doc, fac);
                            //abrimos para trabjar en este documento
                            doc.Open();

                            //Agregar el titulo y el aautor
                            doc.AddTitle("Factura de venta"); doc.AddAuthor("Farmacias Praga");
                            //definir la fuente 
                            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                            //encabezado del documento
                            doc.Add(new Paragraph("Factura"));
                            doc.Add(Chunk.NEWLINE);

                            //Encabezado de columnas
                            PdfPTable tablas = new PdfPTable(4);
                            tablas.WidthPercentage = 70;
                            //defginir el orden de las coliumnas
                            PdfPCell pro = new PdfPCell(new Phrase ("Producto", standarFont));
                            pro.BorderWidth = 0;
                            pro.BorderWidthBottom = 0.75f;

                            PdfPCell prec = new PdfPCell(new Phrase("Precio", standarFont));
                            prec.BorderWidth = 0;
                            prec.BorderWidthBottom = 0.75f;

                            PdfPCell can = new PdfPCell(new Phrase("Cantidad", standarFont));
                            can.BorderWidth = 0;
                            can.BorderWidthBottom = 0.75f;

                            PdfPCell sub = new PdfPCell(new Phrase("Subtotal", standarFont));
                            sub.BorderWidth = 0;
                            sub.BorderWidthBottom = 0.75f;

                            //agregar a la tabla

                            tablas.AddCell(pro);
                            tablas.AddCell(prec);
                            tablas.AddCell(can);
                            tablas.AddCell(sub);

                           // Agregar a la factura
                            foreach (var productos in listaPP)
                            {
                                pro = new PdfPCell(new Phrase(productos.productos, standarFont));
                                pro.BorderWidth = 0;

                                prec = new PdfPCell(new Phrase(productos.precio.ToString(), standarFont));
                                prec.BorderWidth = 0;

                                can = new PdfPCell(new Phrase(productos.cantidad.ToString(), standarFont));
                                can.BorderWidth = 0;

                                sub = new PdfPCell(new Phrase(productos.subtotal.ToString(), standarFont));
                                sub.BorderWidth = 0;

                                tablas.AddCell(pro);
                                tablas.AddCell(prec);
                                tablas.AddCell(can);
                                tablas.AddCell(sub);
                            }

                            doc.Add(tablas); 

                            doc.Close();
                            pf.Close();

                            MessageBox.Show("Pago completo, factura generada!","EXITO!" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            completo?.Invoke(false);
                            facturacionE = false;
                            this.Close();
                        }
                    }
                    else
                    {
                        faltante = total - totalrecibido;
                        MessageBox.Show("Falta "+faltante+" en efectivo para cokmpletar el pago", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Rellene algun campo en efectivo por favor.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtnumerotarjeta.Text) && !string.IsNullOrEmpty(txtfecha.Text) && !string.IsNullOrEmpty(txtccv.Text) && !string.IsNullOrEmpty(txtnombretarjet.Text))
                {
                    DialogResult dr = MessageBox.Show("Quieres imprimir una factura?", "Imprimir Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        completo?.Invoke(false);
                        facturacionE = false;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Rellene los campos de tarjeta para continuar con el pago.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        ErrorProvider er = new ErrorProvider();
        private void txtnumerotarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool val = Validaciones.solonumeros(e);
            if (!val)
            {
                er.SetError(txtnumerotarjeta, "Solo se permiten numeros.");
            }
            else
            {
                er.Clear();
            }
        }

        private void txtccv_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool val = Validaciones.solonumeros(e);
            if (!val)
            {
                er.SetError(txtccv, "Solo se permiten numeros.");
            }
            else
            {
                er.Clear();
            }
        }

        private void txtnombretarjet_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool val = Validaciones.sololetras(e);
            if (!val)
            {
                er.SetError(txtnumerotarjeta, "Solo se permiten letras.");
            }
            else
            {
                er.Clear();
            }
        }

        private void txtcoordobas_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool val = Validaciones.solonumeros(e);
            if (!val)
            {
                er.SetError(txtcoordobas, "Solo se permiten numeros.");
            }
            else
            {
                er.Clear();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtcoordobas_TextChanged(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(txtcoordobas.Text))
            {
                total = Convert.ToDouble(LBLtotalpagar.Text);
                dolares = Convert.ToDouble(txtdolares.Text);
                coordobas = Convert.ToDouble(txtcoordobas.Text);
                cambioDolar = Convert.ToDouble(dolares * 36.60);
                lblcambiodolar.Text = cambioDolar.ToString("N2");
                totalrecibido = (cambioDolar + coordobas);
                LBrecibido.Text = totalrecibido.ToString("N2");
                if (totalrecibido >= total)
                {
                    cambio = (totalrecibido - total);
                    LBcambio.Text = cambio.ToString("N2");
                }
                LBcambio.Text = cambio.ToString("N2");
            }
            else
            {
                LBrecibido.Text = cambioDolar.ToString("N2");
                if (totalrecibido >= total)
                {
                    cambio = (totalrecibido - total);
                    LBcambio.Text = cambio.ToString("N2");
                }
                else
                {
                    LBcambio.Text = "0.00";
                }
            }
              
        }

        private void txtdolares_TextChanged(object sender, EventArgs e)
        {
          
            if (!string.IsNullOrEmpty(txtdolares.Text))
            {
                total = Convert.ToDouble(LBLtotalpagar.Text);
                dolares = Convert.ToDouble(txtdolares.Text);
                coordobas = Convert.ToDouble(txtcoordobas.Text);
                cambioDolar = Convert.ToDouble(dolares * 36.60);
                lblcambiodolar.Text = cambioDolar.ToString("N2");
                totalrecibido = (cambioDolar + coordobas);
                LBrecibido.Text = totalrecibido.ToString("N2");
                if (totalrecibido >= total)
                {
                    cambio = (totalrecibido - total);
                    LBcambio.Text = cambio.ToString("N2");
                }
               
            }
            else
            {
                lblcambiodolar.Text = "0.00";
                LBrecibido.Text = coordobas.ToString("N2");
                if (totalrecibido >= total)
                {
                    cambio = (totalrecibido - total);
                    LBcambio.Text = cambio.ToString("N2");
                }
                else
                {
                    LBcambio.Text = "0.00";
                }
              
            }
        }

        private void txtcoordobas_Enter(object sender, EventArgs e)
        {
            if (txtcoordobas.Text == "0.00")
            {
                txtcoordobas.Text = "";
            }
        }

        private void txtcoordobas_Leave(object sender, EventArgs e)
        {
            if(txtcoordobas.Text == "")
            {
                txtcoordobas.Text = "0.00";
            }
            else
            {
                if (decimal.TryParse(txtcoordobas.Text, out decimal valor))
                {
                    txtcoordobas.Text = valor.ToString("N2");
                }
                else
                {
                    txtcoordobas.Text = "0.00";
                }
            }
        }

        private void txtdolares_Leave(object sender, EventArgs e)
        {
            if (txtdolares.Text == "")
            {
                txtdolares.Text = "0.00";
            }
            else
            {
                if (decimal.TryParse(txtdolares.Text, out decimal valor))
                {
                    txtdolares.Text = valor.ToString("N2");
                }
                else
                {
                    txtdolares.Text = "0.00";
                }
            }
        }

        private void txtdolares_Enter(object sender, EventArgs e)
        {
            if (txtdolares.Text == "0.00")
            {
                txtdolares.Text = "";
            }
        }

        private void txtdolares_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool val = Validaciones.solonumeros(e);
            if (!val)
            {
                er.SetError(txtdolares, "Solo se permiten numeros.");
            }
            else
            {
                er.Clear();
            }
        }
    }
}
