namespace LawyerHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1511 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cobroes", "Activo");
            DropColumn("dbo.Pagoes", "Activo");
            DropColumn("dbo.Recordatorios", "Activo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Recordatorios", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pagoes", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cobroes", "Activo", c => c.Boolean(nullable: false));
        }
    }
}
