using System;
namespace firstdata.Models

{
    public class AmountComponents : BaseModel
    {
        public String Subtotal { get; set; }
        public String VatAmount { get; set; }
        public String LocalTax { get; set; }
        public String Shipping { get; set; }
        public String Cashback { get; set; }
        public String Tip { get; set; }
        public String ConvenienceFee { get; set; }
    }
}
