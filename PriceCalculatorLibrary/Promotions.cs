using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorLibrary
{
    //Offers
   public class Promotions
    {
       public int GetOfferForProduct(string productName)
       {
           int num = 0;
           switch (productName.ToLower())
           {
               case "butter":
                   num = 2;
                   break;
               case "milk":
                   num = 3;
                   break;
           }
           return num;
       }
    }
}
