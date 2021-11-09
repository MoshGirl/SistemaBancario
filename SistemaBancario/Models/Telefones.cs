using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaBancario.Models
{
    public class Telefones
    {
        public int Id { get; set; }
        [Required]
        public string DDD { get; set; }
        [Required]
        public string Telefone { get; set; }

        //public Usuarios Usuarios; 
        //[Key, ForeignKey("Usuarios")]
        //public int Id_Usuario { get; set; }
    }
}