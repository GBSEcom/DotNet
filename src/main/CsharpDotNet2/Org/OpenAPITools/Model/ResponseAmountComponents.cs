using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Amount component details, used in responses.
  /// </summary>
  [DataContract]
  public class ResponseAmountComponents : AmountComponents {
    /// <summary>
    /// Amount added for proccessing or handling fees.
    /// </summary>
    /// <value>Amount added for proccessing or handling fees.</value>
    [DataMember(Name="convenienceFee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "convenienceFee")]
    public decimal? ConvenienceFee { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResponseAmountComponents {\n");
      sb.Append("  ConvenienceFee: ").Append(ConvenienceFee).Append("\n");
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
