using System;
namespace firstdata.Models
{
	public class AccessTokenResponse : BaseModel
    {
        public String AccessToken { get; set; }
        public String ClientRequestId { get; set; }
        public String ApiTraceId { get; set; }
        public String TransactionStatus { get; set; }
        public Error Error { get; set; }
    }
}
