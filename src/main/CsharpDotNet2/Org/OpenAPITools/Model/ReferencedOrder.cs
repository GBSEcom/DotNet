using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ReferencedOrder {
    /// <summary>
    /// Use this to retrieve the payment instrument information from an existing Order
    /// </summary>
    /// <value>Use this to retrieve the payment instrument information from an existing Order</value>
    [DataMember(Name="orderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderId")]
    public string OrderId { get; set; }

    /// <summary>
    /// Gets or Sets PaymentTokenization
    /// </summary>
    [DataMember(Name="paymentTokenization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentTokenization")]
    public PaymentTokenization PaymentTokenization { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReferencedOrder {\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  PaymentTokenization: ").Append(PaymentTokenization).Append("\n");
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
