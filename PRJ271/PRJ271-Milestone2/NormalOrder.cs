﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ271_Milestone2
{
    internal class NormalOrder:Order
    {
        protected NormalOrder(DateTime date, string orderNumber, string orderDescription, int orderQuantity, int itemPrice) : base(date, orderNumber, orderDescription, orderQuantity, itemPrice) { }

        public override void ConfirmOrder()
        {

        }
        public override void DeleteOrder()
        {

        }
        public override void UpdateOrderDetails()
        {

        }
    }
}
