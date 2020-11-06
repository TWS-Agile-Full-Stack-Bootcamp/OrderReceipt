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
        private Order order;

        public OrderReceipt(Order order)
        {
            this.order = order;
        }

        public string PrintReceipt()
        {
            StringBuilder output = new StringBuilder();

            // print headers
            output.Append("======Printing Orders======\n");

            // print date, bill no, customer name
            output.Append(RenderCustomer(order));

            // prints lineItems
            output.Append(order.RenderLineItems());

            // prints the state tax
            output.Append($"Sales Tax\t{order.CalculateTotalSalesTax()}");

            // print total amount
            output.Append($"Total Amount\t{order.CalculateTotalAmountWithTax()}");
            return output.ToString();
        }

        private string RenderCustomer(Order order)
        {
            StringBuilder customerStringBuider = new StringBuilder();
            customerStringBuider.Append(order.CustomerName);
            customerStringBuider.Append(order.CustomerAddress);
            return customerStringBuider.ToString();
        }
    }
}
