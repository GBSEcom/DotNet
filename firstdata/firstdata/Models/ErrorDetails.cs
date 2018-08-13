using System;
namespace firstdata.Models
{
    public class ErrorDetails : BaseModel
    {
        public String Field { get; set; }
        public String Message { get; set; }
    }
}
