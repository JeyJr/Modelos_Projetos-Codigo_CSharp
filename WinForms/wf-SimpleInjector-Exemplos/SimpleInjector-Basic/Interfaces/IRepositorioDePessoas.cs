using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjector_Basic.Interfaces
{
    public interface IRepositorioDePessoas
    {
        void AdicionarPessoa(Pessoa pessoa);
        List<Pessoa> ObterTodasAsPessoas();
    }
}
