using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Additional paramters for authentication redirect.
  /// </summary>
  [DataContract]
  public class AuthenticationRedirectParams {
    /// <summary>
    /// Message sent from merchant server to authenticate the cardholder.
    /// </summary>
    /// <value>Message sent from merchant server to authenticate the cardholder.</value>
    [DataMember(Name="payerAuthenticationRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payerAuthenticationRequest")]
    public string PayerAuthenticationRequest { get; set; }

    /// <summary>
    /// Terminal URL for processing request.
    /// </summary>
    /// <value>Terminal URL for processing request.</value>
    [DataMember(Name="termUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termUrl")]
    public string TermUrl { get; set; }

    /// <summary>
    /// Merchant data.
    /// </summary>
    /// <value>Merchant data.</value>
    [DataMember(Name="merchantData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantData")]
    public string MerchantData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationRedirectParams {\n");
      sb.Append("  PayerAuthenticationRequest: ").Append(PayerAuthenticationRequest).Append("\n");
      sb.Append("  TermUrl: ").Append(TermUrl).Append("\n");
      sb.Append("  MerchantData: ").Append(MerchantData).Append("\n");
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
