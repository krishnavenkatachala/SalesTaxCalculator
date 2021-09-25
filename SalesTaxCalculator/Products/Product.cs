using System;
using SalesTaxCalculator.Products.Factory;
using SalesTaxCalculator.Utilities;

namespace SalesTaxCalculator.Products
{
    /// <summary>
    /// This is the abstract class definition for a Product
    /// </summary>
    public abstract class Product
    {
        #region Constructors
        public Product()
        {
            this.Name = string.Empty;
            this.Price = 0.0M;
            this.IsImported = false;
            this.Quantity = 0;
            this.TaxedCost = 0.0M;
        }
        public Product(string name, decimal price, bool isImported, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.IsImported = isImported;
            this.Quantity = quantity;
        }
        #endregion

        #region Properties
        public string Name { get; set; }
        public int Quantity { get; set; }

        private decimal _price;

        public decimal Price
        {
            set { _price = value; }
            get { return _price; }
        }

        public bool IsImported { get; set; }

        public decimal TaxedCost { get; set; }

        public ProductType ProductType { get; set; }
        #endregion

        #region Virtual Functions
        public virtual decimal CalculateTaxValue()
        {
            decimal tax = 0;
            if (IsImported)
            {
                tax = Convert.ToDecimal(Convert.ToDouble(Price * Quantity) * 0.05);
            }
            return Math.Round(tax * 20, MidpointRounding.AwayFromZero) / 20;
        }
        #endregion
    }
}
