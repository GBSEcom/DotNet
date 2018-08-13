using System;
namespace firstdata.Models
{
    public class WalletDecryptionResponse : BaseModel
    {
        public DecryptedData DecryptedData { get; set; }
    }
}
