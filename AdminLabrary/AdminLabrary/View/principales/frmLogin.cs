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


namespace AdminLabrary.View.principales
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '#';
          
        }

        public void btnIniciarsesion_Click(object sender, EventArgs e)
           
        {
            
        string u = txtUsuario.Text;

            using (BibliotecaEntities1 db = new BibliotecaEntities1())
            {
                var lista = from admin in db.Administradores
                            where admin.Usuario == txtUsuario.Text
                            && admin.Contraseña == txtContraseña.Text
                            select admin;
                if (lista.Count() > 0)
                {
                    frmPrincipal f = new frmPrincipal();
                    string usu = txtUsuario.Text;
                    f.lblUsuarioARecibir.Text = usu;
                    f.ShowDialog();
                   
                    this.Hide();

                }
                else
                {
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";

                    MessageBox.Show("Usuario o contraseña incorrecto","Notificacion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }


            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
