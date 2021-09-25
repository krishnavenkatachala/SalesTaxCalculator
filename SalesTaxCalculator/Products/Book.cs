using System;
using SalesTaxCalculator.Products.Factory;
namespace SalesTaxCalculator.Products
{
    public class Book : Product
    {
        #region Constructors
        public Book()
          : base()
        {
        }
        public Book(string name, decimal price, bool isImported, int quantity)
            : base(name, price, isImported, quantity)
        {

        }
        #endregion
    }
}
