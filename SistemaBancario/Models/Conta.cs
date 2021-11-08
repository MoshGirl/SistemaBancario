using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaBancario.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public string NumeroDaConta { get; set; }
        public DateTime DataDaConta { get; set; }
        public decimal Saldo { get; set; }

    }


}