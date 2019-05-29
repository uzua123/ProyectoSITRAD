using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class DetTelefonoEntity
    {
        public int IdTelefono { get; set; }
        public int IdCliente { get; set; }
        public int IdDireccion { get; set; }

        public string Numero { get; set; }
        public string CodArea { get; set; }
        public string CodPais { get; set; }
        public string Anexo { get; set; }
        public string FLGTipo { get; set; }
    }
}
