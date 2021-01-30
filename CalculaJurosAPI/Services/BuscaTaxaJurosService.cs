using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculaJurosAPI.Services
{
    public static class BuscaTaxaJurosService
    {
        public static async Task<double> ObterTaxaJuros(IConfiguration config)
        {
            try
            {
                double TaxaJuros = await ConsultaTaxaJuros(config);

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

        private static async Task<double> ConsultaTaxaJuros(IConfiguration config)
        {
            using (var http = new HttpClient())
            {
                Uri urlRequisicao = new Uri(config.GetSection("UrlApiAuxiliar").GetSection("UrlApiCalculaJuros").Value);
                var response = await http.GetAsync(urlRequisicao);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return await ObterTaxaJuros(response);
                }
            }
            return 0;
        }

        private static async Task<double> ObterTaxaJuros(HttpResponseMessage respostaHTTP)
        {
            var response = await respostaHTTP.Content.ReadAsStringAsync();
            var sucesso = double.TryParse(response, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double taxaJuros);

            return sucesso ? taxaJuros : 0;
        }
    }
}
