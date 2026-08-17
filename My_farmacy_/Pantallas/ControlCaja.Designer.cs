namespace My_farmacy_.Pantallas
{
    partial class ControlCaja
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFechaF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuarui = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtcategorias = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.pcicon = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelinformacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtcategorias)).BeginInit();
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
            this.panelinformacion.Size = new System.Drawing.Size(1182, 61);
            this.panelinformacion.TabIndex = 6;
            // 
            // lblnombrepantalla
            // 
            this.lblnombrepantalla.AutoSize = true;
            this.lblnombrepantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrepantalla.Location = new System.Drawing.Point(98, 12);
            this.lblnombrepantalla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombrepantalla.Name = "lblnombrepantalla";
            this.lblnombrepantalla.Size = new System.Drawing.Size(291, 32);
            this.lblnombrepantalla.TabIndex = 1;
            this.lblnombrepantalla.Text = "CONTROL DE CAJA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.txtFechaF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbTurno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblusuarui);
            this.panel1.Controls.Add(this.txtfecha);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(21, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 225);
            this.panel1.TabIndex = 7;
            // 
            // txtFechaF
            // 
            this.txtFechaF.BackColor = System.Drawing.Color.Silver;
            this.txtFechaF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaF.Location = new System.Drawing.Point(360, 60);
            this.txtFechaF.Name = "txtFechaF";
            this.txtFechaF.Size = new System.Drawing.Size(136, 24);
            this.txtFechaF.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha:";
            // 
            // cbTurno
            // 
            this.cbTurno.BackColor = System.Drawing.Color.Silver;
            this.cbTurno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbTurno.Location = new System.Drawing.Point(693, 58);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(281, 26);
            this.cbTurno.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Concepto:";
            // 
            // lblusuarui
            // 
            this.lblusuarui.AutoSize = true;
            this.lblusuarui.Location = new System.Drawing.Point(41, 27);
            this.lblusuarui.Name = "lblusuarui";
            this.lblusuarui.Size = new System.Drawing.Size(64, 18);
            this.lblusuarui.TabIndex = 9;
            this.lblusuarui.Text = "Fecha :";
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.Silver;
            this.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfecha.Location = new System.Drawing.Point(13, 60);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(139, 24);
            this.txtfecha.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dtcategorias);
            this.panel3.Location = new System.Drawing.Point(21, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1138, 329);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 282);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1138, 47);
            this.panel4.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 33);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "EGRESOS:";
            // 
            // dtcategorias
            // 
            this.dtcategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtcategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtcategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.dtcategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtcategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtcategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(156)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtcategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtcategorias.ColumnHeadersHeight = 30;
            this.dtcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtcategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column2});
            this.dtcategorias.EnableHeadersVisualStyles = false;
            this.dtcategorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            this.dtcategorias.Location = new System.Drawing.Point(30, 45);
            this.dtcategorias.Margin = new System.Windows.Forms.Padding(30);
            this.dtcategorias.Name = "dtcategorias";
            this.dtcategorias.ReadOnly = true;
            this.dtcategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtcategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtcategorias.RowHeadersVisible = false;
            this.dtcategorias.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtcategorias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtcategorias.RowTemplate.Height = 24;
            this.dtcategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtcategorias.Size = new System.Drawing.Size(1079, 218);
            this.dtcategorias.TabIndex = 6;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnagregar.BackgroundImage = global::My_farmacy_.Properties.Resources.agregarbtn;
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(676, 172);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(128, 33);
            this.btnagregar.TabIndex = 29;
            this.btnagregar.UseVisualStyleBackColor = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnbuscar.BackgroundImage = global::My_farmacy_.Properties.Resources.btnbuscar;
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(196, 172);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(128, 33);
            this.btnbuscar.TabIndex = 31;
            this.btnbuscar.UseVisualStyleBackColor = false;
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
            // Column1
            // 
            this.Column1.HeaderText = "N de Egreso";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Concepto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hora";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Usuario";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Monto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ControlCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 710);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelinformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlCaja";
            this.Text = "ControlCaja";
            this.panelinformacion.ResumeLayout(false);
            this.panelinformacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtcategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelinformacion;
        private System.Windows.Forms.PictureBox pcicon;
        private System.Windows.Forms.Label lblnombrepantalla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFechaF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuarui;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtcategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}