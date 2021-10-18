namespace SistemaBancario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                        Id_Usuario = c.Int(nullable: false),
                        Usuarios_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id)
                .Index(t => t.Usuarios_Id);
            
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
                        Id_TipoUsuario = c.Int(nullable: false),
                        TipoUsuarios_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoUsuarios", t => t.TipoUsuarios_Id)
                .Index(t => t.TipoUsuarios_Id);
            
            CreateTable(
                "dbo.TipoUsuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeTipo = c.String(maxLength: 100),
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
                        Id_Usuario = c.Int(nullable: false),
                        Usuarios_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id)
                .Index(t => t.Usuarios_Id);
            
            CreateTable(
                "dbo.Telefones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DDD = c.String(maxLength: 100),
                        Telefone = c.String(maxLength: 100),
                        Id_Usuario = c.Int(nullable: false),
                        Usuarios_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id)
                .Index(t => t.Usuarios_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefones", "Usuarios_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Enderecos", "Usuarios_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Conta", "Usuarios_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "TipoUsuarios_Id", "dbo.TipoUsuarios");
            DropIndex("dbo.Telefones", new[] { "Usuarios_Id" });
            DropIndex("dbo.Enderecos", new[] { "Usuarios_Id" });
            DropIndex("dbo.Usuarios", new[] { "TipoUsuarios_Id" });
            DropIndex("dbo.Conta", new[] { "Usuarios_Id" });
            DropTable("dbo.Telefones");
            DropTable("dbo.Enderecos");
            DropTable("dbo.TipoUsuarios");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Conta");
        }
    }
}
