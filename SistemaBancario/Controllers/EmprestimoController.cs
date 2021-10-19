using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaBancario.AcessoDados;
using SistemaBancario.Models;

namespace SistemaBancario.Controllers
{
    public class EmprestimoController : Controller
    {
        // GET: Emprestimo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Emprestimo()
        {
            return View();
        }
    }
}