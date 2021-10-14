﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBancario.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public string NumeroDaConta { get; set; }
        public DateTime DataDaConta { get; set; }
        public decimal Saldo { get; set; }
        public string LimiteDoUsuario { get; set; }
        public string Complemento { get; set; }

        public Usuarios Usuarios { get; set; }
        public int Id_Usuario { get; set; }
    }

}