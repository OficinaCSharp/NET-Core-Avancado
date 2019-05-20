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

        public IEnumerable<PessoaModelo> SelecionarPorId(int id, string nome)
        {
            if(id>0 || nome != null)
            {
                return _pessoaRepositorio.SelecionarPorId(id, nome);
            }
            else
            {
                return default(IEnumerable<PessoaModelo>);
            }
        }

        public PessoaModelo inserir(PessoaModelo pessoa)
        {
            var result = _pessoaRepositorio.inserir(pessoa);
            if (result > 0)
            {
                return pessoa;
            }
            else
            {
                return default(PessoaModelo);
            }
        }
    }
}
