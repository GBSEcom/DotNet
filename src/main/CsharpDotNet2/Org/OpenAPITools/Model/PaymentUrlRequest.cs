using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request to generate an embedded payment link.
  /// </summary>
  [DataContract]
  public class PaymentUrlRequest {
    /// <summary>
    /// An optional Outlet ID for clients that support multiple stores in the same developer app.
    /// </summary>
    /// <value>An optional Outlet ID for clients that support multiple stores in the same developer app.</value>
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
    /// Gets or Sets TransactionAmount
    /// </summary>
    [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionAmount")]
    public Amount TransactionAmount { get; set; }

    /// <summary>
    /// Gets or Sets TransactionType
    /// </summary>
    [DataMember(Name="transactionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionType")]
    public TransactionType TransactionType { get; set; }

    /// <summary>
    /// Client order ID if supplied by client, otherwise the order ID.
    /// </summary>
    /// <value>Client order ID if supplied by client, otherwise the order ID.</value>
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
    /// URL for notifying merchant of payment result.
    /// </summary>
    /// <value>URL for notifying merchant of payment result.</value>
    [DataMember(Name="transactionNotificationURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionNotificationURL")]
    public string TransactionNotificationURL { get; set; }

    /// <summary>
    /// Time until payment URL expires.
    /// </summary>
    /// <value>Time until payment URL expires.</value>
    [DataMember(Name="expiration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiration")]
    public long? Expiration { get; set; }

    /// <summary>
    /// If 3D secure should be applied.
    /// </summary>
    /// <value>If 3D secure should be applied.</value>
    [DataMember(Name="authenticateTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticateTransaction")]
    public bool? AuthenticateTransaction { get; set; }

    /// <summary>
    /// Dynamic merchant name for the cardholder's statement.
    /// </summary>
    /// <value>Dynamic merchant name for the cardholder's statement.</value>
    [DataMember(Name="dynamicMerchantName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dynamicMerchantName")]
    public string DynamicMerchantName { get; set; }

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
    /// IPv4 or IPv6 network address.
    /// </summary>
    /// <value>IPv4 or IPv6 network address.</value>
    [DataMember(Name="ip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ip")]
    public string Ip { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentUrlRequest {\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
      sb.Append("  ClientLocale: ").Append(ClientLocale).Append("\n");
      sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
      sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  Billing: ").Append(Billing).Append("\n");
      sb.Append("  Shipping: ").Append(Shipping).Append("\n");
      sb.Append("  TransactionNotificationURL: ").Append(TransactionNotificationURL).Append("\n");
      sb.Append("  Expiration: ").Append(Expiration).Append("\n");
      sb.Append("  AuthenticateTransaction: ").Append(AuthenticateTransaction).Append("\n");
      sb.Append("  DynamicMerchantName: ").Append(DynamicMerchantName).Append("\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  Ip: ").Append(Ip).Append("\n");
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
