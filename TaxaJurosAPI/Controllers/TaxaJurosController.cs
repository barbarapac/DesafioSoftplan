
using Microsoft.AspNetCore.Mvc;
using TaxaJurosAPI.Service;
using System;
using System.Threading.Tasks;

namespace TaxaJurosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        /// <summary>
        /// Retorna a taxa de juros composto.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> BuscaTaxaJuros()
        {
            try
            {
                return Ok(TaxaJurosService.TaxaJurosComposto);
            }
            catch (Exception )
            {
                return UnprocessableEntity("Ops! Ocorreu erro ao consultar a taxa de juros, tente novamente! :)");
            }
        } 


    }
}
