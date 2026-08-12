namespace My_farmacy_
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelinformacion = new System.Windows.Forms.Panel();
            this.lblnombrepantalla = new System.Windows.Forms.Label();
            this.pcpantalla = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbestadoP = new System.Windows.Forms.ComboBox();
            this.lbestado = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldatos = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblusuarui = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltotalproductos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtproductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            this.panelinformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcpantalla)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelinformacion
            // 
            this.panelinformacion.BackColor = System.Drawing.SystemColors.Control;
            this.panelinformacion.Controls.Add(this.lblnombrepantalla);
            this.panelinformacion.Controls.Add(this.pcpantalla);
            this.panelinformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelinformacion.Location = new System.Drawing.Point(0, 0);
            this.panelinformacion.Name = "panelinformacion";
            this.panelinformacion.Size = new System.Drawing.Size(1162, 66);
            this.panelinformacion.TabIndex = 2;
            // 
            // lblnombrepantalla
            // 
            this.lblnombrepantalla.AutoSize = true;
            this.lblnombrepantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrepantalla.Location = new System.Drawing.Point(95, 18);
            this.lblnombrepantalla.Name = "lblnombrepantalla";
            this.lblnombrepantalla.Size = new System.Drawing.Size(151, 32);
            this.lblnombrepantalla.TabIndex = 1;
            this.lblnombrepantalla.Text = "Productos";
            // 
            // pcpantalla
            // 
            this.pcpantalla.BackgroundImage = global::My_farmacy_.Properties.Resources.Icono_productos;
            this.pcpantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcpantalla.Location = new System.Drawing.Point(12, 12);
            this.pcpantalla.Name = "pcpantalla";
            this.pcpantalla.Size = new System.Drawing.Size(66, 43);
            this.pcpantalla.TabIndex = 0;
            this.pcpantalla.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.cbcategoria);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbestadoP);
            this.panel1.Controls.Add(this.lbestado);
            this.panel1.Controls.Add(this.txtdescripcion);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbldatos);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.lblusuarui);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(8, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 209);
            this.panel1.TabIndex = 3;
            // 
            // cbcategoria
            // 
            this.cbcategoria.BackColor = System.Drawing.Color.Silver;
            this.cbcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(287, 84);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(167, 26);
            this.cbcategoria.TabIndex = 26;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btneditar.BackgroundImage = global::My_farmacy_.Properties.Resources.editarbtn;
            this.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(948, 147);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(135, 33);
            this.btneditar.TabIndex = 31;
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Categoría:";
            // 
            // cbestadoP
            // 
            this.cbestadoP.BackColor = System.Drawing.Color.Silver;
            this.cbestadoP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbestadoP.FormattingEnabled = true;
            this.cbestadoP.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbestadoP.Location = new System.Drawing.Point(532, 86);
            this.cbestadoP.Name = "cbestadoP";
            this.cbestadoP.Size = new System.Drawing.Size(112, 26);
            this.cbestadoP.TabIndex = 24;
            // 
            // lbestado
            // 
            this.lbestado.AutoSize = true;
            this.lbestado.Location = new System.Drawing.Point(529, 49);
            this.lbestado.Name = "lbestado";
            this.lbestado.Size = new System.Drawing.Size(66, 18);
            this.lbestado.TabIndex = 23;
            this.lbestado.Text = "Estado:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.Silver;
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcion.Location = new System.Drawing.Point(735, 86);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(348, 41);
            this.txtdescripcion.TabIndex = 11;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnagregar.BackgroundImage = global::My_farmacy_.Properties.Resources.agregarbtn;
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(770, 147);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(134, 33);
            this.btnagregar.TabIndex = 22;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Descripción:";
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatos.ForeColor = System.Drawing.Color.Blue;
            this.lbldatos.Location = new System.Drawing.Point(15, 11);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(68, 25);
            this.lbldatos.TabIndex = 10;
            this.lbldatos.Text = "Datos";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.Silver;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.Location = new System.Drawing.Point(32, 88);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(201, 24);
            this.txtnombre.TabIndex = 8;
            // 
            // lblusuarui
            // 
            this.lblusuarui.AutoSize = true;
            this.lblusuarui.Location = new System.Drawing.Point(29, 49);
            this.lblusuarui.Name = "lblusuarui";
            this.lblusuarui.Size = new System.Drawing.Size(73, 18);
            this.lblusuarui.TabIndex = 9;
            this.lblusuarui.Text = "Nombre:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dtproductos);
            this.panel3.Location = new System.Drawing.Point(8, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1138, 322);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lbltotalproductos);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.txtbuscar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 65);
            this.panel2.TabIndex = 7;
            // 
            // lbltotalproductos
            // 
            this.lbltotalproductos.AutoSize = true;
            this.lbltotalproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalproductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbltotalproductos.Location = new System.Drawing.Point(1049, 17);
            this.lbltotalproductos.Name = "lbltotalproductos";
            this.lbltotalproductos.Size = new System.Drawing.Size(48, 25);
            this.lbltotalproductos.TabIndex = 30;
            this.lbltotalproductos.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(817, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Productos totales:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnbuscar.BackgroundImage = global::My_farmacy_.Properties.Resources.btnbuscar;
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(548, 12);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(135, 33);
            this.btnbuscar.TabIndex = 28;
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.Silver;
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtbuscar.Location = new System.Drawing.Point(259, 20);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(219, 24);
            this.txtbuscar.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(15, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Busqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(167, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Buscar:";
            // 
            // dtproductos
            // 
            this.dtproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtproductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtproductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.dtproductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtproductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtproductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(156)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtproductos.ColumnHeadersHeight = 30;
            this.dtproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.Column6,
            this.Column2,
            this.Column5});
            this.dtproductos.EnableHeadersVisualStyles = false;
            this.dtproductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            this.dtproductos.Location = new System.Drawing.Point(32, 16);
            this.dtproductos.Margin = new System.Windows.Forms.Padding(30);
            this.dtproductos.Name = "dtproductos";
            this.dtproductos.ReadOnly = true;
            this.dtproductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtproductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtproductos.RowHeadersVisible = false;
            this.dtproductos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtproductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtproductos.RowTemplate.Height = 24;
            this.dtproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtproductos.Size = new System.Drawing.Size(1079, 233);
            this.dtproductos.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Descripción";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Categoría";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estado";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btneliminar.BackgroundImage = global::My_farmacy_.Properties.Resources.eliminar;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(583, 147);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(135, 33);
            this.btneliminar.TabIndex = 32;
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1162, 644);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelinformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panelinformacion.ResumeLayout(false);
            this.panelinformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcpantalla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtproductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelinformacion;
        private System.Windows.Forms.Label lblnombrepantalla;
        private System.Windows.Forms.PictureBox pcpantalla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbestadoP;
        private System.Windows.Forms.Label lbestado;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldatos;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblusuarui;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtproductos;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Label lbltotalproductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btneliminar;
    }
}