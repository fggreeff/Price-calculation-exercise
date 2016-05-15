using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PriceCalculatorLibrary;

namespace PriceCalculator.Library.Test
{
    //Jeremy clark, basic TDD Test. I used NUnit for test cases
    //https://www.youtube.com/watch?v=l4xhTq4qmC0
    [TestFixture]
    public class PriceCalculatorTests
    {
        //Kept here to show coding thought process
        [Test]
        public void ButterCostTest()
        {
            Assert.Pass();
        }

        //Ask for basic value of each product
        [Test]
        public void Butter_WhenCalled_ReturnBasePrice()
        {
            //Arrange
            const decimal basePrice = 0.80M;
            //Act
            decimal price = PriceCalculatorLibrary.PriceCalculator.GetButterPrice();
            //Assert
            Assert.AreEqual(basePrice, price);
        }

        [Test]
        public void Milk_WhenCalled_ReturnBasePrice()
        {
            //Arrange
            const decimal basePrice = 1.15M;
            //Act
            decimal price = PriceCalculatorLibrary.PriceCalculator.GetMilkPrice();
            //Assert
            Assert.AreEqual(basePrice, price);
        }

        [Test]
        public void Bread_WhenCalled_ReturnBasePrice()
        {
            //Arrange
            const decimal basePrice = 1.00M;
            //Act
            decimal price = PriceCalculatorLibrary.PriceCalculator.GetBreadPrice();
            //Assert
            Assert.AreEqual(basePrice, price);
        }


        //[Test]
        //public void TwoButter_QaulifyFor_HalfPriceOffBread()
        //{
        //    //Arrange
        //    int totalButter = 2;
        //    //Act
        //    bool isQualified = PriceCalculatorLibrary.PriceCalculator.BreadPromotion(totalButter);
        //    //Assert
        //    Assert.IsTrue(isQualified);
        //}


        [Test]
        public void HowManyTimes_QaulifiedFor_HalfPriceOffBread()
        {
            //Arrange
            int totalButter = 2;
            //Act
            int totalTimesQualified = PriceCalculatorLibrary.PriceCalculator.GetBreadPromotion(totalButter);
            //Assert
            Assert.AreEqual(1, totalTimesQualified);
        }


        [Test]
        public void HowManyTimes_QaulifiedFor_FreeMilk()
        {
            //Arrange
            int totalMilk = 3;
            //Act
            int totalTimesQualified = PriceCalculatorLibrary.PriceCalculator.GetMilkPromotion(totalMilk);
            //Assert
            Assert.AreEqual(1, totalTimesQualified);
        }

        //[Test]
        //public void ThreeMilk_QaulifyFor_FreeMilk()
        //{
        //    //Arrange
        //    int totalMilk = 3;
        //    //Act
        //    bool isQualified = PriceCalculatorLibrary.PriceCalculator.MilkPromotion(totalMilk);
        //    //Assert
        //    Assert.IsTrue(isQualified);
        //}


        //More generic approach
        [Test]
        public void GetTotalAmountForPromotion([Values(3)]int qualifyThreshold, [Values(6)]int productQuantity)
        {
            PriceCalculatorLibrary.PriceCalculator myCalculator = new PriceCalculatorLibrary.PriceCalculator();

            //Act
            int total = myCalculator.GetQualifyQuantity(qualifyThreshold, productQuantity);
            //Assert
            Assert.AreEqual(2, total);
        }

        //Given the basket has 4 milk, I qualify for a promotion and should be discounted 1.15
        [Test]
        public void CalculatePromotionForMilk()//Milk only
        {
            //Arrange 
            //var myProducts = new List<Product> {
            //    new Product{quantity = 8, type="Bread", unitValue=1.00}, 
            //    new Product{quantity = 5, type="Milk", unitValue=1.15},
            //    new Product{quantity = 2, type="Butter", unitValue=0.80}

            //};
            int totaltimestoapplydisscount = 1;
            //Act
            decimal totalValue = PriceCalculatorLibrary.PriceCalculator.MilkPromotion(totaltimestoapplydisscount);

            //Assert
            Assert.AreEqual(1.15M, totalValue);
        }


        //Give 50% off each butter promotion qualified for
        [Test]
        public void GetBreadDiscount([Values(1)]int qualifiedTotal, [Values(1,2,3,45)]int numberOfBreadInBasket)
        {
            PriceCalculatorLibrary.PriceCalculator myCalculator = new PriceCalculatorLibrary.PriceCalculator();

            //Arrange
            //int qualifiedTotal = 1;
            //int numberOfBreadInBasket = 2;

            //Act
            decimal totalDiscount = myCalculator.GetBreadDiscount(qualifiedTotal,
                numberOfBreadInBasket);

            //Assert
            Assert.AreEqual(0.50M, totalDiscount);

        }

        [Test]
        public void GetMilkDiscount([Values(1)]int qualifiedTotal, [Values(4, 8)]int numberOfMilkInBasket)
        {
            PriceCalculatorLibrary.PriceCalculator myCalculator = new PriceCalculatorLibrary.PriceCalculator();

            //Arrange
            //int qualifiedTotal = 1;
            //int numberOfMilkInBasket = 2;

            //Act
            decimal totalDiscount = myCalculator.GetMilkDiscount(qualifiedTotal,
                numberOfMilkInBasket);

            //Assert
            Assert.AreEqual(1.00M, totalDiscount);

        }

        //A more generic approach for getting discount 
        [Test]
        public void GetDiscount([Values(1)]int qualifiedTotal, [Values(4, 8)]int numberOfItemInBasket, [Values(1.00)]decimal productValue)
        {
            PriceCalculatorLibrary.PriceCalculator myCalculator = new PriceCalculatorLibrary.PriceCalculator();

            //Arrange
            //int qualifiedTotal = 1;
            //int numberOfMilkInBasket = 2;

            //Act
            decimal totalDiscount = myCalculator.GetDiscount(qualifiedTotal,
                numberOfItemInBasket, productValue);    

            //Assert
            Assert.AreEqual(productValue, totalDiscount);

        }

        [Test]
        public void GetOfferForProduct_Butter()
        {
            //Added for non static access
            Promotions myPromotion = new Promotions();

            //Arrange
            string product = "Butter";
            //Act
            int numForProduct = myPromotion.GetOfferForProduct(product);
            //Assert
            Assert.AreEqual(2, numForProduct);

        }
        [Test]
        public void GetOfferForProduct_Milk()
        {
            
            Promotions myPromotion = new Promotions();

            //Arrange
            string product = "MILK";
            //Act
            int numForProduct = myPromotion.GetOfferForProduct(product);
            //Assert
            Assert.AreEqual(3, numForProduct);

        }
    }
}
