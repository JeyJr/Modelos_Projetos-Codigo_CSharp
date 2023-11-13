using SimpleInjector_IEnumerator_Basic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjector_IEnumerator_Basic
{
    public class ProdutoConsultas : IProdutoConsultas
    {
        public List<Produto> produtos;

        public ProdutoConsultas()
        {
            produtos = new List<Produto>
            {
                new Produto { ID = 1, Nome = "Produto 1", Preco = 10.99m, QuantidadeEstoque = 100 },
                new Produto { ID = 2, Nome = "Produto 2", Preco = 20.50m, QuantidadeEstoque = 50 },
                new Produto { ID = 3, Nome = "Produto 3", Preco = 5.75m, QuantidadeEstoque = 200 }
            };
        }

        public void AtualizarProduto(Produto produto)
        {
            Produto produtoExistente = produtos.Find(p => p.ID == produto.ID);
            if (produtoExistente != null)
            {
                produtoExistente.Nome = produto.Nome;
                produtoExistente.Preco = produto.Preco;
                produtoExistente.QuantidadeEstoque = produto.QuantidadeEstoque;
            }
        }

        public void InserirProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public Produto? ObterProdutoPorID(int id)
        {
            return produtos.Find(p => p.ID == id);
        }

        public IEnumerable<Produto> ObterTodosProdutos()
        {
            return produtos;
        }

        public void RemoverProduto(int id)
        {
            produtos.RemoveAll(p => p.ID == id);
        }
    }
}
