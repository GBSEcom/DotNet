using System;
namespace firstdata.Models
{
    public class Certificates : BaseModel
    {
        public String Certificate { get; set; }
        public String AppLabel { get; set; }
        public String WalletProvider { get; set; }
        public String Status { get; set; }
    }
}