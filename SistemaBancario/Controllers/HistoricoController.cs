using SistemaBancario.AcessoDados;
using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaBancario.Controllers
{
    public class HistoricoController : Controller
    {
        // GET: Historico
        public ActionResult Index()
        {
            UsuarioContext db = new UsuarioContext();
            int id = (int)Session["UsuarioLogadoId"];

            return View(db.Historico.Where(a=>a.id_usuario.Equals(id)));
        }

    }
}