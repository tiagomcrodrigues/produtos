﻿using produtos02.Models.Response;

namespace produtos02.Data.Entities
{
    public class Produto
    {
        public Produto()
        {
            Id = Guid.NewGuid();
        }

        public Produto(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public Guid CategoriaId { get; set; }
        public bool Ativo { get; set; }


        public virtual ICollection<ProdutoPreco> Precos { get; set; }
        public virtual Estoque Estoque { get; set; }
        public virtual Categoria Categoria { get; set; }
        
    }
}
