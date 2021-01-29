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
                return Ok(ShowMetheCodeService.PathRepoGitHub);
            }
            catch (Exception)
            {
                return UnprocessableEntity("Ops! Ocorreu erro ao consultar a taxa de juros, tente novamente! :)");
            }
        }
    }
}
