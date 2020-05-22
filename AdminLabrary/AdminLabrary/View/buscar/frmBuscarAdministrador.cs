﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.formularios.principales;
using AdminLabrary.Model;

namespace AdminLabrary.View.buscar
{
    public partial class frmBuscarAdministrador : Form
    {
        public frmBuscarAdministrador()
        {
            InitializeComponent();
            filtro();
                
        }

        private void frmBuscarAdministrador_Load(object sender, EventArgs e)
        {

        }
        void filtro()
        {
            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                dgvAdministrador.Rows.Clear();
                string buscar = txtBuscar.Text;
                var ListaA = from Adm in db.Administradores
                             where Adm.Usuario.Contains(buscar)
                             select new
                             {
                                 ID = Adm.Id_Admin,
                                 Usuario = Adm.Usuario,
                                 Contraseña = Adm.Contraseña
                             };
                foreach (var iterar in ListaA)
                {
                    dgvAdministrador.Rows.Add(iterar.ID, iterar.Usuario, iterar.Contraseña);
                }
            }
        }

        public int indicador;

        void seleccionar()
        {
            string Id = dgvAdministrador.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dgvAdministrador.CurrentRow.Cells[1].Value.ToString();
            if (indicador == 1)
            {
                frmPrincipal.admin.admin.txtLector.Text = Nombre;
                frmPrincipal.admin.admin.IDLector = int.Parse(Id);
            }
        }

        private void dgvAdministrador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }

        private void dgvAdministrador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                seleccionar();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }
    }
}
