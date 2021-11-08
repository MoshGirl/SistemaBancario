﻿using SistemaBancario.AcessoDados;
using SistemaBancario.Mapp;
using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaBancario.Controllers
{
    public class DepositosController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Depositos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Depositos(double Valor)
        {
            var db = new UsuarioContext();

            if (Valor > 0)
            {
                //Somar valor depositado com o saldo
                var idLogado = Session["UsuarioLogadoId"];
                Conta conta = new Conta();

                conta = db.Conta.Find(idLogado);
                var user = db.Usuarios.Find(idLogado);

                // var usuarios = db.Usuarios.Where(a => a.id == "4").FirstOrDefault();

                user.Conta.Saldo += Valor;


                Historico historico = new Historico();
                historico.Data = DateTime.Now;
                historico.Descricao = "Deposito";
                historico.Tipo = "R";
                historico.Valor = Valor;
                historico.id_usuario = (int)Session["UsuarioLogadoId"];

                db.Historico.Add(historico);

                db.SaveChanges();


                //-------------------------


                return RedirectToAction(@"../Home");


            }

            else
            {
                //Mensagem de valor inválido
            }


            return View();
        }
    }
}