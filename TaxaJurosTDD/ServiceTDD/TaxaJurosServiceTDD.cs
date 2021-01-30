using NUnit.Framework;
using TaxaJurosAPI.Service;

namespace TaxaJurosTDD.ServiceTDD
{
    public class TaxaJurosServiceTDD
    {

        [SetUp]
        public void Setup()
        {
            TestaValorInformadoTaxaJurosApi();
        }

        [Test]
        public void TestaValorInformadoTaxaJurosApi()
        {
            var TaxaJurosServiceAPI = TaxaJurosService.TaxaJurosComposto;
            double TaxaJurosEsperada = 0.01;
            Assert.IsTrue(TaxaJurosEsperada == TaxaJurosServiceAPI);
        }

    }
}
