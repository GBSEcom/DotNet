using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Authentication verification request specific to 3DSecure transactions.
  /// </summary>
  [DataContract]
  public class Secure3dAuthenticationVerificationRequest : AuthenticationVerificationRequest {
    /// <summary>
    /// A formatted message providing results of the issuer’s cardholder authentication.
    /// </summary>
    /// <value>A formatted message providing results of the issuer’s cardholder authentication.</value>
    [DataMember(Name="payerAuthenticationResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payerAuthenticationResponse")]
    public string PayerAuthenticationResponse { get; set; }

    /// <summary>
    /// Formatted string encoding transaction time, order ID, and return URL data.
    /// </summary>
    /// <value>Formatted string encoding transaction time, order ID, and return URL data.</value>
    [DataMember(Name="merchantData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantData")]
    public string MerchantData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Secure3dAuthenticationVerificationRequest {\n");
      sb.Append("  PayerAuthenticationResponse: ").Append(PayerAuthenticationResponse).Append("\n");
      sb.Append("  MerchantData: ").Append(MerchantData).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
