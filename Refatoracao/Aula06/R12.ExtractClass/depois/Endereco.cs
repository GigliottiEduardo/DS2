using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao.Aula06.R12.ExtractClass.depois
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }

        public Endereco(string Logradouro, string Numero, string Complemento, string Bairro, string CEP, string Municipio, string UF)
        {
            this.Logradouro = Logradouro;
            this.Numero = Numero;
            this.Complemento = Complemento;
            this.Bairro = Bairro;
            this.CEP = CEP;
            this.Municipio = Municipio;
            this.UF = UF;
        }
        public string GetEndereco()
        {
            return $"Endereço: {Logradouro} {Numero} {Complemento} - {Bairro} - CEP {CEP} - {Municipio} - {UF}";
        }

        public void UpdateEndereco(string Logradouro, string Numero, string Complemento, string Bairro, string CEP, string Municipio, string UF)
        {
            this.Logradouro = Logradouro;
            this.Numero = Numero;
            this.Complemento = Complemento;
            this.Bairro = Bairro;
            this.CEP =CEP;
            this.Municipio = Municipio;
            this.UF =UF;
        }
    }
}

