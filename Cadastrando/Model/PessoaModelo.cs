using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class PessoaModelo
    {

        //Isso é uma classe modelo, é como se fosse uma forma para eu fazer um bolo, jogo tudo aqui, coloco no fogo e fica top.
        public int id { get; set; }//SET - Colocando um valor aqui; GET - Pegando valor aqui atribuido
        public string nome { get; set; }
        public string usuario { get; set; }
    }
}
