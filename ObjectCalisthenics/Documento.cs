using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    internal class Documento
    {
        public string ValorDocumento { get; private set; }

        public Documento(string valorDocumento)
        {
            SetDocumento(valorDocumento);
        }

        private void SetDocumento(string valorDocumento)
        {
            if (!ValidarDocumento.IsDocumentoValido(valorDocumento))
                throw new ArgumentException("Documento inválido!");

            ValorDocumento = valorDocumento;
        }
    }
}
