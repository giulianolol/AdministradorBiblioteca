using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Movimiento
    {
        public int Id { get; set; }
        public DateTime Dia { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
    }
}
