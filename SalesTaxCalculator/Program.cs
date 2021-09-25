using SalesTaxCalculator.Billing;
using SalesTaxCalculator.Shopping;
using SalesTaxCalculator.Utilities;
using System;
using System.Linq;

namespace SalesTaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salex Tax Calculatory");
            Console.WriteLine("---------------------");
            ProductStore productStore = new ProductStore();
            try
            {
                productStore.GetOrder();

                if (GetPlaceOrderResponse())
                {
                    productStore.PlaceOrder();
                    var cartItems = productStore.CheckOut();
                    Receipt receipt = productStore.CreateNewReceipt(cartItems, cartItems.Sum(x => x.TaxedCost), cartItems.Sum(x => x.Price));
                    receipt.DisplayBill();
                }
                else
                {
                    //clear cart
                    Console.WriteLine("Thanks for shopping with us! Have a great day");
                    productStore.ClearCart();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry! An Error Occurred, Please contact the administrator");
                #region Commented Code
                /*Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-BEGIN-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                        Console.WriteLine("Message:");
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Stack Trace:");
                        Console.WriteLine(e.StackTrace);
                        Console.WriteLine("Inner Exception:");
                        Console.WriteLine(e.InnerException);
                        Console.WriteLine("*- 
                *-*-*-*-*-*-*-*-*-*-*-*-*-*-END-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");*/
                #endregion
            }
        }

        private static bool GetPlaceOrderResponse()
        {
            Console.WriteLine("Do you want to Place Order(Y/N)?");
            var input = Console.ReadLine();
            return TaxCalculatorUtility.ValidateBooleanInput(input);
        }
    }
}
