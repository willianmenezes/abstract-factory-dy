using AbstractFactory.Domain.Entities.Base;
using AbstractFactory.Domain.ValueObj;

namespace AbstractFactory.Domain.Entities
{
    public class AlimentoInorganico : Alimento
    {
        public AlimentoInorganico(string nome) : base(nome, TipoProduto.Inorganico) { }
    }
}
