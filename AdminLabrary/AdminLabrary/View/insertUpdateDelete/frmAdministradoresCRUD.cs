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
using AdminLabrary.View.buscar;

namespace AdminLabrary.View.insertUpdateDelete
{
    public partial class frmAdministradoresCRUD : Form
    {
        public frmAdministradoresCRUD()
        {
            InitializeComponent();
        }

        public int IDLector;
        public int IDAdmin;
        Administradores admi = new Administradores();
        private void frmAdministradoresCRUD_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;

        }

        public void Limpiar()
        {
            txtContraseña.Text = "";
            txtLector.Text = "";
            txtUsuario.Text = "";
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            btnSeleccionar.Enabled = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                admi.Usuario = txtUsuario.Text;
                admi.Contraseña = txtContraseña.Text;
                admi.Id_Lector = IDLector;
                db.Administradores.Add(admi);
                db.SaveChanges();
                Limpiar();
                frmPrincipal.admin.CargarDatos();


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                admi = db.Administradores.Where(buscarID => buscarID.Id_Admin == IDAdmin).First();
                admi.Usuario = txtUsuario.Text;
                admi.Contraseña = txtContraseña.Text;
                admi.Id_Lector = IDLector;
                db.Entry(admi).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                Limpiar();
                frmPrincipal.admin.CargarDatos();
                this.Close();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                var lista = from pres in db.Alquileres
                            where IDAdmin == pres.Entregado
                            select new { };
                var lis = from prest in db.Alquileres
                          where IDAdmin == prest.Recibido
                          select new { };
                if (lis.Count() == 0 && lista.Count() == 0)
                {
                    admi = db.Administradores.Find(IDAdmin);
                    db.Administradores.Remove(admi);
                    db.SaveChanges();
                    Limpiar();
                    frmPrincipal.admin.CargarDatos();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar, verificar que \r" +
                        "no exista un alquiler con este administrador");
                    this.Close();
                    Limpiar();
                }

            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmBuscarLector lec = new frmBuscarLector();
            lec.indicador = 1;
            lec.ShowDialog();
        }

        int mostrar = 0;
        private void btnVerC_Click(object sender, EventArgs e)
        {
           
            if (mostrar==0)
            {
                txtContraseña.UseSystemPasswordChar = false;
                mostrar = 1;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                mostrar =0;
            }
            
        }
    }
}
