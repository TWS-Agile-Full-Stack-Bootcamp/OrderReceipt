using System.Collections.Generic;
using Xunit;
using OrderReceipt;

namespace OrderReceiptTest
{
    public class OrderReceiptTest
    {
        [Fact]
        public void Should_Print_Customer_Information_On_Order()
        {
            Order order = new Order("Mr X", "Chicago, 60601", new List<LineItem>());
            var receipt = new OrderReceipt.OrderReceipt(order);

            string output = receipt.PrintReceipt();

            Assert.Contains("Mr X", output);
            Assert.Contains("Chicago, 60601", output);
        }

        [Fact]
        public void Should_Print_LineItem_And_Sales_Tax_Information()
        {
            var lineItems = new List<LineItem>()
            {
                new LineItem("milk", 10.0, 2),
                new LineItem("biscuits", 5.0, 5),
                new LineItem("chocolate", 20.0, 1),
            };

            var receipt = new OrderReceipt.OrderReceipt(new Order(null, null, lineItems));

            string output = receipt.PrintReceipt();

            Assert.Contains("milk\t10\t2\t20\n", output);
            Assert.Contains("biscuits\t5\t5\t25\n", output);
            Assert.Contains("chocolate\t20\t1\t20\n", output);
            Assert.Contains("Sales Tax\t6.5", output);
            Assert.Contains("Total Amount\t71.5", output);
        }
    }
}
