namespace SistemaBancario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuarios", "TipoUsuarios_Id", "dbo.TipoUsuarios");
            DropForeignKey("dbo.Conta", "Usuarios_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Enderecos", "Usuarios_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Telefones", "Usuarios_Id", "dbo.Usuarios");
            DropIndex("dbo.Conta", new[] { "Usuarios_Id" });
            DropIndex("dbo.Usuarios", new[] { "TipoUsuarios_Id" });
            DropIndex("dbo.Enderecos", new[] { "Usuarios_Id" });
            DropIndex("dbo.Telefones", new[] { "Usuarios_Id" });
            AddColumn("dbo.Usuarios", "DataDeNascimento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Usuarios", "Sexo", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "EstadoCivil", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "AtividadeAtual", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "Enderecos_Id", c => c.Int());
            AddColumn("dbo.Usuarios", "Telefones_Id", c => c.Int());
            CreateIndex("dbo.Usuarios", "Enderecos_Id");
            CreateIndex("dbo.Usuarios", "Telefones_Id");
            AddForeignKey("dbo.Usuarios", "Enderecos_Id", "dbo.Enderecos", "Id");
            AddForeignKey("dbo.Usuarios", "Telefones_Id", "dbo.Telefones", "Id");
            DropColumn("dbo.Conta", "Id_Usuario");
            DropColumn("dbo.Conta", "Usuarios_Id");
            DropColumn("dbo.Usuarios", "Id_TipoUsuario");
            DropColumn("dbo.Usuarios", "TipoUsuarios_Id");
            DropColumn("dbo.Enderecos", "Id_Usuario");
            DropColumn("dbo.Enderecos", "Usuarios_Id");
            DropColumn("dbo.Telefones", "Id_Usuario");
            DropColumn("dbo.Telefones", "Usuarios_Id");
            DropTable("dbo.TipoUsuarios");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TipoUsuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeTipo = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Telefones", "Usuarios_Id", c => c.Int());
            AddColumn("dbo.Telefones", "Id_Usuario", c => c.Int(nullable: false));
            AddColumn("dbo.Enderecos", "Usuarios_Id", c => c.Int());
            AddColumn("dbo.Enderecos", "Id_Usuario", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "TipoUsuarios_Id", c => c.Int());
            AddColumn("dbo.Usuarios", "Id_TipoUsuario", c => c.Int(nullable: false));
            AddColumn("dbo.Conta", "Usuarios_Id", c => c.Int());
            AddColumn("dbo.Conta", "Id_Usuario", c => c.Int(nullable: false));
            DropForeignKey("dbo.Usuarios", "Telefones_Id", "dbo.Telefones");
            DropForeignKey("dbo.Usuarios", "Enderecos_Id", "dbo.Enderecos");
            DropIndex("dbo.Usuarios", new[] { "Telefones_Id" });
            DropIndex("dbo.Usuarios", new[] { "Enderecos_Id" });
            DropColumn("dbo.Usuarios", "Telefones_Id");
            DropColumn("dbo.Usuarios", "Enderecos_Id");
            DropColumn("dbo.Usuarios", "AtividadeAtual");
            DropColumn("dbo.Usuarios", "EstadoCivil");
            DropColumn("dbo.Usuarios", "Sexo");
            DropColumn("dbo.Usuarios", "DataDeNascimento");
            CreateIndex("dbo.Telefones", "Usuarios_Id");
            CreateIndex("dbo.Enderecos", "Usuarios_Id");
            CreateIndex("dbo.Usuarios", "TipoUsuarios_Id");
            CreateIndex("dbo.Conta", "Usuarios_Id");
            AddForeignKey("dbo.Telefones", "Usuarios_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Enderecos", "Usuarios_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Conta", "Usuarios_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Usuarios", "TipoUsuarios_Id", "dbo.TipoUsuarios", "Id");
        }
    }
}
