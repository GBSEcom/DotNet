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
    /// Document information.
    /// </summary>
    [DataContract]
    public partial class Document : IEquatable<Document>, IValidatableObject
    {
        /// <summary>
        /// Document type.
        /// </summary>
        /// <value>Document type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum NATIONALIDENTITY for value: NATIONAL_IDENTITY
            /// </summary>
            [EnumMember(Value = "NATIONAL_IDENTITY")]
            NATIONALIDENTITY = 1,

            /// <summary>
            /// Enum SINGLETAXIDENTIFICATION for value: SINGLE_TAX_IDENTIFICATION
            /// </summary>
            [EnumMember(Value = "SINGLE_TAX_IDENTIFICATION")]
            SINGLETAXIDENTIFICATION = 2,

            /// <summary>
            /// Enum SINGLECODEOFLABORIDENTIFICATION for value: SINGLE_CODE_OF_LABOR_IDENTIFICATION
            /// </summary>
            [EnumMember(Value = "SINGLE_CODE_OF_LABOR_IDENTIFICATION")]
            SINGLECODEOFLABORIDENTIFICATION = 3,

            /// <summary>
            /// Enum BOOKENLISTMENT for value: BOOK_ENLISTMENT
            /// </summary>
            [EnumMember(Value = "BOOK_ENLISTMENT")]
            BOOKENLISTMENT = 4,

            /// <summary>
            /// Enum CIVICNOTEBOOK for value: CIVIC_NOTEBOOK
            /// </summary>
            [EnumMember(Value = "CIVIC_NOTEBOOK")]
            CIVICNOTEBOOK = 5,

            /// <summary>
            /// Enum PASSPORT for value: PASSPORT
            /// </summary>
            [EnumMember(Value = "PASSPORT")]
            PASSPORT = 6

        }

        /// <summary>
        /// Document type.
        /// </summary>
        /// <value>Document type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Document() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="type">Document type. (required).</param>
        /// <param name="number">Document number. (required).</param>
        public Document(TypeEnum type = default(TypeEnum), string number = default(string))
        {
            // to ensure "type" is required (not null)
            this.Type = type;
            // to ensure "number" is required (not null)
            this.Number = number ?? throw new ArgumentNullException("number is a required property for Document and cannot be null");
        }

        /// <summary>
        /// Document number.
        /// </summary>
        /// <value>Document number.</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(input as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="input">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document input)
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
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
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
            // Number (string) maxLength
            if(this.Number != null && this.Number.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, length must be less than 30.", new [] { "Number" });
            }

            // Number (string) pattern
            Regex regexNumber = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexNumber.Match(this.Number).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must match a pattern of " + regexNumber, new [] { "Number" });
            }

            yield break;
        }
    }
}
