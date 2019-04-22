using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Negocio;

namespace Cadastrando.Controllers
{
    [Route("api/Pessoa")]// Definindo uma url base para acessar qualquer api desta controller

    public class PessoaController : ControllerBase
    {
        //Criando uma estância para poder acessar os Objetos, Propriedades, Métodos da minha classe de Negocio
        PessoaNegocio pessoaNegocio = new PessoaNegocio();
        

        //Criando aqui um controle de Get, onde retorna uma lista de pessoas cadastradas no banco
        [HttpGet]
        //Nesta linha abaixo criamos um metodo de http get que nem esta escrito acima e falamos que ele retorna o resultado de uma ação
        public IActionResult Get() 
        {
            //aqui é o retorno do meu controle de get onde ele retorna um ok e chama um método de selecionar da minha classe de negócio
            return Ok(pessoaNegocio.Selecionar());
        } 

        [HttpPost]
        [ProducesResponseType(typeof(string),201)]
        [ProducesResponseType(402)]
        [ProducesResponseType(500)]
        public IActionResult Post([FromBody] PessoaModelo pessoa)
        {
            return CreatedAtRoute("", pessoaNegocio.inserir(pessoa));
        }


    }
}