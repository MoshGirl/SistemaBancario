using AutoMapper;
using SistemaBancario.Mapp;
using SistemaBancario.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaBancario.Models
{
    public class Usuarios
    {


        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        [Display(Name = "Nome da Empresa")]
        public string NomeEmpresa { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        [Display(Name = "Data de Nascimento")]
        [MinimoDe18Anos]
        public DateTime DataDeNascimento { get; set; }
        [Required]
        public Sexo Sexo { get; set; }
        [Required]
        [Display(Name = "Estado Civil")]
        public EstadoCivil EstadoCivil { get; set; }
        [Required]
        [Display(Name = "Atividade Atual")]
        public AtividadeAtual AtividadeAtual { get; set; }
        public Telefones Telefones { get; set; }
        public Enderecos Enderecos { get; set; }
        public Conta Conta { get; set; }

    }

}