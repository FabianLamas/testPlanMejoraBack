using Microsoft.EntityFrameworkCore;
using Sistema.Datos.Maping;
using Sistema.Entidades.DataEntidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos
{
    public class DbContextSistema : DbContext
    {
        public DbSet<Grupo> Grupos { get; set; } 
        public DbSet<AuditDocument> AuditDocuments { get; set; }
        public DbSet<NonConformanceDocument> NonConformanceDocuments { get; set; }

        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new GrupoMap());
            modelBuilder.ApplyConfiguration(new NonConformanceDocumentMap());
            modelBuilder.ApplyConfiguration(new AuditDocumentMap());
        }
    }
}
