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
        private static readonly double SalesTaxRate = 0.10;
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
            double totalSalesTax = 0d;
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

                totalSalesTax = CalculateTotal(lineItem, totalSalesTax, ref total);
            }

            output.Append($"Sales Tax\t{totalSalesTax}");

            output.Append($"Total Amount\t{total}");
            return output.ToString();
        }

        private static double CalculateTotal(LineItem lineItem, double totalSalesTax, ref double total)
        {
            // calculate sales tax @ rate of 10%
            double salesTax = lineItem.TotalAmount * SalesTaxRate;
            totalSalesTax += salesTax;

            // calculate total amount of lineItem = price * quantity + 10 % sales tax
            total += lineItem.TotalAmount + salesTax;
            return totalSalesTax;
        }
    }
}