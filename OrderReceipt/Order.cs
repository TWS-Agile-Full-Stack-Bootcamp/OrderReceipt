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
            return this.lineItems.Sum(_ => _.CalculateTotalAmountWithTax());
        }

        public double CalculateTotalSalesTax()
        {
            return this.lineItems.Sum(_ => _.CalculateSalesTax());
        }

        public string RenderLineItems()
        {
            return string.Join("\n", this.lineItems.Select(_ => _.Render()).ToList());
        }

        public string RenderCustomer()
        {
            return $"{CustomerName}\n{CustomerAddress}";
        }

        public string RenderTotalSalesTax()
        {
            return $"Sales Tax\t{this.CalculateTotalSalesTax()}";
        }

        public string RenderTotalAmountWithTax()
        {
            return $"Total Amount\t{this.CalculateTotalAmountWithTax()}";
        }

        public string Render()
        {
            return $"{RenderCustomer()}\n" +
                $"{RenderLineItems()}\n" +
                $"{RenderTotalSalesTax()}\n" +
                $"{RenderTotalAmountWithTax()}";
        }
    }
}
