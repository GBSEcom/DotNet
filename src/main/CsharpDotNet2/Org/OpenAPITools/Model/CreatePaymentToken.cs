using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Use this model to create a payment token.
  /// </summary>
  [DataContract]
  public class CreatePaymentToken {
    /// <summary>
    /// Client-supplied payment token value. Only applicable for DataVault tokenization scheme.
    /// </summary>
    /// <value>Client-supplied payment token value. Only applicable for DataVault tokenization scheme.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// If the token is reusable.
    /// </summary>
    /// <value>If the token is reusable.</value>
    [DataMember(Name="reusable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reusable")]
    public bool? Reusable { get; set; }

    /// <summary>
    /// Decline duplicate payment info if client token is supplied.
    /// </summary>
    /// <value>Decline duplicate payment info if client token is supplied.</value>
    [DataMember(Name="declineDuplicates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "declineDuplicates")]
    public bool? DeclineDuplicates { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreatePaymentToken {\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Reusable: ").Append(Reusable).Append("\n");
      sb.Append("  DeclineDuplicates: ").Append(DeclineDuplicates).Append("\n");
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
