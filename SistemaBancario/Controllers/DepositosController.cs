using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaBancario.Controllers
{
    public class DepositosController : Controller
    {
        // GET: Depositos

        [AllowAnonymous]

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Depositos()
        {
            return View();
        }
    }
}