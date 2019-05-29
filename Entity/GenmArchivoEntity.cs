using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class GenmArchivoEntity
    {
        public int IdDocumento { get; set; }
        public string Nombre { get; set; }

        public byte[] Imagen { get; set; }
    }
}
