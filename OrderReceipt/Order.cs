using System.Collections.Generic;
using System.Linq;

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

        public double CalculateTotalAmountWithTax()
        {
            double totalAmountWithTax = 0d;
            foreach (LineItem lineItem in this.LineItems)
            {
                totalAmountWithTax += lineItem.CalculateTotalAmountWithTax();
            }

            return totalAmountWithTax;
        }

        public double CalculateTotalSalesTax()
        {
            double totalSalesTax = 0d;
            foreach (LineItem lineItem in this.LineItems)
            {
                totalSalesTax += lineItem.CalculateSalesTax();
            }

            return totalSalesTax;
        }

        public string RenderLineItems()
        {
            return string.Join("\n", this.lineItems.Select(_ => _.Render()).ToList());
        }
    }
}
