using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    internal class Transacao
    {
        public Guid Id { get; private set; }
        private Pessoa Pessoa { get; set; }
        private ListaDeProdutos Produtos { get; set; } = new ListaDeProdutos();

        public Transacao(Pessoa pessoa)
        {
            Id = Guid.NewGuid();
            Pessoa = pessoa;
        }

        public string GetNomePessoa()
            => Pessoa.GetNomePessoa();

        public void AdicionarProduto(Produto produto)
            => Produtos.Add(produto);

        public void ListarProdutos()
            => Produtos.ForEach(x => x.ImprimeProduto());

        public decimal GetTotalTransacao()
            => Produtos.Sum(x => x.GetValorProduto());
    }
}
