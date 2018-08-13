using System;
namespace firstdata.Models
{
    public class Address : BaseModel
    {
        public String Company { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String Locality { get; set; }
        public String Region { get; set; }
        public String PostalCode { get; set; }
        public String Country { get; set; }
    }
}
