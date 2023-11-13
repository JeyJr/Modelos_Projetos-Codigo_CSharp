using Dapper_Basic.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Basic.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> ObterTodosProdutos();
        IEnumerable<Produto> ObterLista(string personalizado);
        Produto ObterProdutoPorId(int id);
        void InserirProduto(Produto produto);
        void AtualizarProduto(Produto produto);
        void ExcluirProduto(int id);
    }
}
