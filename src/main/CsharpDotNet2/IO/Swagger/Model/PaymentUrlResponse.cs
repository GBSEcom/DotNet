using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Response from embedded payment link request.
  /// </summary>
  [DataContract]
  public class PaymentUrlResponse {
    /// <summary>
    /// Echoes back the value in the Request header for tracking.
    /// </summary>
    /// <value>Echoes back the value in the Request header for tracking.</value>
    [DataMember(Name="clientRequestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientRequestId")]
    public string ClientRequestId { get; set; }

    /// <summary>
    /// Request identifier in API, can be used to request logs from the support.
    /// </summary>
    /// <value>Request identifier in API, can be used to request logs from the support.</value>
    [DataMember(Name="apiTraceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiTraceId")]
    public string ApiTraceId { get; set; }

    /// <summary>
    /// Request status. If it's anything other than 'SUCCESS', please refer to 400s HTTP error codes or decline. See Error object for details.
    /// </summary>
    /// <value>Request status. If it's anything other than 'SUCCESS', please refer to 400s HTTP error codes or decline. See Error object for details.</value>
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
    /// Gets or Sets PaymentUrl
    /// </summary>
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
      sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
      sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
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
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
