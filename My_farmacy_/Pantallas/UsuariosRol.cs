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
using Npgsql.Internal;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace My_farmacy_
{
    public partial class UsuariosRol : Form
    {
        ClasesSQL.LoginSQL ll = new ClasesSQL.LoginSQL();
       // string conexx = "Server=localhost;Port=5432;User Id=postgres;Password=DIOS TE AMA2.0;Database=MyFarmacy;";
        public UsuariosRol()
        {
            InitializeComponent();
        }
        

        private void UsuariosRol_Load(object sender, EventArgs e)
        {
            tlusuario.SetToolTip(txtusuarioagg, "El usuario con el que el empleado entrara al sistema.");
            llenar();
            llenarroles();
        }
        private void llenarroles()
        {
            NpgsqlConnection cn = ll.conexion();
            NpgsqlCommand cf = new NpgsqlCommand("select idrol, nombre, descripcion, estado from rol", cn);
            NpgsqlDataReader rt = cf.ExecuteReader();
            dataroles.Rows.Clear();
            while (rt.Read())
            {
                bool re = Convert.ToBoolean(rt[3]);
                string rol = Convert.ToString(re);
                if (re == true)
                {
                  
                    rol = "Activo";
                }
                else
                {                    
                    rol = "Inactivo";
                }
                    dataroles.Rows.Add(rt[0], rt[1], rol, rt[2]);
            }
            cn.Close();
            cn.Open();
            NpgsqlCommand rrl = new NpgsqlCommand("select nombre from rol", cn);
            
            NpgsqlDataReader dr = rrl.ExecuteReader();
            cbrol.Items.Clear();
            while (dr.Read())
            {
                cbrol.Items.Add(dr[0]);
            }
            cn.Close();
        }
        private void llenar()
        {
            btnmodificar.Visible = false;
            btncancelar.Visible = false;    
            NpgsqlConnection conn = ll.conexion();
            NpgsqlCommand dtu = new NpgsqlCommand("Select u.idusuario, r.nombre as rol, u.usuario, u.nombrecompleto, u.telefeno, u.correo, u.cedula, u.estado from usuario u join rol r on u.idrol = r.idrol", conn);
            NpgsqlDataReader dtru = dtu.ExecuteReader();
            dtusers.Rows.Clear();
            
            while (dtru.Read())
            {
                bool sta = Convert.ToBoolean(dtru[7]);
                string estadoU = Convert.ToString(sta);
                if (sta == true)
                {
                    estadoU = "Activo";
                }
                else
                {
                    estadoU = "Inactivo";
                }
                    dtusers.Rows.Add(dtru[0], dtru[2], dtru[3], dtru[2], dtru[4], dtru[6], dtru[5], estadoU);
            }
            dtru.Close();
            conn.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (camposvr())
            {
                string nombre = txtnombredelrol.Text;
                bool estado;
                if (cbestadoR.Text == "Activo")
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                string descriocion = txtdescripcionrol.Text;

                NpgsqlConnection cxn = ll.conexion();
                NpgsqlCommand ins = new NpgsqlCommand("Insert into rol (nombre, descripcion, estado) values ('" + nombre + "' ,'" + descriocion + "', '" + estado + "' )", cxn);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se guardo correctamente.");
                cxn.Close();
                llenarroles();
            }
            else
            {
                MessageBox.Show("No puede dejar campos vacios.");
            }
            
        }

        private void limpiar()
        {
            txtusersid.Clear();
            txtnombreU.Clear();
            txtusuarioagg.Clear();
            cbrol.Text = "";
            txttelefono.Clear();
            txtcedula.Clear();
            txtcorreo.Clear();
            cbestado.Text = "";
            txtconfirmarcontra.Clear();
            txtcontraseña.Clear();
        }
        private bool camposvr()
        {
            var vl = !string.IsNullOrEmpty(txtnombredelrol.Text) && !string.IsNullOrEmpty(txtdescripcionrol.Text) && !string.IsNullOrEmpty(cbestadoR.Text);

            if (vl)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool camposvacios()
        {
            var vl = !string.IsNullOrEmpty(txtusuarioagg.Text) && !string.IsNullOrEmpty(txtcorreo.Text) &&
                !string.IsNullOrEmpty(txtconfirmarcontra.Text) && !string.IsNullOrEmpty(txtnombreU.Text) && !string.IsNullOrEmpty(txttelefono.Text) &&
                !string.IsNullOrEmpty(cbestado.Text) && !string.IsNullOrEmpty(cbrol.Text) && !string.IsNullOrEmpty(txtcedula.Text);
            if (vl)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //tengoproblemasconlavalidacion del gmail
            if (camposvacios())
            {
                if (lblactivorol.Text == "Activo" && txtconfirmarcontra.Text == txtcontraseña.Text && txttelefono.TextLength == 8 && Validaciones.ValidarEmail(txtcorreo.Text))
                {
                    string nombrecompleto = txtnombreU.Text;
                    string cedula = txtcedula.Text;
                    string usuario = txtusuarioagg.Text;
                    string telefono = txttelefono.Text;
                    string password = txtconfirmarcontra.Text;
                    string correo = txtcorreo.Text;
                    bool estado;
                    if (cbestado.Text == "Activo")
                    {
                        estado = true;
                    }
                    else
                    {
                        estado = false;
                    }
                    string rol = cbrol.Text;

                  
                    NpgsqlConnection cn = ll.conexion();
                    NpgsqlDataAdapter rls = new NpgsqlDataAdapter("select idrol from rol where nombre= '" + rol + "'", cn);
                    DataTable dt = new DataTable();
                    rls.Fill(dt);
                    int idrol = 0;
                    if (dt.Rows.Count > 0)
                    {
                        idrol = Convert.ToInt32(dt.Rows[0]["idrol"]);
                    }
                    
                    NpgsqlCommand vd = new NpgsqlCommand("Insert into usuario (idrol, usuario, nombrecompleto, telefeno, correo, passwords, cedula, estado) values ('" + idrol+ "' , '" + usuario + "' , '" + nombrecompleto+ "' , '" + telefono + "' , '" + correo + "' , '" + password + "' , '" + cedula + "' , '" + estado + "') ", cn);
                    vd.ExecuteNonQuery();
                    MessageBox.Show("Se guardo correctamente");
                    cn.Close();

                    llenar();
                    limpiar();
                }
                else
                {
                    if (lblactivorol.Text == "Inactivo")
                    {
                        MessageBox.Show("El estado del rol no esta activo.");
                    }
                    else if(txttelefono.TextLength > 8 || txttelefono.TextLength < 8)
                    {
                        MessageBox.Show("Numero invalido");
                    }
                    else if(txtconfirmarcontra.Text != txtcontraseña.Text)
                    {
                        MessageBox.Show("La contraseña no coincide.");
                    }
                    else
                    {
                        MessageBox.Show("El gmail no coincide.");
                    }
                  
                }
              
            }
            else
            {
                MessageBox.Show("No se pueden dejar campos vacios.");
            }
           
           
        }

        private void dtusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool roli;
            NpgsqlConnection cc = ll.conexion();
            NpgsqlCommand actr = new NpgsqlCommand("select estado from rol where nombre = '" + cbrol.Text + "'", cc);
            NpgsqlDataReader tr = actr.ExecuteReader();  
        
            while (tr.Read())
            {
                roli = tr.GetBoolean(0);
                if (roli == true)
                {
                    lblactivorol.Text = "Activo";
                    lblactivorol.ForeColor = Color.Green;
                }
                else
                {
                    lblactivorol.Text = "Inactivo";
                    lblactivorol.ForeColor = Color.Red;
                }
            }
               
            cc.Close();
        }
        ErrorProvider er = new ErrorProvider();
        private void txtnombreU_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool val = Validaciones.sololetras(e);
            if (!val)
            {
                er.SetError(txtnombreU, "Solo se permiten letras.");
            }
            else
            {
                er.Clear();
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool val = Validaciones.solonumeros(e);
            if (!val)
            {
                er.SetError(txttelefono, "Solo se permiten numeros.");
            }
            else if (txttelefono.TextLength >= 8)
            { 
                er.SetError(txttelefono, "No se permiten mas de 8 digitos.");
            }
            else
            {
                er.Clear();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = ll.conexion();
            NpgsqlCommand bs = new NpgsqlCommand("Select u.idusuario, r.nombre as rol, u.usuario, u.nombrecompleto, u.telefeno, u.correo, u.cedula, u.estado from usuario u join rol r on u.idrol = r.idrol where u.usuario = '" + txtbuscar.Text + "' ",cn);
            NpgsqlDataReader nc = bs.ExecuteReader();
            dtusers.Rows.Clear();
            while (nc.Read())
            {
                string estado;
                bool es = Convert.ToBoolean(nc[6]);
                if (es == true)
                {
                    estado = "Activo";
                }
                else
                {
                    estado = "Inactivo";
                }

               
                    dtusers.Rows.Add(nc[0], nc[1], nc[2], nc[3], nc[7], nc[3], nc[5], estado);
            }
            nc.Close();

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text == "")
            {
                llenar();
            }
            else
            {
                er.SetError(txtbuscar, "Coloque un usuario.");
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtusersid.Text = dtusers.SelectedCells[0].Value.ToString();
            txtnombreU.Text = dtusers.SelectedCells[2].Value.ToString();
            txtusuarioagg.Text = dtusers.SelectedCells[1].Value.ToString();
            cbrol.Text = dtusers.SelectedCells[3].Value.ToString();
            txttelefono.Text = dtusers.SelectedCells[4].Value.ToString();
            txtcedula.Text= dtusers.SelectedCells[5].Value.ToString();
            txtcorreo.Text= dtusers.SelectedCells[6].Value.ToString();
            cbestado.Text= dtusers.SelectedCells[7].Value.ToString();
            btncancelar.Visible = true;
            btnmodificar.Visible = true;
            btnguardar.Visible = false;

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (camposvacios() && txtconfirmarcontra.Text == txtcontraseña.Text)
            {
                NpgsqlConnection cn = ll.conexion();    
                string nombrecompleto = txtnombreU.Text;
                string cedula = txtcedula.Text;
                string usuario = txtusuarioagg.Text;
                string telefono = txttelefono.Text;
                string password = txtconfirmarcontra.Text;
                string correo = txtcorreo.Text;
                bool estado;
                if (cbestado.Text == "Activo")
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                string rol = cbrol.Text;
                NpgsqlDataAdapter rls = new NpgsqlDataAdapter("select idrol from rol where nombre= '" + rol + "'", cn);
                DataTable dt = new DataTable();
                rls.Fill(dt);
                int idrol = 0;
                if (dt.Rows.Count > 0)
                {
                    idrol = Convert.ToInt32(dt.Rows[0]["idrol"]);
                }
                //, passwords, telefono, correo, cedula, estado, idrol, nombree
                NpgsqlCommand cmd = new NpgsqlCommand("update usuario set idrol= '" + idrol + "', usuario = '" + usuario + "', nombrecompleto= '" + nombrecompleto + "', telefono= '" + telefono + "' , correo= '" + correo + "' , passwords= '" + password + "', cedula= '" + cedula + "' ,estado= '" + estado + "' where idusuario= '" + txtusersid.Text + "'", cn);
                NpgsqlDataReader vb = cmd.ExecuteReader();
                MessageBox.Show("Registro modificado.");
                vb.Close();
                llenar();
                limpiar();
                btnmodificar.Visible = false;
                btncancelar.Visible = false;
                btnguardar.Visible = true;

            }
            else
            {
                MessageBox.Show("Agregue una contraseña.");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Se cancelo la modificacion.");
            btnmodificar.Visible = false;
            btncancelar.Visible = false;
            btnguardar.Visible = true;
            limpiar();
        }
    }
}
