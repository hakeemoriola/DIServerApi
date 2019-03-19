using System;
using System.Collections.Generic;

namespace NHPApi.ViewModels
{
    public class OrderVm
    {
        public OrderVm()
        {
            Lines = new HashSet<OrderLineVm>();
        }
        public string user_id { get; set; }

        public string OrderNo { get; set; }

        public decimal Amount { get; set; }

        public decimal Subamount { get; set; }

        public decimal Ordershipmentcost { get; set; }

        public int Paymentmethodadd { get; set; }

        public int Order_weight_cost { get; set; }

        public decimal Shippingfee { get; set; }

        public DateTime DateCreated { get; set; }
        public HashSet<OrderLineVm> Lines { get; set; }
    }
}