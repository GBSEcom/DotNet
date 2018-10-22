using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Response containing error information.
  /// </summary>
  [DataContract]
  public class ErrorResponse {
    /// <summary>
    /// Echoes back the value from the request header for tracking
    /// </summary>
    /// <value>Echoes back the value from the request header for tracking</value>
    [DataMember(Name="clientRequestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientRequestId")]
    public string ClientRequestId { get; set; }

    /// <summary>
    /// Request identifier in API. Use this to request logs from support.
    /// </summary>
    /// <value>Request identifier in API. Use this to request logs from support.</value>
    [DataMember(Name="apiTraceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiTraceId")]
    public string ApiTraceId { get; set; }

    /// <summary>
    /// The schema type returned in the response.
    /// </summary>
    /// <value>The schema type returned in the response.</value>
    [DataMember(Name="responseType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseType")]
    public ResponseType ResponseType { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public Error Error { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ErrorResponse {\n");
      sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
      sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
      sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
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
