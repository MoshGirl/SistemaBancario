using AutoMapper;
using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBancario.Mapp
{
    public class TransferenciaViewModel
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

        static void Main(string[] args)
        {
            //Configure and create an instace for the mapper

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Transferencias, TransferenciaViewModel>());
            var mapper = config.CreateMapper();
        }
    }
}