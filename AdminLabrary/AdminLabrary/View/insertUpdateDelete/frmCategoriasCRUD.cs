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
    public partial class frmCategoriasCRUD : Form
    {
        public frmCategoriasCRUD()
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
                    categoria.Categoria = txtCategoria.Text;
                    categoria.estado = 0;
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
                    categoria.Categoria = txtCategoria.Text;
                    categoria.estado = 0;
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
                categoria = db.Categorias.Where(buscarId => buscarId.Id_categoria == ID).First();
                categoria.Categoria = txtCategoria.Text;
                categoria.estado = 1;
                db.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                limpiar();
                frmPrincipal.categoria.CargarDatos();
                this.Close();
            }
        }


        private void frmCategoriasCRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
