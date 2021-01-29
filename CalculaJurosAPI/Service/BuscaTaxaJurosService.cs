using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculaJurosAPI.Service
{
    public static class BuscaTaxaJurosService
    {
        public static async Task<decimal> ObterTaxaJuros(IConfiguration config)
        {
            try
            {
                decimal TaxaJuros = await ConsultaTaxaJuros(config);

                if (TaxaJuros <= 0)
                {
                    throw new Exception("Não foi possivel obter a taxa de juros, tente novamente.");
                }

                return TaxaJuros;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static async Task<decimal> ConsultaTaxaJuros(IConfiguration config)
        {
            using (var http = new HttpClient())
            {
                Uri urlRequisicao = new Uri(config.GetSection("UrlApiAuxiliar").GetSection("UrlApiCalculaJuros").Value);
                //HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, urlRequisicao);
                var response = await http.GetAsync(urlRequisicao);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return await ObterTaxaJuros(response);
                }
            }
            return 0;
        }

        private static async Task<decimal> ObterTaxaJuros(HttpResponseMessage respostaHTTP)
        {
            var body = await respostaHTTP.Content.ReadAsStringAsync();
            var sucesso = decimal.TryParse(body, out var taxaJuros);
            return sucesso ? taxaJuros : 0;
        }
    }
}
