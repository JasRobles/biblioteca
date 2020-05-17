using AdminLabrary.formularios.principales;
using AdminLabrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLabrary.View.insertUpdateDelete
{
    public partial class frmEditoriales : Form
    {
        public frmEditoriales()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtEditorial.Text = "";
            txtDirecion.Text = "";
            dtpFecha.Value = DateTime.Now;
            txtEditorial.Enabled = true;
        }
        Editoriales Edit = new Editoriales();
        public int ID;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtEditorial.Text != "")
            {
                using (BibliotecaEntities4 db = new BibliotecaEntities4())
                {
                    Edit.Editorial = txtEditorial.Text;
                    Edit.Fundada = Convert.ToDateTime(dtpFecha.Text);
                    Edit.Direccion = txtDirecion.Text;
                    db.Editoriales.Add(Edit);
                    db.SaveChanges();
                    limpiar();
                    frmPrincipal.Editorial.CargarDatos();
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtEditorial.Text != "")
            {
                using (BibliotecaEntities4 db = new BibliotecaEntities4())
                {
                    Edit = db.Editoriales.Where(buscarId => buscarId.Id_Editorial == ID).First();
                    Edit.Editorial = txtEditorial.Text;
                    Edit.Fundada = Convert.ToDateTime(dtpFecha.Text);
                    Edit.Direccion = txtDirecion.Text;
                    db.Entry(Edit).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    limpiar();
                    frmPrincipal.Editorial.CargarDatos();
                    this.Close();


                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                var lista = from i in db.Libros
                            where i.Id_Editorial == ID
                            select new { };
                if (lista.Count() == 0)
                {
                    Edit = db.Editoriales.Find(ID);
                    db.Editoriales.Remove(Edit);
                    db.SaveChanges();
                    limpiar();
                    frmPrincipal.Editorial.CargarDatos();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar verificar \r" + 
                        "que no exista un libro con esta editorial");
                    this.Close();
                }
            }
        }

        private void frmEditoriales_Load(object sender, EventArgs e)
        {

        }

        private void txtDirecion_TextChanged(object sender, EventArgs e)
        {
            txtDirecion.SelectionStart = txtDirecion.Text.Length;
        }
    }
}
