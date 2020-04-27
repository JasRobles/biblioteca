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
        {using (BibliotecaEntities3 db = new BibliotecaEntities3())
            {
                var lista = from pre in db.Alquileres
                            from li in db.Libros
                            from le in db.Lectores
                            from ad in db.Administradores
                            from a in db.Administradores
                            where pre.Id_Lector == le.Id_Lector
                            && pre.Id_libro == li.Id_libro
                            && pre.Entregado == ad.Id_Admin
                            && pre.Recibido == a.Id_Admin


                            select new    {
                                    ID = pre.Id_alquiler,
                                    Lector = le.Nombres,
                                    Libro = li.Nombre,
                                    Entregado = ad.Usuario,
                                    Fecha_salida = pre.fecha_salida,
                                    Fecha_prevista_Entrega = pre.fecha_prevista_de_entrega,
                                    Fecha_entrega = pre.fecha_de_entrega,
                                    Recibido = a.Usuario
                                    
                                   
                                };





                dgvPrestamos.DataSource = lista.ToList();


            }

        }
    }
}
