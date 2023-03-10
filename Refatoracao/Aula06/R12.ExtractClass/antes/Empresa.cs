using refatoracao.R13.InlineClass.antes;
using System;
using System.Collections.Generic;
using System.Text;
using Refatoracao.Aula06.R12.ExtractClass.depois;

namespace refatoracao.R12.ExtractClass.antes
{
    class Empresa


    {
        public RazaoSocial RazaoSocial { get; private set; }

        public CNPJ CNPJ { get; private set; }

        public Endereco EnderecoComercial { get; private set; } 
        public Endereco EnderecoEntrega { get; private set; }

        public Empresa(RazaoSocial razaoSocial, CNPJ cnpj, Endereco enderecoComercial, Endereco enderecoEntrega)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            EnderecoComercial = enderecoComercial;
            EnderecoEntrega = enderecoEntrega;
        }
  
    }


}
