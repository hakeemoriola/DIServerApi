using System;

namespace NHPApi.ViewModels
{
    public class OrderLineVm
    {
        public string User_ID { get; set; }
        public string SapCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double Amount { get; set; }
        public string OrderNo { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
    }
}