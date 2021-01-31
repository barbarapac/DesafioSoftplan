using CalculaJurosAPI.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculaJurosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowMetheCodeController : ControllerBase
    {
        /// <summary>
        /// Retorna a Url do repositório GitHub.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult BuscaPathUrlGitHub()
        {
            try
            {
                var showMetheCode = new ShowMetheCodeServices();
                return Ok(showMetheCode.PathRepoGitHub());
            }
            catch (Exception)
            {
                return BadRequest("Ops! Ocorreu erro ao consultar a taxa de juros, tente novamente! :)");
            }
        }
    }
}
