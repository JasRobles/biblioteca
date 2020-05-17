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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtCategoria.Text = "";
            txtCategoria.Enabled = true;
        }
        Categorias categoria = new Categorias();
        public int ID;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text!= "")
            {
                using (BibliotecaEntities4 db= new BibliotecaEntities4())
                {
                    categoria.Categoria1 = txtCategoria.Text;
                    db.Categorias.Add(categoria);
                    db.SaveChanges();
                    limpiar();
                    frmPrincipal.categoria.CargarDatos();
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text != "")
            {
                using (BibliotecaEntities4 db = new BibliotecaEntities4())
                {
                    categoria = db.Categorias.Where(buscarId => buscarId.Id_categoria == ID).First();
                    categoria.Categoria1 = txtCategoria.Text;
                    db.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    limpiar();
                    frmPrincipal.categoria.CargarDatos();
                    this.Close();


                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                var lista = from i in db.Libros
                            where i.Id_categoria == ID
                            select new { };
                if(lista.Count() == 0)
                {
                    categoria = db.Categorias.Find(ID);
                    db.Categorias.Remove(categoria);
                    db.SaveChanges();
                    limpiar();
                    frmPrincipal.categoria.CargarDatos();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se puede eliminar, verificar que \r" +
                        "no exista un libro con esta categoria");
                    this.Close();
                }
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
