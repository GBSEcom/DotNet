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
    /// The encrypted wallet payload.
    /// </summary>
    [DataContract]
    public partial class EncryptedGooglePayData : IEquatable<EncryptedGooglePayData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedGooglePayData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EncryptedGooglePayData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedGooglePayData" /> class.
        /// </summary>
        /// <param name="encryptedMessage">The encrypted message containing the actual payment information as well as additional security fields. (required).</param>
        /// <param name="ephemeralPublicKey">The ephemeral public key associated with the private key to encrypt the message in uncompressed point format. (required).</param>
        /// <param name="tag">MAC of the encryptedMessage. (required).</param>
        public EncryptedGooglePayData(string encryptedMessage = default(string), string ephemeralPublicKey = default(string), string tag = default(string))
        {
            // to ensure "encryptedMessage" is required (not null)
            this.EncryptedMessage = encryptedMessage ?? throw new ArgumentNullException("encryptedMessage is a required property for EncryptedGooglePayData and cannot be null");
            // to ensure "ephemeralPublicKey" is required (not null)
            this.EphemeralPublicKey = ephemeralPublicKey ?? throw new ArgumentNullException("ephemeralPublicKey is a required property for EncryptedGooglePayData and cannot be null");
            // to ensure "tag" is required (not null)
            this.Tag = tag ?? throw new ArgumentNullException("tag is a required property for EncryptedGooglePayData and cannot be null");
        }

        /// <summary>
        /// The encrypted message containing the actual payment information as well as additional security fields.
        /// </summary>
        /// <value>The encrypted message containing the actual payment information as well as additional security fields.</value>
        [DataMember(Name = "encryptedMessage", EmitDefaultValue = false)]
        public string EncryptedMessage { get; set; }

        /// <summary>
        /// The ephemeral public key associated with the private key to encrypt the message in uncompressed point format.
        /// </summary>
        /// <value>The ephemeral public key associated with the private key to encrypt the message in uncompressed point format.</value>
        [DataMember(Name = "ephemeralPublicKey", EmitDefaultValue = false)]
        public string EphemeralPublicKey { get; set; }

        /// <summary>
        /// MAC of the encryptedMessage.
        /// </summary>
        /// <value>MAC of the encryptedMessage.</value>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptedGooglePayData {\n");
            sb.Append("  EncryptedMessage: ").Append(EncryptedMessage).Append("\n");
            sb.Append("  EphemeralPublicKey: ").Append(EphemeralPublicKey).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(input as EncryptedGooglePayData);
        }

        /// <summary>
        /// Returns true if EncryptedGooglePayData instances are equal
        /// </summary>
        /// <param name="input">Instance of EncryptedGooglePayData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncryptedGooglePayData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EncryptedMessage == input.EncryptedMessage ||
                    (this.EncryptedMessage != null &&
                    this.EncryptedMessage.Equals(input.EncryptedMessage))
                ) && 
                (
                    this.EphemeralPublicKey == input.EphemeralPublicKey ||
                    (this.EphemeralPublicKey != null &&
                    this.EphemeralPublicKey.Equals(input.EphemeralPublicKey))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.EncryptedMessage != null)
                    hashCode = hashCode * 59 + this.EncryptedMessage.GetHashCode();
                if (this.EphemeralPublicKey != null)
                    hashCode = hashCode * 59 + this.EphemeralPublicKey.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
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
            // EncryptedMessage (string) pattern
            Regex regexEncryptedMessage = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexEncryptedMessage.Match(this.EncryptedMessage).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EncryptedMessage, must match a pattern of " + regexEncryptedMessage, new [] { "EncryptedMessage" });
            }

            // EphemeralPublicKey (string) pattern
            Regex regexEphemeralPublicKey = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexEphemeralPublicKey.Match(this.EphemeralPublicKey).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EphemeralPublicKey, must match a pattern of " + regexEphemeralPublicKey, new [] { "EphemeralPublicKey" });
            }

            // Tag (string) pattern
            Regex regexTag = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexTag.Match(this.Tag).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Tag, must match a pattern of " + regexTag, new [] { "Tag" });
            }

            yield break;
        }
    }
}
