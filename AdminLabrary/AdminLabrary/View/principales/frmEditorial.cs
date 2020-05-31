
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
    public partial class frmEditorial : Form
    {
        public frmEditorial()
        {
            InitializeComponent();
        }

        private void FpEditoriales_Load(object sender, EventArgs e)
        {
            CargarDatos();


        }

        public void CargarDatos()
        {
            using (BibliotecaprogramEntities db = new BibliotecaprogramEntities())
            {
                var lista = from ed in db.Editoriales
                            where ed.estado==0
                            select new {ID = ed.Id_Editorial,Editorial= ed.Editorial,
                                Fundada=ed.Fundada,Direccion= ed.Direccion };
                dgvEditorial.DataSource = lista.ToList();

            }

        }

        private void dgvEditorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        public static frmEditorialesCRUD Editorial = new frmEditorialesCRUD();
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editorial.btnGuardar.Enabled = true;
            Editorial.btnEditar.Enabled = false;
            Editorial.btnEliminar.Enabled = false;
            Editorial.limpiar();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            Editorial.ShowDialog();
        }
        void seleccionar()
        {
            int Id = int.Parse(dgvEditorial.CurrentRow.Cells[0].Value.ToString());
            string edit = dgvEditorial.CurrentRow.Cells[1].Value.ToString();
            string fundada = dgvEditorial.CurrentRow.Cells[2].Value.ToString();
            string direccion = dgvEditorial.CurrentRow.Cells[3].Value.ToString();

            Editorial.txtDirecion.Text = direccion;
            Editorial.txtEditorial.Text = edit;
            Editorial.ID = Id;
            Editorial.dtpFecha.Text = fundada;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            seleccionar();
            Editorial.btnGuardar.Enabled = false;
            Editorial.btnEditar.Enabled = true;
            Editorial.btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            Editorial.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            seleccionar();
            Editorial.btnGuardar.Enabled = false;
            Editorial.btnEditar.Enabled = false;
            Editorial.btnEliminar.Enabled = true ;
            Editorial.txtDirecion.Enabled = false;
            Editorial.txtEditorial.Enabled = false;
            Editorial.dtpFecha.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            Editorial.ShowDialog();
        }
    }
}
