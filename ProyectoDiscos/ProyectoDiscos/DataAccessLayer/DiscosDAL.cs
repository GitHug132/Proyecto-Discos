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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Disco>().ToTable("Disco");
            modelBuilder.Entity<Disco>().ToTable("DiscoTipo");
            modelBuilder.Entity<Disco>().ToTable("Interprete");
            modelBuilder.Entity<Disco>().ToTable("Tipo");
            modelBuilder.Entity<Disco>().ToTable("");
            modelBuilder.Entity<Disco>().ToTable("Disco");
            base.OnModelCreating(modelBuilder);
        }
    }
}