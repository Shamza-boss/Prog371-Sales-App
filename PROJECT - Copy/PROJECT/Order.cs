using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    internal abstract class Order
    {
        private DateTime Date;
        private string OrderNumber;
        private string OrderDescription;
        private int OrderQuantity;
        private int itemPrice;

        protected Order(DateTime date, string orderNumber, string orderDescription, int orderQuantity, int itemPrice)
        {
            Date1 = date;
            OrderNumber1 = orderNumber;
            OrderDescription1 = orderDescription;
            OrderQuantity1 = orderQuantity;
            this.ItemPrice = itemPrice;
        }

        public DateTime Date1 { get => Date; set => Date = value; }
        public string OrderNumber1 { get => OrderNumber; set => OrderNumber = value; }
        public string OrderDescription1 { get => OrderDescription; set => OrderDescription = value; }
        public int OrderQuantity1 { get => OrderQuantity; set => OrderQuantity = value; }
        public int ItemPrice { get => itemPrice; set => itemPrice = value; }

        public abstract void ConfirmOrder();
        public abstract void DeleteOrder();
        public abstract void UpdateOrderDetails();
    }
}
