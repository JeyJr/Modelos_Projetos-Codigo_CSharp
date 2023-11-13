using SimpleInject_Basic_SqlServer.SQL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInject_Basic_SqlServer.SQL
{
    public class CRUDSimples : ICRUDSimples
    {
        private readonly IConexaoBancoDeDados conexao;

        public CRUDSimples(IConexaoBancoDeDados conexao)
        {
            this.conexao = conexao;
        }

        public int Delete(string sql)
        {
            using (SqlConnection connection = new SqlConnection(conexao.ObterStringConexao()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int Insert(string sql)
        {
            using (SqlConnection connection = new SqlConnection(conexao.ObterStringConexao()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }

        public DataTable Select(string sql)
        {
            using (SqlConnection connection = new SqlConnection(conexao.ObterStringConexao()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public int Update(string sql)
        {
            using (SqlConnection connection = new SqlConnection(conexao.ObterStringConexao()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
