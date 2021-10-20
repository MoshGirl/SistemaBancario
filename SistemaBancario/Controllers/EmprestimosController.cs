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
<<<<<<< Updated upstream
=======
        [AllowAnonymous]
>>>>>>> Stashed changes
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Emprestimos()
        {
            return View();
        }

    }
}