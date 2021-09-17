/*
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.4.0.20210824.002
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Fraud likelihood assessment consisting of a score, associated warning(s), and explanation(s) of score received.
    /// </summary>
    [DataContract(Name = "ScoreOnlyResponse_fraudScore")]
    public partial class ScoreOnlyResponseFraudScore : IEquatable<ScoreOnlyResponseFraudScore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreOnlyResponseFraudScore" /> class.
        /// </summary>
        /// <param name="score">The score attributed to this request by our machine learning system, ranging from 0 (less likely to be fraud) to 1000 (more likely to be fraud)..</param>
        /// <param name="warnings">A list of non-critical warnings raised while processing the request. Warnings included in this list will have integration and data-quality related messages..</param>
        /// <param name="explanations">Explanation of the fraud score applied consisting of a description, type of the explanation, and rule (if applicable)..</param>
        /// <param name="recommendedDecision">The action that should be taken for the request that was sent..</param>
        public ScoreOnlyResponseFraudScore(string score = default(string), List<string> warnings = default(List<string>), List<ScoreOnlyResponseFraudScoreExplanations> explanations = default(List<ScoreOnlyResponseFraudScoreExplanations>), string recommendedDecision = default(string))
        {
            this.Score = score;
            this.Warnings = warnings;
            this.Explanations = explanations;
            this.RecommendedDecision = recommendedDecision;
        }

        /// <summary>
        /// The score attributed to this request by our machine learning system, ranging from 0 (less likely to be fraud) to 1000 (more likely to be fraud).
        /// </summary>
        /// <value>The score attributed to this request by our machine learning system, ranging from 0 (less likely to be fraud) to 1000 (more likely to be fraud).</value>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public string Score { get; set; }

        /// <summary>
        /// A list of non-critical warnings raised while processing the request. Warnings included in this list will have integration and data-quality related messages.
        /// </summary>
        /// <value>A list of non-critical warnings raised while processing the request. Warnings included in this list will have integration and data-quality related messages.</value>
        [DataMember(Name = "warnings", EmitDefaultValue = false)]
        public List<string> Warnings { get; set; }

        /// <summary>
        /// Explanation of the fraud score applied consisting of a description, type of the explanation, and rule (if applicable).
        /// </summary>
        /// <value>Explanation of the fraud score applied consisting of a description, type of the explanation, and rule (if applicable).</value>
        [DataMember(Name = "explanations", EmitDefaultValue = false)]
        public List<ScoreOnlyResponseFraudScoreExplanations> Explanations { get; set; }

        /// <summary>
        /// The action that should be taken for the request that was sent.
        /// </summary>
        /// <value>The action that should be taken for the request that was sent.</value>
        [DataMember(Name = "recommendedDecision", EmitDefaultValue = false)]
        public string RecommendedDecision { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScoreOnlyResponseFraudScore {\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  Explanations: ").Append(Explanations).Append("\n");
            sb.Append("  RecommendedDecision: ").Append(RecommendedDecision).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScoreOnlyResponseFraudScore);
        }

        /// <summary>
        /// Returns true if ScoreOnlyResponseFraudScore instances are equal
        /// </summary>
        /// <param name="input">Instance of ScoreOnlyResponseFraudScore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScoreOnlyResponseFraudScore input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
                ) && 
                (
                    this.Explanations == input.Explanations ||
                    this.Explanations != null &&
                    input.Explanations != null &&
                    this.Explanations.SequenceEqual(input.Explanations)
                ) && 
                (
                    this.RecommendedDecision == input.RecommendedDecision ||
                    (this.RecommendedDecision != null &&
                    this.RecommendedDecision.Equals(input.RecommendedDecision))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                if (this.Explanations != null)
                    hashCode = hashCode * 59 + this.Explanations.GetHashCode();
                if (this.RecommendedDecision != null)
                    hashCode = hashCode * 59 + this.RecommendedDecision.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
