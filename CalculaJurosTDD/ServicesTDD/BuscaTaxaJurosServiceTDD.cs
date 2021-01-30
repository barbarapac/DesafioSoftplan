using CalculaJurosAPI.Services;
using NUnit.Framework;
using System.Threading.Tasks;

namespace CalculaJurosTDD.ServicesTDD
{
    public class BuscaTaxaJurosServiceTDD
    {
        [SetUp]
        public void Setup()
        {
            _ = TestaGetTaxaDeJurosHttp();
        }

        [Test]
        public async Task TestaGetTaxaDeJurosHttp()
        {
            double TaxaJurosEsperada = 0.01;
            var TaxaJurosObtida = await BuscaTaxaJurosService.ObterTaxaJuros();

            Assert.IsTrue(TaxaJurosObtida == TaxaJurosEsperada);
        }
    }
}
