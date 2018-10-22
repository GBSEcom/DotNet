using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AuthenticationResponseVerification {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets MD
    /// </summary>
    [DataMember(Name="MD", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MD")]
    public string MD { get; set; }

    /// <summary>
    /// Gets or Sets PaRes
    /// </summary>
    [DataMember(Name="PaRes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaRes")]
    public string PaRes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationResponseVerification {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  MD: ").Append(MD).Append("\n");
      sb.Append("  PaRes: ").Append(PaRes).Append("\n");
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
