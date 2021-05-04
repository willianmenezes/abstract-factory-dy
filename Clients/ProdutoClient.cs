using AbstractFactory.Domain.Entities.Base;
using AbstractFactory.Domain.ValueObj;
using AbstractFactory.Factories;
using AbstractFactory.Factories.AbstractFactories;
using System;
using System.Collections.Generic;

namespace AbstractFactory.Clients
{
    public class ProdutoClient
    {
        private readonly Alimento _alimento;
        private readonly Embalagem _embalagem;

        public ProdutoClient(ProdutoFactory produtoFactory)
        {
            _alimento = produtoFactory.CriarAlimento();
            _embalagem = produtoFactory.CriarEmbalagem();
        }

        public List<Embalagem> BuscarEmbalagens()
        {
            return _embalagem.BuscarEmbalagens();
        }

        public List<Alimento> BuscarAlimentos()
        {
            return _alimento.BuscarAlimentos();
        }

        public static ProdutoClient CriarProdutoFactory(TipoProduto tipoProduto)
        {
            switch (tipoProduto)
            {
                case TipoProduto.Organico:
                    return new ProdutoClient(new ProdutoOrganicoFactory());
                case TipoProduto.Inorganico:
                    return new ProdutoClient(new ProdutoInorganicoFactory());
                default:
                    throw new NotImplementedException("Não foi encontrada implementações para o tipo de produto especificado");
            }
        }
    }
}
