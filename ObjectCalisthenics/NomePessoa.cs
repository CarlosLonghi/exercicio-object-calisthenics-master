using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    internal class NomePessoa
    {
        public string Valor { get; private set; }

        public NomePessoa(string valor)
        {
            SetNomePessoa(valor);
        }

        private void SetNomePessoa(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new ArgumentException("Nome da pessoa não pode ser nulo ou vazio! Verifique.");

            Valor = valor;
        }
    }
}