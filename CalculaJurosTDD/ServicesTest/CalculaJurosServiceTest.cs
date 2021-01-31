using CalculaJurosAPI.Services;
using NUnit.Framework;

namespace CalculaJurosTDD.ServicesTDD
{
    public class CalculaJurosServiceTest
    {
        [SetUp]
        public void Setup()
        {
            TesteCalculoValorFinalDoJurosComporto();
        }

        [Test]
        public void TesteCalculoValorFinalDoJurosComporto()
        {
            var calculaJurosService = new CalculaJurosService();
            double TaxaJuros = 0.01;
            decimal ValorInicial = 100;
            int Meses = 5;
            double ValorFinalEsperado = 105.10;

            double ValorFinalRet = calculaJurosService.CalculaJurosComposto(ValorInicial, Meses, TaxaJuros);
            Assert.IsTrue(ValorFinalRet == ValorFinalEsperado);
        }
    }
}
