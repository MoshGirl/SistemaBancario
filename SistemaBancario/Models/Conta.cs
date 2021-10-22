﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaBancario.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public string NumeroDaConta { get; set; }
        public DateTime DataDaConta { get; set; }
        public double Saldo { get; set; }

        //public Conta(Usuarios id)
        //{
        //    this.NumeroDaConta = id.id;
        //    this.DataDaConta = DateTime.Now;
        //    this.Saldo = 0;
        //    this.Usuarios = id;
        //}
    }


}