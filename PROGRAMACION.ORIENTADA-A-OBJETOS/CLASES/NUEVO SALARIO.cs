using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION.ORIENTADA_A_OBJETOS.CLASES
{
    class NUEVO_SALARIO
    {
        public double Salext(double h, double vh)
        {
            double salextra;
            salextra = h * vh;

            return salextra;
        }
        public double Salanet(double sab,double salex, double ded)
        {
            double salne;

            salne = ((sab + salex) - (ded * (sab + salex)));
            return salne;
        }
    }
}
