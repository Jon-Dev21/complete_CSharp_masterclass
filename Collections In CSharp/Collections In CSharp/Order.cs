using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_In_CSharp
{
    class Order
    {
        // Order ID
        public int OrderId{ get; set; }
        // Order Quantity
        public int OrderQuantity { get; set; }

        // Constructor
        public Order(int id, int quantity)
        {
            this.OrderId = id;
            this.OrderQuantity = quantity;
        }

        /// <summary>
        /// Prints message on the screen indicating that order was processed.
        /// </summary>
        public void ProcessOrder()
        {
            // Print the message
            Console.WriteLine("Order {0} processed!", OrderId);
        }

    }
}
