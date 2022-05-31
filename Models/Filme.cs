﻿using IngressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace IngressoMVC.Models
{
    public class Filme : IEntidade
    {
        public Filme(string titulo, string descricao, decimal preco, string imageURL)
        {
            Titulo = titulo;
            Descricao = descricao;
            Preco = preco;
            ImageURL = imageURL;
        }

        public Filme(string titulo, string descricao, decimal preco, string imageURL, int cinemaId, int produtorId)
        {
            Titulo = titulo;
            Descricao = descricao;
            Preco = preco;
            ImageURL = imageURL;
            ProdutorId = produtorId;
            CinemaId = cinemaId;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public string ImageURL { get; private set; }

        #region relacionamentos
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }

        public int ProdutorId { get; set; }
        public Produtor Produtor { get; set; }

        public List<AtorFilme> AtoresFilmes { get; set; }
        public List<FilmeCategoria> FilmesCategorias { get; set; }
        #endregion


        public void AlteraPreco(decimal novoPreco)
        {
            if(novoPreco < 0)
            {
                return;
            }

            Preco = novoPreco;
        }
    }
}
