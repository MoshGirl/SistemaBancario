namespace SistemaBancario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2210Joao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Conta_Id", c => c.Int());
            AlterColumn("dbo.Conta", "Saldo", c => c.Double(nullable: false));
            CreateIndex("dbo.Usuarios", "Conta_Id");
            AddForeignKey("dbo.Usuarios", "Conta_Id", "dbo.Conta", "Id");
            DropColumn("dbo.Conta", "LimiteDoUsuario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Conta", "LimiteDoUsuario", c => c.String(maxLength: 100));
            DropForeignKey("dbo.Usuarios", "Conta_Id", "dbo.Conta");
            DropIndex("dbo.Usuarios", new[] { "Conta_Id" });
            AlterColumn("dbo.Conta", "Saldo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Usuarios", "Conta_Id");
        }
    }
}
