using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request authentication of the payment card to verify the cardholder and be eligible for liability shift. Provides shared fields for all Authentication request types. Abstract class, do not use this class directly, use one of its children.
  /// </summary>
  [DataContract]
  public class Authentication {
    /// <summary>
    /// Indicates what kind of authentication scheme the merchant wants to use on the card.
    /// </summary>
    /// <value>Indicates what kind of authentication scheme the merchant wants to use on the card.</value>
    [DataMember(Name="requestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestType")]
    public string RequestType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Authentication {\n");
      sb.Append("  RequestType: ").Append(RequestType).Append("\n");
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
