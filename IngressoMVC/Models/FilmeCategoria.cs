using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class FilmesCategoria 
    {
        public FilmesCategoria(int filmeId, int categoriaId)
        {
            FilmeId = filmeId;
            CategoriaId = categoriaId;
        }


        //Filmes
        [key]
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }


        [key]
        // Categoria 
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        
    }
}
