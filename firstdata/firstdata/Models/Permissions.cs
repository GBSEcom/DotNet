using System;
namespace firstdata.Models
{
    public class Permissions : BaseModel
    {
        public String AuthType { get; set; }
        public String AuthId { get; set; }
    }
}
