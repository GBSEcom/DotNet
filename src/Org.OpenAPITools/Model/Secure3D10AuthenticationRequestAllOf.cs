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
    /// Secure3D10AuthenticationRequestAllOf
    /// </summary>
    [DataContract]
    public partial class Secure3D10AuthenticationRequestAllOf : IEquatable<Secure3D10AuthenticationRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D10AuthenticationRequestAllOf" /> class.
        /// </summary>
        /// <param name="termURL">The result of the authentication will be sent to this URL. If not provided, a term URL will be dynamically generated. Note this must be a valid URL (special characters should be URL-encoded)..</param>
        public Secure3D10AuthenticationRequestAllOf(string termURL = default(string))
        {
            this.TermURL = termURL;
        }

        /// <summary>
        /// The result of the authentication will be sent to this URL. If not provided, a term URL will be dynamically generated. Note this must be a valid URL (special characters should be URL-encoded).
        /// </summary>
        /// <value>The result of the authentication will be sent to this URL. If not provided, a term URL will be dynamically generated. Note this must be a valid URL (special characters should be URL-encoded).</value>
        [DataMember(Name = "termURL", EmitDefaultValue = false)]
        public string TermURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Secure3D10AuthenticationRequestAllOf {\n");
            sb.Append("  TermURL: ").Append(TermURL).Append("\n");
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
            return this.Equals(input as Secure3D10AuthenticationRequestAllOf);
        }

        /// <summary>
        /// Returns true if Secure3D10AuthenticationRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of Secure3D10AuthenticationRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Secure3D10AuthenticationRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TermURL == input.TermURL ||
                    (this.TermURL != null &&
                    this.TermURL.Equals(input.TermURL))
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
                if (this.TermURL != null)
                    hashCode = hashCode * 59 + this.TermURL.GetHashCode();
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
