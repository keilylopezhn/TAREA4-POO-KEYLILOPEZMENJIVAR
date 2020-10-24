using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION.ORIENTADA_A_OBJETOS.CLASES
{
    class VENTAS
    {
        public double Venta (double d1,double d2, double d3, double d4, double d5)
        {
            double venta;
            venta = d1 + d2 + d3 + d4 + d5;

            return venta;

        }
        public double Suma(double r, double s)
        {
            double ventas;
            ventas  = (r*s)+s;

            return ventas;

        }
    }
}
