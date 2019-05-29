using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class GenmDocAdjuntoEntity
    {
        public int IdDocAdjunto { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Asunto { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaAdjunto { get; set; }
    }
}
