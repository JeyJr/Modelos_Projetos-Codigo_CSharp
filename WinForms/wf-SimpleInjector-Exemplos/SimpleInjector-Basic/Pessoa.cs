using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjector_Basic
{
    public class Pessoa
    {
        public int Idade { get; private set; }
        public string Nome { get; private set; }

        public Pessoa(int idade, string nome) 
        {
            Idade = idade;
            Nome = nome;
        }
    }
}
