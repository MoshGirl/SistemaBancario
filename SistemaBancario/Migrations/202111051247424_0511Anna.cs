namespace SistemaBancario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0511Anna : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Sobrenome", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Usuarios", "CPF", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "CPF", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Usuarios", "Sobrenome", c => c.String(maxLength: 100));
        }
    }
}
