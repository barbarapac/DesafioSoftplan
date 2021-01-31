using CalculaJurosAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace CalculaJurosTDD.ControllersTest
{
    public class ShowMetheCodeControllerTest
    {
        [SetUp]
        public void Setup()
        {
            TestaGetPathUrlGitHub();
        }

        [Test]
        public void TestaGetPathUrlGitHub()
        {
            string UrlEsperada = "https://github.com/barbarapac/DesafioSoftplan";

            var controller = new ShowMetheCodeController();
            var ActionResult = controller.BuscaPathUrlGitHub();
            var OkResult = ActionResult as OkObjectResult;

            Assert.IsTrue(UrlEsperada == (string)OkResult.Value);
        }
    }
}
