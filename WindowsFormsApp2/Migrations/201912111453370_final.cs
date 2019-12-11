namespace LawyerHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cobroes",
                c => new
                    {
                        CobroId = c.Int(nullable: false, identity: true),
                        Importe = c.Double(nullable: false),
                        FechayHora = c.DateTime(nullable: false),
                        Detalle = c.String(),
                        Juicio_JuicioId = c.Int(),
                        Persona_PersonaId = c.Int(),
                    })
                .PrimaryKey(t => t.CobroId)
                .ForeignKey("dbo.Juicios", t => t.Juicio_JuicioId)
                .ForeignKey("dbo.Personas", t => t.Persona_PersonaId)
                .Index(t => t.Juicio_JuicioId)
                .Index(t => t.Persona_PersonaId);
            
            CreateTable(
                "dbo.Juicios",
                c => new
                    {
                        JuicioId = c.Int(nullable: false, identity: true),
                        NroExpediente = c.String(),
                        Juez = c.String(),
                        Secretario = c.String(),
                        Etapa = c.String(),
                        Descripcion = c.String(),
                        Bienes = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        GrupoFamiliar = c.String(),
                        TipoProceso = c.String(),
                        Recurso = c.String(),
                        Competencia = c.String(),
                        Fuero = c.String(),
                        Caratula = c.String(),
                        Folio = c.String(),
                        Libro = c.String(),
                        Jurisdiccion = c.String(),
                        Precio = c.Double(nullable: false),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.JuicioId);
            
            CreateTable(
                "dbo.Demandadoes",
                c => new
                    {
                        DemandadoId = c.Int(nullable: false, identity: true),
                        Cliente = c.Boolean(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        Juicio_JuicioId = c.Int(),
                        Persona_PersonaId = c.Int(),
                    })
                .PrimaryKey(t => t.DemandadoId)
                .ForeignKey("dbo.Juicios", t => t.Juicio_JuicioId)
                .ForeignKey("dbo.Personas", t => t.Persona_PersonaId)
                .Index(t => t.Juicio_JuicioId)
                .Index(t => t.Persona_PersonaId);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Dni = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Profesion = c.String(),
                        LugarTrabajo = c.String(),
                        Cuil = c.String(),
                        EstadoCivil = c.String(),
                        Representante = c.String(),
                        DomicilioLegal = c.String(),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PersonaId);
            
            CreateTable(
                "dbo.Demandantes",
                c => new
                    {
                        DemandanteId = c.Int(nullable: false, identity: true),
                        Cliente = c.Boolean(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        Juicio_JuicioId = c.Int(),
                        Persona_PersonaId = c.Int(),
                    })
                .PrimaryKey(t => t.DemandanteId)
                .ForeignKey("dbo.Juicios", t => t.Juicio_JuicioId)
                .ForeignKey("dbo.Personas", t => t.Persona_PersonaId)
                .Index(t => t.Juicio_JuicioId)
                .Index(t => t.Persona_PersonaId);
            
            CreateTable(
                "dbo.Documentoes",
                c => new
                    {
                        DocumentoId = c.Int(nullable: false, identity: true),
                        TipoDocumento = c.String(),
                        NroFoja = c.String(),
                        EnExpediente = c.Boolean(nullable: false),
                        Nombre = c.String(),
                        Detalle = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        Juicio_JuicioId = c.Int(),
                        Juicio_JuicioId1 = c.Int(),
                        Juicio_JuicioId2 = c.Int(),
                    })
                .PrimaryKey(t => t.DocumentoId)
                .ForeignKey("dbo.Juicios", t => t.Juicio_JuicioId)
                .ForeignKey("dbo.Juicios", t => t.Juicio_JuicioId1)
                .ForeignKey("dbo.Juicios", t => t.Juicio_JuicioId2)
                .Index(t => t.Juicio_JuicioId)
                .Index(t => t.Juicio_JuicioId1)
                .Index(t => t.Juicio_JuicioId2);
            
            CreateTable(
                "dbo.Pagoes",
                c => new
                    {
                        PagoId = c.Int(nullable: false, identity: true),
                        Importe = c.Double(nullable: false),
                        FechayHora = c.DateTime(nullable: false),
                        Detalle = c.String(),
                        Juicio_JuicioId = c.Int(),
                    })
                .PrimaryKey(t => t.PagoId)
                .ForeignKey("dbo.Juicios", t => t.Juicio_JuicioId)
                .Index(t => t.Juicio_JuicioId);
            
            CreateTable(
                "dbo.Recordatorios",
                c => new
                    {
                        RecordatorioId = c.Int(nullable: false, identity: true),
                        Lugar = c.String(),
                        Tipo = c.String(),
                        Descripcion = c.String(),
                        FechayHora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordatorioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pagoes", "Juicio_JuicioId", "dbo.Juicios");
            DropForeignKey("dbo.Documentoes", "Juicio_JuicioId2", "dbo.Juicios");
            DropForeignKey("dbo.Documentoes", "Juicio_JuicioId1", "dbo.Juicios");
            DropForeignKey("dbo.Documentoes", "Juicio_JuicioId", "dbo.Juicios");
            DropForeignKey("dbo.Demandantes", "Persona_PersonaId", "dbo.Personas");
            DropForeignKey("dbo.Demandantes", "Juicio_JuicioId", "dbo.Juicios");
            DropForeignKey("dbo.Demandadoes", "Persona_PersonaId", "dbo.Personas");
            DropForeignKey("dbo.Cobroes", "Persona_PersonaId", "dbo.Personas");
            DropForeignKey("dbo.Demandadoes", "Juicio_JuicioId", "dbo.Juicios");
            DropForeignKey("dbo.Cobroes", "Juicio_JuicioId", "dbo.Juicios");
            DropIndex("dbo.Pagoes", new[] { "Juicio_JuicioId" });
            DropIndex("dbo.Documentoes", new[] { "Juicio_JuicioId2" });
            DropIndex("dbo.Documentoes", new[] { "Juicio_JuicioId1" });
            DropIndex("dbo.Documentoes", new[] { "Juicio_JuicioId" });
            DropIndex("dbo.Demandantes", new[] { "Persona_PersonaId" });
            DropIndex("dbo.Demandantes", new[] { "Juicio_JuicioId" });
            DropIndex("dbo.Demandadoes", new[] { "Persona_PersonaId" });
            DropIndex("dbo.Demandadoes", new[] { "Juicio_JuicioId" });
            DropIndex("dbo.Cobroes", new[] { "Persona_PersonaId" });
            DropIndex("dbo.Cobroes", new[] { "Juicio_JuicioId" });
            DropTable("dbo.Recordatorios");
            DropTable("dbo.Pagoes");
            DropTable("dbo.Documentoes");
            DropTable("dbo.Demandantes");
            DropTable("dbo.Personas");
            DropTable("dbo.Demandadoes");
            DropTable("dbo.Juicios");
            DropTable("dbo.Cobroes");
        }
    }
}
