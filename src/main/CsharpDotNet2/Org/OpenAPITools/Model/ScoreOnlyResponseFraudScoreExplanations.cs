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
  public class ScoreOnlyResponseFraudScoreExplanations {
    /// <summary>
    /// Description of the fraud score explanation.
    /// </summary>
    /// <value>Description of the fraud score explanation.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// ID of the rule being triggered.
    /// </summary>
    /// <value>ID of the rule being triggered.</value>
    [DataMember(Name="rule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rule")]
    public string Rule { get; set; }

    /// <summary>
    /// Type of the explanation (model or rule).
    /// </summary>
    /// <value>Type of the explanation (model or rule).</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScoreOnlyResponseFraudScoreExplanations {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Rule: ").Append(Rule).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
