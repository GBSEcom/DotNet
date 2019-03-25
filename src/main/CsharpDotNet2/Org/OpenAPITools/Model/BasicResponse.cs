using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Contains apiTraceId and clientRequestId shared in all response types.
  /// </summary>
  [DataContract]
  public class BasicResponse {
    /// <summary>
    /// Echoes back the value in the request header for tracking.
    /// </summary>
    /// <value>Echoes back the value in the request header for tracking.</value>
    [DataMember(Name="clientRequestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientRequestId")]
    public string ClientRequestId { get; set; }

    /// <summary>
    /// Request identifier in API, can be used to request logs from the support team.
    /// </summary>
    /// <value>Request identifier in API, can be used to request logs from the support team.</value>
    [DataMember(Name="apiTraceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiTraceId")]
    public string ApiTraceId { get; set; }

    /// <summary>
    /// Gets or Sets ResponseType
    /// </summary>
    [DataMember(Name="responseType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseType")]
    public ResponseType ResponseType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BasicResponse {\n");
      sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
      sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
      sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
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
