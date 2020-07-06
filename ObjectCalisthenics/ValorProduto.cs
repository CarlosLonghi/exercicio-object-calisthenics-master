using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    internal class ValorProduto
    {
        public decimal Valor { get; set; }

        public ValorProduto(decimal valor)
        {
           SetValorProduto(valor);
        }

        private void SetValorProduto(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor do produto precisa ser maior que 0");

            Valor = valor;
        }
    }
}
