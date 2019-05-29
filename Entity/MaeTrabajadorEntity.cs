using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class MaeTrabajadorEntity
    {
        public int IdTrabajador { get; set; }
        public string CodTrabajador { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Ruc { get; set; }
        public string Domicilio { get; set; }
        public int IdProfesion { get; set; }
        public string Profesion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string IdSituacionConyuge { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaCese { get; set; }
        public string FLGActivo { get; set; }
        public string Login { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
