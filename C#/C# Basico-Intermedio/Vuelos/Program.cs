using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos
{
    public delegate float CalcularTotal(float subtotal);
    public delegate void CalcularTotalRef(ref float subtotal);
    public delegate void ImprimirMensaje(string msj);
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
        public void CalcularTotalConImpuestos( ref float monto)
        {
            float total = monto + (monto * Iva) + Tua;
            if (Destino == 559)
                total += ImpuestoFederalSeguridad;
            monto = total;
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
            float precio1 = 9800f;
            total = vueloInter.CalcularMontoTotal;
            float t = total(precio1);
            Console.WriteLine("precio de vuelo internacional {0}", t);

            #region Parametros
            float totalAdultoMayor = CalcularConDescuentoAdultoMayor(t, total);
            Console.WriteLine("Costo vuelo internacional con descuento adulto mayor {0}", totalAdultoMayor);
            #endregion

            #region multicast
            CalcularTotal totalB = vueloInter.CalcularMontoTotal;
            totalB += CalcularTotalSeguro;
            Console.WriteLine("Calcular del seguro {0}", totalB(precio1));
            CalcularTotalRef tr = vueloInter.CalcularTotalConImpuestos;
            tr += CalcularTotalConSeguroRef;
            tr(ref precio1);
            Console.WriteLine("Costo de vuelo internacional con seguro {0}", precio1);
            #endregion
            #region anonimos
            ImprimirMensaje im = delegate (string mensaje)
            {
                Console.WriteLine("mesnaje {0}", mensaje);

            };
            im("Delegado comes");
            #endregion
        }
        static float CalcularConDescuentoAdultoMayor(float monto, CalcularTotal total)
        {
            float subtotal = total(monto);
            return subtotal - (0.35f * subtotal);
                
        }
        static float CalcularTotalSeguro(float total)
        {
            float porcentajeSeguro = 0.1f;
            return total * porcentajeSeguro;

        }
        static void CalcularTotalConSeguroRef(ref float total)
        {
            float porcentajeSeguro = 0.1F;
            total += total * porcentajeSeguro;
        }
        }
    }

