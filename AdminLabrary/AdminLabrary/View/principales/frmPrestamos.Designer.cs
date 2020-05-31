namespace AdminLabrary.View.principales
{
    partial class frmPrestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LECTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTREGADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entregadoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbtnLector = new System.Windows.Forms.RadioButton();
            this.rbtnLibro = new System.Windows.Forms.RadioButton();
            this.rbtnAdministrador = new System.Windows.Forms.RadioButton();
            this.btnRetrazo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPrestamos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LECTOR,
            this.LIBRO,
            this.CANTIDAD,
            this.ENTREGADO,
            this.FECHAS,
            this.FECHAP,
            this.IDLector,
            this.IDLibro,
            this.Entregadoid});
            this.dgvPrestamos.GridColor = System.Drawing.Color.Lime;
            this.dgvPrestamos.Location = new System.Drawing.Point(12, 140);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPrestamos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrestamos.Size = new System.Drawing.Size(917, 399);
            this.dgvPrestamos.TabIndex = 2;
            this.dgvPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellClick);
            this.dgvPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellContentClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // LECTOR
            // 
            this.LECTOR.FillWeight = 120F;
            this.LECTOR.HeaderText = "LECTOR";
            this.LECTOR.Name = "LECTOR";
            this.LECTOR.ReadOnly = true;
            // 
            // LIBRO
            // 
            this.LIBRO.FillWeight = 150F;
            this.LIBRO.HeaderText = "LIBRO";
            this.LIBRO.Name = "LIBRO";
            this.LIBRO.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.FillWeight = 60F;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // ENTREGADO
            // 
            this.ENTREGADO.FillWeight = 60F;
            this.ENTREGADO.HeaderText = "ENTREGADO POR";
            this.ENTREGADO.Name = "ENTREGADO";
            this.ENTREGADO.ReadOnly = true;
            // 
            // FECHAS
            // 
            this.FECHAS.HeaderText = "FECHA  DE SALIDA";
            this.FECHAS.Name = "FECHAS";
            this.FECHAS.ReadOnly = true;
            // 
            // FECHAP
            // 
            this.FECHAP.HeaderText = "FECHA PREVISTA ENTREGA";
            this.FECHAP.Name = "FECHAP";
            this.FECHAP.ReadOnly = true;
            // 
            // IDLector
            // 
            this.IDLector.HeaderText = "IDLector";
            this.IDLector.Name = "IDLector";
            this.IDLector.ReadOnly = true;
            this.IDLector.Visible = false;
            // 
            // IDLibro
            // 
            this.IDLibro.HeaderText = "IDLibro";
            this.IDLibro.Name = "IDLibro";
            this.IDLibro.ReadOnly = true;
            this.IDLibro.Visible = false;
            // 
            // Entregadoid
            // 
            this.Entregadoid.HeaderText = "Entregadoid";
            this.Entregadoid.Name = "Entregadoid";
            this.Entregadoid.ReadOnly = true;
            this.Entregadoid.Visible = false;
            // 
            // btnRecibir
            // 
            this.btnRecibir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRecibir.Enabled = false;
            this.btnRecibir.Location = new System.Drawing.Point(193, 89);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(142, 36);
            this.btnRecibir.TabIndex = 14;
            this.btnRecibir.Text = "RECIBIR";
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevo.Location = new System.Drawing.Point(11, 89);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(142, 36);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVer
            // 
            this.btnVer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVer.Location = new System.Drawing.Point(365, 89);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(142, 36);
            this.btnVer.TabIndex = 15;
            this.btnVer.Text = "PRESTAMOS FINALIZADOS";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(718, 70);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(211, 26);
            this.txtBuscar.TabIndex = 16;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rbtnLector
            // 
            this.rbtnLector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnLector.AutoSize = true;
            this.rbtnLector.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.rbtnLector.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rbtnLector.Location = new System.Drawing.Point(718, 103);
            this.rbtnLector.Name = "rbtnLector";
            this.rbtnLector.Size = new System.Drawing.Size(55, 17);
            this.rbtnLector.TabIndex = 17;
            this.rbtnLector.TabStop = true;
            this.rbtnLector.Text = "Lector";
            this.rbtnLector.UseVisualStyleBackColor = true;
            // 
            // rbtnLibro
            // 
            this.rbtnLibro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnLibro.AutoSize = true;
            this.rbtnLibro.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.rbtnLibro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rbtnLibro.Location = new System.Drawing.Point(779, 103);
            this.rbtnLibro.Name = "rbtnLibro";
            this.rbtnLibro.Size = new System.Drawing.Size(48, 17);
            this.rbtnLibro.TabIndex = 18;
            this.rbtnLibro.TabStop = true;
            this.rbtnLibro.Text = "Libro";
            this.rbtnLibro.UseVisualStyleBackColor = true;
            // 
            // rbtnAdministrador
            // 
            this.rbtnAdministrador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnAdministrador.AutoSize = true;
            this.rbtnAdministrador.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.rbtnAdministrador.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rbtnAdministrador.Location = new System.Drawing.Point(841, 102);
            this.rbtnAdministrador.Name = "rbtnAdministrador";
            this.rbtnAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rbtnAdministrador.TabIndex = 19;
            this.rbtnAdministrador.TabStop = true;
            this.rbtnAdministrador.Text = "Administrador";
            this.rbtnAdministrador.UseVisualStyleBackColor = true;
            // 
            // btnRetrazo
            // 
            this.btnRetrazo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRetrazo.Location = new System.Drawing.Point(535, 89);
            this.btnRetrazo.Name = "btnRetrazo";
            this.btnRetrazo.Size = new System.Drawing.Size(142, 36);
            this.btnRetrazo.TabIndex = 20;
            this.btnRetrazo.Text = "HISTORIAL CON RETRASO";
            this.btnRetrazo.UseVisualStyleBackColor = true;
            this.btnRetrazo.Click += new System.EventHandler(this.btnRetrazo_Click);
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 551);
            this.Controls.Add(this.btnRetrazo);
            this.Controls.Add(this.rbtnAdministrador);
            this.Controls.Add(this.rbtnLibro);
            this.Controls.Add(this.rbtnLector);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvPrestamos);
            this.Name = "frmPrestamos";
            this.Text = "frmPrestamos";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbtnLector;
        private System.Windows.Forms.RadioButton rbtnLibro;
        private System.Windows.Forms.RadioButton rbtnAdministrador;
        private System.Windows.Forms.Button btnRetrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LECTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIBRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTREGADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLector;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entregadoid;
    }
}