using System;
namespace firstdata.Models
{
    public class SepaMandate : BaseModel
    {
        public String Reference { get; set; }
        public String Url { get; set; }
        public String SignatureDate { get; set; }
        public String Type { get; set; }
    }
}
