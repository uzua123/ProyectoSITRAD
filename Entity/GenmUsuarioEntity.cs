using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class GenmUsuarioEntity
    {
        public string IdUsuario { get; set; }
        public int IdSistema { get; set; }
        public string Nombre { get; set; }
        public int idTrabajador { get; set; }
        public string Clave { get; set; }
        public string UsuIngreso { get; set; }
        public string UsuModifca { get; set; }
        public DateTime FechaModifica { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
