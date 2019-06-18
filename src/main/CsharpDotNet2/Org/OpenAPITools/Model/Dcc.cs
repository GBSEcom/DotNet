using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request to perform a dynamic pricing exchange rate inquiry.
  /// </summary>
  [DataContract]
  public class Dcc : CurrencyConversion {
    /// <summary>
    /// Indicates whether customer agrees with rate to be used.
    /// </summary>
    /// <value>Indicates whether customer agrees with rate to be used.</value>
    [DataMember(Name="dccApplied", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dccApplied")]
    public bool? DccApplied { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Dcc {\n");
      sb.Append("  DccApplied: ").Append(DccApplied).Append("\n");
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
