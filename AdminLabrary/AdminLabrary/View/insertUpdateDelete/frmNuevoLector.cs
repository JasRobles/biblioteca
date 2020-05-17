using AdminLabrary.formularios.principales;
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

namespace AdminLabrary.View.insertUpdateDelete
{
    public partial class frmNuevoLector : Form
    {
        public string ID;
        public frmNuevoLector()
        {
           
            InitializeComponent();
          
        }

        public void limpiar()
        {
            txtApellidos.Text = "";
            txtNombre.Text = "";
            txtApellidos.Enabled = true;
            txtNombre.Enabled = true;
        }

        Lectores lector = new Lectores();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtApellidos.Text !="" && txtNombre.Text != "") {
                using (BibliotecaEntities4 db = new BibliotecaEntities4())
                {
                    lector.Nombres = txtNombre.Text;
                    lector.Apellidos = txtApellidos.Text;
                    db.Lectores.Add(lector);
                    db.SaveChanges();
                    limpiar();
                    frmPrincipal.lector.CargarDatos();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtApellidos.Text != "" && txtNombre.Text != "")
            {
                using (BibliotecaEntities4 db = new BibliotecaEntities4())
                {
                    int id = int.Parse(ID);
                    lector = db.Lectores.Where(buscarid => buscarid.Id_Lector == id).First();
                    lector.Nombres = txtNombre.Text;
                    lector.Apellidos = txtApellidos.Text;
                    db.Entry(lector).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    limpiar();
                    frmPrincipal.lector.CargarDatos();
                    this.Close();
                }


            }
        }

        private void frmNuevoLector_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                int id = int.Parse(ID);
                var lista = from i in db.Alquileres
                            where i.Id_Lector == id
                            select new { };
                if (lista.Count() == 0)
                {
                    lector = db.Lectores.Find(id);
                    db.Lectores.Remove(lector);
                    db.SaveChanges();
                    limpiar();
                    frmPrincipal.lector.CargarDatos();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar, verificar \r" +
                        "que no exista un alquiler con este lector");
                }
               
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
