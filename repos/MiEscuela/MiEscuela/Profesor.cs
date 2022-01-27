using System;
using System.Collections.Generic;
using System.Text;

namespace MiEscuela
{
    class Profesor<Tipo> : Empleado<Tipo>

    {

        #region Atributos
        private string matricula;
        

        #endregion
        #region Propiedades
        public string Matricula
        {
            get
            {
                return matricula + "_2017";

            }
            set
            {
                this.matricula = value;
            }
        }
        public Materia Materia { get; set; }

        public FrecuenciaPago frecPago { get; set; }



        #endregion


        #region Metodos
        public string Checar()

        {

            DateTime horaActual = DateTime.Now;
            //guardar la hora en la BD
            string resp = "Hora de registro : " + horaActual;
            return resp;

        }

        public void AsignarMateria (Materia materia)
        {
            Materia = materia;

        }
        #endregion

        #region Constructor

        public Profesor()
        {
            this.Matricula = "2017";
            this.Activo = true;

        }
        
        #endregion




    }

}
