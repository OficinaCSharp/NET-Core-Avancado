using Dapper;
using Model;
using Repositorio.Configuracao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repositorio
{
    public class PessoaRepositorio
    {

        //Criei um metodo que retorna um IEnumerable de PessoasModelo, ou seja... Vai retornar uma lista de pessoas para mim 
        public IEnumerable<PessoaModelo> Selecionar()
        {
            //Estou usando uma nova conexão com o Sqn e dentro do SQLConnection estou passando uma classe que tem uma string de conexão
            using (var connection = new SqlConnection(dbConnection.GetConn()))
            {
                //estou retornando uma query que ele vai executar nessa conexão que fez assim, essa query vai trazer para mim algo do tipo
                //pessoaModelo, e a query(comando) que vou fazer no banco esta dentro das Aspas 
                return connection.Query<PessoaModelo>($"Select * from Pessoas");

            }
        }

        public int inserir (PessoaModelo pessoa)
        {
            using (var connection = new SqlConnection(dbConnection.GetConn()))
            {
                return connection.QuerySingle<int>($"DECLARE @id int;" +
                    $"Insert into Pessoas (nome, usuario) Values ('{pessoa.nome}', '{pessoa.usuario}')"+
                    $"SET @id = SCOPE_IDENTITY();" +
                    $"select @id");
            }
        }
    }
}
