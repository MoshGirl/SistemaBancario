namespace SistemaBancario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2110 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Conta", "Complemento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Conta", "Complemento", c => c.String(maxLength: 100));
        }
    }
}
