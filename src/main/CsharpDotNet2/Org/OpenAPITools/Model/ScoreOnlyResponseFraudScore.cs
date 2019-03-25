using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ScoreOnlyResponseFraudScore {
    /// <summary>
    /// The score attributed to this request by our machine learning system, ranging from 0 (less likely to be fraud) to 1000 (more likely to be fraud).
    /// </summary>
    /// <value>The score attributed to this request by our machine learning system, ranging from 0 (less likely to be fraud) to 1000 (more likely to be fraud).</value>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public string Score { get; set; }

    /// <summary>
    /// A list of non-critical warnings raised while processing the request. Warnings included in this list will have integration and data-quality related messages.
    /// </summary>
    /// <value>A list of non-critical warnings raised while processing the request. Warnings included in this list will have integration and data-quality related messages.</value>
    [DataMember(Name="warnings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warnings")]
    public List<string> Warnings { get; set; }

    /// <summary>
    /// Type of the explanation to the warning raised
    /// </summary>
    /// <value>Type of the explanation to the warning raised</value>
    [DataMember(Name="explanations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "explanations")]
    public List<ScoreOnlyResponseFraudScoreExplanations> Explanations { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScoreOnlyResponseFraudScore {\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  Warnings: ").Append(Warnings).Append("\n");
      sb.Append("  Explanations: ").Append(Explanations).Append("\n");
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
