using SalesTaxCalculator.Products;
using System.Collections.Generic;

namespace SalesTaxCalculator.Shopping
{
    public class ShoppingCart
    {
        private List<Product> _productList { get; set; }

        public ShoppingCart()
        {
            _productList = new List<Product>();
        }

        public void AddItemToCart(Product product)
        {
            _productList.Add(product);
        }

        public List<Product> GetItemsFromCart()
        {
            return _productList;
        }

        public void ClearCart()
        {
            _productList.Clear();
        }
    }
}
