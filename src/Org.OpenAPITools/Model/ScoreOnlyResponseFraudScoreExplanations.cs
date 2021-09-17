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
    /// ScoreOnlyResponseFraudScoreExplanations
    /// </summary>
    [DataContract(Name = "ScoreOnlyResponse_fraudScore_explanations")]
    public partial class ScoreOnlyResponseFraudScoreExplanations : IEquatable<ScoreOnlyResponseFraudScoreExplanations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreOnlyResponseFraudScoreExplanations" /> class.
        /// </summary>
        /// <param name="description">Description of the fraud score explanation..</param>
        /// <param name="rule">ID of the rule being triggered..</param>
        /// <param name="type">Type of the explanation (model or rule)..</param>
        public ScoreOnlyResponseFraudScoreExplanations(string description = default(string), string rule = default(string), string type = default(string))
        {
            this.Description = description;
            this.Rule = rule;
            this.Type = type;
        }

        /// <summary>
        /// Description of the fraud score explanation.
        /// </summary>
        /// <value>Description of the fraud score explanation.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// ID of the rule being triggered.
        /// </summary>
        /// <value>ID of the rule being triggered.</value>
        [DataMember(Name = "rule", EmitDefaultValue = false)]
        public string Rule { get; set; }

        /// <summary>
        /// Type of the explanation (model or rule).
        /// </summary>
        /// <value>Type of the explanation (model or rule).</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScoreOnlyResponseFraudScoreExplanations {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ScoreOnlyResponseFraudScoreExplanations);
        }

        /// <summary>
        /// Returns true if ScoreOnlyResponseFraudScoreExplanations instances are equal
        /// </summary>
        /// <param name="input">Instance of ScoreOnlyResponseFraudScoreExplanations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScoreOnlyResponseFraudScoreExplanations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Rule == input.Rule ||
                    (this.Rule != null &&
                    this.Rule.Equals(input.Rule))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Rule != null)
                    hashCode = hashCode * 59 + this.Rule.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
