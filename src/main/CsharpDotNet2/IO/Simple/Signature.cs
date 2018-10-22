using System;
using System.Text;
using System.Security.Cryptography;

namespace IO.Simple
{
    public class Signature
    {
        private String apiKey;
        private String apiSecret;
        private String clientRequestId;
        public String ClientRequestId { get => clientRequestId; }
        private long timeStamp;
        public long TimeStamp { get => timeStamp; }

        public Signature(String _apiKey, String _apiSecret)
        {
            apiKey = _apiKey;
            apiSecret = _apiSecret;
            clientRequestId = Guid.NewGuid().ToString();
            timeStamp = (DateTimeOffset.Now.ToUnixTimeMilliseconds());
        }

        public string Sign(String payload="")
        {
            UTF8Encoding encoder = new UTF8Encoding();

            // Create signature message
            string message = apiKey + clientRequestId + timeStamp.ToString() + payload;
            byte[] secretKeyBytes = encoder.GetBytes(apiSecret);
            byte[] messageBytes = encoder.GetBytes(message);

            // Perform hashing
            HMACSHA256 hmac = new HMACSHA256(secretKeyBytes);
            byte[] hmacBytes = hmac.ComputeHash(messageBytes);
            String hexHmac = ByteArrayToString(hmacBytes);

            // Convert to Base64
            byte[] hexBytes = encoder.GetBytes(hexHmac);
            String signature = Convert.ToBase64String(hexBytes);

            return signature;
        }

        private string ByteArrayToString(byte[] input)
        {
            int i;
            StringBuilder output = new StringBuilder(input.Length);
            for (i = 0; i < input.Length; i++)
            {
                output.Append(input[i].ToString("x2"));
            }
            return output.ToString();
        }
    }
}
