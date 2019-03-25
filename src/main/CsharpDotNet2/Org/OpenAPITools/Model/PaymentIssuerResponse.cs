using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The issuers response to the payment request. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization).
  /// </summary>
  [DataContract]
  public class PaymentIssuerResponse {
    /// <summary>
    /// The verification response code, as sent by the verification system.
    /// </summary>
    /// <value>The verification response code, as sent by the verification system.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// The interpretation of the response code. Valid values are \"approved\" - The verification was conducted and is approved. \"declined\" - The verification was conducted and is not approved. \"disabled\" - The verification was not conducted because it was not requested or disabled in the verification. \"unknown\" - The verification was attempted but it failed due to some system error (e.g. timeout).
    /// </summary>
    /// <value>The interpretation of the response code. Valid values are \"approved\" - The verification was conducted and is approved. \"declined\" - The verification was conducted and is not approved. \"disabled\" - The verification was not conducted because it was not requested or disabled in the verification. \"unknown\" - The verification was attempted but it failed due to some system error (e.g. timeout).</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// An identifier of the system/specification from which the code was received, and how the status was derived.
    /// </summary>
    /// <value>An identifier of the system/specification from which the code was received, and how the status was derived.</value>
    [DataMember(Name="scheme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheme")]
    public string Scheme { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentIssuerResponse {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Scheme: ").Append(Scheme).Append("\n");
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
