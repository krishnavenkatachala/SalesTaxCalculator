using SalesCalculator.Products.Factory;
using SalesTaxCalculator.Billing;
using SalesTaxCalculator.Products;
using SalesTaxCalculator.Products.Factory;
using SalesTaxCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SalesTaxCalculator.Shopping
{
    public class ProductStore
    {
        #region Private Variables
        private ShoppingCart _shoppingCart; 
        #endregion
       
        #region Constructor
        public ProductStore()
        {
            _shoppingCart = new ShoppingCart();
        } 
        #endregion

        #region Public Methods
        public void GetOrder()
        {
            Console.WriteLine("-----------Shopping Cart-------------");
            int count = 0;
            IProductFactory productFactory = new ProductFactory();
            do
            {
                int itemNo = ++count;
                Console.WriteLine($"Input {itemNo}");
                string productName = GetProductName();
                decimal productPrice = GetProductPrice();
                bool isImported = IsProductedImported();
                int quantity = GetProductQuantity();
                ProductType productType;
                GetProductType(out productType);
                Product product = productFactory.CreateProduct(productName, productPrice, isImported, quantity, productType);
                if (product != null)
                    _shoppingCart.AddItemToCart(product);

            } while (ContinueShopping());
        }
        public void PlaceOrder()
        {
            foreach (var product in _shoppingCart.GetItemsFromCart())
            {
                product.TaxedCost = product.CalculateTaxValue();
            }
        }
        public void ClearCart()
        {
            _shoppingCart.ClearCart();
        }
        public List<Product> CheckOut()
        {
            return _shoppingCart.GetItemsFromCart();
        }
        public Receipt CreateNewReceipt(List<Product> productList, decimal totalTax, decimal totalAmount)
        {
            return new Receipt(productList, totalTax, totalAmount);
        }
        #endregion

        #region Private Methods
        private string GetProductName()
        {
            Console.Write("Kindly enter the product name: ");
            return Console.ReadLine();
        }
        private decimal GetProductPrice()
        {
            Console.Write("Kindly enter the product price: ");
            var intput = Console.ReadLine();
            decimal price;
            while (!(decimal.TryParse(intput, out price)))
            {
                Console.WriteLine("Invalid price. Please enter a number");
            }

            return price;
        }
        private bool IsProductedImported()
        {
            Console.Write("Is Product imported?(Y/N)");
            var input = Console.ReadLine();
            return TaxCalculatorUtility.ValidateBooleanInput(input);
        }
        private int GetProductQuantity()
        {
            Console.Write("Kindly enter the quantity: ");
            var input = Console.ReadLine();
            int intVal;
            while (!(int.TryParse(input, out intVal)))
            {
                Console.WriteLine("Invalid input. Please enter an integer value");
            }
            return intVal;
        }
        private bool ContinueShopping()
        {
            Console.Write("Do you want to continue shopping by adding more products?(Y/N): ");
            var input = Console.ReadLine();
            return TaxCalculatorUtility.ValidateBooleanInput(input);
        }
        private void GetProductType(out ProductType productType)
        {
            Console.WriteLine("Please enter Product Categpry of Item\n1. Book\n2. Food\n3. Medical\n4. Other");

            if (!Enum.TryParse<ProductType>(Console.ReadLine(), out productType))
            {
                throw new Exception("Invalid Product Type, Please enter a valid option");
            }
        }
        #endregion
    }
}
