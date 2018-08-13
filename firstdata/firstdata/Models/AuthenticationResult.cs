using System;
namespace firstdata.Models
{
    public class AuthenticationResult : BaseModel
    {
        public AuthResultApplePay ApplePay { get; set; }
        public AuthResultSecure3d Secure3d { get; set; }
    }
}
