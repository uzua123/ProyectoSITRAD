using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD:Controllers/TipoDocumentoController.cs
using Entity;
=======

>>>>>>> origin/master:Controllers/TipoDocumentoController.cs
using Models;

namespace Controllers
{
   public class TipoDocumentoController
    {
        TipoDocumentoModel objTypeDocModel = new TipoDocumentoModel();

        public DataTable View()
        {
            return objTypeDocModel.View();
        }
        public void VerLista(DataGridView data)
        {
            Models.TipoDocumentoModel tipo = new TipoDocumentoModel();
            tipo.ListTipoDocumentPorDataGriview(data);

        }
        public void Add(GenmTipoDocumentoEntity objEnt)
        {
            objTypeDocModel.Add(objEnt);
        }

        public void Update(GenmTipoDocumentoEntity obj)
        {
            objTypeDocModel.Update(obj);
        }

        public void Delete(GenmTipoDocumentoEntity obj)
        {
            objTypeDocModel.Delete(obj);
        }

        public DataTable SearchId(GenmTipoDocumentoEntity objTipDocEnt)
        {
            return objTypeDocModel.SearchId(objTipDocEnt);
        }

        public void SearchTipoDocumento(DataGridView dgv, string textoBuscar)
        {

            GenmTipoDocumentoEntity objEnt = new GenmTipoDocumentoEntity();
            objEnt.Descripcion = textoBuscar;
            objTypeDocModel.SearchTipoDocumentoDescripcion(dgv, objEnt);

        }
    }
}
