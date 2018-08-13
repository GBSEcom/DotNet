using System;
namespace firstdata.Models
{
    public class AvsResponse : BaseModel
    {
        public String StreetNumberMatch { get; set; }
        public String PostalCodeMatch { get; set; }
    }
}
