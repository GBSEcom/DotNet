using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Submit the result of the authentication managed outside of The Gateway. For more convenient usage without implementing 3-D Secure yourself see \&quot;authenticationRequest\&quot; section.
  /// </summary>
  [DataContract]
  public class PaymentCardAuthenticationResult {
    /// <summary>
    /// Type of authentication result. For example, 3-D Secure.
    /// </summary>
    /// <value>Type of authentication result. For example, 3-D Secure.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Card enrollment result from the Verification Response (VeRes)
    /// </summary>
    /// <value>Card enrollment result from the Verification Response (VeRes)</value>
    [DataMember(Name="verificationResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verificationResponse")]
    public string VerificationResponse { get; set; }

    /// <summary>
    /// Payer authentication result from Payment Authentication Response (PaRes)
    /// </summary>
    /// <value>Payer authentication result from Payment Authentication Response (PaRes)</value>
    [DataMember(Name="payerAuthenticationResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payerAuthenticationResponse")]
    public string PayerAuthenticationResponse { get; set; }

    /// <summary>
    /// Cardholder Authentication Verification Value (CAVV)
    /// </summary>
    /// <value>Cardholder Authentication Verification Value (CAVV)</value>
    [DataMember(Name="authenticationValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationValue")]
    public string AuthenticationValue { get; set; }

    /// <summary>
    /// Authentication ID
    /// </summary>
    /// <value>Authentication ID</value>
    [DataMember(Name="xid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "xid")]
    public string Xid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentCardAuthenticationResult {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  VerificationResponse: ").Append(VerificationResponse).Append("\n");
      sb.Append("  PayerAuthenticationResponse: ").Append(PayerAuthenticationResponse).Append("\n");
      sb.Append("  AuthenticationValue: ").Append(AuthenticationValue).Append("\n");
      sb.Append("  Xid: ").Append(Xid).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
