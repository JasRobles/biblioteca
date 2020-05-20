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
    public partial class frmBuscarLibros : Form
    {
        public frmBuscarLibros()
        {
            InitializeComponent();
            filtro();
        }

        private void frmBuscarLibros_Load(object sender, EventArgs e)
        {

        }

        void filtro()
        {

            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                dgvLibro.Rows.Clear();
                string buscar = txtBuscar.Text;
                var ListaLib = from Lib in db.Libros
                               from Aut in db.Autores where Lib.Id_autor == Aut.Id_autor
                               where Lib.Nombre.Contains(buscar)
                               where Lib.cantidad > 0
                               select new
                               {
                                   Id = Lib.Id_libro,
                                   Nombre = Lib.Nombre,
                                   Autor = Aut.Nombre,
                                   Cantidad = Lib.cantidad
                               };

                foreach (var iterar in ListaLib )
                {
                    dgvLibro.Rows.Add(iterar.Id, iterar.Nombre, iterar.Autor, iterar.Cantidad);
                }

            }

        }
        public int indicador;
        void seleccionar()
        {
            String Id = dgvLibro.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dgvLibro.CurrentRow.Cells[1].Value.ToString();
            if (indicador == 1)
            {
                frmPrincipal.admin.admin.txtLector.Text = Nombre;
                frmPrincipal.admin.admin.IDLector = int.Parse(Id);
                this.Close();
            }
        }

        private void dgvLibro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }

        private void dgvLibro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                seleccionar();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }
    }
}
