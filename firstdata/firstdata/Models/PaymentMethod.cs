using System;
namespace firstdata.Models
{
    public class PaymentMethod : BaseModel
    {
        public String Type { get; set; }
        public PaymentCard PaymentCard { get; set; }
        public SepaDirectDebit SepaDirectDebit { get; set; }
        public ApplePay ApplePay { get; set; }
    }
}
