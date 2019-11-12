namespace LawyerHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nueva : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cobroes", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Juicios", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Demandadoes", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Personas", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Demandantes", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Documentoes", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pagoes", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Recordatorios", "Activo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recordatorios", "Activo");
            DropColumn("dbo.Pagoes", "Activo");
            DropColumn("dbo.Documentoes", "Activo");
            DropColumn("dbo.Demandantes", "Activo");
            DropColumn("dbo.Personas", "Activo");
            DropColumn("dbo.Demandadoes", "Activo");
            DropColumn("dbo.Juicios", "Activo");
            DropColumn("dbo.Cobroes", "Activo");
        }
    }
}
