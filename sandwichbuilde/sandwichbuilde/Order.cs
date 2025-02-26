using System;

namespace sandwichbuilde
{
    public class Order
    {
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public Sandwich Sandwich { get; set; }
        public decimal Tip { get; set; }

        public decimal CalculateTotalCost()
        {
            return Sandwich.CalculateCost() + Tip;
        }
    }
}