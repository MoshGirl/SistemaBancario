using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaBancario.Models
{
    public class Enderecos
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "País")]
        public string Pais { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Rua { get; set; }
        [Required]
        public string Numero { get; set; }
        public string Complemento { get; set; }

        //public Usuarios Usuarios;
        //[Key, ForeignKey("Usuarios")]
        //public int Id_Usuario { get; set; }
    }
}