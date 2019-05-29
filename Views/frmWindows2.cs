using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;

namespace Views
{
    public partial class frmWindows2 : Form
    {

        public frmWindows2()
        {
            InitializeComponent();
            prueba_con tabla = new prueba_con();
            tabla.List(dataGridView1);
        }

        
    }
}
