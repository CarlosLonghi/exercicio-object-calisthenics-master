using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    public static class ValidarDocumento
    {

        public static bool IsDocumentoValido(string documento)
            => documento.Length.Equals(14) || documento.Length.Equals(11);
    }
}
