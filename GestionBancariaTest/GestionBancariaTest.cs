using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionBancariaAppNS;
namespace GestionBancariaTest
{
    //YAG2223
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarReintegro()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 250;
            double saldoEsperado = 750;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarReintegro(reintegro);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001,
            "Se produjo un error al realizar el reintegro, saldo" + "incorrecto.");
        }
        //YAG2223
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarReintegroCantidadNoValida()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 1250;
            double saldoFinal = saldoInicial - reintegro;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarReintegro(reintegro);
        }


        //YAG2223
        [TestMethod]
        public void ValidarIngreso()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 250;
            double saldoEsperado = 1250;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarIngreso(ingreso);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el ingreso, saldo" + "incorrecto.");
        }

        //YAG2223
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarIngresoCantidadNoValida()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -250;
            double saldoFinal = saldoInicial + ingreso;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarIngreso(ingreso);
        }
    }
}
