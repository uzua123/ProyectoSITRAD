using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Windows.Forms;

namespace Controllers
{
  public   class CorrelativoController
    {
        CorrelativoModel objModel = new CorrelativoModel();

        public void View(DataGridView dgv)
        {
            CorrelativoModel objModel = new CorrelativoModel();
            objModel.ListCorrelativoDataGridView(dgv);
        }

        public void Add(GenmExpedientesEntity objEnt)
        {
             objModel.Add(objEnt);
        }

        public void Update(GenmExpedientesEntity objEnt)
        {
            objModel.Update(objEnt);
        }


    }
}
