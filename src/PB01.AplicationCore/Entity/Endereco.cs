using System;
using System.Collections.Generic;
using System.Text;

namespace PB01.AplicationCore.Entity
{
    class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
    }
}
