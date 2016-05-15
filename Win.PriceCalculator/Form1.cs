using PriceCalculatorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.PriceCalculator
{
    public partial class frmPriceCalc : Form
    {
        private List<Item> myItemList;
        private Item myBreadItem, myMilkItem, myButterItem;
        private int breadQualifyTotal;
        private int milkQualifyTotal;
        private decimal totalDiscount;
        private PriceCalculatorLibrary.PriceCalculator myCalculatorLib;
        private Promotions myOffers;

        public frmPriceCalc()
        {
           
            InitializeComponent();
            lblPromotion.Text = "-Buy 2 Butter and get a Bread at 50% off \n-Buy 3 Milk and get the 4th milk for free";
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //Reset value
            totalDiscount = 0;

            //Instantiate object
            myOffers = new Promotions();
            myCalculatorLib = new PriceCalculatorLibrary.PriceCalculator();

            //Class for item type (Bread, Milk, Butter)
            myBreadItem = new Bread() { Quantity = Convert.ToInt32(numBread.Value) };
            myButterItem = new Butter() { Quantity = Convert.ToInt32(numButter.Value) };
            myMilkItem = new Milk() { Quantity = Convert.ToInt32(numMilk.Value) };

            //Add items to list.
            myItemList = new List<Item>();
            myItemList.Add(myBreadItem);
            myItemList.Add(myButterItem);
            myItemList.Add(myMilkItem);

           //Get Total value of items
            var sum = myItemList.Sum(x => x.Total);
            
            //Get the offer for the Bread promotion
            int offerBreadThreshold = myOffers.GetOfferForProduct(myButterItem.ProductName);
            breadQualifyTotal = myCalculatorLib.GetQualifyQuantity(offerBreadThreshold, Convert.ToInt32(numButter.Value));

            //Get the offer for the Milk promotion
            int offerMilkThreshold = myOffers.GetOfferForProduct(myMilkItem.ProductName);
            milkQualifyTotal = myCalculatorLib.GetQualifyQuantity(offerMilkThreshold, Convert.ToInt32(numMilk.Value));

             //Bread Promotion
            totalDiscount += myCalculatorLib.GetDiscount(breadQualifyTotal, Convert.ToInt32(numBread.Value), myBreadItem.Price / 2);//Todo: use a property for discount

            //Milk Promotion
            totalDiscount += myCalculatorLib.GetDiscount(milkQualifyTotal, Convert.ToInt32(numMilk.Value), myMilkItem.Price);

            
            //Apply discount
            lblTotal.Text = string.Format("Total: {0}",sum - totalDiscount);

            #region Readme Notes
            //This was a nice challenge using NUnit and developing with TDD first
            //As you will pick up, I still have some things to learn when it comes to designing the architecture of a project. 
            //This is where I would like to focus more and get some experience and understanding.
            #endregion

        }
        //Close app
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }







    }
}
