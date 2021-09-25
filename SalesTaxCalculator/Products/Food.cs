using SalesTaxCalculator.Products.Factory;

namespace SalesTaxCalculator.Products
{
    public class Food : Product
    {
        #region Constructors
        public Food() : base()
        {

        }

        public Food(string name, decimal price, bool isImported, int quantity)
            : base(name, price, isImported, quantity)
        {

        } 
        #endregion

    }
}
