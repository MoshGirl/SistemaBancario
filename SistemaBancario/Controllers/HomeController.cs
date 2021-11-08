using SistemaBancario.AcessoDados;
using SistemaBancario.Mapp;
using SistemaBancario.Models;
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
                Usuarios user = new Usuarios();
                user = db.Usuarios.Find(idLogado);
                

                ViewBag.Saldo = user.Conta.Saldo;
                ViewBag.NConta = user.Conta.NumeroDaConta;

                

                int id = (int)Session["UsuarioLogadoId"];
                double Receita=0;
                double Despesa = 0;

                var graficoReceita = db.Historico.Where(a => a.id_usuario.Equals(id) && a.Tipo.Equals("R"));
                var graficoDespesa = db.Historico.Where(a => a.id_usuario.Equals(id) && a.Tipo.Equals("D"));

                foreach (var GR in graficoReceita)
                {
                    Receita += GR.Valor;
                }

                foreach (var GD in graficoDespesa)
                {
                    Despesa += GD.Valor;
                }
                ViewBag.Receita = Receita;
                ViewBag.Despesa = Despesa;

                return View(db.Historico.Where(a => a.id_usuario.Equals(id)).OrderByDescending(a=>a.Data).Take(5));


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