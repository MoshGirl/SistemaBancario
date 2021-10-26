using AutoMapper;
using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBancario.Mapp
{
    public class EmprestimoViewModel
    {

        public double ValorTotal { get; set; }
        public int NumeroDeParcelas { get; set; }
        public double ValorDoJuros { get; set; }
        public DateTime DiaVencimento { get; set; }
        public DateTime DiaPago { get; set; }
        public double TotalPago { get; set; }
        public Usuarios Usuarios { get; set; }

        static void Main(string[] args)
        {
            //Configure and create an instace for the mapper

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Emprestimos, EmprestimoViewModel>());
            var mapper = config.CreateMapper();
        }
    }
}