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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Prevista_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlquiler
            // 
            this.dgvAlquiler.AllowUserToAddRows = false;
            this.dgvAlquiler.AllowUserToDeleteRows = false;
            this.dgvAlquiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Lector,
            this.Libro,
            this.Fecha_Salida,
            this.Fecha_Prevista_Entrega,
            this.Fecha_Entrega,
            this.Recibido});
            this.dgvAlquiler.Location = new System.Drawing.Point(-1, 67);
            this.dgvAlquiler.Name = "dgvAlquiler";
            this.dgvAlquiler.ReadOnly = true;
            this.dgvAlquiler.Size = new System.Drawing.Size(993, 266);
            this.dgvAlquiler.TabIndex = 12;
            this.dgvAlquiler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlquiler_CellDoubleClick);
            this.dgvAlquiler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAlquiler_KeyDown);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(-1, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(244, 20);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // Id
            // 
            this.Id.FillWeight = 20F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Lector
            // 
            this.Lector.HeaderText = "Lector";
            this.Lector.Name = "Lector";
            this.Lector.ReadOnly = true;
            // 
            // Libro
            // 
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            // 
            // Fecha_Salida
            // 
            this.Fecha_Salida.HeaderText = "Fecha_Salida";
            this.Fecha_Salida.Name = "Fecha_Salida";
            this.Fecha_Salida.ReadOnly = true;
            // 
            // Fecha_Prevista_Entrega
            // 
            this.Fecha_Prevista_Entrega.HeaderText = "Fecha_Prevista_Entrega";
            this.Fecha_Prevista_Entrega.Name = "Fecha_Prevista_Entrega";
            this.Fecha_Prevista_Entrega.ReadOnly = true;
            // 
            // Fecha_Entrega
            // 
            this.Fecha_Entrega.HeaderText = "Fecha_Entrega";
            this.Fecha_Entrega.Name = "Fecha_Entrega";
            this.Fecha_Entrega.ReadOnly = true;
            // 
            // Recibido
            // 
            this.Recibido.HeaderText = "Recibido";
            this.Recibido.Name = "Recibido";
            this.Recibido.ReadOnly = true;
            // 
            // frmBuscarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 345);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Prevista_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recibido;
    }
}