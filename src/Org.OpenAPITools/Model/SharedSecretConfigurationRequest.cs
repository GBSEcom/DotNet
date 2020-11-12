/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.14.0.20201015.001
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
    /// Request to create or update success/fail URLs for store.
    /// </summary>
    [DataContract]
    public partial class SharedSecretConfigurationRequest : IEquatable<SharedSecretConfigurationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSecretConfigurationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SharedSecretConfigurationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSecretConfigurationRequest" /> class.
        /// </summary>
        /// <param name="sharedSecret">Shared secret/password for Connect. (required).</param>
        public SharedSecretConfigurationRequest(string sharedSecret = default(string))
        {
            // to ensure "sharedSecret" is required (not null)
            this.SharedSecret = sharedSecret ?? throw new ArgumentNullException("sharedSecret is a required property for SharedSecretConfigurationRequest and cannot be null");
        }

        /// <summary>
        /// Shared secret/password for Connect.
        /// </summary>
        /// <value>Shared secret/password for Connect.</value>
        [DataMember(Name = "sharedSecret", EmitDefaultValue = false)]
        public string SharedSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharedSecretConfigurationRequest {\n");
            sb.Append("  SharedSecret: ").Append(SharedSecret).Append("\n");
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
            return this.Equals(input as SharedSecretConfigurationRequest);
        }

        /// <summary>
        /// Returns true if SharedSecretConfigurationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SharedSecretConfigurationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedSecretConfigurationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SharedSecret == input.SharedSecret ||
                    (this.SharedSecret != null &&
                    this.SharedSecret.Equals(input.SharedSecret))
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
                if (this.SharedSecret != null)
                    hashCode = hashCode * 59 + this.SharedSecret.GetHashCode();
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
            // SharedSecret (string) pattern
            Regex regexSharedSecret = new Regex(@"[^ ]{7,16}", RegexOptions.CultureInvariant);
            if (false == regexSharedSecret.Match(this.SharedSecret).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SharedSecret, must match a pattern of " + regexSharedSecret, new [] { "SharedSecret" });
            }

            yield break;
        }
    }
}
