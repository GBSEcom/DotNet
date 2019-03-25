using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The result of the 3DS (3D Secure) check.
  /// </summary>
  [DataContract]
  public class PaymentVerification3ds {
    /// <summary>
    /// 3DS Response Code. This field is required if the parent object is present.
    /// </summary>
    /// <value>3DS Response Code. This field is required if the parent object is present.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// Interpretation of the Response Code.
    /// </summary>
    /// <value>Interpretation of the Response Code.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Identifier of the Scheme. This field is required if the parent object is present.
    /// </summary>
    /// <value>Identifier of the Scheme. This field is required if the parent object is present.</value>
    [DataMember(Name="scheme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheme")]
    public string Scheme { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentVerification3ds {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Scheme: ").Append(Scheme).Append("\n");
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
