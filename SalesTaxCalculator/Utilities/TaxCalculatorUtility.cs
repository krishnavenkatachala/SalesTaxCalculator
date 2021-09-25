using System;

namespace SalesTaxCalculator.Utilities
{
    public static class TaxCalculatorUtility
    {
        private const double ROUND_OFF = 0.05;

        public static decimal BOOK_TAX = 0.0M;
        public static decimal FOOD_TAX = 0.0M;
        public static decimal MEDICAL_TAX = 0.0M;
        public static decimal MISC_TAX = 0.10M;

        /// <summary>
        /// Tounds off a decimal value to it's nearest 0.05
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal AdjustRoundOff(decimal value)
        {
            return Convert.ToDecimal(value / Convert.ToDecimal(ROUND_OFF) + 0.5M) * 0.5M;
        }

        public static bool ValidateBooleanInput(string input)
        {
            bool isValid = false;
            while (!isValid)
            {
                if (string.Equals(input, "Y", StringComparison.OrdinalIgnoreCase))
                    isValid = true;
                else if (string.Equals(input, "N", StringComparison.OrdinalIgnoreCase))
                    isValid = true;
                else
                    Console.WriteLine("Invalid input. Please Enter (Y/N)");
            }
            return string.Equals(input, "Y", StringComparison.OrdinalIgnoreCase);
        }
    }
    public enum ProductType
    {
        Book = 1,
        Food = 2,
        Medical = 3,
        Other = 4
    }
}
