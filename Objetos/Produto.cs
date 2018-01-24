using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Produto
    {
        public string codigo { get; set;}
        public string embalagem { get; set; }
        public double preco { get; set; }

        public Produto(string codigo, string embalagem, double preco)
        {
            this.codigo = codigo;
            this.embalagem = embalagem;
            this.preco = preco;
        }

    }
}
