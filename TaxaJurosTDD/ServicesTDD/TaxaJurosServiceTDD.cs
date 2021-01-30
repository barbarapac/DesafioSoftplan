using NUnit.Framework;
using TaxaJurosAPI.Services;

namespace TaxaJurosTDD.ServicesTDD
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
