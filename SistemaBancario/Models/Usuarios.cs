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
        internal string id;

        public int Id { get; set; }
        [Required]
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
    }
}