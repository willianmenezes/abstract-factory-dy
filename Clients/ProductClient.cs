

using AbstractFactory.Domain.Base;
using AbstractFactory.Domain.Enums;
using AbstractFactory.Factories;
using AbstractFactory.Factories.AbstractFactories;
using System;
using System.Collections.Generic;

namespace AbstractFactory.Clients
{
    public class ProductClient
    {
        private readonly Food _food;
        private readonly Packing _packing;

        public ProductClient(ProductFactory productFactory)
        {
            _food = productFactory.CreateFood();
            _packing = productFactory.CreatePacking();
        }

        public List<Food> SearchFood()
        {
            return _food.SearchFood();
        }

        public List<Packing> SearchPacking()
        {
            return _packing.SearchPacking();
        }

        public static ProductClient CreateProductClient(TypeProduct type)
        {
            switch (type)
            {
                case TypeProduct.Organic:
                    return new ProductClient(new ProductOrganicFactory());

                case TypeProduct.Inorganic:
                    return new ProductClient(new ProductInorganicFactory());

                default:
                    throw new NotImplementedException("Not Found");
            }
        }
    }
}
