using SistemaBancario.AcessoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBancario.Models
{
    public class LoginModel
    {
        public static bool ValidarUsuario(string cpf, string senha)
        {
            var loguei = false;

            var db = new UsuarioContext();

            var rest = db.Usuarios.Where(a => a.CPF == cpf || (a.CNPJ == cpf && a.Senha == senha)).ToString();

            if (rest.Equals("true"))
            {

                loguei = true;         

            }


            return loguei;
        }


    }
}