
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
    public partial class frmAdministradores : Form
    {
        public frmAdministradores()
        {
            InitializeComponent();
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            using (BibliotecaEntities3 db = new BibliotecaEntities3())
            {
                var lista = from ad in db.Administradores
                            from lec in db.Lectores
                            where ad.Id_Lector == lec.Id_Lector
                            select new
                            {
                                 ID = ad.Id_Admin,
                                Nombre = lec.Nombres, Usuario = ad.Usuario,
                                Contraseña = ad.Contraseña
                            };
                dgvAdmi.DataSource = lista.ToList();

            }

        }
    }
}
