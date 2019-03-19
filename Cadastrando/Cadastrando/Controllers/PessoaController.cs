using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace Cadastrando.Controllers
{
    [Route("api/Pessoa")]// Rota da  url

    public class PessoaController : ControllerBase
    {
        PessoaNegocio pessoaNegocio = new PessoaNegocio();
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(pessoaNegocio.Selecionar());
        } 

    }
}