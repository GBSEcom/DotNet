using System;
namespace firstdata.Models
{
    public class Contact : BaseModel
    {
        public String Phone { get; set; }
        public String MobilePhone { get; set; }
        public String Fax { get; set; }
        public String Email { get; set; }
    }
}
