using System;
using System.Collections.Generic;

namespace firstdata.Models
{
    public class CarRental : BaseModel
    {
        public String AgreementNumber { get; set; }
        public String RenterName { get; set; }
        public String ReturnCity { get; set; }
        public String ReturnDate { get; set; }
        public String PickupDate { get; set; }
        public String RentalClassId { get; set; }
        public List<ExtraCharge> ExtraCharges { get; set; }
        public String NoShowIndicator { get; set; }
    }
}