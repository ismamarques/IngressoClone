﻿using System;
using IngressoMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IngressoMVC.Migrations
{
    [DbContext(typeof(IngressoDbContext))]
    partial class IngressoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IngressoMVC.Models.Ator", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Bio")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("DataAlteracao")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("DataCadastro")
                    .HasColumnType("datetime2");

                b.Property<string>("FotoPerfilURL")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Nome")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Atores");
            });

            modelBuilder.Entity("IngressoMVC.Models.AtorFilme", b =>
            {
                b.Property<int>("AtorId")
                    .HasColumnType("int");

                b.Property<int>("FilmeId")
                    .HasColumnType("int");

                b.HasKey("AtorId", "FilmeId");

                b.HasIndex("FilmeId");

                b.ToTable("AtoresFilmes");
            });

            modelBuilder.Entity("IngressoMVC.Models.Categoria", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("DataAlteracao")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("DataCadastro")
                    .HasColumnType("datetime2");

                b.Property<string>("Nome")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Categorias");
            });

            modelBuilder.Entity("IngressoMVC.Models.Cinema", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("DataAlteracao")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("DataCadastro")
                    .HasColumnType("datetime2");

                b.Property<string>("Descricao")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LogoURL")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Nome")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Cinemas");
            });

            modelBuilder.Entity("IngressoMVC.Models.Filme", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("CinemaId")
                    .HasColumnType("int");

                b.Property<DateTime>("DataAlteracao")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("DataCadastro")
                    .HasColumnType("datetime2");

                b.Property<string>("Descricao")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ImageURL")
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("Preco")
                    .HasColumnType("decimal(18,2)");

                b.Property<int>("ProdutorId")
                    .HasColumnType("int");

                b.Property<string>("Titulo")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("CinemaId");

                b.HasIndex("ProdutorId");

                b.ToTable("Filmes");
            });

            modelBuilder.Entity("IngressoMVC.Models.FilmeCategoria", b =>
            {
                b.Property<int>("FilmeId")
                    .HasColumnType("int");

                b.Property<int>("CategoriaId")
                    .HasColumnType("int");

                b.HasKey("FilmeId", "CategoriaId");

                b.HasIndex("CategoriaId");

                b.ToTable("FilmesCategorias");
            });

            modelBuilder.Entity("IngressoMVC.Models.Produtor", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Bio")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("DataAlteracao")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("DataCadastro")
                    .HasColumnType("datetime2");

                b.Property<string>("FotoPerfilURL")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Nome")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Produtores");
            });

            modelBuilder.Entity("IngressoMVC.Models.AtorFilme", b =>
            {
                b.HasOne("IngressoMVC.Models.Ator", "Ator")
                    .WithMany("AtoresFilmes")
                    .HasForeignKey("AtorId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("IngressoMVC.Models.Filme", "Filme")
                    .WithMany("AtoresFilmes")
                    .HasForeignKey("FilmeId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Ator");

                b.Navigation("Filme");
            });

            modelBuilder.Entity("IngressoMVC.Models.Filme", b =>
            {
                b.HasOne("IngressoMVC.Models.Cinema", "Cinema")
                    .WithMany("Filmes")
                    .HasForeignKey("CinemaId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("IngressoMVC.Models.Produtor", "Produtor")
                    .WithMany("Filmes")
                    .HasForeignKey("ProdutorId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Cinema");

                b.Navigation("Produtor");
            });

            modelBuilder.Entity("IngressoMVC.Models.FilmeCategoria", b =>
            {
                b.HasOne("IngressoMVC.Models.Categoria", "Categoria")
                    .WithMany("FilmesCategorias")
                    .HasForeignKey("CategoriaId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("IngressoMVC.Models.Filme", "Filme")
                    .WithMany("FilmesCategorias")
                    .HasForeignKey("FilmeId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Categoria");

                b.Navigation("Filme");
            });

            modelBuilder.Entity("IngressoMVC.Models.Ator", b =>
            {
                b.Navigation("AtoresFilmes");
            });

            modelBuilder.Entity("IngressoMVC.Models.Categoria", b =>
            {
                b.Navigation("FilmesCategorias");
            });

            modelBuilder.Entity("IngressoMVC.Models.Cinema", b =>
            {
                b.Navigation("Filmes");
            });

            modelBuilder.Entity("IngressoMVC.Models.Filme", b =>
            {
                b.Navigation("AtoresFilmes");

                b.Navigation("FilmesCategorias");
            });

            modelBuilder.Entity("IngressoMVC.Models.Produtor", b =>
            {
                b.Navigation("Filmes");
            });
#pragma warning restore 612, 618
        }
    }
}