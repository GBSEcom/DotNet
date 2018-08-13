using System;
namespace firstdata.Models
{
    public class CertificateCreationResponse : BaseModel
    {
        public String ClientRequestId { get; set; }
        public String ApiTraceId { get; set; }
        public String Certificate { get; set; }
    }
}
