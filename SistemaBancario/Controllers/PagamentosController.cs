﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaBancario.Controllers
{
    public class PagamentosController : Controller
    {
        // GET: Pagamentos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Pagamentos()
        {
            return View();
        }
    }
}