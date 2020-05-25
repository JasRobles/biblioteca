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



        }
    }
}
