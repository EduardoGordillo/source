using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraDeImpuestos1
    {
        const decimal porcentajeIVA = 0.16m;

        public decimal ObtenerIVA(decimal montoReserva)
        {
            
           return porcentajeIVA * montoReserva;
        }

        public decimal ObtenerISH(decimal montoReserva, decimal ISH)
        {
            return montoReserva * ISH;
        }
    }
}

