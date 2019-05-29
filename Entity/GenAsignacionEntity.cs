using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class GenAsignacionEntity
    {
        public int IdTrabajador { get; set; }
        public int IdSecuencial { get; set; }
        public int IdDocumento { get; set; }
        public int IdCorrelativo { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime FechaAceptacion { get; set; }
        public DateTime FechaRespuesta { get; set; }
        public string IdEstadoAsignacion { get; set; }
        public string ObsAsignar { get; set; }
        public string ObsResponder { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public string FechaModificacion { get; set; }
        public string FLGEstado { get; set; }
        public string FLGRecibido { get; set; }
    }
}
