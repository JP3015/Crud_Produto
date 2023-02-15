﻿// <auto-generated />
using Crud___Produto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Crud___Produto.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Crud___Produto.Models.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Desc");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.Property<double>("peso")
                        .HasColumnType("double")
                        .HasColumnName("Peso");

                    b.Property<double>("preco")
                        .HasColumnType("double")
                        .HasColumnName("Preco");

                    b.HasKey("id");

                    b.ToTable("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
