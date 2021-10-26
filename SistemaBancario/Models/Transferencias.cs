using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBancario.Models
{
    public class Transferencias
    {
        public int Id { get; set; }
        public double ValorDeTransferencia { get; set; }
        public string NomeDoBanco { get; set; }
        public int Agencia { get; set; }
        public string Conta { get; set; }
        public string NomeDoFavorecido { get; set; }
        public string CpfCnpj { get; set; }
        public DateTime DiaDaTransferencia { get; set; }
        public Usuarios Usuarios { get; set; }
        public Conta Contas { get; set; }
    }
}