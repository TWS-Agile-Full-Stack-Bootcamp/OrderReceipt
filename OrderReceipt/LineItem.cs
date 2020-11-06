using System;

namespace OrderReceipt
{
    public class LineItem
    {
        private string description;
        private double price;
        private int quantity;

        public LineItem(string description, double price, int quantity)
        {
            this.description = description;
            this.price = price;
            this.quantity = quantity;
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

        public static string RenderLineItem(LineItem lineItem)
        {
            return $"{lineItem.Description}\t{lineItem.Price:0.0}\t{lineItem.Quantity}\t{lineItem.TotalAmount:0.0}\n";
        }
    }
}
