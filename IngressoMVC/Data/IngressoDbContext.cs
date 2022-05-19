using IngressoMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Data
{
    public class IngressoDbContext : DbContext 
    {
        public IngressoDbContext(DbContextOptions<IngressoDbContext> options)
            : base(options)
        {
            
        }


        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Ator>Atores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<AtorFilme> AtorFilmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<FilmesCategoria> FilmesCategorias { get; set; }
        public DbSet<Produtor> Produtores { get; set; }

    }
}
