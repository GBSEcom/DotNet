using System;
namespace firstdata.Models
{
    public class AuthResultApplePay : BaseModel
    {
        public String OnlinePaymentCryptogram { get; set; }
        public String EciIndicator { get; set; }
    }
}
