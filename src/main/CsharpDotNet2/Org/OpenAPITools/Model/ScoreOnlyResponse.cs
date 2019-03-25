using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Fraud Detect response
  /// </summary>
  [DataContract]
  public class ScoreOnlyResponse {
    /// <summary>
    /// Unique trace ID for issue triage
    /// </summary>
    /// <value>Unique trace ID for issue triage</value>
    [DataMember(Name="apiTraceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiTraceId")]
    public string ApiTraceId { get; set; }

    /// <summary>
    /// Please refer to \"Errors Section\" for more info.
    /// </summary>
    /// <value>Please refer to \"Errors Section\" for more info.</value>
    [DataMember(Name="transactionStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionStatus")]
    public string TransactionStatus { get; set; }

    /// <summary>
    /// If status returned is \"failure\", input validation errors occurred. Please refer to the \"Errors Section\" for more info.
    /// </summary>
    /// <value>If status returned is \"failure\", input validation errors occurred. Please refer to the \"Errors Section\" for more info.</value>
    [DataMember(Name="validationStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validationStatus")]
    public string ValidationStatus { get; set; }

    /// <summary>
    /// The transactionType provided in request.
    /// </summary>
    /// <value>The transactionType provided in request.</value>
    [DataMember(Name="transactionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionType")]
    public string TransactionType { get; set; }

    /// <summary>
    /// Gets or Sets FraudScore
    /// </summary>
    [DataMember(Name="fraudScore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fraudScore")]
    public ScoreOnlyResponseFraudScore FraudScore { get; set; }

    /// <summary>
    /// Gets or Sets RecommendedDecision
    /// </summary>
    [DataMember(Name="recommendedDecision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recommendedDecision")]
    public string RecommendedDecision { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScoreOnlyResponse {\n");
      sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
      sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
      sb.Append("  ValidationStatus: ").Append(ValidationStatus).Append("\n");
      sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
      sb.Append("  FraudScore: ").Append(FraudScore).Append("\n");
      sb.Append("  RecommendedDecision: ").Append(RecommendedDecision).Append("\n");
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
