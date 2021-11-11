using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Models
{
    public class Emprestimos
    {
        public int Id { get; set; }
        [Display(Name = "Valor")]
        public double ValorTotal { get; set; }
        [Display(Name = "Número de  Parcelas")]
        public int NumeroDeParcelas { get; set; }
        public double ValorDoJuros { get; set; }
        [Display(Name = "Data de Vencimento")]
        public DateTime DiaVencimento { get; set; }
        public DateTime DiaPago { get; set; }
        public double TotalPago { get; set; }
        public int id_usuario { get; set; }

    }
}