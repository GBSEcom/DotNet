using System;
namespace firstdata.Models
{
    public class CertificateRequest : BaseModel
    {
        public String AppLabel { get; set; }
        public String WalletProvider { get; set; }
        public Permissions Permissions { get; set; }
    }
}
