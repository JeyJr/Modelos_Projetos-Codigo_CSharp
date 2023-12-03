using SimpleInjector_Basic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjector_Basic
{
    public class ServicoDePessoas : IServicoDePessoas
    {
        private IRepositorioDePessoas repositorioDePessoas;

        public ServicoDePessoas(IRepositorioDePessoas repositorioDePessoas)
        {
            this.repositorioDePessoas = repositorioDePessoas;
        }

        public void RegistrarPessoa(int idade, string nome)
        {
            Pessoa pessoa = new Pessoa(idade, nome);
            repositorioDePessoas.AdicionarPessoa(pessoa);
        }

        public List<Pessoa> ObterTodasAsPessoas()
        {
            return repositorioDePessoas.ObterTodasAsPessoas();
        }
    }
}
