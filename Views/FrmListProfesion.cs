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

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Tramite Documentario", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
          
            var objModal = new FrmModalProfesional();
            objModal.lblTitle.Text = "Agregar Nuevo Profesion";
            objModal.btnGuardar.Text = "Guardar Datos";
            string idTabla = Convert.ToString(this.dgvDataList.CurrentRow.Cells[0].Value);
            objModal.txtId.Text = idTabla;
            objModal.ShowDialog();
            objCon.ViewListProfesional(dgvDataList,objEnt);

        }

        private void DgvDataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                if (e.ColumnIndex==dgvDataList.Columns[7].Index)
                {
                    var objContMultTbl = new MultiTablaController();
                    var objEntMultTbl = new RcdMultiTablaEntity();
                    var objModal =FrmModalProfesional.GetInstancia();

                    objModal.txtId.Text = Convert.ToString(dgvDataList.CurrentRow.Cells[0].Value);
                    objModal.txtIdDetalle.Text = Convert.ToString(dgvDataList.CurrentRow.Cells[2].Value);
                    objModal.txtProfesion.Text=Convert.ToString( dgvDataList.CurrentRow.Cells[4].Value);

                    objModal.lblTitle.Text = "Actualizar Profesion";
                    objModal.btnGuardar.Text = "&Actualizar";
                    objEntMultTbl.IdTabla = 3;
                    objModal.ShowDialog();
                    objContMultTbl.ViewListProfesional(dgvDataList,objEntMultTbl);
                }
                else if (e.ColumnIndex==dgvDataList.Columns[8].Index)
                {
                    DialogResult r = MessageBox.Show("Esta seguro que desea eliminar el registro?\n\n\t*" + Convert.ToString(this.dgvDataList.CurrentRow.Cells[4].Value), "Sistema de Tramite Documentario",
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (r==DialogResult.OK)
                    {
                        int idTabla =int .Parse( dgvDataList.CurrentRow.Cells[0].Value.ToString());

                        RcdMultiTablaEntity objEnt = new RcdMultiTablaEntity();

                        objEnt.IdTabla = int.Parse(dgvDataList.CurrentRow.Cells[0].Value.ToString());
                        objEnt.IdTablaDetalle = int.Parse(dgvDataList.CurrentRow.Cells[2].Value.ToString());

                        objCon.Delete(objEnt);

                        dgvDataList.Rows.RemoveAt(e.RowIndex);

                        MensajeOk("El registro ha sido eliminado con Exito.");


                        lblTotal.Text = "Total de registros: " + Convert.ToString(dgvDataList.Rows.Count);
                    }
                }
            }
        }
    }
}
