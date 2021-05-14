using AbstractFactory.Domain.Enums;
using System.Collections.Generic;

namespace AbstractFactory.Domain.Base
{
    public abstract class Food
    {
        protected Food(TypeProduct type)
        {
            Type = type;
        }

        public string Name { get; set; }
        public TypeProduct Type { get; set; }

        public abstract List<Food> SearchFood();
    }
}