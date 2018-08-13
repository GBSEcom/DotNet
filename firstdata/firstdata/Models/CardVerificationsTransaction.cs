using System;
namespace firstdata.Models
{
    public class CardVerificationsTransaction : BaseModel
    {
        public String StoreId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
