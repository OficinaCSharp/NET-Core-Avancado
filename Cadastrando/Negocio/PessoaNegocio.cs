using Model;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
  

    public class PessoaNegocio
    {
        //Criando uma estância para poder acessar os Objetos, Propriedades, Métodos da minha classe de Repositorio
        PessoaRepositorio _pessoaRepositorio = new PessoaRepositorio();//instancia


        //Criando um metodo chamado selecionar que retorna um IEnumerable de PessoasModelo, IEnumerable é uma lista
        public IEnumerable<PessoaModelo> Selecionar()
        {
            //Este é o retorno do método então ele vai retornar exatamente o que o metodo Selecionar da minha repositorio me devolver.
            return _pessoaRepositorio.Selecionar(); 
        }
    }
}
