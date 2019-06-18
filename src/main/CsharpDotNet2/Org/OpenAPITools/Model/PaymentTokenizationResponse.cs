using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PaymentTokenizationResponse : BasicResponse {
    /// <summary>
    /// The status of the request.
    /// </summary>
    /// <value>The status of the request.</value>
    [DataMember(Name="requestStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestStatus")]
    public string RequestStatus { get; set; }

    /// <summary>
    /// Time of the request.
    /// </summary>
    /// <value>Time of the request.</value>
    [DataMember(Name="requestTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestTime")]
    public long? RequestTime { get; set; }

    /// <summary>
    /// Gets or Sets AvsResponse
    /// </summary>
    [DataMember(Name="avsResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avsResponse")]
    public AVSResponse AvsResponse { get; set; }

    /// <summary>
    /// Security code check response.
    /// </summary>
    /// <value>Security code check response.</value>
    [DataMember(Name="securityCodeResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityCodeResponse")]
    public string SecurityCodeResponse { get; set; }

    /// <summary>
    /// Card brand.
    /// </summary>
    /// <value>Card brand.</value>
    [DataMember(Name="brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    /// <summary>
    /// Country of the card issued.
    /// </summary>
    /// <value>Country of the card issued.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets PaymentToken
    /// </summary>
    [DataMember(Name="paymentToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentToken")]
    public PaymentTokenDetails PaymentToken { get; set; }

    /// <summary>
    /// Gets or Sets PaymentCard
    /// </summary>
    [DataMember(Name="paymentCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentCard")]
    public PaymentCard PaymentCard { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentTokenizationResponse {\n");
      sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
      sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
      sb.Append("  AvsResponse: ").Append(AvsResponse).Append("\n");
      sb.Append("  SecurityCodeResponse: ").Append(SecurityCodeResponse).Append("\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
      sb.Append("  PaymentCard: ").Append(PaymentCard).Append("\n");
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
