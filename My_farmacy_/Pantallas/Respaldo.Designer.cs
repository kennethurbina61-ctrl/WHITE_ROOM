namespace My_farmacy_.Pantallas
{
    partial class Respaldo
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
            this.lblnombrepantalla = new System.Windows.Forms.Label();
            this.pcpantalla = new System.Windows.Forms.PictureBox();
            this.Crearrespaldo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btncrear = new System.Windows.Forms.Button();
            this.pnlrestaurar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnselecionar = new System.Windows.Forms.Button();
            this.pnlrestauraarBD = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnver = new System.Windows.Forms.Button();
            this.panelinformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcpantalla)).BeginInit();
            this.Crearrespaldo.SuspendLayout();
            this.pnlrestaurar.SuspendLayout();
            this.pnlrestauraarBD.SuspendLayout();
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
            this.panelinformacion.Size = new System.Drawing.Size(1061, 66);
            this.panelinformacion.TabIndex = 3;
            // 
            // lblnombrepantalla
            // 
            this.lblnombrepantalla.AutoSize = true;
            this.lblnombrepantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrepantalla.Location = new System.Drawing.Point(95, 18);
            this.lblnombrepantalla.Name = "lblnombrepantalla";
            this.lblnombrepantalla.Size = new System.Drawing.Size(143, 32);
            this.lblnombrepantalla.TabIndex = 1;
            this.lblnombrepantalla.Text = "Respaldo";
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
            // Crearrespaldo
            // 
            this.Crearrespaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crearrespaldo.Controls.Add(this.label1);
            this.Crearrespaldo.Controls.Add(this.btncrear);
            this.Crearrespaldo.Location = new System.Drawing.Point(46, 106);
            this.Crearrespaldo.Name = "Crearrespaldo";
            this.Crearrespaldo.Size = new System.Drawing.Size(255, 432);
            this.Crearrespaldo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generar una copia de seguridad\r\npara proteger su información.\r\n";
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(20, 353);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(182, 41);
            this.btncrear.TabIndex = 2;
            this.btncrear.Text = "Crear Respaldo";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // pnlrestaurar
            // 
            this.pnlrestaurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlrestaurar.Controls.Add(this.label2);
            this.pnlrestaurar.Controls.Add(this.btnselecionar);
            this.pnlrestaurar.Location = new System.Drawing.Point(418, 106);
            this.pnlrestaurar.Name = "pnlrestaurar";
            this.pnlrestaurar.Size = new System.Drawing.Size(255, 432);
            this.pnlrestaurar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Restaurar la base de datos \r\nseleccionando un archivo de\r\n respaldo desde su equi" +
    "po.\r\n";
            // 
            // btnselecionar
            // 
            this.btnselecionar.Location = new System.Drawing.Point(24, 353);
            this.btnselecionar.Name = "btnselecionar";
            this.btnselecionar.Size = new System.Drawing.Size(182, 41);
            this.btnselecionar.TabIndex = 0;
            this.btnselecionar.Text = "Seleccionar archivo";
            this.btnselecionar.UseVisualStyleBackColor = true;
            // 
            // pnlrestauraarBD
            // 
            this.pnlrestauraarBD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlrestauraarBD.Controls.Add(this.label3);
            this.pnlrestauraarBD.Controls.Add(this.btnver);
            this.pnlrestauraarBD.Location = new System.Drawing.Point(754, 106);
            this.pnlrestauraarBD.Name = "pnlrestauraarBD";
            this.pnlrestauraarBD.Size = new System.Drawing.Size(255, 432);
            this.pnlrestauraarBD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Restaurar la base de datos\r\n utilizando uno de los respaldos\r\n existentes en el s" +
    "istema.";
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(24, 353);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(182, 41);
            this.btnver.TabIndex = 1;
            this.btnver.Text = "Ver respaldos";
            this.btnver.UseVisualStyleBackColor = true;
            // 
            // Respaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 634);
            this.Controls.Add(this.pnlrestauraarBD);
            this.Controls.Add(this.pnlrestaurar);
            this.Controls.Add(this.Crearrespaldo);
            this.Controls.Add(this.panelinformacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Respaldo";
            this.Text = "Respaldo";
            this.panelinformacion.ResumeLayout(false);
            this.panelinformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcpantalla)).EndInit();
            this.Crearrespaldo.ResumeLayout(false);
            this.Crearrespaldo.PerformLayout();
            this.pnlrestaurar.ResumeLayout(false);
            this.pnlrestaurar.PerformLayout();
            this.pnlrestauraarBD.ResumeLayout(false);
            this.pnlrestauraarBD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelinformacion;
        private System.Windows.Forms.Label lblnombrepantalla;
        private System.Windows.Forms.PictureBox pcpantalla;
        private System.Windows.Forms.Panel Crearrespaldo;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Panel pnlrestaurar;
        private System.Windows.Forms.Button btnselecionar;
        private System.Windows.Forms.Panel pnlrestauraarBD;
        private System.Windows.Forms.Button btnver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}