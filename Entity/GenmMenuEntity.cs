using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class GenmMenuEntity
    {
        public int IdMenu { get; set; }
        public string Descripcion { get; set; }
        public string UsuIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string UsuModifica { get; set; }
        public DateTime FechaModifica { get; set; }
        public int IdPadre { get; set; }
        public string Orden { get; set; }
        public string Url { get; set; }
    }
}
