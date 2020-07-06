using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    internal class Produto
    {
        public Guid Id { get; private set; }
        private DescricaoProduto Descricao { get; set; }
        private ValorProduto Valor { get; set; }

        public Produto(string descricao, decimal valor)
        {
            Id = Guid.NewGuid();
            Descricao = new DescricaoProduto(descricao);
            Valor = new ValorProduto(valor);
        }

        public string GetDescricaoProduto() 
            => Descricao.Valor;

        public decimal GetValorProduto()
            => Valor.Valor;

        public void ImprimeProduto()
            => Console.WriteLine($"Descrição: {GetDescricaoProduto()} \n Valor: {GetValorProduto()}");
        
    }
}
