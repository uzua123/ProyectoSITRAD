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
    public partial class FrmListDocumentType : Form
    {
        TipoDocumentoController objTipoDocController = new TipoDocumentoController();


        public FrmListDocumentType()
        {
            InitializeComponent();
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            var m = new FrmModal();
            m.lblTitle.Text = "Agregar Nuevo Tipo Documento";
            m.btnGuardar.Text = "Guardar Datos";
            m.lblEstado.Visible = false;
            m.chkEstatus.Visible = false;
            m.ShowDialog();
            objTipoDocController.VerLista(dgvDataList);
        }

        private void FrmListDocumentType_Load(object sender, EventArgs e)
        {
            //TipoDocumentoController obj = new TipoDocumentoController();
            //dgvDataList.DataSource = obj.View();
            var obj = new TipoDocumentoController();

            obj.VerLista(dgvDataList);
            
            lblTotal.Text = "Total de registros: " + Convert.ToString(dgvDataList.Rows.Count);


        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Tramite Documentario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dgvDataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == dgvDataList.Columns[4].Index)
                {
                    var dato = new TipoDocumentoController();
                    var obj = FrmModal.GetInstancia();

                    obj.txtId.Text = Convert.ToString(this.dgvDataList.CurrentRow.Cells[0].Value);
                    obj.txtDescription.Text = Convert.ToString(this.dgvDataList.CurrentRow.Cells[1].Value);
                    obj.txtSigla.Text = Convert.ToString(this.dgvDataList.CurrentRow.Cells[2].Value);
                    if (this.dgvDataList.CurrentRow.Cells[3].Value.ToString()=="1")
                    {
                        obj.chkEstatus.Checked = true;
                    }
                    else
                    {
                        obj.chkEstatus.Checked = false;
                    }
                    obj.lblTitle.Text = "Actualizar Tipo Documento";
                    obj.btnGuardar.Text = "Actualizar";
                    obj.ShowDialog();
                    dato.VerLista(dgvDataList);
                }
                if (e.ColumnIndex == dgvDataList.Columns[5].Index)
                {
                    DialogResult r = MessageBox.Show("Esta seguro que desea eliminar el registro?\n\n\t*" + Convert.ToString(this.dgvDataList.CurrentRow.Cells[1].Value), "Sistema de Tramite Documentario",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    
                    if (r == DialogResult.OK)
                    {
                        int tipo_id = int.Parse(dgvDataList.Rows[e.RowIndex].Cells[0].Value.ToString());
                        TipoDocumentoController objCon = new TipoDocumentoController();
                        GenmTipoDocumentoEntity objEnt = new GenmTipoDocumentoEntity();
                        objEnt.IdTipoDocumento = tipo_id;
                        objCon.Delete(objEnt);

                        dgvDataList.Rows.RemoveAt(e.RowIndex);


                        MensajeOk("El registro ha sido eliminado correctamente.");
                        objCon.VerLista(dgvDataList);
                    }
                    else
                    {
                        //MessageBox.Show("Cancelando Operacion");
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            var dato = new TipoDocumentoController();

            if (txtSearch.Text.Trim().Length > 0)
            {
                dato.SearchTipoDocumento(dgvDataList, txtSearch.Text );

            }
            else
            {
                dato.VerLista(dgvDataList);
            }

            //this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dgvDataList.Rows.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
