namespace SistemaBancario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tentandoarrumaralgo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Historico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Descricao = c.String(maxLength: 100),
                        Tipo = c.String(maxLength: 100),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        id_usuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Historico");
        }
    }
}
