using System;
using Microsoft.AspNetCore.Mvc;

namespace Modulo_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(), // Retorna a data completa
                Hora = DateTime.Now.ToShortTimeString()  // Retorna a hora completa
            };

            return Ok(obj);  // Retorna um status 200 com o objeto JSON
        }
    }
}
