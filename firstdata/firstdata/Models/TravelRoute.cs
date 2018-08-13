using System;
namespace firstdata.Models
{
    public class TravelRoute : BaseModel
    {
        public String DepartureDate { get; set; }
        public String Origin { get; set; }
        public String Destination { get; set; }
        public String CarrierCode { get; set; }
        public String ServiceCharge { get; set; }
        public String StopoverType { get; set; }
        public String FareBasisCode { get; set; }
        public String DepartureTax { get; set; }
        public String FlightNumber { get; set; }
    }
}
