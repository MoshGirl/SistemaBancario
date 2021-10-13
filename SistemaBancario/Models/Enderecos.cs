using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBancario.Models
{
    public class Enderecos
    {
        public int Id { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public Usuarios Usuarios { get; set; }
        public int Id_Usuario { get; set; }
    }
}