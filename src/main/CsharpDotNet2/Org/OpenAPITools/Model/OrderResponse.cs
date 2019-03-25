using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// This is the common object for primary and secondary payment request responses.
  /// </summary>
  [DataContract]
  public class OrderResponse : BasicResponse {
    /// <summary>
    /// The response transaction ID
    /// </summary>
    /// <value>The response transaction ID</value>
    [DataMember(Name="ipgTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipgTransactionId")]
    public string IpgTransactionId { get; set; }

    /// <summary>
    /// Client order ID if supplied by client, otherwise the order ID
    /// </summary>
    /// <value>Client order ID if supplied by client, otherwise the order ID</value>
    [DataMember(Name="orderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderId")]
    public string OrderId { get; set; }

    /// <summary>
    /// The transaction time in seconds since Epoch
    /// </summary>
    /// <value>The transaction time in seconds since Epoch</value>
    [DataMember(Name="transactionTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionTime")]
    public long? TransactionTime { get; set; }

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
    /// Gets or Sets Mandate
    /// </summary>
    [DataMember(Name="mandate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mandate")]
    public SepaMandate Mandate { get; set; }

    /// <summary>
    /// Required for some payment methods (for example, Klarna)
    /// </summary>
    /// <value>Required for some payment methods (for example, Klarna)</value>
    [DataMember(Name="transactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactions")]
    public List<Transaction> Transactions { get; set; }

    /// <summary>
    /// Gets or Sets Processor
    /// </summary>
    [DataMember(Name="processor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processor")]
    public ProcessorData Processor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderResponse {\n");
      sb.Append("  IpgTransactionId: ").Append(IpgTransactionId).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  TransactionTime: ").Append(TransactionTime).Append("\n");
      sb.Append("  Billing: ").Append(Billing).Append("\n");
      sb.Append("  Shipping: ").Append(Shipping).Append("\n");
      sb.Append("  Mandate: ").Append(Mandate).Append("\n");
      sb.Append("  Transactions: ").Append(Transactions).Append("\n");
      sb.Append("  Processor: ").Append(Processor).Append("\n");
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
