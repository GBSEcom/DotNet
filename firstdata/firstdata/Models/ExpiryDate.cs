using System;
using Newtonsoft.Json;

namespace firstdata.Models
{
    public class ExpiryDate : BaseModel
    {
        public String Month { get; set; }
        public String Year { get; set; }
        [JsonIgnore]
        public String ExpiryString;

        public ExpiryDate(String expiry)
        {
            SetDateFromString(expiry);
        }

        private void SetDateFromString(String value){
            if (value.Length == 3)
                value = value.PadLeft(4, '0');
            if (value.Length != 4)
                throw new System.ArgumentException("Expiry Date must be 3 or 4 characters: MMYY or MYY");
            Month = value.Substring(0, 2);
            Year = value.Substring(2, 2);
        }
    }
}
