using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAplicationEdd
{
    class CCaldera
    {
        private int tempMax = 120;
        private int tempActual = 0;
        private string marca = "";
        private bool funciona = true;

        public int Temperatura { get { return tempActual; } set { tempActual = value; } }
        public string Marca { get { return marca; } set { marca = value; } }
        public bool Funciona { get { return funciona; } }
        public CCaldera(string pMarca, int pTemp)
        {
            marca = pMarca;
            tempActual = pTemp;

        }
         // v1
        //public void Trabajar(int pAumento)
        //{
        //    if (funciona == false)
        //        Console.WriteLine("La caldera {0} esta descompuesta", marca);
        //    else
        //    {
        //        tempActual += pAumento;
        //        Console.WriteLine("La temperatura actual es de {0}", tempActual);

        //        if(tempActual > tempMax)
        //        {
        //            Console.WriteLine($"{marca} supero la temperatura, tiene {tempActual}");
        //            tempActual = tempMax;
        //            funciona = false;

        //            //throw new Exception("Excepcion de prueba");

        //            //primera version de la excepcion propia
        //            // creamos ima imstancia de nuestra clase de excepcion

        //            CalderaExcepcion ex = new CalderaExcepcion(string.Format($"La caldera {marca} se ha sobrecalentado"), "Nivel de presion de agua bajo", DateTime.Now); ;

        //            ex.HelpLink = "http//www.edd0613.com";

        //            throw ex;
        //        }
        //    }
        public void Trabajar(int pAumento)
        {
            if(pAumento < 0)
            {
                throw new ArgumentOutOfRangeException("Aumento", pAumento ,  "El aumento no puede ser negativo");
            }
            if (funciona == false)
                Console.WriteLine("La caldera {0} esta descompuesta", marca);
            else
            {
                tempActual += pAumento;
                Console.WriteLine("La temperatura actual es de {0}", tempActual);

                if (tempActual > tempMax)
                {
                    Console.WriteLine($"{marca} supero la temperatura, tiene {tempActual}");
                    tempActual = tempMax;
                    funciona = false;

                    //throw new Exception("Excepcion de prueba");

                    //primera version de la excepcion propia
                    // creamos ima imstancia de nuestra clase de excepcion

                    CalderaExcepcion ex = new CalderaExcepcion(string.Format($"La caldera {marca} se ha sobrecalentado"), "Nivel de presion de agua bajo", DateTime.Now); ;

                    ex.HelpLink = "http//www.edd0613.com";

                    throw ex;
                }
            }
        }
}
}// finaliza

// v1
//public class CalderaExepcion : ApplicationException
//{
//    private string mensaje = "";
//    private DateTime momento;
//    private string causa;

//    public DateTime Momento { get { return momento; } set { momento = value; } }
//    public string Causa { get { return causa; } set { causa = value; } }

//    public CalderaExepcion(string pMensaje, string pCausa, DateTime pMomento)
//    {
//        this.mensaje = pMensaje;
//        causa = pCausa;
//        momento = pMomento;
//    }

//    public override string Message => string.Format("Mensaje de la excepcion: {0}", mensaje);
//}

// v2
//public class CalderaExepcion : ApplicationException
//{
//    private string mensaje = "";
//    private DateTime momento;
//    private string causa;

//    public DateTime Momento { get { return momento; } set { momento = value; } }
//    public string Causa { get { return causa; } set { causa = value; } }

//    public CalderaExepcion(string pMensaje, string pCausa, DateTime pMomento)
//        : base (pMensaje )
//    {

//        causa = pCausa;
//        momento = pMomento;
//    }

//    //public override string Message => string.Format("Mensaje de la excepcion: {0}", mensaje);
//}

// v3

/// <summary>
/// Excepcion completa deacuerdo con las reglas de .NET
/// derivar de Excepcion/ApplicationException
/// Usar [system.Serializable]
/// definir contructor Default
/// Definir constructor que coloca message en la herencia 
/// definir constructor que maneja excepciones internas
/// definir costructor que maneja la serializacion
/// </summary>
[Serializable]
public class CalderaExcepcion : ApplicationException
{
    public CalderaExcepcion() { }
    public CalderaExcepcion(string pMensaje) : base(pMensaje) { }
    public CalderaExcepcion(string pMensaje,
                                    System.Exception inner)
        : base(pMensaje, inner) { }
    protected CalderaExcepcion(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }
    private DateTime momento;
    private string causa;

    public DateTime Momento { get { return momento; } set { momento = value; } }
    public string Causa { get { return causa; } set { causa = value; } }

    public CalderaExcepcion(string pMensaje, string pCausa, DateTime pMomento)
        : base (pMensaje)
    {
        causa = pCausa;
        momento = pMomento;
    }



}