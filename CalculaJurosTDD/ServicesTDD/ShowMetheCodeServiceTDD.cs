using NUnit.Framework;
using CalculaJurosAPI.Service;

namespace CalculaJurosTDD.ServicesTDD
{
    public class ShowMetheCodeServiceTDD
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
            string UrlRetorno = ShowMetheCodeServices.PathRepoGitHub;

            Assert.IsTrue(UrlRetorno == UrlEsperada);
        }
    }
}
