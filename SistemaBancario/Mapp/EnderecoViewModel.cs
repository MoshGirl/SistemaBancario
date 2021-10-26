using AutoMapper;
using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBancario.Mapp
{
    public class EnderecoViewModel
    {
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        static void Main(string[] args)
        {
            //Configure and create an instace for the mapper

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Enderecos, EnderecoViewModel>());
            var mapper = config.CreateMapper();
        }
    }
}