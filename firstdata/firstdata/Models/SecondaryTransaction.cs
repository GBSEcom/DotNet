using System;
namespace firstdata.Models
{
    public class SecondaryTransaction : TransactionRequest
    {
        public String StoreId { get; set; }
        public Amount Amount { get; set; }
        public SplitShipment SplitShipment { get; set; }
    }
}
