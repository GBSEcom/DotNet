using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request to create a gateway schedule. Abstract class, do not use this class directly, use one of its children.
  /// </summary>
  [DataContract]
  public class PaymentSchedulesRequest {
    /// <summary>
    /// Object name of the payment schedules request.
    /// </summary>
    /// <value>Object name of the payment schedules request.</value>
    [DataMember(Name="requestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestType")]
    public string RequestType { get; set; }

    /// <summary>
    /// Store ID number.
    /// </summary>
    /// <value>Store ID number.</value>
    [DataMember(Name="storeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeId")]
    public string StoreId { get; set; }

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
    [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchaseOrderNumber")]
    public string PurchaseOrderNumber { get; set; }

    /// <summary>
    /// Gets or Sets TransactionOrigin
    /// </summary>
    [DataMember(Name="transactionOrigin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionOrigin")]
    public TransactionOrigin TransactionOrigin { get; set; }

    /// <summary>
    /// Dynamic merchant name for the cardholder's statement.
    /// </summary>
    /// <value>Dynamic merchant name for the cardholder's statement.</value>
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
    /// Gets or Sets TransactionAmount
    /// </summary>
    [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionAmount")]
    public Amount TransactionAmount { get; set; }

    /// <summary>
    /// Gets or Sets ClientLocale
    /// </summary>
    [DataMember(Name="clientLocale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientLocale")]
    public ClientLocale ClientLocale { get; set; }

    /// <summary>
    /// Client order ID if supplied by client.
    /// </summary>
    /// <value>Client order ID if supplied by client.</value>
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
    /// User supplied comments.
    /// </summary>
    /// <value>User supplied comments.</value>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public string Comments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentSchedulesRequest {\n");
      sb.Append("  RequestType: ").Append(RequestType).Append("\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  NumberOfPayments: ").Append(NumberOfPayments).Append("\n");
      sb.Append("  MaximumFailures: ").Append(MaximumFailures).Append("\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  TransactionOrigin: ").Append(TransactionOrigin).Append("\n");
      sb.Append("  DynamicMerchantName: ").Append(DynamicMerchantName).Append("\n");
      sb.Append("  Frequency: ").Append(Frequency).Append("\n");
      sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
      sb.Append("  ClientLocale: ").Append(ClientLocale).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  Billing: ").Append(Billing).Append("\n");
      sb.Append("  Shipping: ").Append(Shipping).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
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
