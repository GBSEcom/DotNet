using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Model for processor data
  /// </summary>
  [DataContract]
  public class ProcessorData {
    /// <summary>
    /// Gets or Sets ReferenceNumber
    /// </summary>
    [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceNumber")]
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizationCode
    /// </summary>
    [DataMember(Name="authorizationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorizationCode")]
    public string AuthorizationCode { get; set; }

    /// <summary>
    /// Gets or Sets ResponseCode
    /// </summary>
    [DataMember(Name="responseCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseCode")]
    public string ResponseCode { get; set; }

    /// <summary>
    /// Gets or Sets AssociationResponseCode
    /// </summary>
    [DataMember(Name="associationResponseCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "associationResponseCode")]
    public string AssociationResponseCode { get; set; }

    /// <summary>
    /// Gets or Sets ResponseMessage
    /// </summary>
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
    /// Gets or Sets SecurityCodeResponse
    /// </summary>
    [DataMember(Name="securityCodeResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityCodeResponse")]
    public string SecurityCodeResponse { get; set; }


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
      sb.Append("  AssociationResponseCode: ").Append(AssociationResponseCode).Append("\n");
      sb.Append("  ResponseMessage: ").Append(ResponseMessage).Append("\n");
      sb.Append("  AvsResponse: ").Append(AvsResponse).Append("\n");
      sb.Append("  SecurityCodeResponse: ").Append(SecurityCodeResponse).Append("\n");
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
