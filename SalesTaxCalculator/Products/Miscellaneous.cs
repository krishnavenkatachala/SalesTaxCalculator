using SalesTaxCalculator.Products.Factory;
using System;

namespace SalesTaxCalculator.Products
{
    public class Miscellaneous : Product
    {
        #region Constructors
        public Miscellaneous() : base()
        {

        }

        public Miscellaneous(string name, decimal price, bool isImported, int quantity)
            : base(name, price, isImported, quantity)
        {

        }
        #endregion

        #region Override Methods
        public override decimal CalculateTaxValue()
        {
            decimal importedTax = 0;

            if (IsImported == true)
            {
                importedTax = Convert.ToDecimal(Convert.ToDouble(Price * Quantity) * 0.05);
            }

            var salesTax = Convert.ToDecimal(Convert.ToDouble(Price * Quantity) * 0.1);
            var tax = Decimal.Add(importedTax, salesTax);
            return Math.Round(tax * 20, MidpointRounding.AwayFromZero)/20;
        }

        #endregion
    }
}
