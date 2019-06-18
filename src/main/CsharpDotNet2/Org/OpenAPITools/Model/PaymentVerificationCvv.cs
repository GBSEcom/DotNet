using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The result of the CVV (Card Verification Value, or Card Security Code) check.
  /// </summary>
  [DataContract]
  public class PaymentVerificationCvv {
    /// <summary>
    /// CVV response code.
    /// </summary>
    /// <value>CVV response code.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// Interpretation of the response code.
    /// </summary>
    /// <value>Interpretation of the response code.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Identifier of the scheme.
    /// </summary>
    /// <value>Identifier of the scheme.</value>
    [DataMember(Name="scheme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheme")]
    public string Scheme { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentVerificationCvv {\n");
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
