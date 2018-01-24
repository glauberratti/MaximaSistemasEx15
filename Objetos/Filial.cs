using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Filial
    {
        public string nome { get; set; }
        public string numCNPJ { get; set; }

        public Filial(string nome, string cnpj)
        {
            this.nome = nome;
            numCNPJ = cnpj;
        }
    }
}
