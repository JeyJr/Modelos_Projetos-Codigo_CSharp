using SimpleInject_Basic_SqlServer.SQL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInject_Basic_SqlServer.SQL
{
    public class ConexaoBancoDeDados : IConexaoBancoDeDados
    {

        private static string autenticacaoWindows = "Data Source = INSTANCIA;Initial Catalog = BASE DE DADOS; Integrated Security = True;";
        public string ObterStringConexao()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(autenticacaoWindows);
            builder.TrustServerCertificate = true;
            return builder.ConnectionString;
        }
    }
}
