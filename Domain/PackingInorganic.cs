

using AbstractFactory.Domain.Base;
using AbstractFactory.Domain.Enums;
using System.Collections.Generic;

namespace AbstractFactory.Domain
{
    public class PackingInorganic : Packing
    {
        public PackingInorganic() : base(TypeProduct.Inorganic) { }

        public override List<Packing> SearchPacking()
        {
            return new List<Packing>()
            {
                new PackingInorganic(){ Name = "Packing Inorganic 01" },
                new PackingInorganic(){ Name = "Packing Inorganic 02" },
                new PackingInorganic(){ Name = "Packing Inorganic 03" },
            };
        }
    }
}
