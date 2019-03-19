using System;

namespace NHPApi.ViewModels
{
    public class CustomerVm
    {
        public string user_id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public DateTime Insertdate { get; set; }
    }
}