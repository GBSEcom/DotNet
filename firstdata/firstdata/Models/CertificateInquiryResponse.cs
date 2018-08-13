using System;
using System.Collections.Generic;
namespace firstdata.Models
{
    public class CertificateInquiryResponse : BaseModel
    {
        public String ClientRequestId { get; set; }
        public String ApiTraceId { get; set; }
        public List<Certificates> Certificates { get; set; }
    }
}
