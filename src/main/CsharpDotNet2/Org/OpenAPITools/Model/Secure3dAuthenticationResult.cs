using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Submit the result of the authentication managed outside of the gateway. For more convenient usage without implementing 3-D Secure yourself see \&quot;authenticationRequest\&quot; section.
  /// </summary>
  [DataContract]
  public class Secure3dAuthenticationResult : Authentication {
    /// <summary>
    /// Card enrollment result from the Verification Response (VeRes).
    /// </summary>
    /// <value>Card enrollment result from the Verification Response (VeRes).</value>
    [DataMember(Name="verificationResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verificationResponse")]
    public string VerificationResponse { get; set; }

    /// <summary>
    /// Result of authentication attempt from Payer Authentication Response (PaRes).
    /// </summary>
    /// <value>Result of authentication attempt from Payer Authentication Response (PaRes).</value>
    [DataMember(Name="authenticationAttemptResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationAttemptResult")]
    public string AuthenticationAttemptResult { get; set; }

    /// <summary>
    /// The Cardholder Authentication Verification Value (CAVV) is a cryptographic value derived by the issuer during payment authentication that can provide evidence of the results of payment authentication during an online purchase.
    /// </summary>
    /// <value>The Cardholder Authentication Verification Value (CAVV) is a cryptographic value derived by the issuer during payment authentication that can provide evidence of the results of payment authentication during an online purchase.</value>
    [DataMember(Name="authenticationValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationValue")]
    public string AuthenticationValue { get; set; }

    /// <summary>
    /// The transaction identifier (XID) is a unique tracking number set by the merchant.
    /// </summary>
    /// <value>The transaction identifier (XID) is a unique tracking number set by the merchant.</value>
    [DataMember(Name="xid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "xid")]
    public string Xid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Secure3dAuthenticationResult {\n");
      sb.Append("  VerificationResponse: ").Append(VerificationResponse).Append("\n");
      sb.Append("  AuthenticationAttemptResult: ").Append(AuthenticationAttemptResult).Append("\n");
      sb.Append("  AuthenticationValue: ").Append(AuthenticationValue).Append("\n");
      sb.Append("  Xid: ").Append(Xid).Append("\n");
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
