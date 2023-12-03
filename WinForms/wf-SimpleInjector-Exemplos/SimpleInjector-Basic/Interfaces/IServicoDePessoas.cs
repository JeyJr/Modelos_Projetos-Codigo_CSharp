using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjector_Basic.Interfaces
{
    public interface IServicoDePessoas
    {
        void RegistrarPessoa(int idade, string nome);
        List<Pessoa> ObterTodasAsPessoas();
    }
}
