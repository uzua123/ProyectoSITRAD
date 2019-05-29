using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class GenDocTupaRequisitoEntity
    {
        public int IdDocumento { get; set; }
        public int IdTupa { get; set; }
        public int IdRequisito { get; set; }
        public int Presento { get; set; }
        public string Descripcion { get; set; }
        public string UsuIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string UsuModifica { get; set; }
        public DateTime FechaModifica { get; set; }
    }
}
