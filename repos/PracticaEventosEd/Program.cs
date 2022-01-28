using System;

namespace PracticaEventosEd
{ 
    public enum TipoAlerta
{
    Error = 1,
    Advertencia = 2,
    Exito = 3
}

public enum TipoPago
{
    Tarjeta = 1,
    Transferencia = 2,
    Otros = 3
}
   // public delegate void CambioFormaPagoHandler(TipoPago tipoPago, TipoAlerta alerta);



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa una forma de pago");
            Console.WriteLine("1 - Tarjeta \n2 -Tranferencia \n3- Otros");
            string tipoPago = Console.ReadLine();

            FormaDePago fm = new FormaDePago();
            fm.CambioFormaPago += fm_selecionFormaPago;

            fm.CambioFormaPago += fm_continuarProcesoPago;
            fm.Tipo = (TipoPago)Enum.Parse(typeof(TipoPago), tipoPago);
            
        }

        static void fm_selecionFormaPago(object emisor, CambioFormaPagoEventArgs args )
        {
            if (args.TipoAlerta.Equals(TipoAlerta.Error))

                Console.WriteLine("error, elegiste una forma de pago incorrecta");
            else if (args.TipoAlerta.Equals(TipoAlerta.Exito))
                Console.WriteLine("Forma de pago sleccionanda: {0}", args.TipoPago.ToString());



        } 
        static void fm_continuarProcesoPago( object emisor, CambioFormaPagoEventArgs args )
        {
            bool estatus = false;
            if (args.Equals(TipoAlerta.Exito))
            {

                Console.WriteLine("continuando con el proceso de pago por ", args.ToString());
                Console.WriteLine("Presione X para continuar..", args.ToString());
                string tipoPago = Console.ReadLine();
                if (tipoPago == "x")
                    estatus = true;
            }
            Console.WriteLine("confirmacion recibida, estatus de la operacion {0}", estatus ? "confirmada" : "cancelada");
        }
    }
public class FormaDePago // event broadcaste /emisora
{
    private TipoPago tipo;
        public event EventHandler<CambioFormaPagoEventArgs> CambioFormaPago;
        public TipoPago Tipo
        {
            get { return tipo; }
            set
            {
                TipoAlerta TipoAlerta = TipoAlerta.Error;
                if (value.Equals(TipoPago.Tarjeta)
                    || value.Equals(TipoPago.Transferencia)
                        || value.Equals(TipoPago.Otros))
                {
                    tipo = value;
                    TipoAlerta = TipoAlerta.Exito;
                }
                CambioFormaPagoEventArgs args = new CambioFormaPagoEventArgs
                {
                    TipoPago = tipo,
                    TipoAlerta = TipoAlerta
                };
                CambioFormaPago(this, args);
            }
           
        }
      




    
   }
    public class CambioFormaPagoEventArgs : EventArgs
    {
        public TipoAlerta TipoAlerta { get; set; }
        public TipoPago TipoPago { get; set; }
    }
}
