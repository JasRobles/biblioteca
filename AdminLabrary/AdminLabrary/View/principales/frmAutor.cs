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
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        private void FpAutor_Load(object sender, EventArgs e)
        {
            CargarDatos();
            

          
        }

        private void CargarDatos()
        {
            using (BibliotecaEntities3 db = new BibliotecaEntities3())
            {
                var lista = from autores in db.Autores
                            select new
                            {
                                ID = autores.Id_autor,
                                Nombre = autores.Nombre,
                                Fecha_Nacimiento
                                = autores.fecha_nacimiento,
                                Nacionalidad = autores.Nacionalidad
                            };

                dgvAutores.DataSource = lista.ToList();
            }

        }

       
    }
}
