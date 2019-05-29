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
    public partial class FrmDocumentsList : Form
    {
        public FrmDocumentsList()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmModalDocuments doc = new FrmModalDocuments();
            doc.ShowDialog();
        }
    }
}
