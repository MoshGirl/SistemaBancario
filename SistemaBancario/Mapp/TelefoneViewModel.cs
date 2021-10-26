using AutoMapper;
using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBancario.Mapp
{
    public class TelefoneViewModel
    {
        public int Id { get; set; }
        public string DDD { get; set; }
        public string Telefone { get; set; }

        static void Main(string[] args)
        {
            //Configure and create an instace for the mapper

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Telefones, TelefoneViewModel>());
            var mapper = config.CreateMapper();
        }
    }
}