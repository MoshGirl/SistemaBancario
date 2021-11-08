using SistemaBancario.AcessoDados;
using SistemaBancario.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SistemaBancario.Controllers
{
    public class LoginController : Controller
    {
        private UsuarioContext _context;

        public LoginController()
        {
            _context = new UsuarioContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string cpf, string senha)
        {

            Usuarios usuario = _context.Usuarios.Where(a => a.CPF.Equals(cpf) && a.Senha.Equals(senha)).FirstOrDefault();

            if (usuario != null)
            {
                Usuarios user = new Usuarios();
                Conta conta = new Conta();
                FormsAuthentication.SetAuthCookie(cpf, true);

                Session["UsuarioLogadoNome"] = usuario.Nome;
                Session["UsuarioLogadoId"] = usuario.Id;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.mensagemErro = "Usuario ou senha invalidos!!!";
                return View();
            }

            
        }

        public ActionResult SingOut()
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();

            return RedirectToAction("Index", "Home");
        }

    }
}