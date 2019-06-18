using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Common object for transaction.
  /// </summary>
  [DataContract]
  public class Transaction {
    /// <summary>
    /// The state of the transaction.
    /// </summary>
    /// <value>The state of the transaction.</value>
    [DataMember(Name="transactionState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionState")]
    public string TransactionState { get; set; }

    /// <summary>
    /// The transaction ID.
    /// </summary>
    /// <value>The transaction ID.</value>
    [DataMember(Name="ipgTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipgTransactionId")]
    public string IpgTransactionId { get; set; }

    /// <summary>
    /// Client order ID if supplied by client.
    /// </summary>
    /// <value>Client order ID if supplied by client.</value>
    [DataMember(Name="orderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderId")]
    public string OrderId { get; set; }

    /// <summary>
    /// Gets or Sets TransactionType
    /// </summary>
    [DataMember(Name="transactionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionType")]
    public TransactionType TransactionType { get; set; }

    /// <summary>
    /// Gets or Sets PaymentMethodDetails
    /// </summary>
    [DataMember(Name="paymentMethodDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethodDetails")]
    public PaymentMethodDetails PaymentMethodDetails { get; set; }

    /// <summary>
    /// Gets or Sets TransactionAmount
    /// </summary>
    [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionAmount")]
    public Amount TransactionAmount { get; set; }

    /// <summary>
    /// The submission component.
    /// </summary>
    /// <value>The submission component.</value>
    [DataMember(Name="submissionComponent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "submissionComponent")]
    public string SubmissionComponent { get; set; }

    /// <summary>
    /// The payer security level.
    /// </summary>
    /// <value>The payer security level.</value>
    [DataMember(Name="payerSecurityLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payerSecurityLevel")]
    public string PayerSecurityLevel { get; set; }

    /// <summary>
    /// The transaction time in seconds since epoch.
    /// </summary>
    /// <value>The transaction time in seconds since epoch.</value>
    [DataMember(Name="transactionTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionTime")]
    public long? TransactionTime { get; set; }

    /// <summary>
    /// Store ID number.
    /// </summary>
    /// <value>Store ID number.</value>
    [DataMember(Name="storeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeId")]
    public string StoreId { get; set; }

    /// <summary>
    /// The user ID.
    /// </summary>
    /// <value>The user ID.</value>
    [DataMember(Name="userId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userId")]
    public string UserId { get; set; }

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
      sb.Append("class Transaction {\n");
      sb.Append("  TransactionState: ").Append(TransactionState).Append("\n");
      sb.Append("  IpgTransactionId: ").Append(IpgTransactionId).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
      sb.Append("  PaymentMethodDetails: ").Append(PaymentMethodDetails).Append("\n");
      sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
      sb.Append("  SubmissionComponent: ").Append(SubmissionComponent).Append("\n");
      sb.Append("  PayerSecurityLevel: ").Append(PayerSecurityLevel).Append("\n");
      sb.Append("  TransactionTime: ").Append(TransactionTime).Append("\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  Processor: ").Append(Processor).Append("\n");
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
