using System;
using System.Collections.Generic;

namespace firstdata.Models
{
    public class Airline : BaseModel
    {
        public String PassengerName { get; set; }
        public String TicketNumber { get; set; }
        public String IssuingCarrier { get; set; }
        public String CarrierName { get; set; }
        public String TravelAgencyIataCode { get; set; }
        public String TravelAgencyName { get; set; }
        public String AirlinePlanNumber { get; set; }
        public String AirlineInvoiceNumber { get; set; }
        public String ReservationSystem { get; set; }
        public String Restricted { get; set; }
        public List<TravelRoute> TravelRoute { get; set; }
        public String RelatedTicketNumber { get; set; }
        public List<AncillaryServiceCategory> AncillaryServiceCategory { get; set; }
        public String TicketPurchase { get; set; }
    }
}
