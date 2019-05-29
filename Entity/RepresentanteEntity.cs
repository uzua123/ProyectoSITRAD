using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class RepresentanteEntity
    {
        public int IdRepresentante { get; set; }
        public int IdCliente { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Nombre { get; set; }
        public string NumDocumento { get; set; }
        public int IdDocumento { get; set; }
        public int FLGReoLegal { get; set; }
        public int FLGEstado { get; set; }
        public string Email { get; set; }
    }
}
