using Microsoft.EntityFrameworkCore;
using PB01.AplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PB01.Infrastructure.Data
{
   public class BemPatrimonialContext : DbContext
    {
        public BemPatrimonialContext(DbContextOptions<BemPatrimonialContext> options) : base(options)
        {
            
        }


        public DbSet<BemPatrimonial> BensPatrimoniais { get; set; }
        public DbSet<Auditoria> Auditorias { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Responsavel> Responsaveis { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BemPatrimonial>().ToTable("BemPatrimonial");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<Endereco>().ToTable("Endereço");
            modelBuilder.Entity<Responsavel>().ToTable("Responsavel");
            modelBuilder.Entity<Auditoria>().ToTable("Auditoria");




        }
    }
}
