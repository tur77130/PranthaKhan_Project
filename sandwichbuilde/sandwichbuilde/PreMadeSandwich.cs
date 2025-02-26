using System.Collections.Generic;

namespace sandwichbuilde
{
    public class PreMadeSandwich
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<string> Meats { get; set; } = new List<string>();
        public List<string> Toppings { get; set; } = new List<string>();
        public List<string> Sauces { get; set; } = new List<string>();
        public List<string> Cheeses { get; set; } = new List<string>();
        public List<string> PremiumAdditions { get; set; } = new List<string>();
        public string ImagePath { get; set; } // Path to the image file
    }
}