using System;
namespace firstdata.Models
{
    public class AuthenticationRedirect : BaseModel
    {
        public String Type { get; set; }
        public String TargetUrl { get; set; }
        public AuthRedirectParams Params { get; set; }
    }
}
