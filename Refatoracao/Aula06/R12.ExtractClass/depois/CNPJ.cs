using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao.Aula06.R12.ExtractClass.depois
{
    public class CNPJ
    {
        public string Codigo { get; private set; }

        public CNPJ(string codigo)
        {
            Codigo = codigo;
        }
    }
}
