using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (p_menu.Visible == true)
            {
                p_menu.Visible = false;
            }
            else
            {
                p_menu.Visible = true;
            }
        }

        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            if (p1.Visible == true)
            {
                p1.Visible = false;
            }
            else
            {
                p1.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (p2.Visible == true)
            {
                p2.Visible = false;
            }
            else
            {
                p2.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (p3.Visible == true)
            {
                p3.Visible = false;
            }
            else
            {
                p3.Visible = true;
            }
        }
    }
}
