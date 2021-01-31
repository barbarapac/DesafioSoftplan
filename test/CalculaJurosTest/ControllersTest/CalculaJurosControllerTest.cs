using CalculaJurosAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace CalculaJurosTDD.ControllersTest
{
    public class CalculaJurosControllerTest
    {
        [SetUp]
        public void Setup()
        {
            TestaGetCalculoDeJurosComposto();
        }

        [Test]
        public void TestaGetCalculoDeJurosComposto()
        {
            decimal ValorInicial = 100;
            int Meses = 5;
            double ValorFinalEsperado = 105.10;

            var controller = new CalculaJurosController();
            var actionResult = controller.CalculaJuros(ValorInicial, Meses);
            double ResultadoRetornado = (double)((ObjectResult)actionResult.Result).Value;

            Assert.IsTrue(ResultadoRetornado == ValorFinalEsperado);
        }
    }
}