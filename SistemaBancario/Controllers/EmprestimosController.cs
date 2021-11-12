using SistemaBancario.AcessoDados;
using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaBancario.Controllers
{
    public class EmprestimosController : Controller
    {
        
        private UsuarioContext db = new UsuarioContext();

        public ActionResult Index()
        {
            var idLogado = Session["UsuarioLogadoId"];
            var listaEmprestimo = db.Emprestimos.Where(a => a.id_usuario.Equals((int)idLogado)).ToList();
            return View(listaEmprestimo);
        }
        public ActionResult ver()
        {
            var idLogado = Session["UsuarioLogadoId"];
            var listaEmprestimo = db.Emprestimos.Where(a => a.id_usuario.Equals((int)idLogado)).ToList();
            return View(listaEmprestimo);
        }
        public ActionResult Solicitar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Solicitar(Emprestimos emprestimosView)
        {
            var idLogado = Session["UsuarioLogadoId"];
            var data = DateTime.Now.ToString("dd/MM/yyyy");


            Emprestimos emprestimos = new Emprestimos();
            Usuarios user = new Usuarios();
            Enderecos end = new Enderecos();
            Conta conta = new Conta();
            DateTime dataVencimento = Convert.ToDateTime(data);
            dataVencimento.AddDays(+30);

            var valorEmprestimoSemJuros = emprestimosView.ValorTotal;

            emprestimos.ValorDoJuros = emprestimosView.ValorTotal * 0.05;
            emprestimos.ValorTotal = emprestimosView.ValorTotal + emprestimos.ValorDoJuros;
            emprestimos.NumeroDeParcelas = emprestimosView.NumeroDeParcelas;
            
            emprestimos.TotalPago = 0;
            emprestimos.DiaVencimento = dataVencimento;
            emprestimos.DiaPago = dataVencimento;
            emprestimos.id_usuario = (int)Session["UsuarioLogadoId"];

            conta = db.Conta.Find(idLogado);
            conta.Saldo += valorEmprestimoSemJuros;


            Historico historico = new Historico();
            historico.Data = DateTime.Now;
            historico.Descricao = "Emprestimo";
            historico.Tipo = "R";
            historico.Valor = emprestimosView.ValorTotal;
            historico.id_usuario = (int)Session["UsuarioLogadoId"];

            db.Historico.Add(historico);

            db.Emprestimos.Add(emprestimos);
            db.SaveChanges();

            return RedirectToAction("/Index");
        }

    }
}