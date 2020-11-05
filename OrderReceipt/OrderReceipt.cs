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
        private Order order;

        public OrderReceipt(Order order)
        {
            this.order = order;
        }

        public string PrintReceipt()
        {
            StringBuilder output = new StringBuilder();
            output.Append("======Printing Orders======\n");
            output.Append(order.CustomerName);
            output.Append(order.CustomerAddress);
            double totSalesTx = 0d;
            double total = 0d;
            foreach (LineItem lineItem in order.LineItems)
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
                total += lineItem.TotalAmount + salesTax;
            }

            output.Append("Sales Tax").Append('\t').Append(totSalesTx);

            output.Append("Total Amount").Append('\t').Append(total);
            return output.ToString();
        }
    }
}