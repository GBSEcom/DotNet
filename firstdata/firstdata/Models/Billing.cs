using System;
namespace firstdata.Models
{
    public class Billing : BaseModel
    {
        public String Name { get; set; }
        public String PersonalNumber { get; set; }
        public String BirthDate { get; set; }
        public String Gender { get; set; }
        public Contact Contact { get; set; }
        public Address Address { get; set; }
    }
}
