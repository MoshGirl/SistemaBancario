﻿using SistemaBancario.AcessoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaBancario.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (!Request.IsAuthenticated)
            {
                return View();

            }
            else
            {
                var db = new UsuarioContext();
                var idLogado = Session["UsuarioLogadoId"];

                var Conta = db.Conta.Find(idLogado);
                var user = db.Usuarios.Find(idLogado);
                

                ViewBag.Saldo = user.Conta.Saldo;
                return View();
            }

        }

        public ActionResult About()
        {
            ViewBag.Message = "Um pouco sobre o projeto desenvolvido.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}