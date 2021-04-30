/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.2.0.20210406.001
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
    /// Request to inquire information from the payer or merchant.
    /// </summary>
    [DataContract]
    public partial class ProvideDetailPaymentStepRequest : IEquatable<ProvideDetailPaymentStepRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvideDetailPaymentStepRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProvideDetailPaymentStepRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvideDetailPaymentStepRequest" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="hint">hint.</param>
        /// <param name="javaScriptValidationExpression">javaScriptValidationExpression.</param>
        /// <param name="key">key.</param>
        /// <param name="label">label.</param>
        public ProvideDetailPaymentStepRequest(string type = default(string), string hint = default(string), string javaScriptValidationExpression = default(string), string key = default(string), string label = default(string))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ProvideDetailPaymentStepRequest and cannot be null");
            this.Hint = hint;
            this.JavaScriptValidationExpression = javaScriptValidationExpression;
            this.Key = key;
            this.Label = label;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Hint
        /// </summary>
        [DataMember(Name = "hint", EmitDefaultValue = false)]
        public string Hint { get; set; }

        /// <summary>
        /// Gets or Sets JavaScriptValidationExpression
        /// </summary>
        [DataMember(Name = "javaScriptValidationExpression", EmitDefaultValue = false)]
        public string JavaScriptValidationExpression { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProvideDetailPaymentStepRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Hint: ").Append(Hint).Append("\n");
            sb.Append("  JavaScriptValidationExpression: ").Append(JavaScriptValidationExpression).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(input as ProvideDetailPaymentStepRequest);
        }

        /// <summary>
        /// Returns true if ProvideDetailPaymentStepRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProvideDetailPaymentStepRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProvideDetailPaymentStepRequest input)
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
                    this.Hint == input.Hint ||
                    (this.Hint != null &&
                    this.Hint.Equals(input.Hint))
                ) && 
                (
                    this.JavaScriptValidationExpression == input.JavaScriptValidationExpression ||
                    (this.JavaScriptValidationExpression != null &&
                    this.JavaScriptValidationExpression.Equals(input.JavaScriptValidationExpression))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                if (this.Hint != null)
                    hashCode = hashCode * 59 + this.Hint.GetHashCode();
                if (this.JavaScriptValidationExpression != null)
                    hashCode = hashCode * 59 + this.JavaScriptValidationExpression.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
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