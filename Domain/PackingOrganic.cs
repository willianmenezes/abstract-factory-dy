

using AbstractFactory.Domain.Base;
using AbstractFactory.Domain.Enums;
using System.Collections.Generic;

namespace AbstractFactory.Domain
{
    public class PackingOrganic : Packing
    {
        public PackingOrganic() : base(TypeProduct.Organic) { }

        public override List<Packing> SearchPacking()
        {
            return new List<Packing>()
            {
                new PackingOrganic(){ Name = "Packing Organic 01"},
                new PackingOrganic(){ Name = "Packing Organic 02"},
                new PackingOrganic(){ Name = "Packing Organic 03"},
            };
        }
    }
}
