using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Fraud Detect request payload
  /// </summary>
  [DataContract]
  public class ScoreOnlyRequest {
    /// <summary>
    /// Merchant reference code. Used by FirstAPI and reflected in settlement records and Webhook notifications. Typically, the merchantRef field is the purchase order number or unique sequence value associated to a given transaction.
    /// </summary>
    /// <value>Merchant reference code. Used by FirstAPI and reflected in settlement records and Webhook notifications. Typically, the merchantRef field is the purchase order number or unique sequence value associated to a given transaction.</value>
    [DataMember(Name="merchantRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantRef")]
    public string MerchantRef { get; set; }

    /// <summary>
    /// Type of transaction merchant wants to process.
    /// </summary>
    /// <value>Type of transaction merchant wants to process.</value>
    [DataMember(Name="transactionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionType")]
    public string TransactionType { get; set; }

    /// <summary>
    /// Defines the type of the original transaction that is being evaluated for the Fraud Score.
    /// </summary>
    /// <value>Defines the type of the original transaction that is being evaluated for the Fraud Score.</value>
    [DataMember(Name="originalTransactionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalTransactionType")]
    public string OriginalTransactionType { get; set; }

    /// <summary>
    /// The unique ID of this transaction. Must be unique for the entire system (not just within a specific merchant or industry). Subsequent requests related to the same transaction must have the same transactionId (e.g. transaction/deposit or   transaction/authorization-reversal). This field is used formatching transactions with settlement and chargeback information. If there is no such ID available you may wish to compose one from fields available in both systems. Consider including backend, issuer, merchant id, date and time, amount, etc. as necessary.
    /// </summary>
    /// <value>The unique ID of this transaction. Must be unique for the entire system (not just within a specific merchant or industry). Subsequent requests related to the same transaction must have the same transactionId (e.g. transaction/deposit or   transaction/authorization-reversal). This field is used formatching transactions with settlement and chargeback information. If there is no such ID available you may wish to compose one from fields available in both systems. Consider including backend, issuer, merchant id, date and time, amount, etc. as necessary.</value>
    [DataMember(Name="originalTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalTransactionId")]
    public string OriginalTransactionId { get; set; }

    /// <summary>
    /// The amount processed for the original transaction.
    /// </summary>
    /// <value>The amount processed for the original transaction.</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// The currency of the original transaction.
    /// </summary>
    /// <value>The currency of the original transaction.</value>
    [DataMember(Name="currencyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyCode")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    [DataMember(Name="customer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer")]
    public Customer Customer { get; set; }

    /// <summary>
    /// Gets or Sets BillingAddress
    /// </summary>
    [DataMember(Name="billingAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAddress")]
    public BillingAddress BillingAddress { get; set; }

    /// <summary>
    /// Gets or Sets Device
    /// </summary>
    [DataMember(Name="device", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "device")]
    public Device Device { get; set; }

    /// <summary>
    /// Gets or Sets Loyalty
    /// </summary>
    [DataMember(Name="loyalty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loyalty")]
    public Loyalty Loyalty { get; set; }

    /// <summary>
    /// Gets or Sets Payment
    /// </summary>
    [DataMember(Name="payment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment")]
    public Payment Payment { get; set; }

    /// <summary>
    /// Gets or Sets Merchant
    /// </summary>
    [DataMember(Name="merchant", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchant")]
    public Merchant Merchant { get; set; }

    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public FraudOrder Order { get; set; }

    /// <summary>
    /// A JSON object that can carry any additional information that might be helpful for fraud detection.
    /// </summary>
    /// <value>A JSON object that can carry any additional information that might be helpful for fraud detection.</value>
    [DataMember(Name="userDefined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDefined")]
    public Object UserDefined { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScoreOnlyRequest {\n");
      sb.Append("  MerchantRef: ").Append(MerchantRef).Append("\n");
      sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
      sb.Append("  OriginalTransactionType: ").Append(OriginalTransactionType).Append("\n");
      sb.Append("  OriginalTransactionId: ").Append(OriginalTransactionId).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  Customer: ").Append(Customer).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  Device: ").Append(Device).Append("\n");
      sb.Append("  Loyalty: ").Append(Loyalty).Append("\n");
      sb.Append("  Payment: ").Append(Payment).Append("\n");
      sb.Append("  Merchant: ").Append(Merchant).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
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
