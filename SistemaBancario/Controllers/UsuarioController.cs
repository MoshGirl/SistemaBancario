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
    public class UsuarioController : Controller
    {
        private UsuarioContext db = new UsuarioContext();

        // GET: Usuario
        public ActionResult Index()
        {
            return View(db.Usuarios.ToList());
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios usuarios = db.Usuarios.Find(id);
            if (usuarios == null)
            {
                return HttpNotFound();
            }
            return View(usuarios);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                Usuarios user = new Usuarios();
                Telefones tel = new Telefones();
                Enderecos end = new Enderecos();




                tel.DDD = usuarios.Telefones.DDD;
                tel.Telefone = usuarios.Telefones.Telefone;
                //tel.Id_Usuario = usuarios.Id;

                end.Pais = usuarios.Enderecos.Pais;
                end.Estado = usuarios.Enderecos.Estado;
                end.Cidade = usuarios.Enderecos.Cidade;
                end.Bairro = usuarios.Enderecos.Bairro;
                end.Rua = usuarios.Enderecos.Rua;
                end.Numero = usuarios.Enderecos.Numero;
                end.Complemento = usuarios.Enderecos.Complemento;
                //end.Id_Usuario = usuarios.Id;

                user.Nome = usuarios.Nome;
                user.Sobrenome = usuarios.Sobrenome;
                user.CPF = usuarios.CPF;
                user.CNPJ = usuarios.CNPJ;
                user.NomeEmpresa = usuarios.NomeEmpresa;
                user.Email = usuarios.Email;
                user.Senha = usuarios.Senha;
                //user.TipoUsuarios = null;
                
                user.DataDeNascimento = usuarios.DataDeNascimento;
                user.Sexo = usuarios.Sexo;
                user.EstadoCivil = usuarios.EstadoCivil;
                user.AtividadeAtual = usuarios.AtividadeAtual;


                user.Enderecos = end;
                user.Telefones = tel;


                user.Enderecos.Pais = end.Pais;
                user.Enderecos.Estado = end.Estado;
                user.Enderecos.Cidade = end.Cidade;
                user.Enderecos.Bairro = end.Bairro;
                user.Enderecos.Rua = end.Rua;
                user.Enderecos.Numero = end.Numero;
                user.Enderecos.Complemento = end.Complemento;
                //user.Enderecos.Id_Usuario = usuarios.Id;

                db.Usuarios.Add(usuarios);
                db.SaveChanges();
                return RedirectToAction("../Home");
            }

            return View(usuarios);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios usuarios = db.Usuarios.Find(id);
            if (usuarios == null)
            {
                return HttpNotFound();
            }
            return View(usuarios);
        }

        // POST: Usuario/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Sobrenome,CPF,CNPJ,NomeEmpresa,Email,Senha,Id_TipoUsuario")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuarios);
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios usuarios = db.Usuarios.Find(id);
            if (usuarios == null)
            {
                return HttpNotFound();
            }
            return View(usuarios);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuarios usuarios = db.Usuarios.Find(id);
            db.Usuarios.Remove(usuarios);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
