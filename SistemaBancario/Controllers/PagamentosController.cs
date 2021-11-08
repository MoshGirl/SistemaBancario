using SistemaBancario.AcessoDados;
using SistemaBancario.Models;
using System;
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

        [HttpPost]
        public ActionResult Pagamentos(string codigo, double valor, string dataVencimento)
        {

            var db = new UsuarioContext();

            var idLogado = Session["UsuarioLogadoId"];
            Conta contaUsuario = new Conta();
            contaUsuario = db.Conta.Find(idLogado);

            if (contaUsuario.Saldo > valor && !contaUsuario.NumeroDaConta.Equals(contaUsuario.Id))
            {
                var user = db.Usuarios.Find(idLogado);
                user.Conta.Saldo = user.Conta.Saldo - valor;
                

                Historico historico = new Historico();
                historico.Data = DateTime.Now;
                historico.Descricao = "Pagamento de conta: "+codigo;
                historico.Tipo = "D";
                historico.Valor = valor;
                historico.id_usuario = (int)Session["UsuarioLogadoId"];
                db.Historico.Add(historico);

                db.SaveChanges();
                return View();

            }

            return View();
        }
    }
}