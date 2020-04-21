
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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void FpCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            using (BibliotecaEntities1 db= new BibliotecaEntities1())
            {
                var lista = from cat in db.Categorias
                            select new {ID = cat.Id_categoria,Categoria =cat.Categoria };
                dgvCategoria.DataSource = lista.ToList();
            }

        }
    }
}
