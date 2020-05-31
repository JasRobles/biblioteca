namespace AdminLabrary.View.insertUpdateDelete
{
    partial class frmAlquileresCRUD
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
            this.txtLector = new System.Windows.Forms.TextBox();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.btnSeleccionarLibro = new System.Windows.Forms.Button();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblLibro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionarLector = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLector
            // 
            this.txtLector.Enabled = false;
            this.txtLector.Location = new System.Drawing.Point(12, 36);
            this.txtLector.Name = "txtLector";
            this.txtLector.Size = new System.Drawing.Size(235, 26);
            this.txtLector.TabIndex = 0;
            // 
            // txtLibro
            // 
            this.txtLibro.Enabled = false;
            this.txtLibro.Location = new System.Drawing.Point(12, 91);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(235, 26);
            this.txtLibro.TabIndex = 1;
            // 
            // btnSeleccionarLibro
            // 
            this.btnSeleccionarLibro.BackColor = System.Drawing.Color.Lime;
            this.btnSeleccionarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarLibro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSeleccionarLibro.FlatAppearance.BorderSize = 2;
            this.btnSeleccionarLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSeleccionarLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSeleccionarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarLibro.Location = new System.Drawing.Point(291, 90);
            this.btnSeleccionarLibro.Name = "btnSeleccionarLibro";
            this.btnSeleccionarLibro.Size = new System.Drawing.Size(155, 31);
            this.btnSeleccionarLibro.TabIndex = 20;
            this.btnSeleccionarLibro.Text = "SELECCIONAR";
            this.btnSeleccionarLibro.UseVisualStyleBackColor = false;
            this.btnSeleccionarLibro.Click += new System.EventHandler(this.btnSeleccionarLibro_Click);
            // 
            // btnRecibir
            // 
            this.btnRecibir.BackColor = System.Drawing.Color.Lime;
            this.btnRecibir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecibir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRecibir.FlatAppearance.BorderSize = 2;
            this.btnRecibir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRecibir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRecibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibir.Location = new System.Drawing.Point(167, 203);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(133, 31);
            this.btnRecibir.TabIndex = 18;
            this.btnRecibir.Text = "RECIBIR";
            this.btnRecibir.UseVisualStyleBackColor = false;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(12, 203);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 31);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibro.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLibro.Location = new System.Drawing.Point(97, 68);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(63, 20);
            this.lblLibro.TabIndex = 21;
            this.lblLibro.Text = "LIBRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(97, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "LECTOR";
            // 
            // btnSeleccionarLector
            // 
            this.btnSeleccionarLector.BackColor = System.Drawing.Color.Lime;
            this.btnSeleccionarLector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarLector.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSeleccionarLector.FlatAppearance.BorderSize = 2;
            this.btnSeleccionarLector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSeleccionarLector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSeleccionarLector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarLector.Location = new System.Drawing.Point(291, 35);
            this.btnSeleccionarLector.Name = "btnSeleccionarLector";
            this.btnSeleccionarLector.Size = new System.Drawing.Size(155, 31);
            this.btnSeleccionarLector.TabIndex = 23;
            this.btnSeleccionarLector.Text = "SELECCIONAR";
            this.btnSeleccionarLector.UseVisualStyleBackColor = false;
            this.btnSeleccionarLector.Click += new System.EventHandler(this.btnSeleccionarLector_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(77, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(12, 149);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(235, 26);
            this.txtCantidad.TabIndex = 24;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // frmAlquileresCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(486, 246);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnSeleccionarLector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.btnSeleccionarLibro);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.txtLector);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAlquileresCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlquileresCRUD";
            this.Load += new System.EventHandler(this.frmAlquileresCRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnSeleccionarLibro;
        public System.Windows.Forms.Button btnRecibir;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSeleccionarLector;
        public System.Windows.Forms.TextBox txtLector;
        public System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCantidad;
    }
}