using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProyectoSimulacion1.Models
{
    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model3")
        {
        }

        public virtual DbSet<DETALLE_CLIENTE> DETALLE_CLIENTE { get; set; }
        public virtual DbSet<DETALLE_HORA> DETALLE_HORA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DETALLE_HORA>()
                .HasMany(e => e.DETALLE_CLIENTE)
                .WithRequired(e => e.DETALLE_HORA)
                .WillCascadeOnDelete(false);
        }
    }
}
