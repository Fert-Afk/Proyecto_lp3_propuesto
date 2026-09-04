using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaVentas
{
    internal class Producto
    {
        public int stockInicial = 0;
        public string nombre { get; set; }
        public double precio { get; set; }
        public string marca { get; set; }
        public int cantidad { get; set; }
        public int stock { get; set; }
    }
}
