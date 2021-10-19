namespace SistemaBancario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroDaConta = c.String(maxLength: 100),
                        DataDaConta = c.DateTime(nullable: false),
                        Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LimiteDoUsuario = c.String(maxLength: 100),
                        Complemento = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Enderecos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pais = c.String(maxLength: 100),
                        Estado = c.String(maxLength: 100),
                        Cidade = c.String(maxLength: 100),
                        Bairro = c.String(maxLength: 100),
                        Rua = c.String(maxLength: 100),
                        Numero = c.String(maxLength: 100),
                        Complemento = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Telefones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DDD = c.String(maxLength: 100),
                        Telefone = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        Sobrenome = c.String(maxLength: 100),
                        CPF = c.String(maxLength: 100),
                        CNPJ = c.String(maxLength: 100),
                        NomeEmpresa = c.String(maxLength: 100),
                        Email = c.String(maxLength: 100),
                        Senha = c.String(maxLength: 100),
                        DataDeNascimento = c.DateTime(nullable: false),
                        Sexo = c.Int(nullable: false),
                        EstadoCivil = c.Int(nullable: false),
                        AtividadeAtual = c.Int(nullable: false),
                        Enderecos_Id = c.Int(),
                        Telefones_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enderecos", t => t.Enderecos_Id)
                .ForeignKey("dbo.Telefones", t => t.Telefones_Id)
                .Index(t => t.Enderecos_Id)
                .Index(t => t.Telefones_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "Telefones_Id", "dbo.Telefones");
            DropForeignKey("dbo.Usuarios", "Enderecos_Id", "dbo.Enderecos");
            DropIndex("dbo.Usuarios", new[] { "Telefones_Id" });
            DropIndex("dbo.Usuarios", new[] { "Enderecos_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Telefones");
            DropTable("dbo.Enderecos");
            DropTable("dbo.Conta");
        }
    }
}
