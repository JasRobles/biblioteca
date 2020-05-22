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

namespace AdminLabrary.View.buscar
{
    public partial class frmBuscarAlquiler : Form
    {
        public frmBuscarAlquiler()
        {
            InitializeComponent();
        }

        private void frmBuscarAlquiler_Load(object sender, EventArgs e)
        {

        }

        void filtro()
        {
            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                string buscar = txtBuscar.Text;
                var ListaA = from Alq in db.Alquileres
                             where Alq.
            }
        }
    }
}
