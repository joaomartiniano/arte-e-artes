using System;
using System.Collections.Generic;
using System.Web;

namespace Arte_e_Artes
{
    
    /// <summary>
    /// Representa um produto e os respetivos dados.
    /// </summary>
    public class Produto
    {
        public int ID { get; set; }
        public string Designacao { get; set; }
        public string Autor { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }
        public decimal Preco { get; set; }
        public string Imagem_thumbnail { get; set; }
        public string Imagem { get; set; }
        public string Dimensoes { get; set; }
        /// <summary>
        /// Categoria do produto (1 = pintura, 2 = fotografia)
        /// </summary>
        public int Categoria_ID { get; set; }

        public Produto(int id, string designacao, string autor, string descricao, string data, decimal preco, string imagem_thumbnail, string imagem, string dimensoes, int categoria_id)
        {
            ID = id;
            Designacao = designacao;
            Autor = autor;
            Descricao = descricao;
            Data = data;
            Preco = preco;
            Imagem_thumbnail = imagem_thumbnail;
            Imagem = imagem;
            Dimensoes = dimensoes;
            Categoria_ID = categoria_id;
        }
    }

}