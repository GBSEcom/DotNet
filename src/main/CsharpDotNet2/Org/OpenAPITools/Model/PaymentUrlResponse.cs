using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Response from an embedded payment link request.
  /// </summary>
  [DataContract]
  public class PaymentUrlResponse : BasicResponse {
    /// <summary>
    /// Request status. If it is anything other than 'SUCCESS', please refer to 400s HTTP error codes or decline. See Error object for details.
    /// </summary>
    /// <value>Request status. If it is anything other than 'SUCCESS', please refer to 400s HTTP error codes or decline. See Error object for details.</value>
    [DataMember(Name="requestStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestStatus")]
    public string RequestStatus { get; set; }

    /// <summary>
    /// Client Order ID if supplied by client, otherwise the Order ID.
    /// </summary>
    /// <value>Client Order ID if supplied by client, otherwise the Order ID.</value>
    [DataMember(Name="orderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderId")]
    public string OrderId { get; set; }

    /// <summary>
    /// URL for embedded payment link
    /// </summary>
    /// <value>URL for embedded payment link</value>
    [DataMember(Name="paymentUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentUrl")]
    public string PaymentUrl { get; set; }

    /// <summary>
    /// ID code from the transaction.
    /// </summary>
    /// <value>ID code from the transaction.</value>
    [DataMember(Name="transactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionId")]
    public string TransactionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentUrlResponse {\n");
      sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  PaymentUrl: ").Append(PaymentUrl).Append("\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
