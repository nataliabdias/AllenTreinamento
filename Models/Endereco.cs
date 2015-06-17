using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models
{
    public class Endereco
    {

        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public int IdPessoa { get; set; }
       // public TipoEndereco TipoEndereco { get; set; }
    }
}