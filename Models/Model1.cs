using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProyectoSimulacion1.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ELABORACIÓN_PRODUCTO> ELABORACIÓN_PRODUCTO { get; set; }
        public virtual DbSet<MATERIA_PRIMA> MATERIA_PRIMA { get; set; }
        public virtual DbSet<PRODUCTO_PERSONA> PRODUCTO_PERSONA { get; set; }
        public virtual DbSet<PRODUCTOS> PRODUCTOS { get; set; }
        public virtual DbSet<PRODUCTOS_TIEMPO> PRODUCTOS_TIEMPO { get; set; }
        public virtual DbSet<TIEMPO_ATENCION> TIEMPO_ATENCION { get; set; }
        public virtual DbSet<TOTAL_VENTAS_FUTURAS> TOTAL_VENTAS_FUTURAS { get; set; }
        public virtual DbSet<VENTAS_FUTURAS> VENTAS_FUTURAS { get; set; }
        public virtual DbSet<VENTAS_INDIVIDUALES> VENTAS_INDIVIDUALES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MATERIA_PRIMA>()
                .Property(e => e.NOMBRE_MATERIA_PRIMA)
                .IsUnicode(false);

            modelBuilder.Entity<MATERIA_PRIMA>()
                .HasMany(e => e.ELABORACIÓN_PRODUCTO)
                .WithRequired(e => e.MATERIA_PRIMA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.NOMBRE_PRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .HasMany(e => e.ELABORACIÓN_PRODUCTO)
                .WithRequired(e => e.PRODUCTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTOS>()
                .HasMany(e => e.PRODUCTO_PERSONA)
                .WithRequired(e => e.PRODUCTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTOS>()
                .HasMany(e => e.VENTAS_INDIVIDUALES)
                .WithRequired(e => e.PRODUCTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTOS>()
                .HasMany(e => e.VENTAS_FUTURAS)
                .WithRequired(e => e.PRODUCTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIEMPO_ATENCION>()
                .HasMany(e => e.PRODUCTOS_TIEMPO)
                .WithRequired(e => e.TIEMPO_ATENCION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIEMPO_ATENCION>()
                .HasMany(e => e.VENTAS_INDIVIDUALES)
                .WithRequired(e => e.TIEMPO_ATENCION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TOTAL_VENTAS_FUTURAS>()
                .HasMany(e => e.PRODUCTO_PERSONA)
                .WithRequired(e => e.TOTAL_VENTAS_FUTURAS)
                .WillCascadeOnDelete(false);
        }
    }
}
