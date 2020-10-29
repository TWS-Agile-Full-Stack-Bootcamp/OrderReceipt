using System.Text;

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
        private Order o;

        public OrderReceipt(Order o)
        {
            this.o = o;
        }

        public string PrintReceipt()
        {
            StringBuilder output = new StringBuilder();

            // print headers
            output.Append("======Printing Orders======\n");

            // print date, bill no, customer name
            //        output.Append("Date - " + order.getDate();
            output.Append(o.CustomerName);
            output.Append(o.CustomerAddress);
            //        output.Append(order.getCustomerLoyaltyNumber());

            // prints lineItems
            double totSalesTx = 0d;
            double tot = 0d;
            foreach (LineItem lineItem in o.LineItems)
            {
                output.Append(lineItem.Description);
                output.Append('\t');
                output.Append(lineItem.Price);
                output.Append('\t');
                output.Append(lineItem.Quantity);
                output.Append('\t');
                output.Append(lineItem.TotalAmount);
                output.Append('\n');

                // calculate sales tax @ rate of 10%
                double salesTax = lineItem.TotalAmount * .10;
                totSalesTx += salesTax;

                // calculate total amount of lineItem = price * quantity + 10 % sales tax
                tot += lineItem.TotalAmount + salesTax;
            }

            // prints the state tax
            output.Append("Sales Tax").Append('\t').Append(totSalesTx);

            // print total amount
            output.Append("Total Amount").Append('\t').Append(tot);
            return output.ToString();
        }
    }
}
