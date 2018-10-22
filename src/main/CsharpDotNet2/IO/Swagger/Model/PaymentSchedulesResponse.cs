using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Response from the gateway scheduler creation call.
  /// </summary>
  [DataContract]
  public class PaymentSchedulesResponse {
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
    /// Result of requested operation. If it's anything other than 'SUCCESS', please refer to 400s HTTP error codes or decline. See Error object for details.
    /// </summary>
    /// <value>Result of requested operation. If it's anything other than 'SUCCESS', please refer to 400s HTTP error codes or decline. See Error object for details.</value>
    [DataMember(Name="transactionStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionStatus")]
    public string TransactionStatus { get; set; }

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
      sb.Append("class PaymentSchedulesResponse {\n");
      sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
      sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
      sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
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
