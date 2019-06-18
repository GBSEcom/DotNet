using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Model for processor data.
  /// </summary>
  [DataContract]
  public class ProcessorData {
    /// <summary>
    /// Reference transaction ID.
    /// </summary>
    /// <value>Reference transaction ID.</value>
    [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceNumber")]
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// Code returned to confirm transaction.
    /// </summary>
    /// <value>Code returned to confirm transaction.</value>
    [DataMember(Name="authorizationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorizationCode")]
    public string AuthorizationCode { get; set; }

    /// <summary>
    /// Response code from endpoints.
    /// </summary>
    /// <value>Response code from endpoints.</value>
    [DataMember(Name="responseCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseCode")]
    public string ResponseCode { get; set; }

    /// <summary>
    /// Network used for transaction.
    /// </summary>
    /// <value>Network used for transaction.</value>
    [DataMember(Name="network", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "network")]
    public string Network { get; set; }

    /// <summary>
    /// Raw response code from issuer.
    /// </summary>
    /// <value>Raw response code from issuer.</value>
    [DataMember(Name="associationResponseCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "associationResponseCode")]
    public string AssociationResponseCode { get; set; }

    /// <summary>
    /// Message returned from endpoints.
    /// </summary>
    /// <value>Message returned from endpoints.</value>
    [DataMember(Name="responseMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseMessage")]
    public string ResponseMessage { get; set; }

    /// <summary>
    /// Gets or Sets AvsResponse
    /// </summary>
    [DataMember(Name="avsResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avsResponse")]
    public AVSResponse AvsResponse { get; set; }

    /// <summary>
    /// Code returned for CVV.
    /// </summary>
    /// <value>Code returned for CVV.</value>
    [DataMember(Name="securityCodeResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityCodeResponse")]
    public string SecurityCodeResponse { get; set; }

    /// <summary>
    /// Code to map merchant advice code to ISO specification.
    /// </summary>
    /// <value>Code to map merchant advice code to ISO specification.</value>
    [DataMember(Name="merchantAdviceCodeIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantAdviceCodeIndicator")]
    public string MerchantAdviceCodeIndicator { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProcessorData {\n");
      sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
      sb.Append("  AuthorizationCode: ").Append(AuthorizationCode).Append("\n");
      sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
      sb.Append("  Network: ").Append(Network).Append("\n");
      sb.Append("  AssociationResponseCode: ").Append(AssociationResponseCode).Append("\n");
      sb.Append("  ResponseMessage: ").Append(ResponseMessage).Append("\n");
      sb.Append("  AvsResponse: ").Append(AvsResponse).Append("\n");
      sb.Append("  SecurityCodeResponse: ").Append(SecurityCodeResponse).Append("\n");
      sb.Append("  MerchantAdviceCodeIndicator: ").Append(MerchantAdviceCodeIndicator).Append("\n");
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
