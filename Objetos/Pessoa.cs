using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Pessoa
    {
        public string nome { get; set; }
        public byte tipoPessoa { get; set; }
        public string numDocumento { get; set; }
        public string telefone { get; set; }

        public Pessoa(string nome, byte tipoPessoa, string numDocumento, string telefone)
        {
            this.nome = nome;
            this.tipoPessoa = tipoPessoa;
            this.numDocumento = numDocumento;
            this.telefone = telefone;
        }
    }
}
