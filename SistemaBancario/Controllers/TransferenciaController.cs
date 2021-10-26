using SistemaBancario.AcessoDados;
using System.Linq;
using System.Web.Mvc;

namespace SistemaBancario.Controllers
{
    public class TransferenciaController : Controller
    {
        // GET: Transferencia
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Transferencias()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Pesquisa(string valor)
        {
            UsuarioContext db = new UsuarioContext();
            return View(db.Usuarios.Where(a => a.CPF.Contains(valor) || a.CNPJ.Contains(valor)));
        }
    }
}