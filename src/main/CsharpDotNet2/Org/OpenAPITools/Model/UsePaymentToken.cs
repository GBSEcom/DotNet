using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Payment token usage details.
  /// </summary>
  [DataContract]
  public class UsePaymentToken {
    /// <summary>
    /// Client-supplied payment token value.
    /// </summary>
    /// <value>Client-supplied payment token value.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Gets or Sets Function
    /// </summary>
    [DataMember(Name="function", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "function")]
    public CardFunction Function { get; set; }

    /// <summary>
    /// Card verification value/number.
    /// </summary>
    /// <value>Card verification value/number.</value>
    [DataMember(Name="securityCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityCode")]
    public string SecurityCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsePaymentToken {\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Function: ").Append(Function).Append("\n");
      sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
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
