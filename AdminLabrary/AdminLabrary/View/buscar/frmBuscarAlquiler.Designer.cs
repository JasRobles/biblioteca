namespace AdminLabrary.View.buscar
{
    partial class frmBuscarAlquiler
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
            this.dgvAlquiler = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Prevista_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlquiler
            // 
            this.dgvAlquiler.AllowUserToAddRows = false;
            this.dgvAlquiler.AllowUserToDeleteRows = false;
            this.dgvAlquiler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlquiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Lector,
            this.Libro,
            this.Entregado,
            this.Fecha_Salida,
            this.Fecha_Prevista_Entrega,
            this.Fecha_Entrega,
            this.Recibido});
            this.dgvAlquiler.Location = new System.Drawing.Point(12, 67);
            this.dgvAlquiler.Name = "dgvAlquiler";
            this.dgvAlquiler.ReadOnly = true;
            this.dgvAlquiler.Size = new System.Drawing.Size(1039, 266);
            this.dgvAlquiler.TabIndex = 12;
            this.dgvAlquiler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlquiler_CellDoubleClick);
            this.dgvAlquiler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAlquiler_KeyDown);
            // 
            // Id
            // 
            this.Id.FillWeight = 40F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Lector
            // 
            this.Lector.FillWeight = 130F;
            this.Lector.HeaderText = "Lector";
            this.Lector.Name = "Lector";
            this.Lector.ReadOnly = true;
            // 
            // Libro
            // 
            this.Libro.FillWeight = 130F;
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            // 
            // Entregado
            // 
            this.Entregado.FillWeight = 60F;
            this.Entregado.HeaderText = "Entregado";
            this.Entregado.Name = "Entregado";
            this.Entregado.ReadOnly = true;
            // 
            // Fecha_Salida
            // 
            this.Fecha_Salida.FillWeight = 80F;
            this.Fecha_Salida.HeaderText = "Fecha_Salida";
            this.Fecha_Salida.Name = "Fecha_Salida";
            this.Fecha_Salida.ReadOnly = true;
            // 
            // Fecha_Prevista_Entrega
            // 
            this.Fecha_Prevista_Entrega.FillWeight = 80F;
            this.Fecha_Prevista_Entrega.HeaderText = "Fecha Prevista Entrega";
            this.Fecha_Prevista_Entrega.Name = "Fecha_Prevista_Entrega";
            this.Fecha_Prevista_Entrega.ReadOnly = true;
            // 
            // Fecha_Entrega
            // 
            this.Fecha_Entrega.FillWeight = 80F;
            this.Fecha_Entrega.HeaderText = "Fecha_Entrega";
            this.Fecha_Entrega.Name = "Fecha_Entrega";
            this.Fecha_Entrega.ReadOnly = true;
            // 
            // Recibido
            // 
            this.Recibido.FillWeight = 60F;
            this.Recibido.HeaderText = "Recibido";
            this.Recibido.Name = "Recibido";
            this.Recibido.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(244, 20);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(283, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(283, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(283, 12);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // frmBuscarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 345);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dgvAlquiler);
            this.Controls.Add(this.txtBuscar);
            this.Name = "frmBuscarAlquiler";
            this.Text = "frmBuscarAlquiler";
            this.Load += new System.EventHandler(this.frmBuscarAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlquiler;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Prevista_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recibido;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}