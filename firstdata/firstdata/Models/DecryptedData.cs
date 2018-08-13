using System;
namespace firstdata.Models
{
    public class DecryptedData : BaseModel
    {
        public Amount Amount { get; set; }
        public PaymentCard PaymentCard { get; set; }
    }
}
