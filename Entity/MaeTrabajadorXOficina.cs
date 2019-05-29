using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class MaeTrabajadorXOficina
    {
        public int IdTrabajador { get; set; }

        public string IdOficina { get; set; }
        public string FLGActivo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string observacion { get; set; }

    }
}
