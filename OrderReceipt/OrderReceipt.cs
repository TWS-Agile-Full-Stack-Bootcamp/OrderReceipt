using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderReceipt
{
    /**
     * OrderReceipt prints the details of order including customer name, address, description, quantity,
     * price and amount. It also calculates the sales tax @ 10% and prints as part
     * of order. It computes the total order amount (amount of individual lineItems +
     * total sales tax) and prints it.
     */
    public class OrderReceipt
    {
        private const string HEADER = "======Printing Orders======\n";
        private Order order;

        public OrderReceipt(Order order)
        {
            this.order = order;
        }

        public string PrintReceipt()
        {
            StringBuilder output = new StringBuilder();

            // print headers
            output.Append(RenderHeader());

            output.Append(RenderOrder());

            return output.ToString();
        }

        private string RenderOrder()
        {
            StringBuilder orderRender = new StringBuilder();
            // print date, bill no, customer name
            orderRender.Append(order.RenderCustomer());

            // prints lineItems
            orderRender.Append(order.RenderLineItems());

            // prints the state tax
            orderRender.Append(order.RenderTotalSalesTax());

            // print total amount
            orderRender.Append(order.RenderTotalAmountWithTax());

            return orderRender.ToString();
        }

        private static string RenderHeader()
        {
            return HEADER;
        }
    }
}
