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
using Controllers;



namespace Views
{
    public partial class FrmModalProfesional : Form
    {
        MultiTablaController objContMultiTbl = new MultiTablaController();
        public FrmModalProfesional()
        {
            InitializeComponent();
        }
        private static FrmModalProfesional _Instancia;
        public static FrmModalProfesional GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FrmModalProfesional();
            }
            return _Instancia;
            
        }

        string ValidationTextbox()
        {
            if (this.txtProfesion.Text.Trim().Length==0)
            {
                return "Ingrese la profesion.";
            }
            //else if (this.txtAbreviatura.Text.Trim().Length==0)
            //{
            //    return "Ingrese la Abreviatura.";
            //}
            else {
                return "";
            }
        }

        void ClearCampus()
        {
            this.txtProfesion.Text = string.Empty;
            this.txtAbreviatura.Text = string.Empty;
        }

        void MessageOk(string texto)
        {

            MessageBox.Show(texto, "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void MessageError(string texto)
        {
            MessageBox.Show(texto, "Mensaje Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModalProfesional_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (lblTitle.Text == "Agregar Nuevo Profesion")
            {
                if (this.ValidationTextbox() == "")
                {
                    RcdMultiTablaEntity objEnt = new RcdMultiTablaEntity();
                    objEnt.IdTabla = int.Parse(txtId.Text);
                    objEnt.Descripcion1 = txtProfesion.Text;
                    //objEnt.Descripcion2 = txtAbreviatura.Text;

                    try
                    {
                        objContMultiTbl.Add(objEnt);
                        MessageOk("La Profesion ha sido registrado correctamente.");
                        ClearCampus();

                    }
                    catch (Exception)
                    {


                    }

                }
                else
                {
                    MessageError(ValidationTextbox());
                }

            }
            else if (lblTitle.Text == "Actualizar Profesion")
            {
                if (this.ValidationTextbox() == "")
                {
                    RcdMultiTablaEntity objEnt = new RcdMultiTablaEntity();
                    objEnt.IdTabla = int.Parse(txtId.Text);
                    objEnt.IdTablaDetalle = int.Parse(txtIdDetalle.Text);
                    objEnt.Descripcion1 = txtProfesion.Text;
                    //objEnt.Descripcion2 = txtAbreviatura.Text;
                   
                    try
                    {
                        objContMultiTbl.Update(objEnt);
                        MessageOk("La Profesion ha sido actualizado correctamente.");
                        //ClearCampus();
                        this.Close();

                    }
                    catch (Exception)
                    {


                    }

                }
                else
                {
                    MessageError(ValidationTextbox ());
                }

            }
        }
    }
}
