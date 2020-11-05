using System.Collections.Generic;

namespace OrderReceipt
{
    public class Order
    {
        private List<LineItem> li;

        public Order(string customerName, string customerAddress, List<LineItem> li)
        {
            this.CustomerName = customerName;
            this.CustomerAddress = customerAddress;
            this.li = li;
        }

        public string CustomerName { get; }

        public string CustomerAddress { get; }

        public List<LineItem> LineItems
        {
            get { return li; }
        }
    }
}
