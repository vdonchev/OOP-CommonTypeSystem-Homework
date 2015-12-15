namespace _02.Customer.Models
{
    using System;

    public class Payment
    {
        private string productName;
        private decimal price;

        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public string ProductName { get; private set; }

        public decimal Price { get; private set; }

        public override string ToString()
        {
            return $"{this.ProductName}: {this.Price:C0}";
        }
    }
}