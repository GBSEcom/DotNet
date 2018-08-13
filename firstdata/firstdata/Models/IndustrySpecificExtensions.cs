using System;
namespace firstdata.Models
{
    public class IndustrySpecificExtensions : BaseModel
    {
        public Airline Airline { get; set; }
        public Lodging Lodging { get; set; }
        public CarRental CarRental { get; set; }
    }
}
