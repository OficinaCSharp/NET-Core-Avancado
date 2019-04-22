using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Configuracao
{
    public class dbConnection
    {
        //Aqui criei uma string de conexão para me conectar com meu banco de dados
        //Data souce = Servidor
        //Initial Catalog = Banco de dados
        //Integrated Security = Se conecta com o windows então = true
        private static string ConnectionString = "Data source=localhost,1433;Initial Catalog=Cadastro;Integrated Security=false; User ID=SA; password=123Aa321";
        
        //Este metodo chama-se GetConn, mas poderia ter o nome de banana, e ele retorna o texto da string acima
        public static string GetConn()
        {
            return ConnectionString;
        }
    }
}
