using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    internal class Pessoa
    {
        private Documento Documento { get; set; }
        private NomePessoa Nome { get; set; }

        public Pessoa(string documento, string nome)
        {
            Documento = new Documento(documento);
            Nome = new NomePessoa(nome);
        }

        public string GetDocumento()
            => Documento.ValorDocumento;

        public string GetNomePessoa()
            => Nome.Valor;
    }
}
