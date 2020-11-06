using System.Collections.Generic;

namespace OrderReceipt
{
    public class Order
    {
        private string name;
        private string address;
        private List<LineItem> lineItems;

        public Order(string name, string address, List<LineItem> lineItems)
        {
            this.name = name;
            this.address = address;
            this.lineItems = lineItems;
        }

        public string CustomerName
        {
            get { return name; }
        }

        public string CustomerAddress
        {
            get { return address; }
        }

        public List<LineItem> LineItems
        {
            get { return lineItems; }
        }
    }
}
