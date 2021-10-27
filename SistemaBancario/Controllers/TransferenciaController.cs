using SistemaBancario.AcessoDados;
using SistemaBancario.Models;
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
            UsuarioContext db = new UsuarioContext();

            var id = (int)Session["UsuarioLogadoId"];
            var saldo = db.Usuarios.Find(id);
            return View();
        }

        [HttpPost]
        public ActionResult Transferencias(double valor, string numeroConta)
        {
            var db = new UsuarioContext();

            var idLogado = Session["UsuarioLogadoId"];
            Conta contaTitular = new Conta();
            Conta contaParaTransferir = new Conta();
            contaTitular = db.Conta.Find(idLogado);

            if (contaTitular.Saldo > valor) {
                
                contaParaTransferir = db.Conta.Where(a => a.NumeroDaConta.Equals(numeroConta))
                    .FirstOrDefault();

                var user = db.Usuarios.Find(idLogado);

                contaParaTransferir.Saldo = contaParaTransferir.Saldo + valor;
                contaTitular.Saldo = contaTitular.Saldo - valor;
                db.SaveChanges();
                return View();

            }

            else
            {
                // fazer mensagem de erro
                return View();
            }
        }
        [HttpPost]
        public ActionResult RealizarTransferenciasCPF(double valor, string cpf)
        {
            var db = new UsuarioContext();

            var idLogado = Session["UsuarioLogadoId"];
            Conta contaTitular = new Conta();
            Conta contaParaTransferir = new Conta();

            var user = db.Usuarios.Find(idLogado);

            contaParaTransferir = (Conta)db.Usuarios.Where(a => a.CPF.Equals(cpf));
           
            contaParaTransferir.Saldo = contaParaTransferir.Saldo + valor;
            contaTitular.Saldo = contaTitular.Saldo - valor;

            return View();
        }

    }
}