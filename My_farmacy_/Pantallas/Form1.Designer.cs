namespace My_farmacy_
{
    partial class loging
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
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.panellogear = new System.Windows.Forms.Panel();
            this.linkrecuperar = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pccontrasena = new System.Windows.Forms.PictureBox();
            this.pcusuario = new System.Windows.Forms.PictureBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.panellogo = new System.Windows.Forms.Panel();
            this.logoimg = new System.Windows.Forms.PictureBox();
            this.labelacerca = new System.Windows.Forms.Label();
            this.lblservicios = new System.Windows.Forms.Label();
            this.lblayuda = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.panelcontenedor.SuspendLayout();
            this.panellogear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pccontrasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcusuario)).BeginInit();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelcontenedor.Controls.Add(this.panellogear);
            this.panelcontenedor.Controls.Add(this.panellogo);
            this.panelcontenedor.Location = new System.Drawing.Point(165, 90);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(406, 538);
            this.panelcontenedor.TabIndex = 0;
            // 
            // panellogear
            // 
            this.panellogear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.panellogear.Controls.Add(this.linkrecuperar);
            this.panellogear.Controls.Add(this.button1);
            this.panellogear.Controls.Add(this.txtcontrasena);
            this.panellogear.Controls.Add(this.label2);
            this.panellogear.Controls.Add(this.label3);
            this.panellogear.Controls.Add(this.txtusuario);
            this.panellogear.Controls.Add(this.label1);
            this.panellogear.Controls.Add(this.pccontrasena);
            this.panellogear.Controls.Add(this.pcusuario);
            this.panellogear.Controls.Add(this.Usuario);
            this.panellogear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panellogear.Location = new System.Drawing.Point(0, 152);
            this.panellogear.Name = "panellogear";
            this.panellogear.Size = new System.Drawing.Size(406, 386);
            this.panellogear.TabIndex = 2;
            this.panellogear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panellogear_MouseDown);
            // 
            // linkrecuperar
            // 
            this.linkrecuperar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkrecuperar.AutoSize = true;
            this.linkrecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.linkrecuperar.LinkColor = System.Drawing.Color.Black;
            this.linkrecuperar.Location = new System.Drawing.Point(118, 332);
            this.linkrecuperar.Name = "linkrecuperar";
            this.linkrecuperar.Size = new System.Drawing.Size(160, 16);
            this.linkrecuperar.TabIndex = 0;
            this.linkrecuperar.TabStop = true;
            this.linkrecuperar.Text = "¿No puedes ingresar?";
            this.linkrecuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkrecuperar_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(99, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontrasena.ForeColor = System.Drawing.Color.Black;
            this.txtcontrasena.Location = new System.Drawing.Point(111, 200);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(183, 15);
            this.txtcontrasena.TabIndex = 2;
            this.txtcontrasena.Text = "Ingrese su contraseña";
            this.txtcontrasena.Enter += new System.EventHandler(this.txtcontrasena_Enter);
            this.txtcontrasena.Leave += new System.EventHandler(this.txtcontrasena_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(107, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "___________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(107, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña";
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.Black;
            this.txtusuario.Location = new System.Drawing.Point(111, 84);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(183, 15);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.Text = "Ingrese su usuario";
            this.txtusuario.Enter += new System.EventHandler(this.txtusuario_Enter);
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "___________________";
            // 
            // pccontrasena
            // 
            this.pccontrasena.BackColor = System.Drawing.Color.Transparent;
            this.pccontrasena.BackgroundImage = global::My_farmacy_.Properties.Resources.Contrsaena;
            this.pccontrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pccontrasena.Location = new System.Drawing.Point(41, 164);
            this.pccontrasena.Name = "pccontrasena";
            this.pccontrasena.Size = new System.Drawing.Size(49, 59);
            this.pccontrasena.TabIndex = 7;
            this.pccontrasena.TabStop = false;
            // 
            // pcusuario
            // 
            this.pcusuario.BackColor = System.Drawing.Color.Transparent;
            this.pcusuario.BackgroundImage = global::My_farmacy_.Properties.Resources.Usuario;
            this.pcusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcusuario.Location = new System.Drawing.Point(41, 48);
            this.pcusuario.Name = "pcusuario";
            this.pcusuario.Size = new System.Drawing.Size(49, 61);
            this.pcusuario.TabIndex = 6;
            this.pcusuario.TabStop = false;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Usuario.ForeColor = System.Drawing.Color.Black;
            this.Usuario.Location = new System.Drawing.Point(107, 48);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(74, 20);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panellogo.BackgroundImage = global::My_farmacy_.Properties.Resources._1a080ddb_833b_4de6_a188_08a823057cce;
            this.panellogo.Controls.Add(this.logoimg);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(406, 152);
            this.panellogo.TabIndex = 1;
            this.panellogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panellogo_MouseDown);
            // 
            // logoimg
            // 
            this.logoimg.BackColor = System.Drawing.Color.Transparent;
            this.logoimg.BackgroundImage = global::My_farmacy_.Properties.Resources.ChatGPT_Image_3_ago_2026__16_06_46;
            this.logoimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoimg.Location = new System.Drawing.Point(121, 29);
            this.logoimg.Name = "logoimg";
            this.logoimg.Size = new System.Drawing.Size(183, 91);
            this.logoimg.TabIndex = 0;
            this.logoimg.TabStop = false;
            // 
            // labelacerca
            // 
            this.labelacerca.AutoSize = true;
            this.labelacerca.BackColor = System.Drawing.Color.Transparent;
            this.labelacerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelacerca.ForeColor = System.Drawing.Color.Black;
            this.labelacerca.Location = new System.Drawing.Point(12, 9);
            this.labelacerca.Name = "labelacerca";
            this.labelacerca.Size = new System.Drawing.Size(78, 16);
            this.labelacerca.TabIndex = 1;
            this.labelacerca.Text = "Acerca de";
            // 
            // lblservicios
            // 
            this.lblservicios.AutoSize = true;
            this.lblservicios.BackColor = System.Drawing.Color.Transparent;
            this.lblservicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblservicios.ForeColor = System.Drawing.Color.Black;
            this.lblservicios.Location = new System.Drawing.Point(124, 9);
            this.lblservicios.Name = "lblservicios";
            this.lblservicios.Size = new System.Drawing.Size(72, 16);
            this.lblservicios.TabIndex = 2;
            this.lblservicios.Text = "Servicios";
            // 
            // lblayuda
            // 
            this.lblayuda.AutoSize = true;
            this.lblayuda.BackColor = System.Drawing.Color.Transparent;
            this.lblayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblayuda.ForeColor = System.Drawing.Color.Black;
            this.lblayuda.Location = new System.Drawing.Point(238, 9);
            this.lblayuda.Name = "lblayuda";
            this.lblayuda.Size = new System.Drawing.Size(51, 16);
            this.lblayuda.TabIndex = 3;
            this.lblayuda.Text = "Ayuda";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BackgroundImage = global::My_farmacy_.Properties.Resources.Exit;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Location = new System.Drawing.Point(709, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(49, 39);
            this.btnexit.TabIndex = 4;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnminimizar.BackgroundImage = global::My_farmacy_.Properties.Resources.Minimizar;
            this.btnminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnminimizar.Location = new System.Drawing.Point(634, 12);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(49, 39);
            this.btnminimizar.TabIndex = 5;
            this.btnminimizar.TabStop = false;
            // 
            // loging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::My_farmacy_.Properties.Resources.fondopng;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 692);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblayuda);
            this.Controls.Add(this.lblservicios);
            this.Controls.Add(this.labelacerca);
            this.Controls.Add(this.panelcontenedor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loging_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loging_MouseDown);
            this.panelcontenedor.ResumeLayout(false);
            this.panellogear.ResumeLayout(false);
            this.panellogear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pccontrasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcusuario)).EndInit();
            this.panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Panel panellogear;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.PictureBox logoimg;
        private System.Windows.Forms.Label labelacerca;
        private System.Windows.Forms.Label lblservicios;
        private System.Windows.Forms.Label lblayuda;
        private System.Windows.Forms.PictureBox btnexit;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox pcusuario;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.PictureBox pccontrasena;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkrecuperar;
    }
}

