using SistemaBancario.AcessoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaBancario.Models
{
    public class ValidarSaldoService
    {

        public decimal ConsultaSaldo(int id)
        {
            var idLogado = id;
            UsuarioContext db = new UsuarioContext();

            var conta = db.Conta.Find(idLogado);
            Usuarios user = new Usuarios();
            var usuarioLogado = db.Usuarios.Find(idLogado);

            var saldo = conta.Saldo;
            return (decimal)saldo;
        }
    }
}