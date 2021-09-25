using SalesTaxCalculator.Products.Factory;

namespace SalesTaxCalculator.Products
{
    public class Medical : Product
    {
        #region Constructors
        public Medical() : base()
        {

        }

        public Medical(string name, decimal price, bool isImported, int quantity)
            : base(name, price, isImported, quantity)
        {

        }
        #endregion

    }
}
