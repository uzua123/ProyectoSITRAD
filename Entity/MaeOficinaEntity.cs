using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class MaeOficinaEntity
    {
        public string IdOficina { get; set; }
        public string Descripcion { get; set; }
        public int Idjefe { get; set; }
        public string IdoficinaSup { get; set; }
        public string Sigla { get; set; }
        public string SiglaDocumento { get; set; }
        public string FLGActivo { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int IdGerencia { get; set; }
        public int IdSubGerencia { get; set; }
    }
}
