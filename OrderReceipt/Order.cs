using System.Collections.Generic;

namespace OrderReceipt
{
    public class Order
    {
        private string addr;
        private List<LineItem> li;

        public Order(string customerName, string addr, List<LineItem> li)
        {
            this.CustomerName = customerName;
            this.addr = addr;
            this.li = li;
        }

        public string CustomerName { get; }

        public string CustomerAddress
        {
            get { return addr; }
        }

        public List<LineItem> LineItems
        {
            get { return li; }
        }
    }
}
