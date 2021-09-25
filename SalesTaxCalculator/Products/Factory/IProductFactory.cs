using SalesTaxCalculator.Products;
using SalesTaxCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesCalculator.Products.Factory
{
    public interface IProductFactory
    {
        Product CreateProduct(string name, decimal price, bool isImported, int quantity, ProductType productType);
    }
}
