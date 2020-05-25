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
using AdminLabrary.View.insertUpdateDelete;

namespace AdminLabrary.View.principales
{
    public partial class frmPrestamos : Form
    {
        public frmPrestamos()
        {
            InitializeComponent();
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {using (BibliotecaEntities4 db = new BibliotecaEntities4())
            {
                var lista = from pre in db.Alquileres
                            from li in db.Libros
                            from le in db.Lectores
                            from ad in db.Administradores
                            where pre.Id_Lector == le.Id_Lector
                            && pre.Id_libro == li.Id_libro
                            && pre.Entregado == ad.Id_Admin
                            && pre.Recibido == null
                         


                            select new    
                            {
                                    ID = pre.Id_alquiler,
                                    Lector = le.Nombres,
                                    Libro = li.Nombre,
                                    Entregado = ad.Usuario,
                                    Fecha_salida = pre.fecha_salida,
                                    Fecha_prevista_Entrega = pre.fecha_prevista_de_entrega,
                                    
                                };





                dgvPrestamos.DataSource = lista.ToList();


            }

        }

        public  frmAlquileresCRUD alquiler = new frmAlquileresCRUD();
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            alquiler.ShowDialog();
        }
    }
}
