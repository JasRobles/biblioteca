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
        public int indicador = 1;
        public frmBuscarLector()
        {
            InitializeComponent();
        }

       
        private void frmBuscarLector_Load(object sender, EventArgs e)
        {
            filtro();

        }
       public  void filtro()
        {
            if(indicador == 1) {
                using (BibliotecaEntities4 db = new BibliotecaEntities4())
                {
                    
                    dgvLecto.Rows.Clear();
                    string buscar = txtBuscar.Text;
                    var listaL = from LEC in db.Lectores
                                 where !(from adm in db.Administradores select adm.Id_Lector).Contains(LEC.Id_Lector)
                                 && LEC.Nombres.Contains(buscar)
                                 && LEC.estado ==0
                                 select new
                                 {
                                     ID = LEC.Id_Lector,
                                     Nombres = LEC.Nombres,
                                     Apellidos = LEC.Apellidos
                                 };
                  foreach(var i in listaL)
                    {

                        dgvLecto.Rows.Add(i.ID, i.Nombres, i.Apellidos);
                    }
                    
                }
            }
            else
            {
                using (BibliotecaEntities4 db = new BibliotecaEntities4())
                {
                    dgvLecto.Rows.Clear();
                    string buscar = txtBuscar.Text;
                    var listaL = from LEC in db.Lectores
                                 where LEC.Nombres.Contains(buscar)
                                  && LEC.estado == 0
                                 select new
                                 {
                                     ID = LEC.Id_Lector,
                                     Nombres = LEC.Nombres,
                                     Apellidos = LEC.Apellidos
                                 };
                    foreach (var i in listaL)
                    {

                        var lista = from pres in db.Alquileres
                                    where pres.Id_Lector == i.ID
                                    && pres.Recibido == null
                                    select new
                                    {
                                        pres
                                    };
                        if(lista.Count() <= 3)
                        {
                            dgvLecto.Rows.Add(i.ID, i.Nombres, i.Apellidos);
                        }
                    }

                }

            }
        }

        private void dgvLectores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }
        void seleccionar()
        {
           
            if (indicador == 1)
            {
                string id = dgvLecto.CurrentRow.Cells[0].Value.ToString();
                string Nombre = dgvLecto.CurrentRow.Cells[1].Value.ToString();
                frmPrincipal.admin.admin.txtLector.Text = Nombre;
                frmPrincipal.admin.admin.IDLector = int.Parse(id);
                this.Close();
            }
            else
            {
                string idl = dgvLecto.CurrentRow.Cells[0].Value.ToString();
                string Nombrel = dgvLecto.CurrentRow.Cells[1].Value.ToString();
                frmPrincipal.prestamos.alquiler.txtLector.Text = Nombrel;
                frmPrincipal.prestamos.alquiler.idLector = int.Parse(idl);
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
