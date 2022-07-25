using System;
using System.Collections.Generic;
using System.Text;

namespace MiEscuela
{
    abstract class Materia
    {

        #region Atributos
        string clave;
        string nombre;
        //Profesor coordinador;


        #endregion


        #region Metodos

        public abstract decimal Evaluar();
       

     
        #endregion
    }
}
