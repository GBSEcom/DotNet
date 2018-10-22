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
  public class TransactionResponseAuthenticationRedirectParams {
    /// <summary>
    /// Gets or Sets PaReq
    /// </summary>
    [DataMember(Name="PaReq", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaReq")]
    public string PaReq { get; set; }

    /// <summary>
    /// Gets or Sets TermUrl
    /// </summary>
    [DataMember(Name="TermUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TermUrl")]
    public string TermUrl { get; set; }

    /// <summary>
    /// Gets or Sets MD
    /// </summary>
    [DataMember(Name="MD", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MD")]
    public string MD { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionResponseAuthenticationRedirectParams {\n");
      sb.Append("  PaReq: ").Append(PaReq).Append("\n");
      sb.Append("  TermUrl: ").Append(TermUrl).Append("\n");
      sb.Append("  MD: ").Append(MD).Append("\n");
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
