using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculadoraDeImpuestos
{
    /* Obtener el IVA a partir del monto de una reserva
     * Obtener el impuesto estatal sobre hospedaje a partir del monto de una reserva(entrada : el % del impuesto estatal) 
     * Obtener el monto total de la reserva(con impuestos incluidos)
     */
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        
        public void ImpuestosTest()
        {
            //arrange
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            //Act
            decimal iva = ci.ObtenerIVA(1550.00);

            //Assert
            // iva = 16%
            // 1550*.16 = 248
            Assert.AreEqual(248.00);


        }
    }
}
