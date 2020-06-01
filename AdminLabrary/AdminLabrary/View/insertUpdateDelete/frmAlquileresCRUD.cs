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
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace AdminLabrary.View.insertUpdateDelete
{
    public partial class frmAlquileresCRUD : Form
    {
        public int IdEntregado;
        public int idAlquiler;
        public int IdLibro;
        public int idLector;
        public int idAdmin;
        public int cantidad;
        public int indicador = 1;
        public DateTime fecha_salida;
        public DateTime fecha_pre;
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
            lec.filtro();
            lec.ShowDialog();
        }
        void enable()
        {
            if (indicador == 1)
            {

                btnRecibir.Enabled = false;
                btnGuardar.Enabled = true;
                btnSeleccionarLector.Enabled = true;
                btnSeleccionarLibro.Enabled = true;

            }
            else
            {
                btnGuardar.Enabled = false;
                btnRecibir.Enabled = true;
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
              if (int.Parse(txtCantidad.Text) <= cantidad) {
                if (txtLector.Text != "" && txtLibro.Text != "" && int.Parse(txtCantidad.Text) > 0)
                {
                    using (BibliotecaprogramEntities db = new BibliotecaprogramEntities())
                    {
                        alqu.Id_Lector = idLector;
                        alqu.Id_libro = IdLibro;
                        alqu.Entregado = idAdmin;
                        alqu.cantidad = int.Parse(txtCantidad.Text);
                        alqu.fecha_salida = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                        DateTime fecha = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                        alqu.fecha_prevista_de_entrega = fecha.AddDays(8);
                        db.Alquileres.Add(alqu);
                        db.SaveChanges();
                        frmPrincipal.prestamos.CargarDatos();
                        txtLector.Text = "";
                        txtLibro.Text = "";
                        IdEntregado = 0;
                        idAlquiler = 0;
                        IdLibro = 0;
                        idLector = 0;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(idAdmin.ToString() + idLector.ToString() + IdLibro.ToString());
                }
            }
            else
            {
                MessageBox.Show("La cantidad ingresada sobrepasa al limite permitido.\r" +
                    "El limite es: "+cantidad.ToString());
            }
           
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            using (BibliotecaprogramEntities db = new BibliotecaprogramEntities())
            {
                if (int.Parse(txtCantidad.Text) > cantidad || int.Parse(txtCantidad.Text) > 0)
                {
                    MessageBox.Show("Cantidad incorrecta");
                }
                else if (int.Parse(txtCantidad.Text) < cantidad && int.Parse(txtCantidad.Text)>0)
                {
                    alqu = db.Alquileres.Where(buscarID => buscarID.Id_alquiler == idAlquiler).First();
                    alqu.Id_Lector = idLector;
                    alqu.Id_libro = IdLibro;
                    alqu.cantidad = int.Parse(txtCantidad.Text);
                    alqu.Entregado = IdEntregado;
                    alqu.fecha_salida = fecha_salida;
                    alqu.fecha_prevista_de_entrega = fecha_pre;
                    alqu.fecha_de_entrega = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                    alqu.Recibido = idAdmin;
                    db.Entry(alqu).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    Alquileres alqui = new Alquileres();
                    alqui.Id_Lector = idLector;
                    alqui.Id_libro = IdLibro;
                    alqui.cantidad = cantidad -int.Parse(txtCantidad.Text);
                    alqui.Entregado = IdEntregado;
                    alqui.fecha_salida = fecha_salida;
                    alqui.fecha_prevista_de_entrega = fecha_pre;
                    db.Alquileres.Add(alqui);
                    db.SaveChanges();
                }
                else if (int.Parse(txtCantidad.Text) == cantidad && int.Parse(txtCantidad.Text) > 0)
                {
                    alqu = db.Alquileres.Where(buscarID => buscarID.Id_alquiler == idAlquiler).First();
                    alqu.Id_Lector = idLector;
                    alqu.Id_libro = IdLibro;
                    alqu.cantidad = int.Parse(txtCantidad.Text);
                    alqu.Entregado = IdEntregado;
                    alqu.fecha_salida = fecha_salida;
                    alqu.fecha_prevista_de_entrega = fecha_pre;
                    alqu.fecha_de_entrega = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                    alqu.Recibido = idAdmin;
                    db.Entry(alqu).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

               

            }
            limpiar();
            frmPrincipal.prestamos.CargarDatos();
            this.Close();
        }
        public void limpiar()
        {

            txtLector.Text = "";
            txtLibro.Text = "";
            txtCantidad.Text = "";
            IdEntregado = 0;
            idAlquiler = 0;
            IdLibro = 0;
            idLector = 0;
           

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
