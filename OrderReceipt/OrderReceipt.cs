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

            // print headers
            output.Append("======Printing Orders======\n");

            // print date, bill no, customer name
            //        output.Append("Date - " + order.getDate();
            output.Append(order.CustomerName);
            output.Append(order.CustomerAddress);
            //        output.Append(order.getCustomerLoyaltyNumber());

            // prints lineItems
            double totalSalesTax = 0d;
            double totalAmount = 0d;
            foreach (LineItem lineItem in order.LineItems)
            {
                //output.Append(lineItem.Description);
                //output.Append('\t');
                //output.Append(lineItem.Price.ToString("0.0"));
                //output.Append('\t');
                //output.Append(lineItem.Quantity);
                //output.Append('\t');
                //output.Append(lineItem.TotalAmount.ToString("0.0"));
                //output.Append('\n');

                output.Append($"{lineItem.Description}\t{lineItem.Price:0.0}\t{lineItem.Quantity}\t{lineItem.TotalAmount:0.0}\n");

                // calculate sales tax @ rate of 10%
                double salesTax = lineItem.TotalAmount * .10;
                totalSalesTax += salesTax;

                // calculate total amount of lineItem = price * quantity + 10 % sales tax
                totalAmount += lineItem.TotalAmount + salesTax;
            }

            // prints the state tax
            output.Append($"Sales Tax\t{totalSalesTax}");

            // print total amount
            output.Append($"Total Amount\t{totalAmount}");
            return output.ToString();
        }
    }
}
