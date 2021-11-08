using SistemaBancario.AcessoDados;
using SistemaBancario.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace SistemaBancario.Controllers
{
    public class TransferenciaController : Controller
    {
        private ValidarSaldoService _validarSaldoService;
        // GET: Transferencia

        public TransferenciaController()
        {
            _validarSaldoService = new ValidarSaldoService();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Transferencias()
        {
            var idLogado = Session["UsuarioLogadoId"];
            int id = (int)idLogado;

            var saldoUsuario = _validarSaldoService.ConsultaSaldo(id);
            ViewBag.Saldo = saldoUsuario;

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

            if (contaTitular.Saldo > valor && !contaTitular.NumeroDaConta.Equals(numeroConta)) {
                
                contaParaTransferir = db.Conta.Where(a => a.NumeroDaConta.Equals(numeroConta))
                    .FirstOrDefault();

                if(contaParaTransferir != null)
                {

                
                var user = db.Usuarios.Find(idLogado);


                contaParaTransferir.Saldo = contaParaTransferir.Saldo + valor;
                contaTitular.Saldo = contaTitular.Saldo - valor;

                Historico historico = new Historico();
                historico.Data = DateTime.Now;
                historico.Descricao = "Transferencia para conta: "+numeroConta;
                historico.Tipo = "D";
                historico.Valor = valor;
                historico.id_usuario = (int)Session["UsuarioLogadoId"];

                //----------------------------------------------------

                Historico historicoUserRecebe = new Historico();
                historicoUserRecebe.Data = DateTime.Now;
                historicoUserRecebe.Descricao = "Deposito de : "+user.Nome;
                historicoUserRecebe.Tipo = "R";
                historicoUserRecebe.Valor = valor;
                Conta conta = db.Conta.Where(a => a.NumeroDaConta.Equals(numeroConta)).FirstOrDefault();
                historicoUserRecebe.id_usuario = conta.Id;

                db.Historico.Add(historico);
                db.Historico.Add(historicoUserRecebe);

                db.SaveChanges();
                ViewBag.mensagemSucesso = "Transferencia realizada!";
                return View();
                }
                else
                {
                    int id = (int)idLogado;
                    var saldoUsuario = _validarSaldoService.ConsultaSaldo(id);
                    ViewBag.Saldo = saldoUsuario;
                    ViewBag.mensagemSucesso = "Usuario Invalido";
                    return View();
                }

            }

            else
            {
                ViewBag.mensagemErro = "Erro ao encontrar destinatario ou por falta de saldo! ";
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