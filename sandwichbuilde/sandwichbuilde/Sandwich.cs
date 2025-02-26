using System;
using System.Collections.Generic;

namespace sandwichbuilde
{
    public class Sandwich
    {
        public string Size { get; set; }
        public string BreadType { get; set; }
        public List<string> Sauces { get; set; } = new List<string>();
        public List<string> Meats { get; set; } = new List<string>();
        public List<string> Cheeses { get; set; } = new List<string>();
        public List<string> Toppings { get; set; } = new List<string>();
        public List<string> PremiumAdditions { get; set; } = new List<string>();
        public decimal Price { get; set; } // Added price property

        // Constructor for custom sandwiches
        public Sandwich() { }

        // Constructor for pre-made sandwiches
        public Sandwich(PreMadeSandwich preMadeSandwich)
        {
            Size = "Medium"; // Default size for pre-made sandwiches
            BreadType = "White"; // Default bread type
            Meats = preMadeSandwich.Meats;
            Toppings = preMadeSandwich.Toppings;
            Sauces = preMadeSandwich.Sauces;
            Cheeses = preMadeSandwich.Cheeses;
            PremiumAdditions = preMadeSandwich.PremiumAdditions;
            Price = preMadeSandwich.Price; // Fixed price for pre-made sandwiches
        }

        public decimal CalculateCost()
        {
            if (Price > 0) // Pre-made sandwich has a fixed price
            {
                return Price;
            }

            // Calculate cost for custom sandwiches
            var sizeCosts = new Dictionary<string, decimal>
            {
                { "Small", 5.00m },
                { "Medium", 7.00m },
                { "Large", 9.00m },
                { "Extra-Large", 11.00m },
                { "Party-Size", 15.00m }
            };

            var meatCost = Meats.Count * 1.50m; // $1.50 per meat
            var cheeseCost = Cheeses.Count * 1.00m; // $1.00 per cheese
            var premiumCost = PremiumAdditions.Count * 2.00m; // $2.00 per premium addition

            return sizeCosts[Size] + meatCost + cheeseCost + premiumCost;
        }
    }
}