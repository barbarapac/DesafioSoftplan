using NUnit.Framework;
using TaxaJurosAPI.Services;

namespace TaxaJurosTDD.ServicesTest
{
    public class TaxaJurosServiceTest
    {

        [SetUp]
        public void Setup()
        {
            TestaValorInformadoTaxaJurosApi();
        }

        [Test]
        public void TestaValorInformadoTaxaJurosApi()
        {

            var taxaJurosServiceAPI = new TaxaJurosService();
            double taxaJurosEsperada = 0.01;
            Assert.IsTrue(taxaJurosEsperada == taxaJurosServiceAPI.TaxaJurosComposto());
        }

    }
}
