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
    public partial class frmLibros : Form
    {
        public frmLibros()
        {
            InitializeComponent();
            CargaDratos();
        }

        private void fpLibros_Load(object sender, EventArgs e)
        {


            

        }

        private void librosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmLibros_Load(object sender, EventArgs e)
        {

        }
        private void CargaDratos()
        {
            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                dgvLibros.Rows.Clear();
                var lista = from li in db.Libros
                            from au in db.Autores
                            from ca in db.Categorias
                            from ed in db.Editoriales
                            where li.Id_categoria == ca.Id_categoria
                            && li.Id_autor == au.Id_autor
                            && li.Id_Editorial == ed.Id_Editorial
                            select new 
                            { ID = li.Id_libro, Nombre = li.Nombre,
                                Cantidad =li.cantidad,Año=li.Año,Numero_edicion =li.Numero_edicion,
                                Autor = au.Nombre,Editorial = ed.Editorial,Categoria = ca.Categoria1,
                                idAutor = li.Id_autor,idEditorial = li.Id_Editorial, idCategoria = li.Id_categoria
                            };
                foreach (var i in lista)
                {
                    dgvLibros.Rows.Add(i.ID,i.Nombre,i.Cantidad,i.Año,i.Numero_edicion,i.Autor, i.Editorial, i.Categoria,i.idAutor,i.idEditorial,i.idCategoria);
                }

              

            }

        }
        public frmLibrosCRUD Libros = new frmLibrosCRUD();
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Libros.ShowDialog();

        }

    }
}
