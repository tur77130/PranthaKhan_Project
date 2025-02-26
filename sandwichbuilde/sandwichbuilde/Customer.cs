namespace sandwichbuilde
{
    public class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string DeliveryMethod { get; set; } // "Delivery" or "Pickup"
    }
}