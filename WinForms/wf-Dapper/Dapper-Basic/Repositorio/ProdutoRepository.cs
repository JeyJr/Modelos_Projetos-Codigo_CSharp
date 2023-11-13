using Dapper;
using Dapper_Basic.Base;
using Dapper_Basic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Basic.Repositorio
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly string connectionString;

        public ProdutoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AtualizarProduto(Produto produto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "UPDATE Produtos SET NOME = @Nome, VALOR = @Valor, DESCRICAO = @Descricao, ATIVO = @Ativo WHERE PK_ID = @Id";
                connection.Execute(sql, produto);
            }
        }

        public void ExcluirProduto(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM Produtos WHERE PK_ID = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }

        public void InserirProduto(Produto produto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Produtos (NOME, VALOR, DESCRICAO, ATIVO) VALUES (@Nome, @Valor, @Descricao, @Ativo)";
                connection.Execute(sql, produto);
            }
        }

        public IEnumerable<Produto> ObterLista(string personalizado)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Produtos WHERE " + personalizado;
                return connection.Query<Produto>(sql);
            }
        }

        public Produto ObterProdutoPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Produtos WHERE PK_ID = @Id";
                return connection.QueryFirstOrDefault<Produto>(sql, new { Id = id });
            }
        }

        public IEnumerable<Produto> ObterTodosProdutos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Produtos";
                return connection.Query<Produto>(sql);
            }
        }
    }
}
