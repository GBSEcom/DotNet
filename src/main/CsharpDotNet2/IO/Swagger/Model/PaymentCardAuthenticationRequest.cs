using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request authentication of the card (typically, 3-D Secure) to verify the cardholder and be eligible for liability shift
  /// </summary>
  [DataContract]
  public class PaymentCardAuthenticationRequest {
    /// <summary>
    /// Indicates what kind of authentication scheme the merchant wants to use on the card. Currently, only 3-D Secure is supported.
    /// </summary>
    /// <value>Indicates what kind of authentication scheme the merchant wants to use on the card. Currently, only 3-D Secure is supported.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentCardAuthenticationRequest {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
