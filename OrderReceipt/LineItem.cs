using System;

namespace OrderReceipt
{
    public class LineItem
    {
        private double p;
        private int qty;

        public LineItem(string description, double p, int qty)
        {
            this.Description = description;
            this.p = p;
            this.qty = qty;
        }

        public string Description { get; }

        public double Price
        {
            get { return p; }
        }

        public int Quantity
        {
            get { return qty; }
        }

        public double TotalAmount
        {
            get { return p * qty; }
        }
    }
}
