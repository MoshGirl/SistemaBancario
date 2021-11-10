using SistemaBancario.Mapp;
using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SistemaBancario.AcessoDados
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext() : base("DefaultConnection")
        {
        }

        public DbSet <Usuarios> Usuarios { get; set; }
        public DbSet <Enderecos> Enderecos { get; set; }
        public DbSet <Conta> Conta { get; set; }
        public DbSet <Telefones> Telefones { get; set; }
        public DbSet <Historico> Historico { get; set; }
        public DbSet <Emprestimos> Emprestimos { get; set; }

        //public DbSet <TipoUsuarios> TipoUsuarios{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(100));
        }
    }
}