using System;
namespace firstdata.Models
{
    public class Order : BaseModel
    {
        public String OrderId { get; set; }
        public Billing Billing { get; set; }
        public Shipping Shipping { get; set; }
    }
}
