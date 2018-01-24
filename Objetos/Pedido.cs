namespace Exercicio15
{
    class Pedido
    {
        public string filial { get; set; }
        public string produto { get; set; }
        public string pessoa { get; set; }

        public Pedido(string filial, string produto, string pessoa)
        {
            this.filial = filial;
            this.produto = produto;
            this.pessoa = pessoa;
        }
    }
}
