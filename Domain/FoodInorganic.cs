
using AbstractFactory.Domain.Base;
using AbstractFactory.Domain.Enums;
using System.Collections.Generic;

namespace AbstractFactory.Domain
{
    public class FoodInorganic : Food
    {
        public FoodInorganic() : base(TypeProduct.Inorganic) { }

        public override List<Food> SearchFood()
        {
            return new List<Food>()
            {
                new FoodInorganic(){ Name = "Food Inorganic 01" },
                new FoodInorganic(){ Name = "Food Inorganic 02" },
                new FoodInorganic(){ Name = "Food Inorganic 03" },
            };
        }
    }
}
