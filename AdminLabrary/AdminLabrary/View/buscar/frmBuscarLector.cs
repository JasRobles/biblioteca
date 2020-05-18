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
using AdminLabrary.Model;

namespace AdminLabrary.View.buscar
{
    public partial class frmBuscarLector : Form
    {
        public frmBuscarLector()
        {
            InitializeComponent();
        }

        public int indicador;
        private void frmBuscarLector_Load(object sender, EventArgs e)
        {
            filtro();

        }
        void filtro()
        {
            
            using (BibliotecaEntities4 db  = new BibliotecaEntities4())
            {
                string buscar = txtBuscar.Text;
                var listaL = from LEC in db.Lectores
                            where !(from adm in db.Administradores select adm.Id_Lector).Contains(LEC.Id_Lector)
                            && LEC.Nombres.Contains(buscar)
                            select new
                            {
                                ID = LEC.Id_Lector,
                                Nombres = LEC.Nombres,
                                Apellidos = LEC.Apellidos
                            };
                dgvLecto.DataSource = listaL.ToList();
            }
        }

        private void dgvLectores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }
        void seleccionar()
        {
            string id = dgvLecto.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dgvLecto.CurrentRow.Cells[1].Value.ToString();
            if (indicador == 1)
            {
                frmPrincipal.admin.admin.txtLector.Text = Nombre;
                frmPrincipal.admin.admin.IDLector = int.Parse(id);
                this.Close();
            }
        }

        
      

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void dgvLecto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }

        private void dgvLecto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                seleccionar();
            }
        }
    }
}
