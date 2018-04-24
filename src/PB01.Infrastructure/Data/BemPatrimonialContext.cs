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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BemPatrimonial>().ToTable("BemPatrimonial");
        }
    }
}
