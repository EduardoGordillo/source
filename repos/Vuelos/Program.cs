using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos
{
    public delegate float CalcularTotal(float subtotal);
    class VueloNacional
    {
        float Iva
        {
            get
            {
                if (Redondo)
                    return 0.16f;
                return 0.04f;
            }
        }
      float Tua
        {get
            {
                return 220f;

            }
        }
    public bool Redondo { get; set; }
    public float CalcularMontoTotal(float monto)
        {
            return monto + (monto * Iva) + Tua;
        }


    }
    class VueloInternacional {
        float Iva
        {
            get
            {
                if (Redondo)
                    return 0.16f;
                return 0.04f;
            }
        }
        float Tua
        {
            get
            {
                return 360f;

            }
        }
        float ImpuestoFederalSeguridad
        {
            get
            { return 190.75f; }
        }
        public bool Redondo { get; set; }
        public int Destino { get; set; }
        public float CalcularMontoTotal(float monto)
        {
            float total = monto + (monto * Iva) + Tua;
            if (Destino == 559)
                return total + ImpuestoFederalSeguridad;
            return total;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            VueloNacional vueloNac = new VueloNacional
            {
                Redondo = true
            };
            //CalcularTotal total = new CalcularTotal(vueloNac.CalcularMontoTotal);
            CalcularTotal total = vueloNac.CalcularMontoTotal;
            float precio = 5500.00f;
            Console.WriteLine("Costo del vuelo nacional {0} ", total(precio));

            VueloInternacional vueloInter = new VueloInternacional
            {
                Redondo = false,
            Destino = 559,
            };
            /*CalcularTotal total1 = vueloInter.CalcularMontoTotal;
            float precio1 = 8800.00F;
            Console.WriteLine("Costo de vuelo internacional {0}", total1(precio1));*/
            total = vueloInter.CalcularMontoTotal;
            float t = total(precio);
            Console.WriteLine("precio de vuelo internacional {0}", t);
        }
    }
}
