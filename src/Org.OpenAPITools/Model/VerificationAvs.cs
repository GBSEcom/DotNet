/*
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.5.0.20211029.001
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
    /// The result of the AVS (Address Verification System) check.
    /// </summary>
    [DataContract(Name = "VerificationAvs")]
    public partial class VerificationAvs : IEquatable<VerificationAvs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationAvs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerificationAvs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationAvs" /> class.
        /// </summary>
        /// <param name="code">AVS response code. (required).</param>
        /// <param name="status">Interpretation of the response code..</param>
        /// <param name="scheme">Identifier of the scheme. (required).</param>
        public VerificationAvs(string code = default(string), string status = default(string), string scheme = default(string))
        {
            // to ensure "code" is required (not null)
            this.Code = code ?? throw new ArgumentNullException("code is a required property for VerificationAvs and cannot be null");
            // to ensure "scheme" is required (not null)
            this.Scheme = scheme ?? throw new ArgumentNullException("scheme is a required property for VerificationAvs and cannot be null");
            this.Status = status;
        }

        /// <summary>
        /// AVS response code.
        /// </summary>
        /// <value>AVS response code.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Interpretation of the response code.
        /// </summary>
        /// <value>Interpretation of the response code.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Identifier of the scheme.
        /// </summary>
        /// <value>Identifier of the scheme.</value>
        [DataMember(Name = "scheme", IsRequired = true, EmitDefaultValue = false)]
        public string Scheme { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerificationAvs {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
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
            return this.Equals(input as VerificationAvs);
        }

        /// <summary>
        /// Returns true if VerificationAvs instances are equal
        /// </summary>
        /// <param name="input">Instance of VerificationAvs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerificationAvs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Scheme == input.Scheme ||
                    (this.Scheme != null &&
                    this.Scheme.Equals(input.Scheme))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Scheme != null)
                    hashCode = hashCode * 59 + this.Scheme.GetHashCode();
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
            // Code (string) pattern
            Regex regexCode = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexCode.Match(this.Code).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, must match a pattern of " + regexCode, new [] { "Code" });
            }

            // Scheme (string) pattern
            Regex regexScheme = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexScheme.Match(this.Scheme).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scheme, must match a pattern of " + regexScheme, new [] { "Scheme" });
            }

            yield break;
        }
    }
}
