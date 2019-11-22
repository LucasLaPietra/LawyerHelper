namespace LawyerHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class neva3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Documentoes", "Juicio_JuicioId", "dbo.Juicios");
            AddColumn("dbo.Documentoes", "Juicio_JuicioId1", c => c.Int());
            AddColumn("dbo.Documentoes", "Juicio_JuicioId2", c => c.Int());
            CreateIndex("dbo.Documentoes", "Juicio_JuicioId1");
            CreateIndex("dbo.Documentoes", "Juicio_JuicioId2");
            AddForeignKey("dbo.Documentoes", "Juicio_JuicioId2", "dbo.Juicios", "JuicioId");
            AddForeignKey("dbo.Documentoes", "Juicio_JuicioId1", "dbo.Juicios", "JuicioId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Documentoes", "Juicio_JuicioId1", "dbo.Juicios");
            DropForeignKey("dbo.Documentoes", "Juicio_JuicioId2", "dbo.Juicios");
            DropIndex("dbo.Documentoes", new[] { "Juicio_JuicioId2" });
            DropIndex("dbo.Documentoes", new[] { "Juicio_JuicioId1" });
            DropColumn("dbo.Documentoes", "Juicio_JuicioId2");
            DropColumn("dbo.Documentoes", "Juicio_JuicioId1");
            AddForeignKey("dbo.Documentoes", "Juicio_JuicioId", "dbo.Juicios", "JuicioId");
        }
    }
}
