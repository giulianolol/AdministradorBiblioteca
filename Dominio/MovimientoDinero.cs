using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class MovimientoDinero
    {
        public DateTime Dia { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
    }
}
