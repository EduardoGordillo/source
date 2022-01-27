using System;
using System.Collections.Generic;
using System.Text;

namespace MiEscuela
{
    class MiClase : MiInterfaz
    {
        int numero;
        public int Numero { get; set; }
        string miPropiedad;
        string MiInterfaz.MiPropiedad
        {
            get { return miPropiedad; }
            set { miPropiedad = value; }
        }
        string MiInterfaz.MiMensaje()
        {
            string msj = "Mensaje desde MiClase.MiMensaje()";
            return msj;  
        }


    }
}
