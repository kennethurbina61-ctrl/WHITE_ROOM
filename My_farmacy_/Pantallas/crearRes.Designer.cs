namespace My_farmacy_.Pantallas
{
    partial class crearRes
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
            this.tabla = new System.Windows.Forms.DataGridView();
            this.txtnombreresapaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtreceptor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnrestaurar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla
            // 
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(156)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.ColumnHeadersHeight = 30;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            this.tabla.Location = new System.Drawing.Point(30, 304);
            this.tabla.Margin = new System.Windows.Forms.Padding(30);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.RowHeadersVisible = false;
            this.tabla.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.tabla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tabla.RowTemplate.Height = 24;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(724, 147);
            this.tabla.TabIndex = 47;
            // 
            // txtnombreresapaldo
            // 
            this.txtnombreresapaldo.BackColor = System.Drawing.Color.Silver;
            this.txtnombreresapaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombreresapaldo.Location = new System.Drawing.Point(213, 75);
            this.txtnombreresapaldo.Name = "txtnombreresapaldo";
            this.txtnombreresapaldo.Size = new System.Drawing.Size(514, 24);
            this.txtnombreresapaldo.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre respaldo:";
            // 
            // txtreceptor
            // 
            this.txtreceptor.BackColor = System.Drawing.Color.Silver;
            this.txtreceptor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtreceptor.Location = new System.Drawing.Point(240, 147);
            this.txtreceptor.Name = "txtreceptor";
            this.txtreceptor.Size = new System.Drawing.Size(514, 24);
            this.txtreceptor.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Receptor de Respaldo:";
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnrestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnrestaurar.ForeColor = System.Drawing.Color.White;
            this.btnrestaurar.Location = new System.Drawing.Point(577, 238);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(128, 33);
            this.btnrestaurar.TabIndex = 52;
            this.btnrestaurar.Text = "Restaurar";
            this.btnrestaurar.UseVisualStyleBackColor = false;
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btncrear.ForeColor = System.Drawing.Color.White;
            this.btncrear.Location = new System.Drawing.Point(372, 238);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(128, 33);
            this.btncrear.TabIndex = 53;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnseleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnseleccionar.ForeColor = System.Drawing.Color.White;
            this.btnseleccionar.Location = new System.Drawing.Point(130, 238);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(128, 33);
            this.btnseleccionar.TabIndex = 54;
            this.btnseleccionar.Text = "Seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = false;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // crearRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 506);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnrestaurar);
            this.Controls.Add(this.txtreceptor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombreresapaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "crearRes";
            this.Text = "crearRes";
            this.Load += new System.EventHandler(this.crearRes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.TextBox txtnombreresapaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtreceptor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnrestaurar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnseleccionar;
    }
}