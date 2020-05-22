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
using AdminLabrary.formularios.principales;

namespace AdminLabrary.View.buscar
{
    public partial class frmBuscarCategoria : Form
    {
        public frmBuscarCategoria()
        {
            InitializeComponent();
            filtro();
        }

        private void frmBuscarCategoria_Load(object sender, EventArgs e)
        {

        }

        void filtro()
        {
            using(BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                dgvCategoria.Rows.Clear();
                string buscar = txtBuscar.Text;
                var ListaC = from Categ in db.Categorias
                             where Categ.Categoria1.Contains(buscar)
                             select new
                             {
                                 ID = Categ.Id_categoria,
                                 Categoria = Categ.Categoria1

                             };
                foreach(var iterar in ListaC)
                {
                    dgvCategoria.Rows.Add(iterar.ID, iterar.Categoria);
                }
            }
        }

        public int indicador;
        void seleccionar()
        {
            string Id = dgvCategoria.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
            if(indicador == 1)
            {
                frmPrincipal.admin.admin.txtLector.Text = Nombre;
                frmPrincipal.admin.admin.IDLector = int.Parse(Id);
                this.Close();
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }

        private void dgvCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                seleccionar();
            }
        }
    }
}
