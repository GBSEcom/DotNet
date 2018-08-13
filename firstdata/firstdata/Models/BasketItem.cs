using System;
namespace firstdata.Models
{
    public class BasketItem : BaseModel
    {
        public String Id { get; set; }
        public String Description { get; set; }
        public Amount UnitPrice { get; set; }
        public String Count { get; set; }
    }
}
