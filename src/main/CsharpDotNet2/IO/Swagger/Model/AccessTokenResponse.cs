using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Access Token generation response
  /// </summary>
  [DataContract]
  public class AccessTokenResponse {
    /// <summary>
    /// Access Token for authentication
    /// </summary>
    /// <value>Access Token for authentication</value>
    [DataMember(Name="accessToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessToken")]
    public string AccessToken { get; set; }

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
    /// The result of the requested operation. If this is anything other than 'SUCCESS', please refer to the 400s HTTP error codes. See ErrorResponse object for details.
    /// </summary>
    /// <value>The result of the requested operation. If this is anything other than 'SUCCESS', please refer to the 400s HTTP error codes. See ErrorResponse object for details.</value>
    [DataMember(Name="requestStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestStatus")]
    public string RequestStatus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessTokenResponse {\n");
      sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
      sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
      sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
      sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
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
