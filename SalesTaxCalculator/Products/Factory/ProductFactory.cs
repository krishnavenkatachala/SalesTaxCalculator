using SalesCalculator.Products.Factory;
using SalesTaxCalculator.Utilities;
using System;

namespace SalesTaxCalculator.Products.Factory
{
    public class ProductFactory : IProductFactory
    {
        public Product CreateProduct(string name, decimal price, bool isImported, int quantity, ProductType productType)
        {
            Product product = null;
            switch (productType)
            {
                case ProductType.Book:
                    product = new Book(name, price, isImported, quantity);
                    break;
                case ProductType.Food:
                    product = new Food(name, price, isImported, quantity);
                    break;
                case ProductType.Medical:
                    product = new Medical(name, price, isImported, quantity);
                    break;
                case ProductType.Other:
                    product = new Miscellaneous(name, price, isImported, quantity);
                    break;
            }
            return product;
        }
    }
}
