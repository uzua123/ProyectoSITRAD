using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

using Entity;
using Models;

namespace Controllers
{
  public  class MultiTablaController
    {
        MultiTablaModel objModel = new MultiTablaModel();

        public void View(DataGridView dgv)
        {
            //return objModel.View();
            MultiTablaModel om = new MultiTablaModel();
            om.ListMultiTablaPorDataGridView(dgv);
        }



        public void Add(RcdMultiTablaEntity obj)
        {
            objModel.Add(obj);
        }

        public void Update(RcdMultiTablaEntity obj)
        {
            objModel.Update(obj);
        }

        public void Delete(RcdMultiTablaEntity obj)
        {
            objModel.Delete(obj);
        }


        public void ViewListProfesional(DataGridView dgv, RcdMultiTablaEntity obj)
        {
            RcdMultiTablaEntity objent = new RcdMultiTablaEntity();

            //objent.IdTabla = obj;
            //objent.IdTablaDetalle = idtabladetalle;
            objModel.ListMultiTablaPorIdTabla(dgv, obj);
        }
    }
}
