using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.formularios.principales;
using AdminLabrary.Model;


namespace AdminLabrary.View.principales
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';

        }

        public static frmPrincipal f = new frmPrincipal();
        public void btnIniciarsesion_Click(object sender, EventArgs e)

        {

            string u = txtUsuario.Text;

            using (BibliotecaprogramEntities db = new BibliotecaprogramEntities())
            {
                var lista = from admin in db.Roles
                            where admin.Usuario == txtUsuario.Text
                            && admin.Contraseña == txtContraseña.Text
                            && admin.estado == 0
                            && admin.Rol ==1

                            select new
                            {
                                ID = admin.Id_rol,
                                Nombre = admin.Usuario,
                                contaseña = admin.Contraseña
                            };


                if (lista.Count() > 0)
                {

                    string usu = txtUsuario.Text;
                    f.lblUsuarioARecibir.Text = usu;
                    foreach (var i in lista)
                    {
                        frmPrincipal.prestamos.alquiler.idAdmin = i.ID;
                    }
                    f.ShowDialog();
                    this.Close();

                }
                else
                {
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";

                    MessageBox.Show("Usuario o contraseña incorrecto", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
