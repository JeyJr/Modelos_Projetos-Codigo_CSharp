using SimpleInjector_Basic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjector_Basic
{
    public class RepositorioDePessoas : IRepositorioDePessoas
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
        
        public void AdicionarPessoa(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
        }

        public List<Pessoa> ObterTodasAsPessoas()
        {
            return pessoas;
        }
    }
}
