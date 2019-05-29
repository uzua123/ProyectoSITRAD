using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Entity;
using Controllers;
namespace Views
{
    public partial class FrmListCorrelative : Form
    {
        CorrelativoController objCont = new CorrelativoController();
        GenmExpedientesEntity objEnt = new GenmExpedientesEntity();

        public FrmListCorrelative()
        {
            InitializeComponent();
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Tramite Documentario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmListCorrelative_Load(object sender, EventArgs e)
        {
            var obj = new CorrelativoController();
            RcdMultiTablaEntity ent = new RcdMultiTablaEntity();
            obj.View(dgvDataList);

            lblTotal.Text = "Total de Registros: "+Convert.ToString(dgvDataList.Rows.Count);

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var objModal = new FrmModalCorrelativo();
            objModal.lblTitle.Text = "Agregar  Nuevo Correlativo";
            objModal.btnGuardar.Text = "Guardar Datos";
            objModal.ShowDialog();
            objCont.View(dgvDataList);
        }
    }
}
