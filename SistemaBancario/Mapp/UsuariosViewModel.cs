using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AutoMapper;
using SistemaBancario.Models;
using SistemaBancario.Models.Enums;

namespace SistemaBancario.Mapp
{
    public class UsuariosViewModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [Required]
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string NomeEmpresa { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public DateTime DataDeNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        [Required]
        public AtividadeAtual AtividadeAtual { get; set; }

        public Telefones Telefones { get; set; }
        public Enderecos Enderecos { get; set; }
        public Conta Conta { get; set; }
        public object Id { get; internal set; }

        static void Main(string[] args)
        {
            //Configure and create an instace for the mapper
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Usuarios, UsuariosViewModel>());
            var mapper = config.CreateMapper();
        }
    }
}