using NUnit.Framework;
using CalculaJurosAPI.Service;

namespace CalculaJurosTDD.ServicesTDD
{
    public class ShowMetheCodeServiceTest
    {
        [SetUp]
        public void Setup()
        {
            TestaValorUrlGitGub();
        }

        [Test]
        public void TestaValorUrlGitGub()
        {
            string UrlEsperada = "https://github.com/barbarapac/DesafioSoftplan";
            var showMetheCodeServices = new ShowMetheCodeServices();
            string UrlRetorno = showMetheCodeServices.PathRepoGitHub();

            Assert.IsTrue(UrlRetorno == UrlEsperada);
        }
    }
}
