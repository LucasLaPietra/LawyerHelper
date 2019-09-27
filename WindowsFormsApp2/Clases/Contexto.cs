using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LawyerHelper.Clases
{
    class Contexto:DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cobro> Cobros { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Demandante> Demandantes { get; set; }
        public DbSet<Demandado> Demandados { get; set; }
        public DbSet<Juicio> Juicios { get; set; }
        public DbSet<Recordatorio> Recordatorios { get; set; }
    }
}
