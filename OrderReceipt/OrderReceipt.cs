﻿using System.Collections.Generic;
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
                double salesTax = CalculateSalesTax(lineItem);
                totalSalesTax += salesTax;

                // calculate total amount of lineItem = price * quantity + 10 % sales tax
                totalAmountWithTax += lineItem.TotalAmount + salesTax;
            }

            // prints the state tax
            output.Append($"Sales Tax\t{totalSalesTax}");

            // print total amount
            output.Append($"Total Amount\t{totalAmountWithTax}");
            return output.ToString();
        }

        private static double CalculateSalesTax(LineItem lineItem)
        {
            // calculate sales tax @ rate of 10%
            return lineItem.TotalAmount * .10;
        }

        private static string RenderLineItems(List<LineItem> lineItems)
        {
            return string.Join("\n", lineItems.Select(_ => _.Render()).ToList());
        }
    }
}
