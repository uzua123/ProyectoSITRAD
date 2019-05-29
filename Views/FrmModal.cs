using Controllers;
using Entity;
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
    public partial class FrmModal : Form
    {
        TipoDocumentoController objTipDoc = new TipoDocumentoController();
        public FrmModal()
        {
            InitializeComponent();
        }

        private static FrmModal _Instancia;
        public static FrmModal GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FrmModal();
            }
            return _Instancia;
        }

        //Validacion
        string Validation()
        {
            if (this.txtDescription.Text.Trim().Length==0)
            {
                return "Ingrese una Descripcion";
            }else
            if (this.txtSigla.Text.Trim().Length==0)
            {
                return "ingrese la Sigla";
            }
            else
            {
                return "";
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ClearCampus()
        {
            this.txtDescription.Text = string.Empty;
            this.txtSigla.Text = string.Empty;
        }

        void MessageConfirmation(string texto) {

            MessageBox.Show(texto,"Mensaje Confirmacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        void MessageError(string texto)
        {
            MessageBox.Show(texto, "Mensaje Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
            if (lblTitle.Text == "Agregar Nuevo Tipo Documento")
            {
                if (this.Validation() == "")
                {
                    GenmTipoDocumentoEntity objEnt = new GenmTipoDocumentoEntity();
                    // obj.IdTipoDocumento =int.Parse( txtId.Text);
                    objEnt.Descripcion = txtDescription.Text;
                    objEnt.Sigla = txtSigla.Text;

                    try
                    {
                        objTipDoc.Add(objEnt);
                        MessageConfirmation("El Tipo de Documento ha sido registrado correctamente.");
                        ClearCampus();

                    }
                    catch (Exception)
                    {


                    }

                }
                else
                {
                    MessageError(Validation());
                }

            }
            else if (lblTitle.Text == "Actualizar Tipo Documento")
            {
                if (this.Validation() == "")
                {
                    GenmTipoDocumentoEntity objEnt = new GenmTipoDocumentoEntity();
                    objEnt.IdTipoDocumento =int.Parse( txtId.Text);
                    objEnt.Descripcion = txtDescription.Text;
                    objEnt.Sigla = txtSigla.Text;
                       if (chkEstatus.Checked)
                    {
                        objEnt.Estado = "1";
                    }
                    else
                    {
                        objEnt.Estado = "0";
                    }

                    try
                    {
                        objTipDoc.Update(objEnt);
                        MessageConfirmation("El Tipo de Documento ha sido actualizado correctamente.");
                        //ClearCampus();
                        this.Close();

                    }
                    catch (Exception)
                    {


                    }

                }
                else
                {
                    MessageError(Validation());
                }

            }
        }
    }
}
