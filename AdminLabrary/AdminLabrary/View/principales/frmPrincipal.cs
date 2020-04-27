
using AventStack.ExtentReports.Gherkin.Model;
using System;



using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AdminLabrary.View.principales;

namespace AdminLabrary.formularios.principales
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            frmLogin f = new frmLogin();

            
          
          
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            

            MostrarPanel(new frmAutor());
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
   

        public void MostrarPanel(Form Panel)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = Panel;
            Panel.TopLevel = false;
            Panel.FormBorderStyle = FormBorderStyle.None;
            Panel.Dock = DockStyle.Fill;
            pPrincipal.Controls.Add(Panel);
            pPrincipal.Tag = Panel;
            Panel.BringToFront();
            Panel.Show();
        }

      
        private void btnProductos_Click(object sender, EventArgs e)
        {

            MostrarPanel(new frmEditoriales());
        
        }

      

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("¿Desea salir de la aplicacion?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (resu == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }


        int Boton = 0;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (Boton == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizar.Visible = true;
                btnMinimizar.Visible = true;
                Boton = 1;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMinimizar.Visible = true;
                btnMaximizar.Visible = true;
                Boton = 0;
            }

        }

        private void btnMinimizar_Click(object sender, EventArgs e)

        {
          
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int lParam, int v);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);


        }

        private void PanelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }


        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
         MostrarPanel(new frmAdministradores());
        }

       
        private void btnLectores_Click(object sender, EventArgs e)
        {

            MostrarPanel(new frmLectores());
           
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {

            MostrarPanel(new frmCat());
            
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
        

            MostrarPanel(new frmLibros());
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            MostrarPanel(new frmPrestamos());
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            MostrarPanel(new frmAutor());
        }

        int botonO = 0;
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (botonO == 0)
            {
                PanelMenu.Hide();
                botonO = 1;
           
            }
            else
            {
                PanelMenu.Show();
                botonO = 0;
            }

        }
    }

}


