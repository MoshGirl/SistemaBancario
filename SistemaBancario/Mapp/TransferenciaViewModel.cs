﻿using AutoMapper;
using SistemaBancario.Models;
using System;

namespace SistemaBancario.Mapp
{
    public class TransferenciaViewModel
    {
        public int Id { get; set; }
        public double ValorDeTransferencia { get; set; }
        public string NomeDoBanco { get; set; }
        public int AgenciaDestino { get; set; }
        public string ContaDestino { get; set; }
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