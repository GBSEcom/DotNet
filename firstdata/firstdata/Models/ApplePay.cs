using System;
namespace firstdata.Models
{
    public class ApplePay : BaseModel
    {
        public String Signature { get; set; }
        public ApplePayHeader Header { get; set; }
        public String Data { get; set; }
        public String Version { get; set; }
        public String AppId { get; set; }
    }
}
