using System;

namespace SistemaBancario.Models
{
    public class Emprestimos
    {
        public int Id { get; set; }
        public double ValorTotal { get; set; }
        public int NumeroDeParcelas { get; set; }
        public double ValorDoJuros { get; set; }
        public DateTime DiaVencimento { get; set; }
        public DateTime DiaPago { get; set; }
        public double TotalPago { get; set; }
        public int id_usuario { get; set; }

    }
}