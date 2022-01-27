using System;
using System.Collections.Generic;
using System.Text;

namespace MiEscuela
{
    public enum FrecuenciaPago
    {
        Quincenal,
        Mensual,
        Bimestral

    }
    public class Empleado<Tipo>
    {
        #region Atributos
        private Tipo id;
        private string nombre;
        private bool activo;
        private int edad;
        private string nacionalidad;
        private decimal pago;
        #endregion

        #region Propiedades
        public Tipo Id
        {
            get; set; 

         }
        public string Nombre
        {
            get
            {
                return nombre;

            }
            set
            {
                this.nombre = value;
            }

        }

        public bool Activo { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public decimal Pago { get; }


        #endregion


        #region Metodos
        public void CalcularPago()
        {


        }
        #endregion

        #region Constructor

        public Empleado()
        {
            this.Activo = true;


        }
        public Empleado(string nombre )
        {
            Nombre = nombre;
            this.Activo = true;

        }
        #endregion

    }
}
