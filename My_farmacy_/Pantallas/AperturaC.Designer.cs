namespace My_farmacy_.Pantallas
{
    partial class AperturaC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lbldatos = new System.Windows.Forms.Label();
            this.lblusuarui = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudInicial = new System.Windows.Forms.NumericUpDown();
            this.nudDolar = new System.Windows.Forms.NumericUpDown();
            this.panelinformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcicon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDolar)).BeginInit();
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
            this.panelinformacion.Size = new System.Drawing.Size(1174, 61);
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
            this.lblnombrepantalla.Size = new System.Drawing.Size(308, 32);
            this.lblnombrepantalla.TabIndex = 1;
            this.lblnombrepantalla.Text = "APERTURA DE CAJA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtHora);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbTurno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtdireccion);
            this.panel1.Controls.Add(this.lbldatos);
            this.panel1.Controls.Add(this.lblusuarui);
            this.panel1.Controls.Add(this.txtfecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 180);
            this.panel1.TabIndex = 6;
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.Silver;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHora.Location = new System.Drawing.Point(308, 117);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(136, 24);
            this.txtHora.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Hora:";
            // 
            // cbTurno
            // 
            this.cbTurno.BackColor = System.Drawing.Color.Silver;
            this.cbTurno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbTurno.Location = new System.Drawing.Point(919, 116);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(131, 26);
            this.cbTurno.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(950, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Turno:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.Silver;
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdireccion.Location = new System.Drawing.Point(548, 117);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(257, 24);
            this.txtdireccion.TabIndex = 13;
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatos.ForeColor = System.Drawing.Color.Blue;
            this.lbldatos.Location = new System.Drawing.Point(8, 12);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(206, 25);
            this.lbldatos.TabIndex = 10;
            this.lbldatos.Text = "Información General";
            // 
            // lblusuarui
            // 
            this.lblusuarui.AutoSize = true;
            this.lblusuarui.Location = new System.Drawing.Point(32, 83);
            this.lblusuarui.Name = "lblusuarui";
            this.lblusuarui.Size = new System.Drawing.Size(167, 18);
            this.lblusuarui.TabIndex = 9;
            this.lblusuarui.Text = "Fecha de la apertura:";
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.Silver;
            this.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfecha.Location = new System.Drawing.Point(42, 117);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(139, 24);
            this.txtfecha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.nudDolar);
            this.panel2.Controls.Add(this.nudInicial);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(12, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 180);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingerese cambio de Dólar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Datos Iniciales de caja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ingrese efectivo inicial";
            // 
            // nudInicial
            // 
            this.nudInicial.Location = new System.Drawing.Point(61, 118);
            this.nudInicial.Name = "nudInicial";
            this.nudInicial.Size = new System.Drawing.Size(120, 24);
            this.nudInicial.TabIndex = 29;
            // 
            // nudDolar
            // 
            this.nudDolar.Location = new System.Drawing.Point(492, 118);
            this.nudDolar.Name = "nudDolar";
            this.nudDolar.Size = new System.Drawing.Size(120, 24);
            this.nudDolar.TabIndex = 30;
            // 
            // AperturaC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 548);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelinformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AperturaC";
            this.Text = "AperturaC";
            this.panelinformacion.ResumeLayout(false);
            this.panelinformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcicon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDolar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelinformacion;
        private System.Windows.Forms.PictureBox pcicon;
        private System.Windows.Forms.Label lblnombrepantalla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lbldatos;
        private System.Windows.Forms.Label lblusuarui;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudDolar;
        private System.Windows.Forms.NumericUpDown nudInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}