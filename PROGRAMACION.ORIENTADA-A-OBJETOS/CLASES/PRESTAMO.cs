using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMACION.ORIENTADA_A_OBJETOS.CLASES
{
    class PRESTAMO
    {
        public double Cuota(double pres, double interes, double plazo)
        {
            double cuota;

            cuota = (((pres*interes)+ pres)/ plazo);

            return cuota;
        }
       
    }
}

