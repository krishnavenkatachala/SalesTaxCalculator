using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesCalculator.Products.Factory;
using SalesTaxCalculator.Products;
using SalesTaxCalculator.Products.Factory;
using SalesTaxCalculator.Utilities;

namespace SalesTaxCalculator.Test
{
    [TestClass]
    public class SalesTaxCalculatorTest
    {
        #region PostiveTesting
        [TestMethod]
        public void CheckImportedBookTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("book", 10, true, 3, ProductType.Book);
            decimal expectedTax = 1.5m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void CheckBookTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("book", 10, false, 3, ProductType.Book);
            decimal expectedTax = 0m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void CheckImportedFoodTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("Chocolate Bar", 250, true, 1, ProductType.Food);
            decimal expectedTax = 12.5m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void CheckFoodTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("Chocolate Bar", 250, false, 1, ProductType.Food);
            decimal expectedTax = 0m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void CheckImportedMedicineTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("Headache pills", 2500, true, 1, ProductType.Medical);
            decimal expectedTax = 125m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void CheckMedicineTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("Iodex", 300, false, 1, ProductType.Medical);
            decimal expectedTax = 0m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void CheckImportedMiscellaneousTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("Bus", 4500000, true, 1, ProductType.Other);
            decimal expectedTax = 675000m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void CheckMiscellaneousTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("Sofa", 5000, false, 1, ProductType.Other);
            decimal expectedTax = 500m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreEqual(expectedTax, actualTax);
        } 
        #endregion

        #region NegativeTesting
        [TestMethod]
        public void VerifyImportedBookTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("book 123", 1000, true, 1, ProductType.Book);
            decimal expectedTax = 5.0m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreNotEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void VerifyBookTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("book 1234", 100, false, 1, ProductType.Book);
            decimal expectedTax = 5.0m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreNotEqual(expectedTax, actualTax);
        }
        [TestMethod]
        public void VerifyImportedFoodTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("Chocolate Bar", 20, true, 1, ProductType.Food);
            decimal expectedTax = 1.5m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreNotEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void VerifyFoodTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("Chocolate Bar1", 10, false, 1, ProductType.Food);
            decimal expectedTax = 1m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreNotEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void VerifyImportedMedicineTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("Headache pills", 20, true, 1, ProductType.Medical);
            decimal expectedTax = 100m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreNotEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void VerifyMedicineTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("Iodex", 100, false, 1, ProductType.Medical);
            decimal expectedTax = 10m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreNotEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void VerifyImportedMiscellaneousTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("Bus", 4500000, true, 1, ProductType.Other);
            decimal expectedTax = 12m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreNotEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void VerifyMiscellaneousTax()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.CreateProduct("Sofa", 500, false, 2, ProductType.Other);
            decimal expectedTax = 50.0m;
            var actualTax = book.CalculateTaxValue();

            Assert.AreNotEqual(expectedTax, actualTax);
        }
        #endregion
    }
}
