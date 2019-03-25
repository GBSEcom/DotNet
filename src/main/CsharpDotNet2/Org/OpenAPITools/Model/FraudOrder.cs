using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The list of items included in the order.
  /// </summary>
  [DataContract]
  public class FraudOrder {
    /// <summary>
    /// Gets or Sets ShipToAddress
    /// </summary>
    [DataMember(Name="shipToAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipToAddress")]
    public FraudOrderShipToAddress ShipToAddress { get; set; }

    /// <summary>
    /// The list of items included in the order.
    /// </summary>
    /// <value>The list of items included in the order.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<FraudOrderItems> Items { get; set; }

    /// <summary>
    /// A JSON object that can carry any additional information about the order that might be helpful for fraud detection.
    /// </summary>
    /// <value>A JSON object that can carry any additional information about the order that might be helpful for fraud detection.</value>
    [DataMember(Name="userDefined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDefined")]
    public Object UserDefined { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FraudOrder {\n");
      sb.Append("  ShipToAddress: ").Append(ShipToAddress).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  UserDefined: ").Append(UserDefined).Append("\n");
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
