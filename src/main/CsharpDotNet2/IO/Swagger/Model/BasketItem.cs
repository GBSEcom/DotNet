using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BasketItem {
    /// <summary>
    /// Item ID
    /// </summary>
    /// <value>Item ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Referenced parent Business Entity ID in master database for the outlets // COPY-PASTE ERROR?
    /// </summary>
    /// <value>Referenced parent Business Entity ID in master database for the outlets // COPY-PASTE ERROR?</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets UnitPrice
    /// </summary>
    [DataMember(Name="unitPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitPrice")]
    public Amount UnitPrice { get; set; }

    /// <summary>
    /// Total quantity of items
    /// </summary>
    /// <value>Total quantity of items</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BasketItem {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
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
