using System;
namespace firstdata.Models
{
    public class AuthRedirectParams : BaseModel
    {
        public String PaReq { get; set; }
        public String TermUrl { get; set; }
        public String MD { get; set; }
    }
}
