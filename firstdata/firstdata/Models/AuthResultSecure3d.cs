using System;
namespace firstdata.Models
{
	public class AuthResultSecure3d : BaseModel
    {
        public String Type { get; set; }
        public String VerificationResponse { get; set; }
        public String PayerAuthenticationResponse { get; set; }
        public String AuthenticationValue { get; set; }
        public String Xid { get; set; }
    }
}
