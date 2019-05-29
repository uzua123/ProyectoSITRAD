using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class MaeEmpresaEntity
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string FLGPersona { get; set; }
        public string Ruc { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string PaginaWeb { get; set; }
        public string FLGProveedor { get; set; }
        public int IdEmpresaPadre { get; set; }
        public string FLGTipoEmpresa { get; set; }
        public string TipoEmpresa { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public int IdContribuyente { get; set; }
    }
}
