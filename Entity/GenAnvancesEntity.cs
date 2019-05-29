using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class GenAnvancesEntity
    {
        public int IdAvance { get; set; }
        public int IdDocumento { get; set; }
        public int IdSecuencial { get; set; }
        public int IdTrabajador { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuModificacion { get; set; }
    }
}
