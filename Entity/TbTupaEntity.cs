using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class TbTupaEntity
    {
        public int IdTupa { get; set; }
        public string CodTupa { get; set; }
        public string NomTupa { get; set; }
        public int IdPartida { get; set; }
        public decimal PorcentajeUitTupa { get; set; }
        public decimal ValorTupa { get; set; }
        public int IdTipoRubro { get; set; }
        public int EstadoTupa { get; set; }
        public string CCId { get; set; }
        public int AnnoCCTupa { get; set; }
        public int IdArea { get; set; }
        public int IdGerencia { get; set; }
        public int IdSubGerencia { get; set; }
        public int IdJefatura { get; set; }
        public string Descripcion { get; set; }
        public int DiasRespuesta { get; set; }
        public int FlagHabiles { get; set; }
        public string TipoRespuesta { get; set; }
    }
}
