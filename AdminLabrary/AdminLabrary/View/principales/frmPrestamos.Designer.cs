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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LECTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTREGADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entregadoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPrestamos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPrestamos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrestamos.Size = new System.Drawing.Size(917, 374);
            this.dgvPrestamos.TabIndex = 2;
            this.dgvPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellClick);
            // 
            // btnRecibir
            // 
            this.btnRecibir.Enabled = false;
            this.btnRecibir.Location = new System.Drawing.Point(402, 89);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(142, 36);
            this.btnRecibir.TabIndex = 14;
            this.btnRecibir.Text = "RECIBIR";
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // btnNuevo
            // 
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
            this.btnVer.Location = new System.Drawing.Point(661, 89);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(142, 36);
            this.btnVer.TabIndex = 15;
            this.btnVer.Text = "VER TODOS ";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
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
            // ENTREGADO
            // 
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
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 551);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvPrestamos);
            this.Name = "frmPrestamos";
            this.Text = "frmPrestamos";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LECTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIBRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTREGADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLector;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entregadoid;
    }
}