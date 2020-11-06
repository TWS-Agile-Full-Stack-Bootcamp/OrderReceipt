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
            //        output.Append("Date - " + order.getDate();
            output.Append(order.CustomerName);
            output.Append(order.CustomerAddress);
            //        output.Append(order.getCustomerLoyaltyNumber());

            // prints lineItems
            output.Append(RenderLineItems(order.LineItems));

            double totalSalesTax = 0d;
            double totalAmountWithTax = 0d;
            foreach (LineItem lineItem in order.LineItems)
            {
                totalSalesTax += lineItem.CalculateSalesTax();

                totalAmountWithTax += CalculateTotalAmountWithTax(lineItem);
            }

            // prints the state tax
            output.Append($"Sales Tax\t{totalSalesTax}");

            // print total amount
            output.Append($"Total Amount\t{totalAmountWithTax}");
            return output.ToString();
        }

        private static double CalculateTotalAmountWithTax(LineItem lineItem)
        {
            // calculate total amount of lineItem = price * quantity + 10 % sales tax
            return lineItem.TotalAmount + lineItem.CalculateSalesTax();
        }

        private static string RenderLineItems(List<LineItem> lineItems)
        {
            return string.Join("\n", lineItems.Select(_ => _.Render()).ToList());
        }
    }
}
