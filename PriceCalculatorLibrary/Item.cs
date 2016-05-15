using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorLibrary
{
    public abstract class Item
    {
        private decimal total = 0.00M;
        public abstract string ProductName { get; set; }
        public abstract decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal Total
        {
            get
            {
                if (Quantity > 0)
                    total = Quantity * Price;

                return total;
            }

            set
            {
                    total = value;
            }
        }
    }

    public class Bread : Item
    {
        private const string product = "Bread";
        public override string ProductName
        {
            get { return product; }
            set { value = product; }
        }

        private const decimal price = 1.00M;
        public override decimal Price
        {
            get { return price; }
            set { value = price; }
        }
    }

    public class Butter : Item
    {
        private const string product = "Butter";
        public override string ProductName
        {
            get { return product; }
            set { value = product; }
        }

        private const decimal price = 0.80M;
        public override decimal Price
        {
            get { return price; }
            set { value = price; }
        }
    }

    public class Milk : Item
    {
        private const string product = "Milk";
        public override string ProductName
        {
            get { return product; }
            set { value = product; }
        }

        private const decimal price = 1.15M;
        public override decimal Price
        {
            get { return price; }
            set { value = price; }
        }

    }
}
