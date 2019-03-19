namespace NHPApi.ViewModels
{
    public class ProductVm
    {
        public string SapCode { get; set; }
        public string ProductName { get; set; }
        public string Kg { get; set; }
        public decimal discount { get; set; }
        public string uom { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
    }
}