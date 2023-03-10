using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao.Aula06.R12.ExtractClass.depois
{
    public class RazaoSocial
    {
        public string Nome { get; private set; }

        public RazaoSocial(string nome)
        {
            Nome = nome;
        }
    }
}
