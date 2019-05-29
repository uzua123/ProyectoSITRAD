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

using Entity;

namespace Views
{
    public partial class FrmListProfesion : Form
    {
        MultiTablaController objCon = new MultiTablaController();
        RcdMultiTablaEntity objEnt = new RcdMultiTablaEntity();
        public FrmListProfesion()
        {
            InitializeComponent();
        }

        private void FrmListProfesion_Load(object sender, EventArgs e)
        {
            var obj = new MultiTablaController();
            RcdMultiTablaEntity objent = new RcdMultiTablaEntity();
            objent.IdTabla = 3;
            obj.ViewListProfesional(dgvDataList,objent);

            lblTotal.Text = "Total de registros: " + Convert.ToString(dgvDataList.Rows.Count);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataGridView dgv;
            var objModal = new FrmModalProfesional();
            objModal.lblTitle.Text = "Agregar Nuevo Profesion";
            objModal.btnGuardar.Text = "Guardar Datos";
            objEnt.IdTabla = 3;
            objModal.ShowDialog();
            objCon.ViewListProfesional(dgvDataList,objEnt);

        }
    }
}
