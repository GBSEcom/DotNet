using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The frequency of payments.
  /// </summary>
  [DataContract]
  public class Frequency {
    /// <summary>
    /// Rate of frequency.
    /// </summary>
    /// <value>Rate of frequency.</value>
    [DataMember(Name="every", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "every")]
    public int? Every { get; set; }

    /// <summary>
    /// Unit which defines the frequency.
    /// </summary>
    /// <value>Unit which defines the frequency.</value>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit")]
    public string Unit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Frequency {\n");
      sb.Append("  Every: ").Append(Every).Append("\n");
      sb.Append("  Unit: ").Append(Unit).Append("\n");
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
