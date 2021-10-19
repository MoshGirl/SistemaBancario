using System;

namespace SistemaBancario.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public double ValorTotal { get; set; }
        public int NumeroDeParcelas { get; set; }
        public double JurosDaParcela { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime DiaPago { get; set; }
        public double ValorPago { get; set; }
        public Usuarios Usuarios { get; set; }
    }
}