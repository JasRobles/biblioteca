using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.View.buscar;
using AdminLabrary.Model;


namespace AdminLabrary.View.insertUpdateDelete
{
    public partial class frmLibrosCRUD : Form
    {
        public frmLibrosCRUD()
        {
            InitializeComponent();
            CargarCombo();
        }
        string ID_Categoria;
        public int ID_Editorial;
        public int ID_Autor;
        frmBuscarAutor BuscarA = new frmBuscarAutor();

        private void btnSeleccionarA_Click(object sender, EventArgs e)
        {
            BuscarA.indicador = 1;
            BuscarA.ShowDialog();

        }
        Libros Lib = new Libros();

        void CargarCombo()
        {
            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {

                var Categoria = db.Categorias.ToList();
                cmbCategoria.DataSource = Categoria;
                cmbCategoria.ValueMember = "ID_Categoria";
                cmbCategoria.DisplayMember = "Categoria1";

            }
            
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtAutor.Text != "" && txtCantidad.Text != "" 
                && txtEditorial.Text != "" && txtNumero_de_Edicion.Text != "")
            {
                using (BibliotecaEntities4 db = new BibliotecaEntities4())
                {
                    Lib.Nombre = txtNombre.Text;
                    Lib.Año = Convert.ToDateTime(dtpAño.Text);
                    Lib.Id_autor = ID_Autor;
                    Lib.Id_Editorial = ID_Editorial;
                    //Lib.Numero_edicion = txtNumero_de_Edicion.Text;

                    
                    db.Libros.Add(Lib);
                    db.SaveChanges();
                    
                }
            }


        }

        private void frmLibrosCRUD_Load(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID_Categoria = cmbCategoria.SelectedValue.ToString();
        }
    }
}
