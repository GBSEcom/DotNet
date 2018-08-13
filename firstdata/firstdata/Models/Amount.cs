using System;
namespace firstdata.Models
{
    public class Amount : BaseModel
    {
        public String Total { get; set; }
        public String Currency { get; set; }
        public AmountComponents Components { get; set; }

    }
}
