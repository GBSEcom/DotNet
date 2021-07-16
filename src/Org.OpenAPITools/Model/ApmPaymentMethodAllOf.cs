/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.3.0.20210608.001
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ApmPaymentMethodAllOf
    /// </summary>
    [DataContract]
    public partial class ApmPaymentMethodAllOf : IEquatable<ApmPaymentMethodAllOf>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public PaymentMethodType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApmPaymentMethodAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApmPaymentMethodAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApmPaymentMethodAllOf" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="steps">All steps (already) performed on the payment.</param>
        public ApmPaymentMethodAllOf(PaymentMethodType type = default(PaymentMethodType), List<PaymentStepResponse> steps = default(List<PaymentStepResponse>))
        {
            // to ensure "type" is required (not null)
            this.Type = type;
            this.Steps = steps;
        }

        /// <summary>
        /// All steps (already) performed on the payment
        /// </summary>
        /// <value>All steps (already) performed on the payment</value>
        [DataMember(Name = "steps", EmitDefaultValue = false)]
        public List<PaymentStepResponse> Steps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApmPaymentMethodAllOf {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApmPaymentMethodAllOf);
        }

        /// <summary>
        /// Returns true if ApmPaymentMethodAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ApmPaymentMethodAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApmPaymentMethodAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
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
