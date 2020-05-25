using AdminLabrary.Model;
using AdminLabrary.View.buscar;
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
    public partial class frmLibrosCRUD : Form
    {
        public frmLibrosCRUD()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLibrosCRUD_Load(object sender, EventArgs e)
        {

        }
        public int ID_Autor;
        frmBuscarAutor BuscarA = new frmBuscarAutor();
        private void btnSeleccionarA_Click(object sender, EventArgs e)
        {
            BuscarA.ShowDialog();

        }

        Libros Lib = new Libros();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {


                

            }
        }
    }
}
