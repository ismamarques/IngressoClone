using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class FilmesCategoria 
    {
        //Filmes
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }

        // Categoria 
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        
    }
}
