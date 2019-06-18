using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Contains 3DSecure response code.
  /// </summary>
  [DataContract]
  public class Secure3dResponse {
    /// <summary>
    /// Code received after successful payer-auth verification.
    /// </summary>
    /// <value>Code received after successful payer-auth verification.</value>
    [DataMember(Name="responseCode3dSecure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseCode3dSecure")]
    public string ResponseCode3dSecure { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Secure3dResponse {\n");
      sb.Append("  ResponseCode3dSecure: ").Append(ResponseCode3dSecure).Append("\n");
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
