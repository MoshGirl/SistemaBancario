using SistemaBancario.AcessoDados;
using SistemaBancario.Models;
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

            var db = new UsuarioContext();

           
            var usuario = db.Usuarios.Where(a => a.CPF.Equals(cpf) && a.Senha.Equals(senha)).FirstOrDefault();

            if (usuario != null)
            {
                Usuarios user = new Usuarios();
                FormsAuthentication.SetAuthCookie(cpf, true);

                Session["UsuarioLogadoNome"] = usuario.Nome;
                Session["UsuarioLogadoId"] = usuario.Id;
            }

            return RedirectToAction("Index", "Home"); 
        }

        public ActionResult SingOut()
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();

            return RedirectToAction("Index", "Home");
        }

    }
}