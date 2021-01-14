using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;

namespace TesteProjetoTestes
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TesteJuros()
        {
            var TesteJuros = new TesteJuros.Controllers.JurosController();
            decimal ValorTaxaJuros = Convert.ToDecimal(0.01);

            Assert.AreEqual(ValorTaxaJuros, TesteJuros.taxaJuros());
        }

        [TestMethod]
        public void TesteShowMeTheCode()
        {
            var TesteCalculaJuros = new TesteCalculaJuros.Controllers.CalculaJurosController();
            string ValorShowMeTheCode = "https://github.com/thiago-francisco/TesteSoftPlan";

            Assert.AreEqual(ValorShowMeTheCode, TesteCalculaJuros.showMeTheCode());
        }

        [TestMethod]
        public void TesteCalculaJuros()
        {
            var TesteCalculaJuros = new TesteCalculaJuros.Controllers.CalculaJurosController();

            var Result = TesteCalculaJuros.calculaJuros(100, 1);

            Assert.IsNotNull(Result);
            Assert.IsInstanceOfType(Result, typeof(ActionResult<decimal>));
        }
    }
}
