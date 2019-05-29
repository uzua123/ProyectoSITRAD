using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class RcdMultiTablaEntity
    {
        public int IdTabla { get; set; }

        public int IdTablaDetalle { get; set; }
        public int Valor1 { get; set; }
        public string Descripcion1 { get; set; }
        public int Valor2 { get; set; }
        public string Descripcion2 { get; set; }
    }
}
