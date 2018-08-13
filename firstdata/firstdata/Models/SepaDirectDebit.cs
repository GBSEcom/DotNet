using System;
namespace firstdata.Models
{
	public class SepaDirectDebit : BaseModel
    {
        public String Iban { get; set; }
        public String Name { get; set; }
        public String Country { get; set; }
        public String Email { get; set; }
        public SepaMandate Mandate { get; set; }
    }
}
