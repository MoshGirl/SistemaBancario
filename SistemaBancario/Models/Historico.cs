using SistemaBancario.Mapp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBancario.Models
{
    public class Historico
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }
        public int id_usuario { get; set; }
    }
}