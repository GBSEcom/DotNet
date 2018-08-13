using System;
namespace firstdata.Models
{
    public class TransactionResponse : BaseModel
    {
        public String ClientRequestId { get; set; }
        public String ApiTraceId { get; set; }
        public String IpgTransactionId { get; set; }
        public String OrderId { get; set; }
        public String TransactionType { get; set; }
        public String AuthorizationCode { get; set; }
        public AvsResponse AvsResponse { get; set; }
        public String SecurityCodeResponse { get; set; }
        public String Brand { get; set; }
        public String Country { get; set; }
        public String TerminalId { get; set; }
        public String ClientTransactionId { get; set; }
        public String TransactionTime { get; set; }
        public Amount ApprovedAmount { get; set; }
        public String TransactionStatus { get; set; }
        public AuthenticationRedirect AuthenticationRedirect { get; set; }
        public Error Error { get; set; }
    }
}
