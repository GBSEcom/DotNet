using System;
namespace firstdata.Models
{
    public class Shipping : BaseModel
    {
        public String Name { get; set; }
        public Contact Contact { get; set; }
        public Address Address { get; set; }
    }
}
