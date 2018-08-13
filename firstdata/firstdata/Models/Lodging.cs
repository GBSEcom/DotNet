using System;
using System.Collections.Generic;

namespace firstdata.Models
{
    public class Lodging : BaseModel
    {
        public String ArrivalDate { get; set; }
        public String DepartureDate { get; set; }
        public String FolioNumber { get; set; }
        public List<ExtraCharge> ExtraCharges { get; set; }
        public String NoShowIndicator { get; set; }
    }
}
