
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
    public partial class frmLectores : Form
    {
        public frmLectores()
        {
            InitializeComponent();
        }


        private void frmLectores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            using (BibliotecaEntities1 db = new BibliotecaEntities1())
            {
                var lista = from lec in db.Lectores
                            select new
                            {
                                ID = lec.Id_Lector,Nombre=lec.Nombres, Apellidos = lec.Apellidos
                                ,Carnet = lec.Carnet
                            };
                dgvLectores.DataSource = lista.ToList();
            }

        }
    }
}
