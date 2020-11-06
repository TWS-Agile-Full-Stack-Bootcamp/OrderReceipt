using System;

namespace OrderReceipt
{
    public class LineItem
    {
        private string description;
        private double price;
        private int quantity;

        public LineItem(string desc, double p, int qty)
        {
            this.description = desc;
            this.price = p;
            this.quantity = qty;
        }

        public string Description
        {
            get { return description; }
        }

        public double Price
        {
            get { return price; }
        }

        public int Quantity
        {
            get { return quantity; }
        }

        public double TotalAmount
        {
            get { return price * quantity; }
        }
    }
}
