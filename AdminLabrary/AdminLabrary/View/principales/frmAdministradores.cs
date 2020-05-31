
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.Model;
using AdminLabrary.View.insertUpdateDelete;

namespace AdminLabrary.formularios.principales
{
    public partial class frmAdministradores : Form
    {
        public frmAdministradores()
        {
            InitializeComponent();
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            using (BibliotecaprogramEntities db = new BibliotecaprogramEntities())
            {
                dgvAdmi.Rows.Clear();
                var lista = from ad in db.Roles
                            from lec in db.Lectores
                            where ad.Id_Lector == lec.Id_Lector
                            && ad.estado==0
                            && ad.Rol == 1
                            select new
                            {
                                ID = ad.Id_rol,
                                Nombre = lec.Nombres,
                                Usuario = ad.Usuario,
                                Contraseña = ad.Contraseña,
                                IDLector = lec.Id_Lector
                            };
                foreach(var i in lista)
                {
                    dgvAdmi.Rows.Add(i.ID,i.Usuario,i.Contraseña,i.Nombre,i.IDLector);
                }

            }

        }

        public frmAdministradoresCRUD admin = new frmAdministradoresCRUD();
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            admin.btnEditar.Enabled = false;
            admin.btnEliminar.Enabled = false;
            admin.btnSeleccionar.Enabled = true;
            admin.btnGuardar.Enabled = true;
          
            admin.Limpiar();
            admin.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            admin.btnEditar.Enabled = false;
            admin.btnEliminar.Enabled = true;
            admin.btnSeleccionar.Enabled = false;
            admin.btnGuardar.Enabled = false;
            admin.txtContraseña.Enabled = false;
            admin.txtUsuario.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            admin.rbtnAdmi.Checked = true;
            Seleccionar();
            admin.ShowDialog();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            admin.btnEditar.Enabled = true;
            admin.btnEliminar.Enabled = false;
            admin.btnSeleccionar.Enabled = true;
            admin.btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            admin.rbtnAdmi.Checked = true;
            Seleccionar();
            admin.ShowDialog();

        }

        private void dgvAdmi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        void Seleccionar()
        {
            string Id = dgvAdmi.CurrentRow.Cells[0].Value.ToString();
            string usuario = dgvAdmi.CurrentRow.Cells[1].Value.ToString();
            string contraseña = dgvAdmi.CurrentRow.Cells[2].Value.ToString();
            string idU = dgvAdmi.CurrentRow.Cells[4].Value.ToString();
            string lector = dgvAdmi.CurrentRow.Cells[3].Value.ToString();
            admin.txtLector.Text = lector;
            admin.txtContraseña.Text = contraseña;
            admin.IDLector = int.Parse(idU);
            admin.txtUsuario.Text = usuario;
            admin.IDAdmin = int.Parse(Id);
        }
    }
}
