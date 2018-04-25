﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PB01.Infrastructure.Data;
using System;

namespace PB01.Infrastructure.Migrations
{
    [DbContext(typeof(BemPatrimonialContext))]
    partial class BemPatrimonialContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PB01.AplicationCore.Entity.BemPatrimonial", b =>
                {
                    b.Property<int>("BemPatrimonialId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Descricao");

                    b.Property<string>("NumeroTombo");

                    b.HasKey("BemPatrimonialId");

                    b.ToTable("BemPatrimonial");
                });
#pragma warning restore 612, 618
        }
    }
}