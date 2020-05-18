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

        void limpiar()
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
                using (BibliotecaEntities4 db = new BibliotecaEntities4())
                {
                    autor.Nombre = txtNombre.Text;
                    autor.Nacionalidad = txtNacionalidad.Text;
                    autor.fecha_nacimiento = Convert.ToDateTime(dtpFecha.Text);
                    db.Autores.Add(autor);
                    db.SaveChanges();
                    frmPrincipal.Autor.CargarDatos();
                    limpiar();
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNacionalidad.Text != "")
            {
                using (BibliotecaEntities4 db = new BibliotecaEntities4())
                {
                    autor = db.Autores.Where(buscarID => buscarID.Id_autor == ID).First();
                    autor.Nombre = txtNombre.Text;
                    autor.Nacionalidad = txtNacionalidad.Text;
                    autor.fecha_nacimiento = Convert.ToDateTime(dtpFecha.Text);
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
            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                var lista = from i in db.Libros
                            where i.Id_autor == ID
                            select new { };
                if(lista.Count() == 0)
                {
                    autor = db.Autores.Find(ID);
                    db.Autores.Remove(autor);
                    db.SaveChanges();
                    limpiar();
                    frmPrincipal.Autor.CargarDatos();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar verificar \r" +
                        "que no exixta un libro con este autor");
                    this.Close();
                }
            }
        }
    }
}
