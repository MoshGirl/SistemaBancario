using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaBancario.Controllers
{
    public class EmprestimosController : Controller
    {
        // GET: Emprestimos
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Emprestimos()
        {
            return View();
        }

    }
}