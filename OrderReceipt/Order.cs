using System.Collections.Generic;

namespace OrderReceipt
{
    public class Order
    {
        private string nm;
        private string addr;
        private List<LineItem> li;

        public Order(string nm, string addr, List<LineItem> li)
        {
            this.nm = nm;
            this.addr = addr;
            this.li = li;
        }

        public string CustomerName
        {
            get { return nm; }
        }

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
