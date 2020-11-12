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
    /// Country and language of client.
    /// </summary>
    [DataContract]
    public partial class ClientLocale : IEquatable<ClientLocale>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientLocale" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientLocale() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientLocale" /> class.
        /// </summary>
        /// <param name="language">Language used by client. (required).</param>
        /// <param name="country">Country of the client. (required).</param>
        public ClientLocale(string language = default(string), string country = default(string))
        {
            // to ensure "language" is required (not null)
            this.Language = language ?? throw new ArgumentNullException("language is a required property for ClientLocale and cannot be null");
            // to ensure "country" is required (not null)
            this.Country = country ?? throw new ArgumentNullException("country is a required property for ClientLocale and cannot be null");
        }

        /// <summary>
        /// Language used by client.
        /// </summary>
        /// <value>Language used by client.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Country of the client.
        /// </summary>
        /// <value>Country of the client.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientLocale {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as ClientLocale);
        }

        /// <summary>
        /// Returns true if ClientLocale instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientLocale to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientLocale input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
            // Language (string) pattern
            Regex regexLanguage = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexLanguage.Match(this.Language).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Language, must match a pattern of " + regexLanguage, new [] { "Language" });
            }

            // Country (string) pattern
            Regex regexCountry = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexCountry.Match(this.Country).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, must match a pattern of " + regexCountry, new [] { "Country" });
            }

            yield break;
        }
    }
}
