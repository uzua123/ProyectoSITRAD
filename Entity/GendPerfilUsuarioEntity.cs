using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class GendPerfilUsuarioEntity
    {
        public string IdUsuario { get; set; }
        public int IdPerfil { get; set; }
        public int IdSistema { get; set; }
        public string UsuIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string UsuModifica { get; set; }
        public string FechaModifica { get; set; }
    }
}
