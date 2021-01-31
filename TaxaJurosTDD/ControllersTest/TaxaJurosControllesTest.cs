using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using TaxaJurosAPI.Controllers;

namespace TaxaJurosTDD.ControllersTest
{
    public class TaxaJurosControllesTest
    {
        [SetUp]
        public void Setup()
        {
            TestaGetTaxaJurosApi();
        }

        [Test]
        public void TestaGetTaxaJurosApi()
        {
            double TaxaJurosEsperada = 0.01;
            
            var controller = new TaxaJurosController();
            var ActionResult = controller.BuscaTaxaJuros();
            var OkResult = ActionResult as OkObjectResult;

            Assert.IsTrue(TaxaJurosEsperada == (double)OkResult.Value);
        }
    }
}
