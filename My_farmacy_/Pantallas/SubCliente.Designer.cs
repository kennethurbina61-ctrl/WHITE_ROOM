namespace My_farmacy_.Pantallas
{
    partial class SubCliente
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
            this.panelinformacion = new System.Windows.Forms.Panel();
            this.pcicon = new System.Windows.Forms.PictureBox();
            this.lblnombrepantalla = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lbldatos = new System.Windows.Forms.Label();
            this.lblusuarui = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.panelinformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcicon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelinformacion
            // 
            this.panelinformacion.BackColor = System.Drawing.SystemColors.Control;
            this.panelinformacion.Controls.Add(this.pcicon);
            this.panelinformacion.Controls.Add(this.lblnombrepantalla);
            this.panelinformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelinformacion.Location = new System.Drawing.Point(0, 0);
            this.panelinformacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelinformacion.Name = "panelinformacion";
            this.panelinformacion.Size = new System.Drawing.Size(689, 63);
            this.panelinformacion.TabIndex = 5;
            // 
            // pcicon
            // 
            this.pcicon.BackgroundImage = global::My_farmacy_.Properties.Resources.icono_clientes;
            this.pcicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcicon.Location = new System.Drawing.Point(12, 6);
            this.pcicon.Name = "pcicon";
            this.pcicon.Size = new System.Drawing.Size(76, 46);
            this.pcicon.TabIndex = 4;
            this.pcicon.TabStop = false;
            // 
            // lblnombrepantalla
            // 
            this.lblnombrepantalla.AutoSize = true;
            this.lblnombrepantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrepantalla.Location = new System.Drawing.Point(98, 12);
            this.lblnombrepantalla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombrepantalla.Name = "lblnombrepantalla";
            this.lblnombrepantalla.Size = new System.Drawing.Size(126, 32);
            this.lblnombrepantalla.TabIndex = 1;
            this.lblnombrepantalla.Text = "Clientes";
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.Silver;
            this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttelefono.Location = new System.Drawing.Point(429, 163);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(128, 24);
            this.txttelefono.TabIndex = 41;
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.Silver;
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcorreo.Location = new System.Drawing.Point(44, 276);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(257, 24);
            this.txtcorreo.TabIndex = 40;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnagregar.BackgroundImage = global::My_farmacy_.Properties.Resources.agregarbtn;
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(497, 360);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(128, 33);
            this.btnagregar.TabIndex = 37;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Correo:";
            // 
            // cbestado
            // 
            this.cbestado.BackColor = System.Drawing.Color.Silver;
            this.cbestado.Enabled = false;
            this.cbestado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbestado.Location = new System.Drawing.Point(44, 364);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(103, 26);
            this.cbestado.TabIndex = 36;
            this.cbestado.Text = "Activo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Estado:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.Silver;
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdireccion.Location = new System.Drawing.Point(423, 276);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(177, 24);
            this.txtdireccion.TabIndex = 34;
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatos.ForeColor = System.Drawing.Color.Blue;
            this.lbldatos.Location = new System.Drawing.Point(12, 81);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(177, 25);
            this.lbldatos.TabIndex = 32;
            this.lbldatos.Text = "Datos del Cliente";
            // 
            // lblusuarui
            // 
            this.lblusuarui.AutoSize = true;
            this.lblusuarui.Location = new System.Drawing.Point(41, 132);
            this.lblusuarui.Name = "lblusuarui";
            this.lblusuarui.Size = new System.Drawing.Size(73, 18);
            this.lblusuarui.TabIndex = 31;
            this.lblusuarui.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.Silver;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.Location = new System.Drawing.Point(44, 163);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(257, 24);
            this.txtnombre.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Dirección:";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncancelar.BackgroundImage = global::My_farmacy_.Properties.Resources.btncancelar;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(320, 360);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(128, 33);
            this.btncancelar.TabIndex = 42;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // SubCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 426);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.lblusuarui);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelinformacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SubCliente";
            this.Text = "SubCliente";
            this.panelinformacion.ResumeLayout(false);
            this.panelinformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelinformacion;
        private System.Windows.Forms.PictureBox pcicon;
        private System.Windows.Forms.Label lblnombrepantalla;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lbldatos;
        private System.Windows.Forms.Label lblusuarui;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelar;
    }
}