using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class GenmDocumentoEntity
    {
        public int IdDocumento { get; set; }
        public int IdAno { get; set; }
        public int IdRemitenteE { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public DateTime FechaDocumento { get; set; }
        public string Asunto { get; set; }
        public string IdDestinoE { get; set; }
        public string IdEstado { get; set; }
        public string Tipo { get; set; }
        public string IdRemitenteI { get; set; }
        public string IdDestinoI { get; set; }
        public string Observacones { get; set; }
        public string IdNroDocumento { get; set; }
        public string FLGSalida { get; set; }
        public string FLGAnulado { get; set; }
        public string ObsAnulado { get; set; }
        public string AnuladoPor { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string FLGTupa { get; set; }
        public int IdTupa { get; set; }
        public string ClaveWeb { get; set; }
        public string Folios { get; set; }
        public string Remitente { get; set; }
        public int IdCorrelTipoDoc { get; set; }
        public int Plazo { get; set; }
        public int Reservado { get; set; }
        public string NombreRemitente { get; set; }
        public int IdDocPadre { get; set; }
        public string NumDocPadre { get; set; }
        public string FLGAnexo { get; set; }
        public int NumAnexo { get; set; }
        public int FoliosAcumulados { get; set; }
        public string FLGAcumulado { get; set; }
        public string TipoTramite { get; set; }
    }
}
