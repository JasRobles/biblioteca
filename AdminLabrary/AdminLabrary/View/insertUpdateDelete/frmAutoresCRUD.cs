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
    public partial class frmAutoresCRUD : Form
    {
        Autores autor = new Autores();
        public frmAutoresCRUD()
        {
            InitializeComponent();
        }
        public int ID;

        public void limpiar()
        {
            txtNacionalidad.Text = "";
            txtNombre.Text = "";
            dtpFecha.Value = DateTime.Now;
            txtNacionalidad.Enabled = true;
            txtNombre.Enabled = true;
            dtpFecha.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNacionalidad.Text!= "")
            {
                using (BibliotecaprogramEntities db = new BibliotecaprogramEntities())
                {
                    autor.Nombre = txtNombre.Text;
                    autor.Nacionalidad = txtNacionalidad.Text;
                    autor.fecha_nacimiento = Convert.ToDateTime(dtpFecha.Text);
                    autor.estado = 0;
                    db.Autores.Add(autor);
                    db.SaveChanges();
                    frmPrincipal.Autor.CargarDatos();
                    limpiar();
                    this.Close();
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNacionalidad.Text != "")
            {
                using (BibliotecaprogramEntities db = new BibliotecaprogramEntities())
                {
                    autor = db.Autores.Where(buscarID => buscarID.Id_autor == ID).First();
                    autor.Nombre = txtNombre.Text;
                    autor.Nacionalidad = txtNacionalidad.Text;
                    autor.fecha_nacimiento = Convert.ToDateTime(dtpFecha.Text);
                    autor.estado = 0;
                    db.Entry(autor).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    limpiar();
                    frmPrincipal.Autor.CargarDatos();
                    this.Close();
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (BibliotecaprogramEntities db = new BibliotecaprogramEntities())
            {
                autor = db.Autores.Where(buscarID => buscarID.Id_autor == ID).First();
                autor.Nombre = txtNombre.Text;
                autor.Nacionalidad = txtNacionalidad.Text;
                autor.fecha_nacimiento = Convert.ToDateTime(dtpFecha.Text);
                autor.estado = 1;
                db.Entry(autor).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                limpiar();
                frmPrincipal.Autor.CargarDatos();
                this.Close();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAutoresCRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
