using System;
using Newtonsoft.Json;

namespace firstdata.Models
{
    public class PaymentCard : BaseModel
    {
        public String Number { get; set; }
        public ExpiryDate ExpiryDate { get; set; }
        public String SecurityCode { get; set; }
        public String CardFunction { get; set; }
        public String CardholderName { get; set; }
        public AuthenticationRequest AuthenticationRequest { get; set; }
        public String Brand { get; set; }
        public String WalletProviderId { get; set; }
        public AuthenticationResult AuthenticationResult { get; set; }
        public String EnableTokenization { get; set; }
        public String Expiration { set { SetExpiry(value); } }

        public void SetExpiry(String expiry){
            ExpiryDate = new ExpiryDate(expiry);
        }
    }
}
