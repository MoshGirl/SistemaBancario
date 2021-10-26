using AutoMapper;
using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBancario.Mapp
{
    public class ContaViewModel
    {
        public string NumeroDaConta { get; set; }
        public double Saldo { get; set; }
        static void Main(string[] args)
        {
            //Configure and create an instace for the mapper
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Conta, ContaViewModel>());
            var mapper = config.CreateMapper();
        }
    }
}