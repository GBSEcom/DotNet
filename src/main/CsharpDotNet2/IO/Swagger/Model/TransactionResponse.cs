using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// This is the common object for primary and secondary payment request responses
  /// </summary>
  [DataContract]
  public class TransactionResponse {
    /// <summary>
    /// The schema type returned in the response.
    /// </summary>
    /// <value>The schema type returned in the response.</value>
    [DataMember(Name="responseType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseType")]
    public ResponseType ResponseType { get; set; }

    /// <summary>
    /// Echoes back the value in the Request header
    /// </summary>
    /// <value>Echoes back the value in the Request header</value>
    [DataMember(Name="clientRequestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientRequestId")]
    public string ClientRequestId { get; set; }

    /// <summary>
    /// Echoes back the value in the Request header
    /// </summary>
    /// <value>Echoes back the value in the Request header</value>
    [DataMember(Name="apiTraceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiTraceId")]
    public string ApiTraceId { get; set; }

    /// <summary>
    /// The Response Transaction ID
    /// </summary>
    /// <value>The Response Transaction ID</value>
    [DataMember(Name="ipgTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipgTransactionId")]
    public string IpgTransactionId { get; set; }

    /// <summary>
    /// Client Order ID if supplied by client, otherwise the Order ID
    /// </summary>
    /// <value>Client Order ID if supplied by client, otherwise the Order ID</value>
    [DataMember(Name="orderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderId")]
    public string OrderId { get; set; }

    /// <summary>
    /// Gets or Sets TransactionType
    /// </summary>
    [DataMember(Name="transactionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionType")]
    public string TransactionType { get; set; }

    /// <summary>
    /// The processor approval code for compliance.
    /// </summary>
    /// <value>The processor approval code for compliance.</value>
    [DataMember(Name="authorizationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorizationCode")]
    public string AuthorizationCode { get; set; }

    /// <summary>
    /// The processor address validation response for compliance.
    /// </summary>
    /// <value>The processor address validation response for compliance.</value>
    [DataMember(Name="avsResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avsResponse")]
    public string AvsResponse { get; set; }

    /// <summary>
    /// The processor card verification validation response for compliance.
    /// </summary>
    /// <value>The processor card verification validation response for compliance.</value>
    [DataMember(Name="securityCodeResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityCodeResponse")]
    public string SecurityCodeResponse { get; set; }

    /// <summary>
    /// Card brand of the payment instrument
    /// </summary>
    /// <value>Card brand of the payment instrument</value>
    [DataMember(Name="brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    /// <summary>
    /// Country of the card issuer
    /// </summary>
    /// <value>Country of the card issuer</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// The terminal that is processing the transaction
    /// </summary>
    /// <value>The terminal that is processing the transaction</value>
    [DataMember(Name="terminalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terminalId")]
    public string TerminalId { get; set; }

    /// <summary>
    /// The unique client Transaction ID from the Request header, if supplied
    /// </summary>
    /// <value>The unique client Transaction ID from the Request header, if supplied</value>
    [DataMember(Name="clientTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientTransactionId")]
    public string ClientTransactionId { get; set; }

    /// <summary>
    /// The transaction time in seconds since Epoch
    /// </summary>
    /// <value>The transaction time in seconds since Epoch</value>
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
    /// Gets or Sets AuthenticationRedirect
    /// </summary>
    [DataMember(Name="authenticationRedirect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationRedirect")]
    public TransactionResponseAuthenticationRedirect AuthenticationRedirect { get; set; }

    /// <summary>
    /// The transaction id received from schemes for the initial transaction, returned for the transactions marked as \"FIRST\"
    /// </summary>
    /// <value>The transaction id received from schemes for the initial transaction, returned for the transactions marked as \"FIRST\"</value>
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionResponse {\n");
      sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
      sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
      sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
      sb.Append("  IpgTransactionId: ").Append(IpgTransactionId).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
      sb.Append("  AuthorizationCode: ").Append(AuthorizationCode).Append("\n");
      sb.Append("  AvsResponse: ").Append(AvsResponse).Append("\n");
      sb.Append("  SecurityCodeResponse: ").Append(SecurityCodeResponse).Append("\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
      sb.Append("  ClientTransactionId: ").Append(ClientTransactionId).Append("\n");
      sb.Append("  TransactionTime: ").Append(TransactionTime).Append("\n");
      sb.Append("  ApprovedAmount: ").Append(ApprovedAmount).Append("\n");
      sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
      sb.Append("  TransactionState: ").Append(TransactionState).Append("\n");
      sb.Append("  AuthenticationRedirect: ").Append(AuthenticationRedirect).Append("\n");
      sb.Append("  SchemeTransactionId: ").Append(SchemeTransactionId).Append("\n");
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
