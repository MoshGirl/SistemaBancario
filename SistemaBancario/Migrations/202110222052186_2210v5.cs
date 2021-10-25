namespace SistemaBancario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2210v5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Nome", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Usuarios", "CPF", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Usuarios", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(maxLength: 100));
            AlterColumn("dbo.Usuarios", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.Usuarios", "CPF", c => c.String(maxLength: 100));
            AlterColumn("dbo.Usuarios", "Nome", c => c.String(maxLength: 100));
        }
    }
}
