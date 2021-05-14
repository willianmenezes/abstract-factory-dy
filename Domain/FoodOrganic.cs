

using AbstractFactory.Domain.Base;
using AbstractFactory.Domain.Enums;
using System.Collections.Generic;

namespace AbstractFactory.Domain
{
    public class FoodOrganic : Food
    {
        public FoodOrganic() : base(TypeProduct.Organic) { }

        public override List<Food> SearchFood()
        {
            return new List<Food>()
            {
                new FoodOrganic(){ Name = "Food Organic 01" },
                new FoodOrganic(){ Name = "Food Organic 02" },
                new FoodOrganic(){ Name = "Food Organic 03" },
            };
        }
    }
}


