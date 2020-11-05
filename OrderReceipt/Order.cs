using System.Collections.Generic;

namespace OrderReceipt
{
    public class Order
    {
        public Order(string customerName, string customerAddress, List<LineItem> lineItems)
        {
            this.CustomerName = customerName;
            this.CustomerAddress = customerAddress;
            this.LineItems = lineItems;
        }

        public string CustomerName { get; }

        public string CustomerAddress { get; }

        public List<LineItem> LineItems { get; }
    }
}
