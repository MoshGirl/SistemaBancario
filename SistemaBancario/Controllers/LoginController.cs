using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            var loguei = false;

            var db = new UsuarioContext();

           
            var v = db.Usuarios.Where(a => a.CPF.Equals(cpf) && a.Senha.Equals(senha)).FirstOrDefault();

            if (v != null)
            {
                Usuarios user = new Usuarios();
                FormsAuthentication.SetAuthCookie(cpf, true);
                loguei = true;

            }

            return RedirectToAction("Index", "Home"); 
        }

    }
}