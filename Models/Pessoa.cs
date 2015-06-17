using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DtNascimento { get; set; }

        public virtual IList<Endereco> Endereco {get; set; }
        
        //public void AlterarCliente()
        //{


        //}

        //public void IncluirCliente()
        //{


        //}

        //public void ExcluirCliente()
        //{


        //}

        //public void ConsultarCliente()
        //{


        //}
    }
}