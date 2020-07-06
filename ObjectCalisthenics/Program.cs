using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                var pessoa = new Pessoa("89828707500", "PESSOA DE TESTE 1");
                var produto = new Produto("PRODUTO DE TESTE 1", 99.90m);
                var produto1 = new Produto("PRODUTO DE TESTE 2", 99.90m);
                var produto2 = new Produto("PRODUTO DE TESTE 3", 99.90m);
                var transacao = new Transacao(pessoa);

                transacao.AdicionarProduto(produto);
                transacao.AdicionarProduto(produto1);
                transacao.AdicionarProduto(produto2);

                transacao.ListarProdutos();
                
                Console.WriteLine($"Transação para o cliente: {transacao.GetNomePessoa()}");
                Console.WriteLine($"Valor Total Transação: {transacao.GetTotalTransacao()}");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

    }
}
