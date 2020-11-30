using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Entities
{
    public class Cuadrilatero
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }


        public double CalcularArea()
        {
            double a = (LadoA * LadoB);
            return a;
        }

        public double CalcularPerimetro()
        {
            return 2*LadoA + 2*LadoB ;
        }
    }
}
