using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class frmMDIMain : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public frmMDIMain()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        public void AbrirFormulario<MyForm>() where MyForm : Form, new()
        {
            Form formulario;
            formulario = sectionMain.Controls.OfType<MyForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MyForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                sectionMain.Controls.Add(formulario);
                sectionMain.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void frmMDIMain_Load(object sender, EventArgs e)
        {
        }
        int lx, ly;
        int sw, sh;


        private void btnOpcion1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<frmWindows2>();
            MostrarSolomenu();
        }

        private void MostrarSolomenu()
        {
            pTramiteDoc.Visible = false;
            pMantenimiento.Visible = false;
            pConsultas.Visible = false;
            pAdministrador.Visible = false;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int ancho = 296;
        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            //301; 605
            //301; 507
            //296; 605
            if (pMenu.Size.Width == ancho)
            {
                MostrarSolomenu();
                pMenu.Width = 62;

            }
            else
            {
                pMenu.Width = ancho;
            }
        }

        private void btnTramiDoc_Click(object sender, EventArgs e)
        {
            if (pTramiteDoc.Visible == true)
            {
                pTramiteDoc.Visible = false;
            }
            else
            {
                pMenu.Width = ancho;
                pTramiteDoc.Visible = true;
                pMantenimiento.Visible = false;
                pConsultas.Visible = false;
                pAdministrador.Visible = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pMantenimiento.Visible == true)
            {
                pMantenimiento.Visible = false;
            }
            else
            {
                pMenu.Width = ancho;
                pTramiteDoc.Visible = false;
                pMantenimiento.Visible = true;
                pConsultas.Visible = false;
                pAdministrador.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pConsultas.Visible == true)
            {
                pConsultas.Visible = false;
            }
            else
            {
                pMenu.Width = ancho;
                pTramiteDoc.Visible = false;
                pMantenimiento.Visible = false;
                pConsultas.Visible = true;
                pAdministrador.Visible = false;
            }
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            if (pAdministrador.Visible == true)
            {
                pAdministrador.Visible = false;
            }
            else
            {
                pMenu.Width = ancho;
                pTramiteDoc.Visible = false;
                pMantenimiento.Visible = false;
                pConsultas.Visible = false;
                pAdministrador.Visible = true;
            }
        }

<<<<<<< HEAD
        private void btnIngresoDocumentos_Click(object sender, EventArgs e)
        {
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
=======
      
>>>>>>> origin/master

        private void btnNormal_Click_1(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximize.Visible = true;
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnNormal.Visible = true;
            btnMaximize.Visible = false;
        }
    }
}
