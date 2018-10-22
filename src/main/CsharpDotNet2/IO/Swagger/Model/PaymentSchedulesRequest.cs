using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to create a gateway scheduler.
  /// </summary>
  [DataContract]
  public class PaymentSchedulesRequest {
    /// <summary>
    /// Store ID number.
    /// </summary>
    /// <value>Store ID number.</value>
    [DataMember(Name="storeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeId")]
    public string StoreId { get; set; }

    /// <summary>
    /// Order ID used to create recurring payment from existing transaction.
    /// </summary>
    /// <value>Order ID used to create recurring payment from existing transaction.</value>
    [DataMember(Name="referenceOrderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceOrderId")]
    public string ReferenceOrderId { get; set; }

    /// <summary>
    /// Date of mandate signature.
    /// </summary>
    /// <value>Date of mandate signature.</value>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Number of times the recurring payment will process.
    /// </summary>
    /// <value>Number of times the recurring payment will process.</value>
    [DataMember(Name="numberOfPayments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfPayments")]
    public int? NumberOfPayments { get; set; }

    /// <summary>
    /// Number of failures that can be encountered before re-tries cease.
    /// </summary>
    /// <value>Number of failures that can be encountered before re-tries cease.</value>
    [DataMember(Name="maximumFailures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximumFailures")]
    public int? MaximumFailures { get; set; }

    /// <summary>
    /// Invoice number.
    /// </summary>
    /// <value>Invoice number.</value>
    [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// Purchase order number.
    /// </summary>
    /// <value>Purchase order number.</value>
    [DataMember(Name="poNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "poNumber")]
    public string PoNumber { get; set; }

    /// <summary>
    /// The source of the transaction. The possible values are ECI (if the order was received via email or Internet), MOTO (mail order / telephone order) and RETAIL (face to face).
    /// </summary>
    /// <value>The source of the transaction. The possible values are ECI (if the order was received via email or Internet), MOTO (mail order / telephone order) and RETAIL (face to face).</value>
    [DataMember(Name="transactionOrigin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionOrigin")]
    public string TransactionOrigin { get; set; }

    /// <summary>
    /// Dynamic merchant name for the cardholder‘s statement.
    /// </summary>
    /// <value>Dynamic merchant name for the cardholder‘s statement.</value>
    [DataMember(Name="dynamicMerchantName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dynamicMerchantName")]
    public string DynamicMerchantName { get; set; }

    /// <summary>
    /// Gets or Sets Frequency
    /// </summary>
    [DataMember(Name="frequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "frequency")]
    public Frequency Frequency { get; set; }

    /// <summary>
    /// Gets or Sets PaymentMethod
    /// </summary>
    [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethod")]
    public PaymentMethod PaymentMethod { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

    /// <summary>
    /// Gets or Sets ClientLocale
    /// </summary>
    [DataMember(Name="clientLocale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientLocale")]
    public ClientLocale ClientLocale { get; set; }

    /// <summary>
    /// Client Order ID if supplied by client.
    /// </summary>
    /// <value>Client Order ID if supplied by client.</value>
    [DataMember(Name="orderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderId")]
    public string OrderId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentSchedulesRequest {\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
      sb.Append("  ReferenceOrderId: ").Append(ReferenceOrderId).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  NumberOfPayments: ").Append(NumberOfPayments).Append("\n");
      sb.Append("  MaximumFailures: ").Append(MaximumFailures).Append("\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
      sb.Append("  PoNumber: ").Append(PoNumber).Append("\n");
      sb.Append("  TransactionOrigin: ").Append(TransactionOrigin).Append("\n");
      sb.Append("  DynamicMerchantName: ").Append(DynamicMerchantName).Append("\n");
      sb.Append("  Frequency: ").Append(Frequency).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  ClientLocale: ").Append(ClientLocale).Append("\n");
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
