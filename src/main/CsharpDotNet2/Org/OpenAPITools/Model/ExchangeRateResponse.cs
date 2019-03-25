using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Exchange rate response
  /// </summary>
  [DataContract]
  public class ExchangeRateResponse : BasicResponse {
    /// <summary>
    /// Echoes back the value in the request header
    /// </summary>
    /// <value>Echoes back the value in the request header</value>
    [DataMember(Name="clientRequestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientRequestId")]
    public string ClientRequestId { get; set; }

    /// <summary>
    /// Echoes back the value in the request header
    /// </summary>
    /// <value>Echoes back the value in the request header</value>
    [DataMember(Name="apiTraceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiTraceId")]
    public string ApiTraceId { get; set; }

    /// <summary>
    /// The response transaction ID
    /// </summary>
    /// <value>The response transaction ID</value>
    [DataMember(Name="ipgTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipgTransactionId")]
    public string IpgTransactionId { get; set; }

    /// <summary>
    /// Time of the request
    /// </summary>
    /// <value>Time of the request</value>
    [DataMember(Name="requestTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestTime")]
    public string RequestTime { get; set; }

    /// <summary>
    /// Inquiry rate ID.
    /// </summary>
    /// <value>Inquiry rate ID.</value>
    [DataMember(Name="inquiryRateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inquiryRateId")]
    public string InquiryRateId { get; set; }

    /// <summary>
    /// Foreign currency code
    /// </summary>
    /// <value>Foreign currency code</value>
    [DataMember(Name="foreignCurrencyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "foreignCurrencyCode")]
    public string ForeignCurrencyCode { get; set; }

    /// <summary>
    /// Foreign amount
    /// </summary>
    /// <value>Foreign amount</value>
    [DataMember(Name="foreignAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "foreignAmount")]
    public string ForeignAmount { get; set; }

    /// <summary>
    /// Exchange rate
    /// </summary>
    /// <value>Exchange rate</value>
    [DataMember(Name="exchangeRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exchangeRate")]
    public string ExchangeRate { get; set; }

    /// <summary>
    /// Dcc offered.
    /// </summary>
    /// <value>Dcc offered.</value>
    [DataMember(Name="dccOffered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dccOffered")]
    public string DccOffered { get; set; }

    /// <summary>
    /// Exchange rate source timestamp
    /// </summary>
    /// <value>Exchange rate source timestamp</value>
    [DataMember(Name="exchangeRateSourceTimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exchangeRateSourceTimestamp")]
    public string ExchangeRateSourceTimestamp { get; set; }

    /// <summary>
    /// Expiration timestamp
    /// </summary>
    /// <value>Expiration timestamp</value>
    [DataMember(Name="expirationTimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationTimestamp")]
    public string ExpirationTimestamp { get; set; }

    /// <summary>
    /// Margin rate percentage.
    /// </summary>
    /// <value>Margin rate percentage.</value>
    [DataMember(Name="marginRatePercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginRatePercentage")]
    public string MarginRatePercentage { get; set; }

    /// <summary>
    /// Exchange rate source name
    /// </summary>
    /// <value>Exchange rate source name</value>
    [DataMember(Name="exchangeRateSourceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exchangeRateSourceName")]
    public string ExchangeRateSourceName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExchangeRateResponse {\n");
      sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
      sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
      sb.Append("  IpgTransactionId: ").Append(IpgTransactionId).Append("\n");
      sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
      sb.Append("  InquiryRateId: ").Append(InquiryRateId).Append("\n");
      sb.Append("  ForeignCurrencyCode: ").Append(ForeignCurrencyCode).Append("\n");
      sb.Append("  ForeignAmount: ").Append(ForeignAmount).Append("\n");
      sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
      sb.Append("  DccOffered: ").Append(DccOffered).Append("\n");
      sb.Append("  ExchangeRateSourceTimestamp: ").Append(ExchangeRateSourceTimestamp).Append("\n");
      sb.Append("  ExpirationTimestamp: ").Append(ExpirationTimestamp).Append("\n");
      sb.Append("  MarginRatePercentage: ").Append(MarginRatePercentage).Append("\n");
      sb.Append("  ExchangeRateSourceName: ").Append(ExchangeRateSourceName).Append("\n");
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
