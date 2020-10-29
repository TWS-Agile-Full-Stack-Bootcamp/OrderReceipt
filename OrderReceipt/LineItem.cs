using System;

namespace OrderReceipt
{
    public class LineItem
    {
        private string desc;
        private double p;
        private int qty;

        public LineItem(string desc, double p, int qty)
        {
            this.desc = desc;
            this.p = p;
            this.qty = qty;
        }

        public string Description
        {
            get { return desc; }
        }

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
