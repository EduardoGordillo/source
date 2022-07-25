using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculadora;

namespace CalculadoraDeImpuestos
{
    /**Obtener el iva a partir de el monto de una reserva
     * obtener el impuesto estatal sobre el hospedaje a partir de un monto de reserva
     * obtener el monto total de la reserva
     * 
     * 
      */
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void ImpuestosTest()
        {
            //Arrange 
            CalculadoraDeImpuestos1 ci = new CalculadoraDeImpuestos1();
           



            //Act
            decimal iva = ci.ObtenerIVA(1550.00m);

            //Assert
            //IVA= 16%
            //Monto de reserva = 1550
            Assert.AreEqual (248.00m, iva);
        }
        [TestMethod]
        public void ISHTest()
        {
            //Arrange 
            CalculadoraDeImpuestos1 ci = new CalculadoraDeImpuestos1();




            //Act
            decimal ish = ci.ObtenerISH(1550.00m, 0.03m);

            //Assert
            //ISH = 3%
            //Monto de reserva = 1550
            //1550 * .03= 46.5
            Assert.AreEqual(46.50m, ish);
        }
       
        public void CostoTotal()
        {
            //Arrange 
            CalculadoraDeImpuestos1 ci = new CalculadoraDeImpuestos1();




            //Act
            decimal ish = ci.ObtenerISH(1550.00m, .03m);
            decimal iva = ci.ObtenerIVA(1550.00m);
            decimal costoTotal = ish + iva + 1550.00m ;

            //Assert
            //IVA= 16%
            //ISH = 3%
            //Monto de reserva = 1550
            Assert.AreEqual(1844.5,costoTotal);
        }
    }
}
