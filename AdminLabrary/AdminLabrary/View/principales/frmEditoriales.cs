
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
    public partial class frmEditoriales : Form
    {
        public frmEditoriales()
        {
            InitializeComponent();
        }

        private void FpEditoriales_Load(object sender, EventArgs e)
        {
            CargarDatos();


        }

        private void CargarDatos()
        {
            using (BibliotecaEntities3 db = new BibliotecaEntities3())
            {
                var lista = from ed in db.Editoriales
                            select new {ID = ed.Id_Editorial,Editorial= ed.Editorial,
                                Fundada=ed.Fundada,Direccion= ed.Direccion };
                dgvEditorial.DataSource = lista.ToList();

            }

        }
    }
}
