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
        {using (BibliotecaEntities1 db = new BibliotecaEntities1())
            {
                var lista = from pre in db.Alquileres
                            from li in db.Libros
                            from le in db.Lectores
                            where pre.Id_Lector == le.Id_Lector
                            && pre.Id_libro == li.Id_libro
                            select new    {
                                    ID = pre.Id_alquiler,
                                    Lector = le.Nombres,
                                    Libro = li.Nombre,
                                    Entregado = pre.Entregado,
                                    Fecha_salida = pre.fecha_salida,
                                    Fecha_prevista_Entrega = pre.fecha_prevista_de_entrega,
                                    Fecha_entrega = pre.fecha_de_entrega,
                                    Recibido = pre.Recibido
                                };





                dgvPrestamos.DataSource = lista.ToList();


            }

        }
    }
}
