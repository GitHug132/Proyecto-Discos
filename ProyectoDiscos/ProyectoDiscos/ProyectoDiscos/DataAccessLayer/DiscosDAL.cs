using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProyectoDiscos.Models;

namespace ProyectoDiscos.DataAccessLayer
{
    public class DiscosDAL:DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Disco> Discos { get; set; }
        public DbSet<Puntuacion> Puntuaciones { get; set; }
        public DbSet<Interprete> Interpretes { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<DiscoTipo> DiscoTipo { get; set; }
        public DbSet<Tipo> Tipo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Disco>().ToTable("Disco");
            modelBuilder.Entity<Puntuacion>().ToTable("Puntuacion");
            modelBuilder.Entity<Interprete>().ToTable("Interprete");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Tipo>().ToTable("Tipo");
            modelBuilder.Entity<DiscoTipo>().ToTable("DiscoTipo");
            base.OnModelCreating(modelBuilder);
        }
    }
}