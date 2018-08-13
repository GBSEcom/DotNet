using System;
namespace firstdata.Models
{
    public class AuthenticationResponseVerification : BaseModel
    {
        public String Type { get; set; }
        public String MD { get; set; }
        public String PaRes { get; set; }
    }
}
