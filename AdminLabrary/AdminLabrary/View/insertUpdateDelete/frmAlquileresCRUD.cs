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
    public partial class frmAlquileresCRUD : Form
    {
        public int IdLibro;
        public frmAlquileresCRUD()
        {
            InitializeComponent();
        }
        frmBuscarLibros li = new frmBuscarLibros();
        private void btnSeleccionarLibro_Click(object sender, EventArgs e)
        {
            li.ShowDialog();
        }
        frmBuscarLector lec = new frmBuscarLector();
        private void btnSeleccionarLector_Click(object sender, EventArgs e)
        {
            lec.indicador = 2;
            lec.ShowDialog();
        }
    }
}
