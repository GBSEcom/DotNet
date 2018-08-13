using System;
using System.Collections.Generic;
            
namespace firstdata.Models
{
    public class Error : BaseModel
    {
        public String Code { get; set; }
        public String Message { get; set; }
        public List<ErrorDetails> Details { get; set; }
    }
}
