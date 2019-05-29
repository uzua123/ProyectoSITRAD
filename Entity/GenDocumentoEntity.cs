using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class GenDocumentoEntity
    {
        public int IdDocumento { get; set; }
        public int IdCorrelativo { get; set; }
        public DateTime FechaDerivacion { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public string FLGRecibido { get; set; }
        public string ObsAlEnviar { get; set; }
        public string ObsAlRecibir { get; set; }
        public string FLGSalida { get; set; }
        public string IdEstado { get; set; }
        public int IdTipoDocumento { get; set; }
        public string DocAdjuntado { get; set; }
        public int IdRemitenteE { get; set; }
        public string IdRemitenteI { get; set; }
        public string IdDestinoE { get; set; }
        public string IdDestinoI { get; set; }
        public string Tipo { get; set; }
        public int IdCorrelOrigen { get; set; }
        public string Prioridad { get; set; }
        public DateTime FechaEnvio { get; set; }
        public DateTime FechaArchivo { get; set; }
        public string ObsAlArchivar { get; set; }
        public string UbicArchivo { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string DocAdjArchivar { get; set; }
        public int IdTipoDocArchivar { get; set; }
        public string Via { get; set; }
        public int Cargo { get; set; }
    }
}
