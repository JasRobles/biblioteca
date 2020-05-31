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
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        private void FpAutor_Load(object sender, EventArgs e)
        {
            CargarDatos();



        }

        public void CargarDatos()
        {
            using (BibliotecaprogramEntities db = new BibliotecaprogramEntities())
            {
                var lista = from autores in db.Autores
                            where autores.estado ==0
                            select new
                            {
                                ID = autores.Id_autor,
                                Nombre = autores.Nombre,
                                Fecha_Nacimiento
                                = autores.fecha_nacimiento,
                                Nacionalidad = autores.Nacionalidad
                            };

                dgvAutores.DataSource = lista.ToList();
            }

        }

        public static frmAutoresCRUD autor = new frmAutoresCRUD();

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            autor.btnGuardar.Enabled = true;
            autor.btnEditar.Enabled = false;
            autor.btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            autor.limpiar();
            autor.ShowDialog();

        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        void seleccionar()
        {
            string id = dgvAutores.CurrentRow.Cells[0].Value.ToString();
            string nombre = dgvAutores.CurrentRow.Cells[1].Value.ToString();
            string fecha = dgvAutores.CurrentRow.Cells[2].Value.ToString();
            string nacionalidad = dgvAutores.CurrentRow.Cells[3].Value.ToString();
            autor.txtNacionalidad.Text = nacionalidad;
            autor.txtNombre.Text = nombre;
            autor.dtpFecha.Text = fecha;
            autor.ID = int.Parse(id);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            seleccionar();
            autor.btnGuardar.Enabled = false;
            autor.btnEliminar.Enabled = false;
            autor.btnEditar.Enabled = true;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            autor.ShowDialog();
        }

        private void dgvAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            seleccionar();
            autor.btnGuardar.Enabled = false;
            autor.btnEliminar.Enabled = true;
            autor.btnEditar.Enabled = false;
            autor.dtpFecha.Enabled = false;
            autor.txtNacionalidad.Enabled = false;
            autor.txtNombre.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            autor.ShowDialog();
        }
    }
}
