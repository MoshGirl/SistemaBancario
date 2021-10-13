using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBancario.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string NomeEmpresa { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuarios TipoUsuarios { get; set; }
        public int Id_TipoUsuario { get; set; }
    }
}