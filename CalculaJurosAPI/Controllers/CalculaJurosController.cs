using CalculaJurosAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace CalculaJurosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {

        private readonly IConfiguration _config;
        public CalculaJurosController(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Calcula em memória o valor final a ser pago.
        /// </summary>
        /// <param name="ValorInicial"></param>
        /// <param name="Meses"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> CalculaJuros(decimal ValorInicial, int Meses)
        {
            try
            {
                var calculaJurosService = new CalculaJurosService();
                var TaxaJuros = await BuscaTaxaJurosService.ObterTaxaJuros(_config);

                return Ok(calculaJurosService.CalculaJurosComposto(ValorInicial, Meses, TaxaJuros));
            }
            catch (Exception ex)
            {
                return UnprocessableEntity(ex.Message);
            }

        }

    }
}
