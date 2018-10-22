using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to generate an embedded payment link.
  /// </summary>
  [DataContract]
  public class PaymentUrlRequest {
    /// <summary>
    /// An optional outlet id for clients that support multiple store in the same developer app.
    /// </summary>
    /// <value>An optional outlet id for clients that support multiple store in the same developer app.</value>
    [DataMember(Name="storeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeId")]
    public string StoreId { get; set; }

    /// <summary>
    /// Gets or Sets ClientLocale
    /// </summary>
    [DataMember(Name="clientLocale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientLocale")]
    public ClientLocale ClientLocale { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

    /// <summary>
    /// Client Order ID if supplied by client, otherwise the Order ID.
    /// </summary>
    /// <value>Client Order ID if supplied by client, otherwise the Order ID.</value>
    [DataMember(Name="orderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderId")]
    public string OrderId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentUrlRequest {\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
      sb.Append("  ClientLocale: ").Append(ClientLocale).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
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
