using System;
namespace firstdata.Models
{
    public class ApplePayHeader : BaseModel
    {
        public String ApplicationDataHash { get; set; }
        public String EphemeralPublicKey { get; set; }
        public String PublicKeyHash { get; set; }
        public String TransactionId { get; set; }
    }
}
