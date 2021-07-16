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
    /// The processor address validation response for compliance.
    /// </summary>
    [DataContract]
    public partial class AVSResponse : IEquatable<AVSResponse>, IValidatableObject
    {
        /// <summary>
        /// Response if street matches that on file.
        /// </summary>
        /// <value>Response if street matches that on file.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StreetMatchEnum
        {
            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 1,

            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 2,

            /// <summary>
            /// Enum NOINPUTDATA for value: NO_INPUT_DATA
            /// </summary>
            [EnumMember(Value = "NO_INPUT_DATA")]
            NOINPUTDATA = 3,

            /// <summary>
            /// Enum NOTCHECKED for value: NOT_CHECKED
            /// </summary>
            [EnumMember(Value = "NOT_CHECKED")]
            NOTCHECKED = 4

        }

        /// <summary>
        /// Response if street matches that on file.
        /// </summary>
        /// <value>Response if street matches that on file.</value>
        [DataMember(Name = "streetMatch", EmitDefaultValue = false)]
        public StreetMatchEnum? StreetMatch { get; set; }
        /// <summary>
        /// Response if postal code matches that on file.
        /// </summary>
        /// <value>Response if postal code matches that on file.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PostalCodeMatchEnum
        {
            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 1,

            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 2,

            /// <summary>
            /// Enum NOINPUTDATA for value: NO_INPUT_DATA
            /// </summary>
            [EnumMember(Value = "NO_INPUT_DATA")]
            NOINPUTDATA = 3,

            /// <summary>
            /// Enum NOTCHECKED for value: NOT_CHECKED
            /// </summary>
            [EnumMember(Value = "NOT_CHECKED")]
            NOTCHECKED = 4

        }

        /// <summary>
        /// Response if postal code matches that on file.
        /// </summary>
        /// <value>Response if postal code matches that on file.</value>
        [DataMember(Name = "postalCodeMatch", EmitDefaultValue = false)]
        public PostalCodeMatchEnum? PostalCodeMatch { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AVSResponse" /> class.
        /// </summary>
        /// <param name="streetMatch">Response if street matches that on file..</param>
        /// <param name="postalCodeMatch">Response if postal code matches that on file..</param>
        /// <param name="associationAvsResponse">The raw address verification response code returned by issuer. Please refer to response codes section in developer portal for more info..</param>
        public AVSResponse(StreetMatchEnum? streetMatch = null, PostalCodeMatchEnum? postalCodeMatch = null, string associationAvsResponse = default(string))
        {
            this.StreetMatch = streetMatch;
            this.PostalCodeMatch = postalCodeMatch;
            this.AssociationAvsResponse = associationAvsResponse;
        }

        /// <summary>
        /// The raw address verification response code returned by issuer. Please refer to response codes section in developer portal for more info.
        /// </summary>
        /// <value>The raw address verification response code returned by issuer. Please refer to response codes section in developer portal for more info.</value>
        [DataMember(Name = "associationAvsResponse", EmitDefaultValue = false)]
        public string AssociationAvsResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AVSResponse {\n");
            sb.Append("  StreetMatch: ").Append(StreetMatch).Append("\n");
            sb.Append("  PostalCodeMatch: ").Append(PostalCodeMatch).Append("\n");
            sb.Append("  AssociationAvsResponse: ").Append(AssociationAvsResponse).Append("\n");
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
            return this.Equals(input as AVSResponse);
        }

        /// <summary>
        /// Returns true if AVSResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AVSResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AVSResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StreetMatch == input.StreetMatch ||
                    (this.StreetMatch != null &&
                    this.StreetMatch.Equals(input.StreetMatch))
                ) && 
                (
                    this.PostalCodeMatch == input.PostalCodeMatch ||
                    (this.PostalCodeMatch != null &&
                    this.PostalCodeMatch.Equals(input.PostalCodeMatch))
                ) && 
                (
                    this.AssociationAvsResponse == input.AssociationAvsResponse ||
                    (this.AssociationAvsResponse != null &&
                    this.AssociationAvsResponse.Equals(input.AssociationAvsResponse))
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
                if (this.StreetMatch != null)
                    hashCode = hashCode * 59 + this.StreetMatch.GetHashCode();
                if (this.PostalCodeMatch != null)
                    hashCode = hashCode * 59 + this.PostalCodeMatch.GetHashCode();
                if (this.AssociationAvsResponse != null)
                    hashCode = hashCode * 59 + this.AssociationAvsResponse.GetHashCode();
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
