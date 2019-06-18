using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Common object for primary and secondary payment request responses.
  /// </summary>
  [DataContract]
  public class TransactionResponse : BasicResponse {
    /// <summary>
    /// The response transaction ID.
    /// </summary>
    /// <value>The response transaction ID.</value>
    [DataMember(Name="ipgTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipgTransactionId")]
    public string IpgTransactionId { get; set; }

    /// <summary>
    /// Client order ID if supplied by client, otherwise the order ID.
    /// </summary>
    /// <value>Client order ID if supplied by client, otherwise the order ID.</value>
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
    /// Gets or Sets PaymentToken
    /// </summary>
    [DataMember(Name="paymentToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentToken")]
    public PaymentTokenDetails PaymentToken { get; set; }

    /// <summary>
    /// Gets or Sets TransactionOrigin
    /// </summary>
    [DataMember(Name="transactionOrigin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionOrigin")]
    public TransactionOrigin TransactionOrigin { get; set; }

    /// <summary>
    /// Gets or Sets PaymentMethodDetails
    /// </summary>
    [DataMember(Name="paymentMethodDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethodDetails")]
    public PaymentMethodDetails PaymentMethodDetails { get; set; }

    /// <summary>
    /// Country of the card issuer.
    /// </summary>
    /// <value>Country of the card issuer.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// The terminal that is processing the transaction.
    /// </summary>
    /// <value>The terminal that is processing the transaction.</value>
    [DataMember(Name="terminalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terminalId")]
    public string TerminalId { get; set; }

    /// <summary>
    /// The unique merchant transaction ID from the request header, if supplied.
    /// </summary>
    /// <value>The unique merchant transaction ID from the request header, if supplied.</value>
    [DataMember(Name="merchantTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantTransactionId")]
    public string MerchantTransactionId { get; set; }

    /// <summary>
    /// The transaction time in seconds since epoch.
    /// </summary>
    /// <value>The transaction time in seconds since epoch.</value>
    [DataMember(Name="transactionTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionTime")]
    public long? TransactionTime { get; set; }

    /// <summary>
    /// Gets or Sets ApprovedAmount
    /// </summary>
    [DataMember(Name="approvedAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "approvedAmount")]
    public Amount ApprovedAmount { get; set; }

    /// <summary>
    /// The status of the transaction. APPROVED/WAITING are returned by the endpoints.  VALIDATION_FAILED/DECLINED are errors. See ErrorResponse object for details.
    /// </summary>
    /// <value>The status of the transaction. APPROVED/WAITING are returned by the endpoints.  VALIDATION_FAILED/DECLINED are errors. See ErrorResponse object for details.</value>
    [DataMember(Name="transactionStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionStatus")]
    public string TransactionStatus { get; set; }

    /// <summary>
    /// The state of the transaction.
    /// </summary>
    /// <value>The state of the transaction.</value>
    [DataMember(Name="transactionState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionState")]
    public string TransactionState { get; set; }

    /// <summary>
    /// Gets or Sets Secure3dResponse
    /// </summary>
    [DataMember(Name="secure3dResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secure3dResponse")]
    public Secure3dResponse Secure3dResponse { get; set; }

    /// <summary>
    /// The endpoint redirection URL.
    /// </summary>
    /// <value>The endpoint redirection URL.</value>
    [DataMember(Name="redirectURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirectURL")]
    public string RedirectURL { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticationRedirect
    /// </summary>
    [DataMember(Name="authenticationRedirect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationRedirect")]
    public AuthenticationRedirect AuthenticationRedirect { get; set; }

    /// <summary>
    /// The transaction ID received from schemes for the initial transaction of card on file flows.
    /// </summary>
    /// <value>The transaction ID received from schemes for the initial transaction of card on file flows.</value>
    [DataMember(Name="schemeTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schemeTransactionId")]
    public string SchemeTransactionId { get; set; }

    /// <summary>
    /// Gets or Sets Processor
    /// </summary>
    [DataMember(Name="processor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processor")]
    public ProcessorData Processor { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalDetails
    /// </summary>
    [DataMember(Name="additionalDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalDetails")]
    public AdditionalTransactionDetails AdditionalDetails { get; set; }

    /// <summary>
    /// Gets or Sets AccountUpdaterResponse
    /// </summary>
    [DataMember(Name="accountUpdaterResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountUpdaterResponse")]
    public AccountUpdaterResponse AccountUpdaterResponse { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionResponse {\n");
      sb.Append("  IpgTransactionId: ").Append(IpgTransactionId).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
      sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
      sb.Append("  TransactionOrigin: ").Append(TransactionOrigin).Append("\n");
      sb.Append("  PaymentMethodDetails: ").Append(PaymentMethodDetails).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
      sb.Append("  MerchantTransactionId: ").Append(MerchantTransactionId).Append("\n");
      sb.Append("  TransactionTime: ").Append(TransactionTime).Append("\n");
      sb.Append("  ApprovedAmount: ").Append(ApprovedAmount).Append("\n");
      sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
      sb.Append("  TransactionState: ").Append(TransactionState).Append("\n");
      sb.Append("  Secure3dResponse: ").Append(Secure3dResponse).Append("\n");
      sb.Append("  RedirectURL: ").Append(RedirectURL).Append("\n");
      sb.Append("  AuthenticationRedirect: ").Append(AuthenticationRedirect).Append("\n");
      sb.Append("  SchemeTransactionId: ").Append(SchemeTransactionId).Append("\n");
      sb.Append("  Processor: ").Append(Processor).Append("\n");
      sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
      sb.Append("  AccountUpdaterResponse: ").Append(AccountUpdaterResponse).Append("\n");
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
