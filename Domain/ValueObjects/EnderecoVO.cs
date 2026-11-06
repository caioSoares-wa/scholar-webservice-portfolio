using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class EnderecoVO
    {
        
        public string Logradouro { get; private set; } 
        public string Complemento { get; private set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }


        public EnderecoVO( string log, string compl , string bairro, int cep) {
        
            this.Logradouro = log;
            this.Complemento = compl;
            this.Bairro = bairro;
            this.CEP = cep;
        }

    }
}
