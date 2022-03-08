using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizableDisposable
{
    class CPrueba : IDisposable

    //V1
    //{
    //    private int a;
    //    public CPrueba(int pA)
    //    {
    //        a = pA;

    //    }

    //    public override string ToString()
    //    {
    //        return string.Format($"El valor es {a}");
    //    }

    //    ~CPrueba()
    //    {
    //        Console.WriteLine("Estamos en el destructor, aqui liberamos codigo no administrado");
    //    }
    //    public void Dispose()
    //    {
    //        Console.WriteLine("Estamos en Dispose, aqui liberamos lo no administrado {0}", a);

    //        // si se uso dispose no debemos usar el destructor
    //        GC.SuppressFinalize(this);
    //    }
    //}

        //V2
    {
        private bool usoDispose = false;
        private int a;
        public CPrueba(int pA)
        {
            a = pA;

        }

        public void Dispose()
        {

            // se invoca el metodo limpieza 
            // se coloca el true porque se hace uso de dispose
            Limpieza();

            // como usamos dispose indicamos que no se use el destructor
            GC.SuppressFinalize(this);
            
        }

        ~CPrueba()
        {
            Limpieza();
        }

        public override string ToString()
        {
            return string.Format($"El valor es {a}");
        }

        public void Limpieza()
        {
            if(usoDispose == false)
            {
                // codigo de limpieza comun
                Console.WriteLine("Estamos en limpieza, aqui liberamos el codigo no administrado {0}", a);
            }
            usoDispose = true;
        }
    }
}
