﻿using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models
{
    public class FilmeCategoria
    {
        public FilmeCategoria(int filmeId, int categoriaId)
        {
            FilmeId = filmeId;
            CategoriaId = categoriaId;
        }

        [Key]
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }

        [Key]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}