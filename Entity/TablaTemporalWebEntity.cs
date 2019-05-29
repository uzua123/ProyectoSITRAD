using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class TablaTemporalWebEntity
    {
        public int IdDocumento { get; set; }
        public int IdCorrelativo { get; set; }
        public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public DateTime FechaEnvio { get; set; }
        public int IdRemitente { get; set; }
        public string Remitente { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public string Asunto { get; set; }
        public string Expediente { get; set; }
        public int IdDesde { get; set; }
        public string Desde { get; set; }
        public int IdHacia { get; set; }
        public string Hacia { get; set; }
        public string Tipo { get; set; }
        public string IdEstado { get; set; }
        public string Estado { get; set; }
        public DateTime FechaDerivacion { get; set; }
        public DateTime FechaRecibido { get; set; }
        public DateTime FechaArchivado { get; set; }
        public string DocAdjuntado { get; set; }
        public int IdTrabajador { get; set; }
        public string IdEstadoAsignacion { get; set; }
        public string Trabajador { get; set; }
        public string IbsAlEnviar { get; set; }
        public string ObsAlEnviar { get; set; }
        public string ObsAlArchivar { get; set; }
        public string UbicArchivo { get; set; }
        public int Avances { get; set; }
    }
}
