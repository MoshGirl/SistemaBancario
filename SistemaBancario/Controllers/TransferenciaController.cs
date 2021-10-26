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
            return View();
        }

        public ActionResult RealizarTransferencias(double valor, string numeroConta)
        {
            var db = new UsuarioContext();

            var idLogado = Session["UsuarioLogadoId"];
            Conta contaTitular = new Conta();
            Conta contaParaTransferir = new Conta();

            contaTitular = db.Conta.Find(idLogado);
            contaParaTransferir = db.Conta.Find(numeroConta);

            var user = db.Usuarios.Find(idLogado);

            contaParaTransferir.Saldo = contaParaTransferir.Saldo + valor;
            contaTitular.Saldo = contaTitular.Saldo - valor;

            return View();
        }

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