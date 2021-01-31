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
        /// <summary>
        /// Calcula em memória o valor final a ser pago.
        /// </summary>
        /// <param name="ValorInicial"></param>
        /// <param name="Meses"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> CalculaJuros(decimal valorInicial, int meses)
        {
            try
            {
                var calculaJurosService = new CalculaJurosService();
                var taxaJuros = await BuscaTaxaJurosService.ObterTaxaJuros();

                return Ok(calculaJurosService.CalculaJurosComposto(valorInicial, meses, taxaJuros));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
