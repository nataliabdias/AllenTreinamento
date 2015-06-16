using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models
{
    public class Conta
    {

        public int Banco { get; set; }
        public string Agencia { get; set; }
        public string Numero { get; set; }
        public decimal Saldo { get; set; }
        public decimal valorChequeEspecial { get; set; }
    }
}