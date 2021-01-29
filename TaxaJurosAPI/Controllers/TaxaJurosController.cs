
using Microsoft.AspNetCore.Mvc;
using System;
using TaxaJurosAPI.Service;

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
        public IActionResult BuscaTaxaJuros()
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
