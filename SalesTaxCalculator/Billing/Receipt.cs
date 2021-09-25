using SalesTaxCalculator.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxCalculator.Billing
{
    public class Receipt
    {
        public List<Product> Products { get; set; }
        private decimal TotalSalesTax { get; set; }
        private decimal TotalAmount { get; set; }

        public Receipt(List<Product> prod, decimal tax, decimal amount)
        {
            Products = prod;
            TotalSalesTax = tax;
            TotalAmount = Decimal.Add(amount, TotalSalesTax); //adding total amount with total tax sales
        }

        public void DisplayBill()
        {
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-Billing-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.Write($"Date: {DateTime.Now.ToShortDateString()}");
            Console.WriteLine("\n"); //adding 2 new line spaces
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("SlNo\tName\t\t\t\tQuantity\t\tIsImported\tSales Tax\tPrice");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            int counter = 0;
            
            foreach(Product product in Products)
            {
                Decimal TotalAmoutPerItem = Decimal.Add(product.Price, product.TaxedCost);
                Console.WriteLine($"{++counter}\t{product.Name}\t\t\t\t{product.Quantity}\t\t\t{product.IsImported}\t\t{product.TaxedCost}\t\t{TotalAmoutPerItem}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Items: {Products.Count}\t\t\t\t\tSales Taxes: {TotalSalesTax}\t\tTotal Amount:{TotalAmount}");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-Thanks for shopping with us!-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("\n\n\n"); //adding more line spaces
        }
    }
}
