using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Model for processor data
  /// </summary>
  [DataContract]
  public class ProcessorData {
    /// <summary>
    /// Gets or Sets ResponseCode
    /// </summary>
    [DataMember(Name="responseCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseCode")]
    public string ResponseCode { get; set; }

    /// <summary>
    /// Gets or Sets ResponseMessage
    /// </summary>
    [DataMember(Name="responseMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseMessage")]
    public string ResponseMessage { get; set; }

    /// <summary>
    /// Gets or Sets ApprovalCode
    /// </summary>
    [DataMember(Name="approvalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "approvalCode")]
    public string ApprovalCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProcessorData {\n");
      sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
      sb.Append("  ResponseMessage: ").Append(ResponseMessage).Append("\n");
      sb.Append("  ApprovalCode: ").Append(ApprovalCode).Append("\n");
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
