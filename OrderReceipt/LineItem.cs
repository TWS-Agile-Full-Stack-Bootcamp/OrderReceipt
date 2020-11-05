using System;

namespace OrderReceipt
{
    public class LineItem
    {
        private int qty;

        public LineItem(string description, double price, int qty)
        {
            this.Description = description;
            this.Price = price;
            this.qty = qty;
        }

        public string Description { get; }

        public double Price { get; }

        public int Quantity
        {
            get { return qty; }
        }

        public double TotalAmount
        {
            get { return Price * qty; }
        }
    }
}
