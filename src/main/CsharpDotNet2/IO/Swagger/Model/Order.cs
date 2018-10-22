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
  public class Order {
    /// <summary>
    /// Gets or Sets OrderId
    /// </summary>
    [DataMember(Name="orderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderId")]
    public string OrderId { get; set; }

    /// <summary>
    /// Gets or Sets Billing
    /// </summary>
    [DataMember(Name="billing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing")]
    public Billing Billing { get; set; }

    /// <summary>
    /// Gets or Sets Shipping
    /// </summary>
    [DataMember(Name="shipping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping")]
    public Shipping Shipping { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Order {\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  Billing: ").Append(Billing).Append("\n");
      sb.Append("  Shipping: ").Append(Shipping).Append("\n");
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
