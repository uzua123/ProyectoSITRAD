using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class DetDireccionEntity
    {
        public int IdDireccion { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoVia { get; set; }
        public string NomVia { get; set; }
        public string Numero { get; set; }
        public string Interior { get; set; }
        public string Urbanizacion { get; set; }
        public string IdUbigeo { get; set; }
        public string Zona { get; set; }
        public string Referencia { get; set; }
    }
}
