using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Split-shipment related information, in order to reuse the same authorization
  /// </summary>
  [DataContract]
  public class SplitShipment {
    /// <summary>
    /// Total count of the shipment, can be set at preauth or the first postauth.
    /// </summary>
    /// <value>Total count of the shipment, can be set at preauth or the first postauth.</value>
    [DataMember(Name="totalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCount")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Indicates whether the transaction is the final shipment
    /// </summary>
    /// <value>Indicates whether the transaction is the final shipment</value>
    [DataMember(Name="finalShipment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finalShipment")]
    public bool? FinalShipment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SplitShipment {\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
      sb.Append("  FinalShipment: ").Append(FinalShipment).Append("\n");
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
