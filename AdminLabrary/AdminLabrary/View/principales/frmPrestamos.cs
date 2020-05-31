using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.formularios.principales;
using AdminLabrary.Model;
using AdminLabrary.View.buscar;
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
            rbtnLector.Checked = true;
            CargarDatos();
        }

        public void CargarDatos()
        {
            dgvPrestamos.Rows.Clear();
            using (BibliotecaprogramEntities db = new BibliotecaprogramEntities())
            {
                if (rbtnLector.Checked == true)
                {
                    string buscar = txtBuscar.Text;
                    var lista = from pre in db.Alquileres
                                from li in db.Libros
                                from le in db.Lectores
                                from ad in db.Roles
                                where pre.Id_Lector == le.Id_Lector
                                && pre.Id_libro == li.Id_libro
                                && pre.Entregado == ad.Id_rol
                                && pre.Recibido == null
                                && le.Nombres.Contains(buscar)


                                select new
                                {
                                    ID = pre.Id_alquiler,
                                    Lector = le.Nombres,
                                    Libro = li.Nombre,
                                    Cantidad =pre.cantidad,
                                    Entregado = ad.Usuario,
                                    Fecha_salida = pre.fecha_salida,
                                    Fecha_prevista_Entrega = pre.fecha_prevista_de_entrega,
                                    IDLector = pre.Id_Lector,
                                    IDLibro = pre.Id_libro,
                                    IDEntregado = pre.Entregado
                                };

                    foreach (var i in lista)
                    {
                        dgvPrestamos.Rows.Add(i.ID, i.Lector, i.Libro,i.Cantidad, i.Entregado, i.Fecha_salida, i.Fecha_prevista_Entrega, i.IDLector, i.IDLibro, i.IDEntregado);

                    }
                }
                else if (rbtnLibro.Checked == true)
                {
                    {
                        string buscar = txtBuscar.Text;
                        var lista = from pre in db.Alquileres
                                    from li in db.Libros
                                    from le in db.Lectores
                                    from ad in db.Roles
                                    where pre.Id_Lector == le.Id_Lector
                                    && pre.Id_libro == li.Id_libro
                                    && pre.Entregado == ad.Id_rol
                                    && pre.Recibido == null
                                    && li.Nombre.Contains(buscar)


                                    select new
                                    {
                                        ID = pre.Id_alquiler,
                                        Lector = le.Nombres,
                                        Libro = li.Nombre,
                                        Cantidad = pre.cantidad,
                                        Entregado = ad.Usuario,
                                        Fecha_salida = pre.fecha_salida,
                                        Fecha_prevista_Entrega = pre.fecha_prevista_de_entrega,
                                        IDLector = pre.Id_Lector,
                                        IDLibro = pre.Id_libro,
                                        IDEntregado = pre.Entregado
                                    };

                        foreach (var i in lista)
                        {
                            dgvPrestamos.Rows.Add(i.ID, i.Lector, i.Libro, i.Cantidad, i.Entregado, i.Fecha_salida, i.Fecha_prevista_Entrega, i.IDLector, i.IDLibro, i.IDEntregado);

                        }
                    }
                }
                else if (rbtnAdministrador.Checked == true)
                {
                    {
                        string buscar = txtBuscar.Text;
                        var lista = from pre in db.Alquileres
                                    from li in db.Libros
                                    from le in db.Lectores
                                    from ad in db.Roles
                                    where pre.Id_Lector == le.Id_Lector
                                    && pre.Id_libro == li.Id_libro
                                    && pre.Entregado == ad.Id_rol
                                    && pre.Recibido == null
                                    && ad.Usuario.Contains(buscar)


                                    select new
                                    {
                                        ID = pre.Id_alquiler,
                                        Lector = le.Nombres,
                                        Libro = li.Nombre,
                                       Cantidad = pre.cantidad,
                                        Entregado = ad.Usuario,
                                        Fecha_salida = pre.fecha_salida,
                                        Fecha_prevista_Entrega = pre.fecha_prevista_de_entrega,
                                        IDLector = pre.Id_Lector,
                                        IDLibro = pre.Id_libro,
                                        IDEntregado = pre.Entregado
                                    };

                        foreach (var i in lista)
                        {
                            dgvPrestamos.Rows.Add(i.ID, i.Lector, i.Libro, i.Cantidad, i.Entregado, i.Fecha_salida, i.Fecha_prevista_Entrega, i.IDLector, i.IDLibro, i.IDEntregado);

                        }
                    }

                }
            }

        }

        public frmAlquileresCRUD alquiler = new frmAlquileresCRUD();
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            alquiler.limpiar();
            alquiler.txtCantidad.Enabled = true;
            btnRecibir.Enabled = false;
            alquiler.indicador = 1;
            alquiler.ShowDialog();

        }

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRecibir.Enabled = true;
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            alquiler.txtCantidad.Enabled = true;
            alquiler.txtLector.Text = dgvPrestamos.CurrentRow.Cells[1].Value.ToString();
            alquiler.idLector = int.Parse(dgvPrestamos.CurrentRow.Cells[7].Value.ToString());
            alquiler.txtLibro.Text = dgvPrestamos.CurrentRow.Cells[2].Value.ToString();
            alquiler.txtCantidad.Text = dgvPrestamos.CurrentRow.Cells[3].Value.ToString();
            alquiler.cantidad = int.Parse(dgvPrestamos.CurrentRow.Cells[3].Value.ToString());
            alquiler.IdLibro = int.Parse(dgvPrestamos.CurrentRow.Cells[8].Value.ToString());
            alquiler.IdEntregado = int.Parse(dgvPrestamos.CurrentRow.Cells[9].Value.ToString());
            alquiler.fecha_salida = Convert.ToDateTime(dgvPrestamos.CurrentRow.Cells[5].Value.ToString());
            alquiler.fecha_pre = Convert.ToDateTime(dgvPrestamos.CurrentRow.Cells[5].Value.ToString());
            alquiler.idAlquiler = int.Parse(dgvPrestamos.CurrentRow.Cells[0].Value.ToString());
            alquiler.indicador = 2;
            alquiler.ShowDialog();
        }


        private void btnVer_Click(object sender, EventArgs e)
        {
            btnRecibir.Enabled = false;
            frmLogin.f.MostrarPanel(new frmBuscarAlquiler());
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnRetrazo_Click(object sender, EventArgs e)
        {
            btnRecibir.Enabled = false;
            frmLogin.f.MostrarPanel(new frmHistorial());
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
