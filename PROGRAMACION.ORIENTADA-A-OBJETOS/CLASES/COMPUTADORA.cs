using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION.ORIENTADA_A_OBJETOS.CLASES
{
    class COMPUTADORA
    {
        public double Cuota(double venta, double precio)
        {

            double cuota;
            cuota = (venta * precio) * 30 / 360;

               
            return cuota;

        }
    }
}
