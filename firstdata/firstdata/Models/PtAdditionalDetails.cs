using System;
namespace firstdata.Models
{
    public class PtAdditionalDetails : BaseModel
    {
        public String ReferenceNumber { get; set; }
        public String Comments { get; set; }
        public String DynamicMerchantName { get; set; }
        public String InvoiceNumber { get; set; }
        public String PurchaseOrderNumber { get; set; }
        public String RecurringType { get; set; }
    }
}
