using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorLibrary
{
    //I left all the methods as is for reviewing purposes
    public class PriceCalculator
    {
        public static decimal GetButterPrice()
        {
            return 0.80M;
        }

        public static decimal GetMilkPrice()
        {
            return 1.15M;
        }

        public static decimal GetBreadPrice()
        {
            return 1.00M;
        }

        public static decimal BreadPromotion(int totalQualificationForPromotion)
        {
            decimal total = 0.0M;
            for (int i = 0; i < totalQualificationForPromotion; i++)
            {
                total += 0.50M;
            }
            return total;
        }

        public static decimal MilkPromotion(int totalQualificationForPromotion)
        {
            decimal total = 0.0M;
            for (int i = 0; i < totalQualificationForPromotion; i++)
            {
                total += 1.15M;
            }
            return total;
        }

        //Get the total amount of bread promotions qualified for
        public static int GetBreadPromotion(int totalButter)
        {
            int total = 0;
            for (int i = 1; i <= totalButter; i++)
            {
                if (i%2 == 0)
                    total++;
            }
            return total;
        }

        //Get the total amount of milk promotions qualified for
        public static int GetMilkPromotion(int totalMilk)
        {
            int total = 0;
            for (int i = 1; i <= totalMilk; i++)
            {
                if (i % 3 == 0)
                    total++;
            }
            return total;
        }

        //A more generic approach for getting the amount of times a promotion has occured
        public int GetQualifyQuantity(int qualifyThreshold, int productQuantity)
        {
            int total = 0;
            for (int i = 1; i <= productQuantity; i++)
            {
                if (i % qualifyThreshold == 0)
                    total++;
            }
            return total;
        }

        //Get total bread discount for every butter promotion
        public decimal GetBreadDiscount(int qualifiedTotal, int numberOfBreadInBasket)
        {
            decimal totalDiscount = 0.0M;
            for (int i = 0; i < qualifiedTotal; i++)
            {
                //Is there bread in basket to apply discount to
                if (numberOfBreadInBasket >= 1)
                {
                    //Accrue discount
                    totalDiscount += 0.50M;
                    numberOfBreadInBasket--;//Remove the item after discount has been accrued
                }
            }

            return totalDiscount;
        }




        public decimal GetMilkDiscount(int qualifiedTotal, int numberOfMilkInBasket)
        {
            decimal totalDiscount = 0.0M;
            for (int i = 0; i < qualifiedTotal; i++)
            {
                //Is there milk in basket to apply discount to
                if (numberOfMilkInBasket >= 1)
                {
                    //Accrue discount
                    totalDiscount += 1.00M;
                    numberOfMilkInBasket--;//Remove the item after discount has been accrued
                }
            }

            return totalDiscount;
        }

        public decimal GetDiscount(int qualifiedTotal, int numberOfItemInBasket, decimal productValue)
        {
            decimal totalDiscount = 0.0M;
            for (int i = 0; i < qualifiedTotal; i++)
            {
                //Is there item in basket to apply discount to
                if (numberOfItemInBasket >= 1)
                {
                    //Accrue discount   
                    totalDiscount += productValue;
                    numberOfItemInBasket--;//Remove the item after discount has been accrued
                }
            }

            return totalDiscount;
        }
    }
}
