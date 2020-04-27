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
            using (BibliotecaEntities3 db = new BibliotecaEntities3())
            {
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
                                Autor = au.Nombre,Editorial = ed.Editorial,Categoria = ca.Categoria
                            };

                dgvLibros.DataSource = lista.ToList();

            }

        }
    }
}
