using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjector_IEnumerator_Basic.Interfaces
{
    public interface IProdutoConsultas
    {
        IEnumerable<Produto> ObterTodosProdutos();
        Produto ObterProdutoPorID(int id);
        void InserirProduto(Produto produto);
        void AtualizarProduto(Produto produto);
        void RemoverProduto(int id);
    }
}
