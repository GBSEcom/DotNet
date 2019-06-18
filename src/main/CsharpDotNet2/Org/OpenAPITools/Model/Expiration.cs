using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Required for normal transactions except for payment with &#39;RECURRING&#39; flags.
  /// </summary>
  [DataContract]
  public class Expiration {
    /// <summary>
    /// Month of the card expiration date.
    /// </summary>
    /// <value>Month of the card expiration date.</value>
    [DataMember(Name="month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "month")]
    public string Month { get; set; }

    /// <summary>
    /// Year of the card expiration date.
    /// </summary>
    /// <value>Year of the card expiration date.</value>
    [DataMember(Name="year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "year")]
    public string Year { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Expiration {\n");
      sb.Append("  Month: ").Append(Month).Append("\n");
      sb.Append("  Year: ").Append(Year).Append("\n");
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
