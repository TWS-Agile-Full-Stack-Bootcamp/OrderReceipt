using System;

namespace OrderReceipt
{
    public class LineItem
    {
        public LineItem(string description, double price, int quantity)
        {
            this.Description = description;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Description { get; }

        public double Price { get; }

        public int Quantity { get; }

        public double TotalAmount
        {
            get { return Price * Quantity; }
        }
    }
}
