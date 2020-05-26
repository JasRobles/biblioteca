using AdminLabrary.View.buscar;
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
using AdminLabrary.formularios.principales;

namespace AdminLabrary.View.insertUpdateDelete
{
    public partial class frmAlquileresCRUD : Form
    {
        public int IdLibro;
        public int idLector;
        public int idAdmin;
        public int IdDE;
        public int indicador = 1;
        public frmAlquileresCRUD()
        {
            InitializeComponent();
        }
        frmBuscarLibros li = new frmBuscarLibros();
        private void btnSeleccionarLibro_Click(object sender, EventArgs e)
        {
            li.ShowDialog();
        }
        frmBuscarLector lec = new frmBuscarLector();
        private void btnSeleccionarLector_Click(object sender, EventArgs e)
        {
            lec.indicador = 2;
            lec.ShowDialog();
        }
        void enable()
        {
            if(indicador == 1)
            {
                txtLibro.Enabled = true;
                txtLibro.Enabled = true;
                btnRecibir.Enabled = true;
                btnGuardar.Enabled = true;
                btnSeleccionarLector.Enabled = true;
                btnSeleccionarLibro.Enabled = true;

            }
            else
            {
                txtLibro.Enabled = false;
                txtLibro.Enabled = false;
                btnRecibir.Enabled = false;
                btnSeleccionarLector.Enabled = false;
                btnSeleccionarLibro.Enabled = false;
            }
        }
        private void frmAlquileresCRUD_Load(object sender, EventArgs e)
        {
            enable();
        }
        Alquileres alqu = new Alquileres();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                alqu.Id_Lector = idLector;
                alqu.Id_libro = IdLibro;
                alqu.Entregado = idAdmin;
                alqu.fecha_salida = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                DateTime fecha = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                alqu.fecha_prevista_de_entrega = fecha.AddDays(8);
                db.Alquileres.Add(alqu);
                db.SaveChanges();
                frmPrincipal.prestamos.CargarDatos();
                txtLector.Text = "";
                txtLibro.Text = "";
                idLector = 0;
                IdLibro = 0;
                this.Close();
            }
        }
    }
}
